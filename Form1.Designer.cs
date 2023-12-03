
namespace Tienda
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBProductId = new System.Windows.Forms.ListBox();
            this.LBProductName = new System.Windows.Forms.ListBox();
            this.LBUnitPrice = new System.Windows.Forms.ListBox();
            this.LBUnitStock = new System.Windows.Forms.ListBox();
            this.LblProductId = new System.Windows.Forms.Label();
            this.LabelProductName = new System.Windows.Forms.Label();
            this.LblUnitPrice = new System.Windows.Forms.Label();
            this.LabelStock = new System.Windows.Forms.Label();
            this.LblInputPId = new System.Windows.Forms.Label();
            this.LblInputPName = new System.Windows.Forms.Label();
            this.LblInputUPrice = new System.Windows.Forms.Label();
            this.LblInputUStock = new System.Windows.Forms.Label();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.TBProcuctId = new System.Windows.Forms.TextBox();
            this.TBProductName = new System.Windows.Forms.TextBox();
            this.TBUnitPrice = new System.Windows.Forms.TextBox();
            this.TBUnitStock = new System.Windows.Forms.TextBox();
            this.PanelRb = new System.Windows.Forms.Panel();
            this.Lblcategorias = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnBorrarConsultas = new System.Windows.Forms.Button();
            this.BtnBorrarInputs = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBProductId
            // 
            this.LBProductId.FormattingEnabled = true;
            this.LBProductId.Location = new System.Drawing.Point(157, 38);
            this.LBProductId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LBProductId.Name = "LBProductId";
            this.LBProductId.Size = new System.Drawing.Size(85, 225);
            this.LBProductId.TabIndex = 0;
            // 
            // LBProductName
            // 
            this.LBProductName.FormattingEnabled = true;
            this.LBProductName.Location = new System.Drawing.Point(250, 38);
            this.LBProductName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LBProductName.Name = "LBProductName";
            this.LBProductName.Size = new System.Drawing.Size(203, 225);
            this.LBProductName.TabIndex = 1;
            // 
            // LBUnitPrice
            // 
            this.LBUnitPrice.FormattingEnabled = true;
            this.LBUnitPrice.Location = new System.Drawing.Point(461, 38);
            this.LBUnitPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LBUnitPrice.Name = "LBUnitPrice";
            this.LBUnitPrice.Size = new System.Drawing.Size(98, 225);
            this.LBUnitPrice.TabIndex = 2;
            // 
            // LBUnitStock
            // 
            this.LBUnitStock.FormattingEnabled = true;
            this.LBUnitStock.Location = new System.Drawing.Point(567, 38);
            this.LBUnitStock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LBUnitStock.Name = "LBUnitStock";
            this.LBUnitStock.Size = new System.Drawing.Size(45, 225);
            this.LBUnitStock.TabIndex = 3;
            // 
            // LblProductId
            // 
            this.LblProductId.AutoSize = true;
            this.LblProductId.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProductId.Location = new System.Drawing.Point(154, 10);
            this.LblProductId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblProductId.Name = "LblProductId";
            this.LblProductId.Size = new System.Drawing.Size(88, 17);
            this.LblProductId.TabIndex = 4;
            this.LblProductId.Text = "Product ID";
            // 
            // LabelProductName
            // 
            this.LabelProductName.AutoSize = true;
            this.LabelProductName.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProductName.Location = new System.Drawing.Point(250, 10);
            this.LabelProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelProductName.Name = "LabelProductName";
            this.LabelProductName.Size = new System.Drawing.Size(104, 17);
            this.LabelProductName.TabIndex = 5;
            this.LabelProductName.Text = "Product name";
            // 
            // LblUnitPrice
            // 
            this.LblUnitPrice.AutoSize = true;
            this.LblUnitPrice.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUnitPrice.Location = new System.Drawing.Point(458, 10);
            this.LblUnitPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUnitPrice.Name = "LblUnitPrice";
            this.LblUnitPrice.Size = new System.Drawing.Size(88, 17);
            this.LblUnitPrice.TabIndex = 6;
            this.LblUnitPrice.Text = "Unit Price";
            // 
            // LabelStock
            // 
            this.LabelStock.AutoSize = true;
            this.LabelStock.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStock.Location = new System.Drawing.Point(564, 10);
            this.LabelStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelStock.Name = "LabelStock";
            this.LabelStock.Size = new System.Drawing.Size(48, 17);
            this.LabelStock.TabIndex = 7;
            this.LabelStock.Text = "Stock";
            // 
            // LblInputPId
            // 
            this.LblInputPId.AutoSize = true;
            this.LblInputPId.Location = new System.Drawing.Point(64, 54);
            this.LblInputPId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblInputPId.Name = "LblInputPId";
            this.LblInputPId.Size = new System.Drawing.Size(67, 13);
            this.LblInputPId.TabIndex = 8;
            this.LblInputPId.Text = "Product ID";
            // 
            // LblInputPName
            // 
            this.LblInputPName.AutoSize = true;
            this.LblInputPName.Location = new System.Drawing.Point(64, 93);
            this.LblInputPName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblInputPName.Name = "LblInputPName";
            this.LblInputPName.Size = new System.Drawing.Size(79, 13);
            this.LblInputPName.TabIndex = 9;
            this.LblInputPName.Text = "Product name";
            // 
            // LblInputUPrice
            // 
            this.LblInputUPrice.AutoSize = true;
            this.LblInputUPrice.Location = new System.Drawing.Point(64, 132);
            this.LblInputUPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblInputUPrice.Name = "LblInputUPrice";
            this.LblInputUPrice.Size = new System.Drawing.Size(67, 13);
            this.LblInputUPrice.TabIndex = 10;
            this.LblInputUPrice.Text = "Unit price";
            // 
            // LblInputUStock
            // 
            this.LblInputUStock.AutoSize = true;
            this.LblInputUStock.Location = new System.Drawing.Point(64, 174);
            this.LblInputUStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblInputUStock.Name = "LblInputUStock";
            this.LblInputUStock.Size = new System.Drawing.Size(85, 13);
            this.LblInputUStock.TabIndex = 11;
            this.LblInputUStock.Text = "Unit in stock";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnActualizar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnActualizar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnActualizar.Location = new System.Drawing.Point(67, 213);
            this.BtnActualizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(234, 51);
            this.BtnActualizar.TabIndex = 12;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = false;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // TBProcuctId
            // 
            this.TBProcuctId.Location = new System.Drawing.Point(157, 54);
            this.TBProcuctId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBProcuctId.Name = "TBProcuctId";
            this.TBProcuctId.Size = new System.Drawing.Size(144, 20);
            this.TBProcuctId.TabIndex = 13;
            this.TBProcuctId.Tag = "ProductId";
            this.TBProcuctId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TBProductName
            // 
            this.TBProductName.Location = new System.Drawing.Point(157, 93);
            this.TBProductName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBProductName.Name = "TBProductName";
            this.TBProductName.Size = new System.Drawing.Size(144, 20);
            this.TBProductName.TabIndex = 14;
            this.TBProductName.Tag = "ProductName";
            this.TBProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TBUnitPrice
            // 
            this.TBUnitPrice.Location = new System.Drawing.Point(157, 129);
            this.TBUnitPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBUnitPrice.Name = "TBUnitPrice";
            this.TBUnitPrice.Size = new System.Drawing.Size(144, 20);
            this.TBUnitPrice.TabIndex = 15;
            this.TBUnitPrice.Tag = "UnitPrice";
            this.TBUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TBUnitStock
            // 
            this.TBUnitStock.Location = new System.Drawing.Point(157, 171);
            this.TBUnitStock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBUnitStock.Name = "TBUnitStock";
            this.TBUnitStock.Size = new System.Drawing.Size(144, 20);
            this.TBUnitStock.TabIndex = 16;
            this.TBUnitStock.Tag = "UnitsInStock";
            this.TBUnitStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PanelRb
            // 
            this.PanelRb.Location = new System.Drawing.Point(18, 38);
            this.PanelRb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PanelRb.Name = "PanelRb";
            this.PanelRb.Size = new System.Drawing.Size(131, 225);
            this.PanelRb.TabIndex = 17;
            // 
            // Lblcategorias
            // 
            this.Lblcategorias.AutoSize = true;
            this.Lblcategorias.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblcategorias.Location = new System.Drawing.Point(15, 10);
            this.Lblcategorias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lblcategorias.Name = "Lblcategorias";
            this.Lblcategorias.Size = new System.Drawing.Size(88, 17);
            this.Lblcategorias.TabIndex = 18;
            this.Lblcategorias.Text = "Categorias";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Actualizar producto";
            // 
            // BtnBorrarConsultas
            // 
            this.BtnBorrarConsultas.Image = global::Tienda.Properties.Resources.papelera2;
            this.BtnBorrarConsultas.Location = new System.Drawing.Point(619, 38);
            this.BtnBorrarConsultas.Name = "BtnBorrarConsultas";
            this.BtnBorrarConsultas.Size = new System.Drawing.Size(34, 33);
            this.BtnBorrarConsultas.TabIndex = 21;
            this.BtnBorrarConsultas.UseVisualStyleBackColor = true;
            this.BtnBorrarConsultas.Click += new System.EventHandler(this.BtnBorrarConsultas_Click);
            // 
            // BtnBorrarInputs
            // 
            this.BtnBorrarInputs.Image = global::Tienda.Properties.Resources.papelera2;
            this.BtnBorrarInputs.Location = new System.Drawing.Point(308, 213);
            this.BtnBorrarInputs.Name = "BtnBorrarInputs";
            this.BtnBorrarInputs.Size = new System.Drawing.Size(34, 33);
            this.BtnBorrarInputs.TabIndex = 20;
            this.BtnBorrarInputs.UseVisualStyleBackColor = true;
            this.BtnBorrarInputs.Click += new System.EventHandler(this.BtnBorrarInputs_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LblInputPId);
            this.panel1.Controls.Add(this.BtnBorrarInputs);
            this.panel1.Controls.Add(this.LblInputPName);
            this.panel1.Controls.Add(this.LblInputUPrice);
            this.panel1.Controls.Add(this.LblInputUStock);
            this.panel1.Controls.Add(this.BtnActualizar);
            this.panel1.Controls.Add(this.TBUnitStock);
            this.panel1.Controls.Add(this.TBProcuctId);
            this.panel1.Controls.Add(this.TBUnitPrice);
            this.panel1.Controls.Add(this.TBProductName);
            this.panel1.Location = new System.Drawing.Point(659, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 279);
            this.panel1.TabIndex = 22;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1028, 277);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnBorrarConsultas);
            this.Controls.Add(this.Lblcategorias);
            this.Controls.Add(this.PanelRb);
            this.Controls.Add(this.LabelStock);
            this.Controls.Add(this.LblUnitPrice);
            this.Controls.Add(this.LabelProductName);
            this.Controls.Add(this.LblProductId);
            this.Controls.Add(this.LBUnitStock);
            this.Controls.Add(this.LBUnitPrice);
            this.Controls.Add(this.LBProductName);
            this.Controls.Add(this.LBProductId);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBProductId;
        private System.Windows.Forms.ListBox LBProductName;
        private System.Windows.Forms.ListBox LBUnitPrice;
        private System.Windows.Forms.ListBox LBUnitStock;
        private System.Windows.Forms.Label LblProductId;
        private System.Windows.Forms.Label LabelProductName;
        private System.Windows.Forms.Label LblUnitPrice;
        private System.Windows.Forms.Label LabelStock;
        private System.Windows.Forms.Label LblInputPId;
        private System.Windows.Forms.Label LblInputPName;
        private System.Windows.Forms.Label LblInputUPrice;
        private System.Windows.Forms.Label LblInputUStock;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.TextBox TBProcuctId;
        private System.Windows.Forms.TextBox TBProductName;
        private System.Windows.Forms.TextBox TBUnitPrice;
        private System.Windows.Forms.TextBox TBUnitStock;
        private System.Windows.Forms.Panel PanelRb;
        private System.Windows.Forms.Label Lblcategorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnBorrarInputs;
        private System.Windows.Forms.Button BtnBorrarConsultas;
        private System.Windows.Forms.Panel panel1;
    }
}

