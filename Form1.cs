using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;

/// <summary>
/// 
/// Borrar lista categorias? -> revisar su uso, pero no es necesaria.
/// </summary>
namespace Tienda
{
    public partial class FrmMain : Form
    {
        private OleDbConnection connection;
        private IDbCommand command;

        private List<string> categorias = new List<string>();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            EstablecerConexion();
            ConsultarCategorias();

        }


        /// <summary>
        /// Consulta en la base de datos los datos de las categorias.
        /// </summary>
        /// <remarks>
        /// Se consulta el Id y en nombre, que serán usados para la creación de 
        /// los RabioButtons
        /// </remarks>
        private void ConsultarCategorias()
        {
            command = connection.CreateCommand();
            // consulta para las categorias
            command.CommandText = "select CategoryId, CategoryName from categories";

            IDataReader dataReader;
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {               
                categorias.Add(dataReader.GetString(1));
                CrearRadioButtons(dataReader.GetInt32(0), dataReader.GetString(1));
            }
            Lblcategorias.Text += " (" + categorias.Count + ")";
            dataReader.Close();

        }

        /// <summary>
        /// Establece la conexión con la base de datos.
        /// </summary>
        private void EstablecerConexion()
        {
            connection = new OleDbConnection();
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=C:\\temp\\nwind.mdb";
            connection.Open();
            //MessageBox.Show(connection.State.ToString());            
        }

        /// <summary>
        /// Controlador de los RaafioButtons. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>Realiza la consulta a la base de datos y actualiza las ListBox</remarks>
        private void MostrarDatos(Object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked) return;

            LBProductId.Items.Clear();
            LBProductName.Items.Clear();
            LBUnitPrice.Items.Clear();
            LBUnitStock.Items.Clear();


            RadioButton rb = sender as RadioButton;


            command = connection.CreateCommand();
            command.CommandText = "select * from Products where CategoryId=" + rb.Tag.ToString();
            //OleDbParameter parameter = new OleDbParameter("CatagoryId", rb.Tag);
            //command.Parameters.Add(rb.Tag);
            IDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {                
               LBProductId.Items.Add(dataReader.GetInt32(0));
               LBProductName.Items.Add(dataReader.GetString(1));
               LBUnitPrice.Items.Add(dataReader.GetDecimal(5));
               LBUnitStock.Items.Add(dataReader.GetInt16(6));               
            }
            dataReader.Close();
        }

        /// <summary>
        /// Crea un RadionButton con el id y la categoría que se pase como argumentos.
        /// </summary>
        /// <param name="id">id de la categoria de la base de datos. Se guarda como Tag</param>
        /// <param name="categoria">Nombre de la categoría. Valor de Text</param>
        private void CrearRadioButtons(int id, string categoria)
        {
        
            RadioButton rb = new RadioButton();
            rb.Text = categoria;
            rb.Top = ((rb.Height + 3) * (id - 1));
            rb.Tag = id;                
            rb.CheckedChanged += new EventHandler(MostrarDatos);
            PanelRb.Controls.Add(rb);
        }

        /// <summary>
        /// Controlador del evento click sobre el boton "Actualizar".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <remarks>
        /// Se prepara la sentencia de update mediante el método PrepararSentencia y se ejecuta
        /// sobre la base de datos.
        /// </remarks>
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            string sentencia = PrepararSentencia();
            if (sentencia == null)
            {
                // Todos los errores ya están controlados.
                return;
            }
            try
            {
                command.CommandText = sentencia;
                command.ExecuteNonQuery();
                MessageBox.Show("Se ha actualizado el registro");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRORR");         
            }
        }

       

        /// <summary>
        /// Prepara la sentencia sql.
        /// </summary>
        /// <returns>Un string con la sentencia preparada</returns>
        /// <remarks>No tiene en cuenta los TextBox en blanco ni actualiza el Id del producto.</remarks>
        private string PrepararSentencia()
        {
            if (!NormalizarTextBox()) return null;
            string sentencia = "update Products set ";
            // total de textbox con texto
            int total = 0;

            for (int i = 0; i < PanelInput.Controls.OfType<TextBox>().Count(); i++)
            {
                TextBox tb = PanelInput.Controls.OfType<TextBox>().ElementAt(i);
                if (tb.Text.Length <= 0 || tb.Tag.ToString().Equals("ProductId")) continue;
                if (total == 0)
                {
                    if (tb.Tag.ToString().Equals("ProductName"))
                    {
                        sentencia += tb.Tag.ToString() + "='" + tb.Text.ToString() + "'";
                        total++;
                    } else
                    {
                        sentencia += tb.Tag.ToString() + "=" + tb.Text.ToString();
                        total++;
                    }
                    
                } else
                {
                    if (tb.Tag.ToString().Equals("ProductName"))
                    {
                        sentencia += ", " + tb.Tag.ToString() + "='" + tb.Text.ToString() + "'";
                        total++;
                    }
                    else
                    {
                        sentencia += ", " + tb.Tag.ToString() + "=" + tb.Text.ToString();
                        total++;
                    }
                    
                }
            }

            sentencia += " where ProductID=" + TBProcuctId.Text.ToString();

            return sentencia;
        }

        private bool NormalizarTextBox()
        {
            
            if (!Regex.Match(TBProcuctId.Text, "^\\d+$").Success)
            {
                MessageBox.Show("Error en el Id.");
                return false;
            }
            
            TBUnitPrice.Text = TBUnitPrice.Text.Replace(',', '.');
            
            if (!Regex.Match(TBUnitPrice.Text, "^\\d+(\\.\\d+)?$").Success && TBUnitPrice.Text.Length != 0)
            {
                MessageBox.Show("Error en Unit price.");                               
                return false;
            }

            if (!Regex.Match(TBUnitStock.Text, "^\\d+$").Success && TBUnitStock.Text.Length != 0)
            {
                MessageBox.Show("Error en Unit stock.");
                return false;
            }

            return true;
        }

        private void BtnBorrarConsultas_Click(object sender, EventArgs e)
        {
            LBProductId.Items.Clear();
            LBProductName.Items.Clear();
            LBUnitPrice.Items.Clear();
            LBUnitStock.Items.Clear();

            foreach (RadioButton rb in PanelRb.Controls.OfType<RadioButton>())
            {
                rb.Checked = false;
            }
        }

        private void BtnBorrarInputs_Click(object sender, EventArgs e)
        {
            TBProcuctId.Text = "";
            TBProductName.Text = "";
            TBUnitPrice.Text = "";
            TBUnitStock.Text = "";
        }

       
    }
}
