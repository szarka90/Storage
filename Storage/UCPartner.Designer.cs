
namespace Storage
{
    partial class UCPartner
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Content = new System.Windows.Forms.Panel();
            this.szallitGb = new System.Windows.Forms.GroupBox();
            this.deliveryTbx = new System.Windows.Forms.TextBox();
            this.szamlaGb = new System.Windows.Forms.GroupBox();
            this.billingTbx = new System.Windows.Forms.TextBox();
            this.partnerClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billingCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billingPostcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billingCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billingAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryPostcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deiveryCityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankAccountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Content.SuspendLayout();
            this.szallitGb.SuspendLayout();
            this.szamlaGb.SuspendLayout();
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
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.taxNumberDataGridViewTextBoxColumn,
            this.billingCountryDataGridViewTextBoxColumn,
            this.billingPostcodeDataGridViewTextBoxColumn,
            this.billingCityDataGridViewTextBoxColumn,
            this.billingAddressDataGridViewTextBoxColumn,
            this.deliveryCountryDataGridViewTextBoxColumn,
            this.deliveryPostcodeDataGridViewTextBoxColumn,
            this.deiveryCityDataGridViewTextBoxColumn,
            this.deliveryAddressDataGridViewTextBoxColumn,
            this.webDataGridViewTextBoxColumn,
            this.bankAccountDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.partnerClassBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1145, 375);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(15, 605);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(355, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Új partner felvitel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(15, 465);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 116);
            this.groupBox1.TabIndex = 2;
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
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(15, 634);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(355, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Partner módosítása";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(15, 663);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(355, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Partner törlése";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(10, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Partnerek";
            // 
            // Content
            // 
            this.Content.Controls.Add(this.szallitGb);
            this.Content.Controls.Add(this.button3);
            this.Content.Controls.Add(this.szamlaGb);
            this.Content.Controls.Add(this.button2);
            this.Content.Controls.Add(this.groupBox1);
            this.Content.Controls.Add(this.button1);
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Margin = new System.Windows.Forms.Padding(2);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(1175, 729);
            this.Content.TabIndex = 7;
            // 
            // szallitGb
            // 
            this.szallitGb.Controls.Add(this.deliveryTbx);
            this.szallitGb.Location = new System.Drawing.Point(741, 465);
            this.szallitGb.Name = "szallitGb";
            this.szallitGb.Size = new System.Drawing.Size(215, 116);
            this.szallitGb.TabIndex = 1;
            this.szallitGb.TabStop = false;
            this.szallitGb.Text = "Szállítási cím";
            // 
            // szallitCimTbx
            // 
            this.deliveryTbx.Enabled = false;
            this.deliveryTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deliveryTbx.Location = new System.Drawing.Point(0, 18);
            this.deliveryTbx.Multiline = true;
            this.deliveryTbx.Name = "szallitCimTbx";
            this.deliveryTbx.Size = new System.Drawing.Size(215, 98);
            this.deliveryTbx.TabIndex = 3;
            // 
            // szamlaGb
            // 
            this.szamlaGb.Controls.Add(this.billingTbx);
            this.szamlaGb.Location = new System.Drawing.Point(411, 466);
            this.szamlaGb.Name = "szamlaGb";
            this.szamlaGb.Size = new System.Drawing.Size(215, 115);
            this.szamlaGb.TabIndex = 0;
            this.szamlaGb.TabStop = false;
            this.szamlaGb.Text = "Számlázási cím";
            // 
            // szamlaCimTbx
            // 
            this.billingTbx.Enabled = false;
            this.billingTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.billingTbx.Location = new System.Drawing.Point(0, 18);
            this.billingTbx.Multiline = true;
            this.billingTbx.Name = "szamlaCimTbx";
            this.billingTbx.Size = new System.Drawing.Size(215, 97);
            this.billingTbx.TabIndex = 2;
            // 
            // partnerClassBindingSource
            // 
            this.partnerClassBindingSource.DataSource = typeof(Storage.PartnerClass);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 30;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Név";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taxNumberDataGridViewTextBoxColumn
            // 
            this.taxNumberDataGridViewTextBoxColumn.DataPropertyName = "TaxNumber";
            this.taxNumberDataGridViewTextBoxColumn.HeaderText = "Adószám";
            this.taxNumberDataGridViewTextBoxColumn.Name = "taxNumberDataGridViewTextBoxColumn";
            this.taxNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.taxNumberDataGridViewTextBoxColumn.Width = 200;
            // 
            // billingCountryDataGridViewTextBoxColumn
            // 
            this.billingCountryDataGridViewTextBoxColumn.DataPropertyName = "BillingCountry";
            this.billingCountryDataGridViewTextBoxColumn.HeaderText = "BillingCountry";
            this.billingCountryDataGridViewTextBoxColumn.Name = "billingCountryDataGridViewTextBoxColumn";
            this.billingCountryDataGridViewTextBoxColumn.ReadOnly = true;
            this.billingCountryDataGridViewTextBoxColumn.Visible = false;
            // 
            // billingPostcodeDataGridViewTextBoxColumn
            // 
            this.billingPostcodeDataGridViewTextBoxColumn.DataPropertyName = "BillingPostcode";
            this.billingPostcodeDataGridViewTextBoxColumn.HeaderText = "BillingPostcode";
            this.billingPostcodeDataGridViewTextBoxColumn.Name = "billingPostcodeDataGridViewTextBoxColumn";
            this.billingPostcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.billingPostcodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // billingCityDataGridViewTextBoxColumn
            // 
            this.billingCityDataGridViewTextBoxColumn.DataPropertyName = "BillingCity";
            this.billingCityDataGridViewTextBoxColumn.HeaderText = "BillingCity";
            this.billingCityDataGridViewTextBoxColumn.Name = "billingCityDataGridViewTextBoxColumn";
            this.billingCityDataGridViewTextBoxColumn.ReadOnly = true;
            this.billingCityDataGridViewTextBoxColumn.Visible = false;
            // 
            // billingAddressDataGridViewTextBoxColumn
            // 
            this.billingAddressDataGridViewTextBoxColumn.DataPropertyName = "BillingAddress";
            this.billingAddressDataGridViewTextBoxColumn.HeaderText = "BillingAddress";
            this.billingAddressDataGridViewTextBoxColumn.Name = "billingAddressDataGridViewTextBoxColumn";
            this.billingAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.billingAddressDataGridViewTextBoxColumn.Visible = false;
            // 
            // deliveryCountryDataGridViewTextBoxColumn
            // 
            this.deliveryCountryDataGridViewTextBoxColumn.DataPropertyName = "DeliveryCountry";
            this.deliveryCountryDataGridViewTextBoxColumn.HeaderText = "DeliveryCountry";
            this.deliveryCountryDataGridViewTextBoxColumn.Name = "deliveryCountryDataGridViewTextBoxColumn";
            this.deliveryCountryDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliveryCountryDataGridViewTextBoxColumn.Visible = false;
            // 
            // deliveryPostcodeDataGridViewTextBoxColumn
            // 
            this.deliveryPostcodeDataGridViewTextBoxColumn.DataPropertyName = "DeliveryPostcode";
            this.deliveryPostcodeDataGridViewTextBoxColumn.HeaderText = "DeliveryPostcode";
            this.deliveryPostcodeDataGridViewTextBoxColumn.Name = "deliveryPostcodeDataGridViewTextBoxColumn";
            this.deliveryPostcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliveryPostcodeDataGridViewTextBoxColumn.Visible = false;
            // 
            // deiveryCityDataGridViewTextBoxColumn
            // 
            this.deiveryCityDataGridViewTextBoxColumn.DataPropertyName = "DeiveryCity";
            this.deiveryCityDataGridViewTextBoxColumn.HeaderText = "DeiveryCity";
            this.deiveryCityDataGridViewTextBoxColumn.Name = "deiveryCityDataGridViewTextBoxColumn";
            this.deiveryCityDataGridViewTextBoxColumn.ReadOnly = true;
            this.deiveryCityDataGridViewTextBoxColumn.Visible = false;
            // 
            // deliveryAddressDataGridViewTextBoxColumn
            // 
            this.deliveryAddressDataGridViewTextBoxColumn.DataPropertyName = "DeliveryAddress";
            this.deliveryAddressDataGridViewTextBoxColumn.HeaderText = "DeliveryAddress";
            this.deliveryAddressDataGridViewTextBoxColumn.Name = "deliveryAddressDataGridViewTextBoxColumn";
            this.deliveryAddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliveryAddressDataGridViewTextBoxColumn.Visible = false;
            // 
            // webDataGridViewTextBoxColumn
            // 
            this.webDataGridViewTextBoxColumn.DataPropertyName = "Web";
            this.webDataGridViewTextBoxColumn.HeaderText = "Web";
            this.webDataGridViewTextBoxColumn.Name = "webDataGridViewTextBoxColumn";
            this.webDataGridViewTextBoxColumn.ReadOnly = true;
            this.webDataGridViewTextBoxColumn.Width = 200;
            // 
            // bankAccountDataGridViewTextBoxColumn
            // 
            this.bankAccountDataGridViewTextBoxColumn.DataPropertyName = "BankAccount";
            this.bankAccountDataGridViewTextBoxColumn.HeaderText = "Bankszámlaszám";
            this.bankAccountDataGridViewTextBoxColumn.Name = "bankAccountDataGridViewTextBoxColumn";
            this.bankAccountDataGridViewTextBoxColumn.ReadOnly = true;
            this.bankAccountDataGridViewTextBoxColumn.Width = 200;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Megjegyzés";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // UCPartner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Content);
            this.Name = "UCPartner";
            this.Size = new System.Drawing.Size(1175, 729);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Content.ResumeLayout(false);
            this.szallitGb.ResumeLayout(false);
            this.szallitGb.PerformLayout();
            this.szamlaGb.ResumeLayout(false);
            this.szamlaGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partnerClassBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.GroupBox szallitGb;
        private System.Windows.Forms.GroupBox szamlaGb;
        private System.Windows.Forms.TextBox billingTbx;
        private System.Windows.Forms.TextBox deliveryTbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billingCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billingPostcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billingCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billingAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryPostcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deiveryCityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn webDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankAccountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource partnerClassBindingSource;
    }
}
