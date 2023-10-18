namespace SistemaGestionEmpleados.PL
{
    partial class FrmRegister
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
            lblRegisterTitle = new System.Windows.Forms.Label();
            txtNewUsername = new System.Windows.Forms.TextBox();
            lblNewUsername = new System.Windows.Forms.Label();
            lblNewUserRole = new System.Windows.Forms.Label();
            cboNewUserRole = new System.Windows.Forms.ComboBox();
            lblNewPassword = new System.Windows.Forms.Label();
            txtNewPassword = new System.Windows.Forms.TextBox();
            lblConfirmNewPassword = new System.Windows.Forms.Label();
            txtConfirmPassword = new System.Windows.Forms.TextBox();
            btnCancelRegister = new System.Windows.Forms.Button();
            btnCreateUser = new System.Windows.Forms.Button();
            lblEmptyNewUsername = new System.Windows.Forms.Label();
            lblEmptyRole = new System.Windows.Forms.Label();
            lblEmptyNewPassword = new System.Windows.Forms.Label();
            lblConfirmPassword = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lblRegisterTitle
            // 
            lblRegisterTitle.Font = new System.Drawing.Font("Montserrat", 25.8000011F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblRegisterTitle.Location = new System.Drawing.Point(0, 22);
            lblRegisterTitle.Name = "lblRegisterTitle";
            lblRegisterTitle.Size = new System.Drawing.Size(547, 60);
            lblRegisterTitle.TabIndex = 1;
            lblRegisterTitle.Text = "Crear nuevo Usuario";
            lblRegisterTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNewUsername
            // 
            txtNewUsername.Location = new System.Drawing.Point(23, 147);
            txtNewUsername.Name = "txtNewUsername";
            txtNewUsername.PlaceholderText = "Crear nombre de usuario...";
            txtNewUsername.Size = new System.Drawing.Size(344, 27);
            txtNewUsername.TabIndex = 3;
            txtNewUsername.Leave += txtNewUsername_Leave;
            // 
            // lblNewUsername
            // 
            lblNewUsername.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblNewUsername.Location = new System.Drawing.Point(23, 119);
            lblNewUsername.Name = "lblNewUsername";
            lblNewUsername.Size = new System.Drawing.Size(524, 25);
            lblNewUsername.TabIndex = 4;
            lblNewUsername.Text = "Nuevo nombre de usuario";
            lblNewUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNewUserRole
            // 
            lblNewUserRole.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblNewUserRole.Location = new System.Drawing.Point(23, 210);
            lblNewUserRole.Name = "lblNewUserRole";
            lblNewUserRole.Size = new System.Drawing.Size(524, 25);
            lblNewUserRole.TabIndex = 5;
            lblNewUserRole.Text = "Rol";
            lblNewUserRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboNewUserRole
            // 
            cboNewUserRole.FormattingEnabled = true;
            cboNewUserRole.Location = new System.Drawing.Point(23, 238);
            cboNewUserRole.Name = "cboNewUserRole";
            cboNewUserRole.Size = new System.Drawing.Size(227, 28);
            cboNewUserRole.TabIndex = 6;
            cboNewUserRole.Leave += cboNewUserRole_Leave;
            // 
            // lblNewPassword
            // 
            lblNewPassword.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblNewPassword.Location = new System.Drawing.Point(23, 305);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new System.Drawing.Size(524, 25);
            lblNewPassword.TabIndex = 7;
            lblNewPassword.Text = "Nueva contraseña";
            lblNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new System.Drawing.Point(23, 333);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PlaceholderText = "Crear una nueva contraseña...";
            txtNewPassword.Size = new System.Drawing.Size(344, 27);
            txtNewPassword.TabIndex = 8;
            txtNewPassword.Leave += txtNewPassword_Leave;
            // 
            // lblConfirmNewPassword
            // 
            lblConfirmNewPassword.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblConfirmNewPassword.Location = new System.Drawing.Point(23, 399);
            lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            lblConfirmNewPassword.Size = new System.Drawing.Size(524, 25);
            lblConfirmNewPassword.TabIndex = 9;
            lblConfirmNewPassword.Text = "Confirmar nueva contraseña";
            lblConfirmNewPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new System.Drawing.Point(23, 427);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PlaceholderText = "Repetir la contraseña creada...";
            txtConfirmPassword.Size = new System.Drawing.Size(344, 27);
            txtConfirmPassword.TabIndex = 10;
            txtConfirmPassword.Leave += txtConfirmPassword_Leave;
            // 
            // btnCancelRegister
            // 
            btnCancelRegister.Location = new System.Drawing.Point(23, 503);
            btnCancelRegister.Name = "btnCancelRegister";
            btnCancelRegister.Size = new System.Drawing.Size(205, 43);
            btnCancelRegister.TabIndex = 11;
            btnCancelRegister.Text = "Cancelar";
            btnCancelRegister.UseVisualStyleBackColor = true;
            btnCancelRegister.Click += btnCancelRegister_Click;
            // 
            // btnCreateUser
            // 
            btnCreateUser.Enabled = false;
            btnCreateUser.Location = new System.Drawing.Point(309, 503);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new System.Drawing.Size(205, 43);
            btnCreateUser.TabIndex = 12;
            btnCreateUser.Text = "Crear";
            btnCreateUser.UseVisualStyleBackColor = true;
            // 
            // lblEmptyNewUsername
            // 
            lblEmptyNewUsername.ForeColor = System.Drawing.Color.Red;
            lblEmptyNewUsername.Location = new System.Drawing.Point(23, 177);
            lblEmptyNewUsername.Name = "lblEmptyNewUsername";
            lblEmptyNewUsername.Size = new System.Drawing.Size(344, 25);
            lblEmptyNewUsername.TabIndex = 13;
            lblEmptyNewUsername.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEmptyRole
            // 
            lblEmptyRole.ForeColor = System.Drawing.Color.Red;
            lblEmptyRole.Location = new System.Drawing.Point(23, 269);
            lblEmptyRole.Name = "lblEmptyRole";
            lblEmptyRole.Size = new System.Drawing.Size(227, 25);
            lblEmptyRole.TabIndex = 14;
            lblEmptyRole.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEmptyNewPassword
            // 
            lblEmptyNewPassword.ForeColor = System.Drawing.Color.Red;
            lblEmptyNewPassword.Location = new System.Drawing.Point(23, 363);
            lblEmptyNewPassword.Name = "lblEmptyNewPassword";
            lblEmptyNewPassword.Size = new System.Drawing.Size(344, 25);
            lblEmptyNewPassword.TabIndex = 15;
            lblEmptyNewPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.ForeColor = System.Drawing.Color.Red;
            lblConfirmPassword.Location = new System.Drawing.Point(23, 457);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new System.Drawing.Size(344, 25);
            lblConfirmPassword.TabIndex = 16;
            lblConfirmPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(546, 575);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblEmptyNewPassword);
            Controls.Add(lblEmptyRole);
            Controls.Add(lblEmptyNewUsername);
            Controls.Add(btnCreateUser);
            Controls.Add(btnCancelRegister);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblConfirmNewPassword);
            Controls.Add(txtNewPassword);
            Controls.Add(lblNewPassword);
            Controls.Add(cboNewUserRole);
            Controls.Add(lblNewUserRole);
            Controls.Add(lblNewUsername);
            Controls.Add(txtNewUsername);
            Controls.Add(lblRegisterTitle);
            Name = "FrmRegister";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FrmRegister";
            Load += FrmRegister_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblRegisterTitle;
        private System.Windows.Forms.TextBox txtNewUsername;
        private System.Windows.Forms.Label lblNewUsername;
        private System.Windows.Forms.Label lblNewUserRole;
        private System.Windows.Forms.ComboBox cboNewUserRole;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblConfirmNewPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnCancelRegister;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Label lblEmptyNewUsername;
        private System.Windows.Forms.Label lblEmptyRole;
        private System.Windows.Forms.Label lblEmptyNewPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
    }
}