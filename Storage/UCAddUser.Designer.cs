
namespace Storage
{
    partial class UCAddUser
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
            this.mainLabel = new System.Windows.Forms.Label();
            this.userNameLb = new System.Windows.Forms.Label();
            this.passwordLb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.emailLb = new System.Windows.Forms.Label();
            this.userNameTxb = new System.Windows.Forms.TextBox();
            this.password1Txb = new System.Windows.Forms.TextBox();
            this.emailTxb = new System.Windows.Forms.TextBox();
            this.typeOfUserCbx = new System.Windows.Forms.ComboBox();
            this.passwordLb2 = new System.Windows.Forms.Label();
            this.password2Txb = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Content = new System.Windows.Forms.Panel();
            this.passwordCbx = new System.Windows.Forms.CheckBox();
            this.nameTxb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Content.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mainLabel.Location = new System.Drawing.Point(10, 20);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(305, 25);
            this.mainLabel.TabIndex = 14;
            this.mainLabel.Text = "Új felhasználó regisztrálása";
            // 
            // userNameLb
            // 
            this.userNameLb.AutoSize = true;
            this.userNameLb.Location = new System.Drawing.Point(12, 117);
            this.userNameLb.Name = "userNameLb";
            this.userNameLb.Size = new System.Drawing.Size(84, 13);
            this.userNameLb.TabIndex = 15;
            this.userNameLb.Text = "Felhasználónév:";
            // 
            // passwordLb
            // 
            this.passwordLb.AutoSize = true;
            this.passwordLb.Location = new System.Drawing.Point(12, 143);
            this.passwordLb.Name = "passwordLb";
            this.passwordLb.Size = new System.Drawing.Size(39, 13);
            this.passwordLb.TabIndex = 16;
            this.passwordLb.Text = "Jelszó:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Felhasználó típusa:";
            // 
            // emailLb
            // 
            this.emailLb.AutoSize = true;
            this.emailLb.Location = new System.Drawing.Point(12, 222);
            this.emailLb.Name = "emailLb";
            this.emailLb.Size = new System.Drawing.Size(38, 13);
            this.emailLb.TabIndex = 19;
            this.emailLb.Text = "E-mail:";
            // 
            // userNameTxb
            // 
            this.userNameTxb.Location = new System.Drawing.Point(145, 114);
            this.userNameTxb.Name = "userNameTxb";
            this.userNameTxb.Size = new System.Drawing.Size(200, 20);
            this.userNameTxb.TabIndex = 20;
            // 
            // password1Txb
            // 
            this.password1Txb.Location = new System.Drawing.Point(145, 140);
            this.password1Txb.Name = "password1Txb";
            this.password1Txb.PasswordChar = '*';
            this.password1Txb.Size = new System.Drawing.Size(200, 20);
            this.password1Txb.TabIndex = 21;
            // 
            // emailTxb
            // 
            this.emailTxb.Location = new System.Drawing.Point(145, 219);
            this.emailTxb.Name = "emailTxb";
            this.emailTxb.Size = new System.Drawing.Size(200, 20);
            this.emailTxb.TabIndex = 22;
            // 
            // typeOfUserCbx
            // 
            this.typeOfUserCbx.FormattingEnabled = true;
            this.typeOfUserCbx.Location = new System.Drawing.Point(145, 192);
            this.typeOfUserCbx.Name = "typeOfUserCbx";
            this.typeOfUserCbx.Size = new System.Drawing.Size(200, 21);
            this.typeOfUserCbx.TabIndex = 23;
            // 
            // passwordLb2
            // 
            this.passwordLb2.AutoSize = true;
            this.passwordLb2.Location = new System.Drawing.Point(12, 169);
            this.passwordLb2.Name = "passwordLb2";
            this.passwordLb2.Size = new System.Drawing.Size(66, 13);
            this.passwordLb2.TabIndex = 25;
            this.passwordLb2.Text = "Jelszó ismét:";
            // 
            // password2Txb
            // 
            this.password2Txb.Location = new System.Drawing.Point(145, 166);
            this.password2Txb.Name = "password2Txb";
            this.password2Txb.PasswordChar = '*';
            this.password2Txb.Size = new System.Drawing.Size(200, 20);
            this.password2Txb.TabIndex = 26;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(566, 609);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "Mégse";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(485, 609);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Mentés";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Content
            // 
            this.Content.Controls.Add(this.button2);
            this.Content.Controls.Add(this.passwordCbx);
            this.Content.Controls.Add(this.button3);
            this.Content.Controls.Add(this.nameTxb);
            this.Content.Controls.Add(this.label1);
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(644, 635);
            this.Content.TabIndex = 29;
            // 
            // passwordCbx
            // 
            this.passwordCbx.AutoSize = true;
            this.passwordCbx.Location = new System.Drawing.Point(15, 261);
            this.passwordCbx.Name = "passwordCbx";
            this.passwordCbx.Size = new System.Drawing.Size(113, 17);
            this.passwordCbx.TabIndex = 2;
            this.passwordCbx.Text = "Jelszó módosítása";
            this.passwordCbx.UseVisualStyleBackColor = true;
            this.passwordCbx.Visible = false;
            this.passwordCbx.CheckedChanged += new System.EventHandler(this.passwordCbx_CheckedChanged);
            // 
            // nameTxb
            // 
            this.nameTxb.Location = new System.Drawing.Point(145, 88);
            this.nameTxb.Name = "nameTxb";
            this.nameTxb.Size = new System.Drawing.Size(200, 20);
            this.nameTxb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // UCAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.password2Txb);
            this.Controls.Add(this.passwordLb2);
            this.Controls.Add(this.typeOfUserCbx);
            this.Controls.Add(this.emailTxb);
            this.Controls.Add(this.password1Txb);
            this.Controls.Add(this.userNameTxb);
            this.Controls.Add(this.emailLb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordLb);
            this.Controls.Add(this.userNameLb);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.Content);
            this.Name = "UCAddUser";
            this.Size = new System.Drawing.Size(644, 635);
            this.Content.ResumeLayout(false);
            this.Content.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Label userNameLb;
        private System.Windows.Forms.Label passwordLb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label emailLb;
        private System.Windows.Forms.TextBox userNameTxb;
        private System.Windows.Forms.TextBox password1Txb;
        private System.Windows.Forms.TextBox emailTxb;
        private System.Windows.Forms.ComboBox typeOfUserCbx;
        private System.Windows.Forms.Label passwordLb2;
        private System.Windows.Forms.TextBox password2Txb;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.TextBox nameTxb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox passwordCbx;
    }
}
