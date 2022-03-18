
namespace Storage
{
    partial class PartnerSelectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.partnerClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adoszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szamlazasiOrszagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szamlazasiIranyitoszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szamlazasiVarosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szamlazasiCimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szallitasiOrszagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szallitasiIranyitoszamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szallitasiVarosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szalllitasiCimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weboldalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankszamlaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.megjegyzesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partnerClassBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nevDataGridViewTextBoxColumn,
            this.adoszamDataGridViewTextBoxColumn,
            this.szamlazasiOrszagDataGridViewTextBoxColumn,
            this.szamlazasiIranyitoszamDataGridViewTextBoxColumn,
            this.szamlazasiVarosDataGridViewTextBoxColumn,
            this.szamlazasiCimDataGridViewTextBoxColumn,
            this.szallitasiOrszagDataGridViewTextBoxColumn,
            this.szallitasiIranyitoszamDataGridViewTextBoxColumn,
            this.szallitasiVarosDataGridViewTextBoxColumn,
            this.szalllitasiCimDataGridViewTextBoxColumn,
            this.weboldalDataGridViewTextBoxColumn,
            this.bankszamlaDataGridViewTextBoxColumn,
            this.megjegyzesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.partnerClassBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 216);
            this.dataGridView1.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button6.Location = new System.Drawing.Point(713, 415);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 11;
            this.button6.Text = "Mégse";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button5.Location = new System.Drawing.Point(632, 415);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "OK";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 116);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Keresés";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Név:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // partnerClassBindingSource
            // 
            this.partnerClassBindingSource.DataSource = typeof(Storage.PartnerClass);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 50;
            // 
            // nevDataGridViewTextBoxColumn
            // 
            this.nevDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nevDataGridViewTextBoxColumn.HeaderText = "Név";
            this.nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            this.nevDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adoszamDataGridViewTextBoxColumn
            // 
            this.adoszamDataGridViewTextBoxColumn.DataPropertyName = "Adoszam";
            this.adoszamDataGridViewTextBoxColumn.HeaderText = "Adószám";
            this.adoszamDataGridViewTextBoxColumn.Name = "adoszamDataGridViewTextBoxColumn";
            this.adoszamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // szamlazasiOrszagDataGridViewTextBoxColumn
            // 
            this.szamlazasiOrszagDataGridViewTextBoxColumn.DataPropertyName = "SzamlazasiOrszag";
            this.szamlazasiOrszagDataGridViewTextBoxColumn.HeaderText = "Számlázási Ország";
            this.szamlazasiOrszagDataGridViewTextBoxColumn.Name = "szamlazasiOrszagDataGridViewTextBoxColumn";
            this.szamlazasiOrszagDataGridViewTextBoxColumn.ReadOnly = true;
            this.szamlazasiOrszagDataGridViewTextBoxColumn.Width = 120;
            // 
            // szamlazasiIranyitoszamDataGridViewTextBoxColumn
            // 
            this.szamlazasiIranyitoszamDataGridViewTextBoxColumn.DataPropertyName = "SzamlazasiIranyitoszam";
            this.szamlazasiIranyitoszamDataGridViewTextBoxColumn.HeaderText = "Számlázási Irányitószám";
            this.szamlazasiIranyitoszamDataGridViewTextBoxColumn.Name = "szamlazasiIranyitoszamDataGridViewTextBoxColumn";
            this.szamlazasiIranyitoszamDataGridViewTextBoxColumn.ReadOnly = true;
            this.szamlazasiIranyitoszamDataGridViewTextBoxColumn.Width = 150;
            // 
            // szamlazasiVarosDataGridViewTextBoxColumn
            // 
            this.szamlazasiVarosDataGridViewTextBoxColumn.DataPropertyName = "SzamlazasiVaros";
            this.szamlazasiVarosDataGridViewTextBoxColumn.HeaderText = "Számlázási Város";
            this.szamlazasiVarosDataGridViewTextBoxColumn.Name = "szamlazasiVarosDataGridViewTextBoxColumn";
            this.szamlazasiVarosDataGridViewTextBoxColumn.ReadOnly = true;
            this.szamlazasiVarosDataGridViewTextBoxColumn.Width = 120;
            // 
            // szamlazasiCimDataGridViewTextBoxColumn
            // 
            this.szamlazasiCimDataGridViewTextBoxColumn.DataPropertyName = "SzamlazasiCim";
            this.szamlazasiCimDataGridViewTextBoxColumn.HeaderText = "Számlázási Cim";
            this.szamlazasiCimDataGridViewTextBoxColumn.Name = "szamlazasiCimDataGridViewTextBoxColumn";
            this.szamlazasiCimDataGridViewTextBoxColumn.ReadOnly = true;
            this.szamlazasiCimDataGridViewTextBoxColumn.Width = 120;
            // 
            // szallitasiOrszagDataGridViewTextBoxColumn
            // 
            this.szallitasiOrszagDataGridViewTextBoxColumn.DataPropertyName = "SzallitasiOrszag";
            this.szallitasiOrszagDataGridViewTextBoxColumn.HeaderText = "Szállitási Ország";
            this.szallitasiOrszagDataGridViewTextBoxColumn.Name = "szallitasiOrszagDataGridViewTextBoxColumn";
            this.szallitasiOrszagDataGridViewTextBoxColumn.ReadOnly = true;
            this.szallitasiOrszagDataGridViewTextBoxColumn.Width = 120;
            // 
            // szallitasiIranyitoszamDataGridViewTextBoxColumn
            // 
            this.szallitasiIranyitoszamDataGridViewTextBoxColumn.DataPropertyName = "SzallitasiIranyitoszam";
            this.szallitasiIranyitoszamDataGridViewTextBoxColumn.HeaderText = "Szállitási Irányitószám";
            this.szallitasiIranyitoszamDataGridViewTextBoxColumn.Name = "szallitasiIranyitoszamDataGridViewTextBoxColumn";
            this.szallitasiIranyitoszamDataGridViewTextBoxColumn.ReadOnly = true;
            this.szallitasiIranyitoszamDataGridViewTextBoxColumn.Width = 150;
            // 
            // szallitasiVarosDataGridViewTextBoxColumn
            // 
            this.szallitasiVarosDataGridViewTextBoxColumn.DataPropertyName = "SzallitasiVaros";
            this.szallitasiVarosDataGridViewTextBoxColumn.HeaderText = "Szállitási Város";
            this.szallitasiVarosDataGridViewTextBoxColumn.Name = "szallitasiVarosDataGridViewTextBoxColumn";
            this.szallitasiVarosDataGridViewTextBoxColumn.ReadOnly = true;
            this.szallitasiVarosDataGridViewTextBoxColumn.Width = 120;
            // 
            // szalllitasiCimDataGridViewTextBoxColumn
            // 
            this.szalllitasiCimDataGridViewTextBoxColumn.DataPropertyName = "SzalllitasiCim";
            this.szalllitasiCimDataGridViewTextBoxColumn.HeaderText = "Szálllitási Cím";
            this.szalllitasiCimDataGridViewTextBoxColumn.Name = "szalllitasiCimDataGridViewTextBoxColumn";
            this.szalllitasiCimDataGridViewTextBoxColumn.ReadOnly = true;
            this.szalllitasiCimDataGridViewTextBoxColumn.Width = 120;
            // 
            // weboldalDataGridViewTextBoxColumn
            // 
            this.weboldalDataGridViewTextBoxColumn.DataPropertyName = "Weboldal";
            this.weboldalDataGridViewTextBoxColumn.HeaderText = "Weboldal";
            this.weboldalDataGridViewTextBoxColumn.Name = "weboldalDataGridViewTextBoxColumn";
            this.weboldalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bankszamlaDataGridViewTextBoxColumn
            // 
            this.bankszamlaDataGridViewTextBoxColumn.DataPropertyName = "Bankszamla";
            this.bankszamlaDataGridViewTextBoxColumn.HeaderText = "Bankszámla";
            this.bankszamlaDataGridViewTextBoxColumn.Name = "bankszamlaDataGridViewTextBoxColumn";
            this.bankszamlaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // megjegyzesDataGridViewTextBoxColumn
            // 
            this.megjegyzesDataGridViewTextBoxColumn.DataPropertyName = "Megjegyzes";
            this.megjegyzesDataGridViewTextBoxColumn.HeaderText = "Megjegyzes";
            this.megjegyzesDataGridViewTextBoxColumn.Name = "megjegyzesDataGridViewTextBoxColumn";
            this.megjegyzesDataGridViewTextBoxColumn.ReadOnly = true;
            this.megjegyzesDataGridViewTextBoxColumn.Visible = false;
            // 
            // PartnerSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PartnerSelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Partner Kiválasztása";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partnerClassBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.BindingSource partnerClassBindingSource;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adoszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szamlazasiOrszagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szamlazasiIranyitoszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szamlazasiVarosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szamlazasiCimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szallitasiOrszagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szallitasiIranyitoszamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szallitasiVarosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szalllitasiCimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weboldalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankszamlaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn megjegyzesDataGridViewTextBoxColumn;
    }
}