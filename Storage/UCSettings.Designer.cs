
namespace Storage
{
    partial class UCSettings
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
            this.mainLaben = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.companyBtn = new System.Windows.Forms.Button();
            this.usersBtn = new System.Windows.Forms.Button();
            this.Content = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLaben
            // 
            this.mainLaben.AutoSize = true;
            this.mainLaben.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mainLaben.Location = new System.Drawing.Point(10, 20);
            this.mainLaben.Name = "mainLaben";
            this.mainLaben.Size = new System.Drawing.Size(120, 25);
            this.mainLaben.TabIndex = 12;
            this.mainLaben.Text = "Beállítások";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.companyBtn);
            this.panel1.Controls.Add(this.usersBtn);
            this.panel1.Location = new System.Drawing.Point(0, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 666);
            this.panel1.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(0, 192);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 50);
            this.button2.TabIndex = 8;
            this.button2.Text = "Adatbázis csatlakozás";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // companyBtn
            // 
            this.companyBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.companyBtn.Location = new System.Drawing.Point(0, 136);
            this.companyBtn.Name = "companyBtn";
            this.companyBtn.Size = new System.Drawing.Size(175, 50);
            this.companyBtn.TabIndex = 7;
            this.companyBtn.Text = "Céges adatok";
            this.companyBtn.UseVisualStyleBackColor = true;
            this.companyBtn.Click += new System.EventHandler(this.companyBtn_Click);
            // 
            // usersBtn
            // 
            this.usersBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.usersBtn.Location = new System.Drawing.Point(0, 80);
            this.usersBtn.Name = "usersBtn";
            this.usersBtn.Size = new System.Drawing.Size(175, 50);
            this.usersBtn.TabIndex = 6;
            this.usersBtn.Text = "Felhasználók";
            this.usersBtn.UseVisualStyleBackColor = true;
            this.usersBtn.Click += new System.EventHandler(this.usersBtn_Click);
            // 
            // Content
            // 
            this.Content.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Content.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Content.Location = new System.Drawing.Point(181, 63);
            this.Content.Margin = new System.Windows.Forms.Padding(0);
            this.Content.Name = "Content";
            this.Content.Padding = new System.Windows.Forms.Padding(2);
            this.Content.Size = new System.Drawing.Size(987, 657);
            this.Content.TabIndex = 14;
            // 
            // UCSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.Content);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainLaben);
            this.Name = "UCSettings";
            this.Size = new System.Drawing.Size(1175, 729);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLaben;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button companyBtn;
        private System.Windows.Forms.Button usersBtn;
        private System.Windows.Forms.Panel Content;
    }
}
