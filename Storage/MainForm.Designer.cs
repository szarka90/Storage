
namespace Storage
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.userLabel = new System.Windows.Forms.Label();
            this.kilepesBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.bevetelezesBtn = new System.Windows.Forms.Button();
            this.megrendelesBtn = new System.Windows.Forms.Button();
            this.termekBtn = new System.Windows.Forms.Button();
            this.partnerBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Content = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.userLabel);
            this.panel1.Controls.Add(this.kilepesBtn);
            this.panel1.Controls.Add(this.settingsBtn);
            this.panel1.Controls.Add(this.bevetelezesBtn);
            this.panel1.Controls.Add(this.megrendelesBtn);
            this.panel1.Controls.Add(this.termekBtn);
            this.panel1.Controls.Add(this.partnerBtn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 729);
            this.panel1.TabIndex = 0;
            // 
            // userLabel
            // 
            this.userLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.userLabel.Location = new System.Drawing.Point(12, 102);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(156, 20);
            this.userLabel.TabIndex = 11;
            this.userLabel.Text = "username";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // kilepesBtn
            // 
            this.kilepesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.kilepesBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.kilepesBtn.Location = new System.Drawing.Point(0, 666);
            this.kilepesBtn.Name = "kilepesBtn";
            this.kilepesBtn.Size = new System.Drawing.Size(175, 50);
            this.kilepesBtn.TabIndex = 10;
            this.kilepesBtn.Text = "Kilépés";
            this.kilepesBtn.UseVisualStyleBackColor = true;
            this.kilepesBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // beallitasokBtn
            // 
            this.settingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.settingsBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.settingsBtn.Location = new System.Drawing.Point(0, 610);
            this.settingsBtn.Name = "beallitasokBtn";
            this.settingsBtn.Size = new System.Drawing.Size(175, 50);
            this.settingsBtn.TabIndex = 9;
            this.settingsBtn.Text = "Beállítások";
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // bevetelezesBtn
            // 
            this.bevetelezesBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.bevetelezesBtn.Location = new System.Drawing.Point(0, 311);
            this.bevetelezesBtn.Name = "bevetelezesBtn";
            this.bevetelezesBtn.Size = new System.Drawing.Size(175, 50);
            this.bevetelezesBtn.TabIndex = 8;
            this.bevetelezesBtn.Text = "Bevételezés";
            this.bevetelezesBtn.UseVisualStyleBackColor = true;
            this.bevetelezesBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // megrendelesBtn
            // 
            this.megrendelesBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.megrendelesBtn.Location = new System.Drawing.Point(0, 255);
            this.megrendelesBtn.Name = "megrendelesBtn";
            this.megrendelesBtn.Size = new System.Drawing.Size(175, 50);
            this.megrendelesBtn.TabIndex = 7;
            this.megrendelesBtn.Text = "Megrendelés";
            this.megrendelesBtn.UseVisualStyleBackColor = true;
            this.megrendelesBtn.Click += new System.EventHandler(this.orderBtn_Click);
            // 
            // termekBtn
            // 
            this.termekBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.termekBtn.Location = new System.Drawing.Point(0, 199);
            this.termekBtn.Name = "termekBtn";
            this.termekBtn.Size = new System.Drawing.Size(175, 50);
            this.termekBtn.TabIndex = 6;
            this.termekBtn.Text = "Termékek";
            this.termekBtn.UseVisualStyleBackColor = true;
            this.termekBtn.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // partnerBtn
            // 
            this.partnerBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.partnerBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.partnerBtn.Location = new System.Drawing.Point(0, 143);
            this.partnerBtn.Name = "partnerBtn";
            this.partnerBtn.Size = new System.Drawing.Size(175, 50);
            this.partnerBtn.TabIndex = 5;
            this.partnerBtn.Text = "Partnerek";
            this.partnerBtn.UseVisualStyleBackColor = true;
            this.partnerBtn.Click += new System.EventHandler(this.partnerBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(47, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 69);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.SystemColors.Control;
            this.Content.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(175, 0);
            this.Content.Margin = new System.Windows.Forms.Padding(4);
            this.Content.Name = "Content";
            this.Content.Padding = new System.Windows.Forms.Padding(4);
            this.Content.Size = new System.Drawing.Size(1175, 729);
            this.Content.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button partnerBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button megrendelesBtn;
        private System.Windows.Forms.Button termekBtn;
        private System.Windows.Forms.Button kilepesBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button bevetelezesBtn;
        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.Label userLabel;
    }
}