namespace SistemaGestionEmpleados
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWelcomeTitle = new System.Windows.Forms.Label();
            lblUsername = new System.Windows.Forms.Label();
            txtUsername = new System.Windows.Forms.TextBox();
            lblPassword = new System.Windows.Forms.Label();
            txtPassword = new System.Windows.Forms.TextBox();
            btnLogin = new System.Windows.Forms.Button();
            btnRegister = new System.Windows.Forms.Button();
            lblRegisterText = new System.Windows.Forms.Label();
            lblEmptyUsername = new System.Windows.Forms.Label();
            lblEmptyPassword = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblWelcomeTitle
            // 
            lblWelcomeTitle.Font = new System.Drawing.Font("Montserrat", 25.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblWelcomeTitle.Location = new System.Drawing.Point(1, 45);
            lblWelcomeTitle.Name = "lblWelcomeTitle";
            lblWelcomeTitle.Size = new System.Drawing.Size(607, 60);
            lblWelcomeTitle.TabIndex = 0;
            lblWelcomeTitle.Text = "Bienvenido/a Usuario!";
            lblWelcomeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            lblUsername.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblUsername.Location = new System.Drawing.Point(1, 138);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(607, 25);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Nombre de Usuario";
            lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            txtUsername.Location = new System.Drawing.Point(134, 166);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Ingrese su nombre de usuario...";
            txtUsername.Size = new System.Drawing.Size(344, 27);
            txtUsername.TabIndex = 2;
            txtUsername.Leave += txtUsername_Leave;
            // 
            // lblPassword
            // 
            lblPassword.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblPassword.Location = new System.Drawing.Point(1, 231);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new System.Drawing.Size(607, 25);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Contraseña";
            lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            txtPassword.Location = new System.Drawing.Point(134, 259);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Ingrese su contraseña...";
            txtPassword.Size = new System.Drawing.Size(344, 27);
            txtPassword.TabIndex = 4;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // btnLogin
            // 
            btnLogin.Enabled = false;
            btnLogin.Location = new System.Drawing.Point(314, 343);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new System.Drawing.Size(226, 56);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new System.Drawing.Point(68, 343);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new System.Drawing.Size(215, 56);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Registrarse";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblRegisterText
            // 
            lblRegisterText.Font = new System.Drawing.Font("Montserrat", 7.79999971F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblRegisterText.Location = new System.Drawing.Point(68, 314);
            lblRegisterText.Name = "lblRegisterText";
            lblRegisterText.Size = new System.Drawing.Size(215, 26);
            lblRegisterText.TabIndex = 7;
            lblRegisterText.Text = "Registrar un nuevo usuario";
            lblRegisterText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmptyUsername
            // 
            lblEmptyUsername.ForeColor = System.Drawing.Color.Red;
            lblEmptyUsername.Location = new System.Drawing.Point(134, 196);
            lblEmptyUsername.Name = "lblEmptyUsername";
            lblEmptyUsername.Size = new System.Drawing.Size(344, 25);
            lblEmptyUsername.TabIndex = 8;
            lblEmptyUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEmptyPassword
            // 
            lblEmptyPassword.ForeColor = System.Drawing.Color.Red;
            lblEmptyPassword.Location = new System.Drawing.Point(134, 289);
            lblEmptyPassword.Name = "lblEmptyPassword";
            lblEmptyPassword.Size = new System.Drawing.Size(344, 25);
            lblEmptyPassword.TabIndex = 9;
            lblEmptyPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(502, 308);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(608, 438);
            Controls.Add(button1);
            Controls.Add(lblEmptyPassword);
            Controls.Add(lblEmptyUsername);
            Controls.Add(lblRegisterText);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblWelcomeTitle);
            Name = "frmLogin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblRegisterText;
        private System.Windows.Forms.Label lblEmptyUsername;
        private System.Windows.Forms.Label lblEmptyPassword;
        private System.Windows.Forms.Button button1;
    }
}
