﻿namespace SistemaGestionEmpleados.PL
{
    partial class FrmEmployees
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
            picEmployee = new System.Windows.Forms.PictureBox();
            lblBackground = new System.Windows.Forms.Label();
            txtNames = new System.Windows.Forms.TextBox();
            txtFirstSurname = new System.Windows.Forms.TextBox();
            txtSecSurname = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            lblNames = new System.Windows.Forms.Label();
            lblFirstSurname = new System.Windows.Forms.Label();
            lblSecSurname = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            lblPhone = new System.Windows.Forms.Label();
            btnAddEmployee = new System.Windows.Forms.Button();
            btnEditEmployee = new System.Windows.Forms.Button();
            btnDeleteEmployee = new System.Windows.Forms.Button();
            dgvEmployeesList = new System.Windows.Forms.DataGridView();
            names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            fSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            numPhone = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)picEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeesList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPhone).BeginInit();
            SuspendLayout();
            // 
            // picEmployee
            // 
            picEmployee.Location = new System.Drawing.Point(12, 12);
            picEmployee.Name = "picEmployee";
            picEmployee.Size = new System.Drawing.Size(330, 301);
            picEmployee.TabIndex = 0;
            picEmployee.TabStop = false;
            // 
            // lblBackground
            // 
            lblBackground.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            lblBackground.Location = new System.Drawing.Point(0, -1);
            lblBackground.Name = "lblBackground";
            lblBackground.Size = new System.Drawing.Size(1093, 334);
            lblBackground.TabIndex = 1;
            // 
            // txtNames
            // 
            txtNames.Location = new System.Drawing.Point(377, 37);
            txtNames.Name = "txtNames";
            txtNames.Size = new System.Drawing.Size(289, 27);
            txtNames.TabIndex = 2;
            // 
            // txtFirstSurname
            // 
            txtFirstSurname.Location = new System.Drawing.Point(377, 113);
            txtFirstSurname.Name = "txtFirstSurname";
            txtFirstSurname.Size = new System.Drawing.Size(289, 27);
            txtFirstSurname.TabIndex = 3;
            // 
            // txtSecSurname
            // 
            txtSecSurname.Location = new System.Drawing.Point(742, 113);
            txtSecSurname.Name = "txtSecSurname";
            txtSecSurname.Size = new System.Drawing.Size(289, 27);
            txtSecSurname.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(377, 189);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(289, 27);
            txtEmail.TabIndex = 5;
            // 
            // lblNames
            // 
            lblNames.AutoSize = true;
            lblNames.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            lblNames.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNames.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lblNames.Location = new System.Drawing.Point(377, 12);
            lblNames.Name = "lblNames";
            lblNames.Size = new System.Drawing.Size(94, 22);
            lblNames.TabIndex = 7;
            lblNames.Text = "Nombres";
            // 
            // lblFirstSurname
            // 
            lblFirstSurname.AutoSize = true;
            lblFirstSurname.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            lblFirstSurname.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblFirstSurname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lblFirstSurname.Location = new System.Drawing.Point(377, 88);
            lblFirstSurname.Name = "lblFirstSurname";
            lblFirstSurname.Size = new System.Drawing.Size(150, 22);
            lblFirstSurname.TabIndex = 8;
            lblFirstSurname.Text = "Primer Apellido";
            // 
            // lblSecSurname
            // 
            lblSecSurname.AutoSize = true;
            lblSecSurname.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            lblSecSurname.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblSecSurname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lblSecSurname.Location = new System.Drawing.Point(742, 88);
            lblSecSurname.Name = "lblSecSurname";
            lblSecSurname.Size = new System.Drawing.Size(172, 22);
            lblSecSurname.TabIndex = 9;
            lblSecSurname.Text = "Segundo Apellido";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            lblEmail.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lblEmail.Location = new System.Drawing.Point(377, 164);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(181, 22);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Correo Electrónico";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            lblPhone.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPhone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lblPhone.Location = new System.Drawing.Point(742, 164);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new System.Drawing.Size(91, 22);
            lblPhone.TabIndex = 11;
            lblPhone.Text = "Teléfono";
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new System.Drawing.Point(377, 259);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new System.Drawing.Size(181, 54);
            btnAddEmployee.TabIndex = 12;
            btnAddEmployee.Text = "AGREGAR";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // btnEditEmployee
            // 
            btnEditEmployee.Location = new System.Drawing.Point(616, 259);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.Size = new System.Drawing.Size(181, 54);
            btnEditEmployee.TabIndex = 13;
            btnEditEmployee.Text = "EDITAR";
            btnEditEmployee.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.Location = new System.Drawing.Point(850, 259);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new System.Drawing.Size(181, 54);
            btnDeleteEmployee.TabIndex = 14;
            btnDeleteEmployee.Text = "ELIMINAR";
            btnDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // dgvEmployeesList
            // 
            dgvEmployeesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployeesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { names, fSurname, sSurname, email, phone });
            dgvEmployeesList.Location = new System.Drawing.Point(12, 351);
            dgvEmployeesList.Name = "dgvEmployeesList";
            dgvEmployeesList.RowHeadersWidth = 51;
            dgvEmployeesList.RowTemplate.Height = 29;
            dgvEmployeesList.Size = new System.Drawing.Size(1019, 215);
            dgvEmployeesList.TabIndex = 15;
            // 
            // names
            // 
            names.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            names.HeaderText = "Nombres";
            names.MinimumWidth = 6;
            names.Name = "names";
            names.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // fSurname
            // 
            fSurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            fSurname.HeaderText = "Primer Apellido";
            fSurname.MinimumWidth = 6;
            fSurname.Name = "fSurname";
            // 
            // sSurname
            // 
            sSurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            sSurname.HeaderText = "Segundo Apellido";
            sSurname.MinimumWidth = 6;
            sSurname.Name = "sSurname";
            // 
            // email
            // 
            email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            email.HeaderText = "Correo Electrónico";
            email.MinimumWidth = 6;
            email.Name = "email";
            // 
            // phone
            // 
            phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            phone.HeaderText = "Teléfono";
            phone.MinimumWidth = 6;
            phone.Name = "phone";
            // 
            // numPhone
            // 
            numPhone.Location = new System.Drawing.Point(742, 190);
            numPhone.Maximum = new decimal(new int[] { 1874919423, 2328306, 0, 0 });
            numPhone.Name = "numPhone";
            numPhone.Size = new System.Drawing.Size(289, 27);
            numPhone.TabIndex = 16;
            // 
            // FrmEmployees
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1057, 578);
            Controls.Add(numPhone);
            Controls.Add(dgvEmployeesList);
            Controls.Add(btnDeleteEmployee);
            Controls.Add(btnEditEmployee);
            Controls.Add(btnAddEmployee);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblSecSurname);
            Controls.Add(lblFirstSurname);
            Controls.Add(lblNames);
            Controls.Add(txtEmail);
            Controls.Add(txtSecSurname);
            Controls.Add(txtFirstSurname);
            Controls.Add(txtNames);
            Controls.Add(picEmployee);
            Controls.Add(lblBackground);
            Name = "FrmEmployees";
            Text = "FrmEmployees";
            ((System.ComponentModel.ISupportInitialize)picEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeesList).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPhone).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picEmployee;
        private System.Windows.Forms.Label lblBackground;
        private System.Windows.Forms.TextBox txtNames;
        private System.Windows.Forms.TextBox txtFirstSurname;
        private System.Windows.Forms.TextBox txtSecSurname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblNames;
        private System.Windows.Forms.Label lblFirstSurname;
        private System.Windows.Forms.Label lblSecSurname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.DataGridView dgvEmployeesList;
        private System.Windows.Forms.DataGridViewTextBoxColumn names;
        private System.Windows.Forms.DataGridViewTextBoxColumn fSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.NumericUpDown numPhone;
    }
}