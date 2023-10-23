namespace SistemaGestionEmpleados.PL
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
            btnAddEmployee = new System.Windows.Forms.Button();
            btnEditEmployee = new System.Windows.Forms.Button();
            btnDeleteEmployee = new System.Windows.Forms.Button();
            dgvEmployeesList = new System.Windows.Forms.DataGridView();
            id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            names = new System.Windows.Forms.DataGridViewTextBoxColumn();
            fSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            sSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnExam = new System.Windows.Forms.Button();
            cbDepartment = new System.Windows.Forms.ComboBox();
            lblDepartment = new System.Windows.Forms.Label();
            btnClear = new System.Windows.Forms.Button();
            txtID = new System.Windows.Forms.TextBox();
            lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)picEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeesList).BeginInit();
            SuspendLayout();
            // 
            // picEmployee
            // 
            picEmployee.Location = new System.Drawing.Point(48, 12);
            picEmployee.Name = "picEmployee";
            picEmployee.Size = new System.Drawing.Size(263, 231);
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
            txtNames.Location = new System.Drawing.Point(646, 39);
            txtNames.Name = "txtNames";
            txtNames.Size = new System.Drawing.Size(385, 27);
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
            txtSecSurname.Location = new System.Drawing.Point(722, 113);
            txtSecSurname.Name = "txtSecSurname";
            txtSecSurname.Size = new System.Drawing.Size(309, 27);
            txtSecSurname.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(722, 191);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(309, 27);
            txtEmail.TabIndex = 5;
            // 
            // lblNames
            // 
            lblNames.AutoSize = true;
            lblNames.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            lblNames.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblNames.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lblNames.Location = new System.Drawing.Point(646, 14);
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
            lblSecSurname.Location = new System.Drawing.Point(722, 88);
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
            lblEmail.Location = new System.Drawing.Point(722, 166);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(181, 22);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Correo Electrónico";
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new System.Drawing.Point(377, 259);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new System.Drawing.Size(144, 54);
            btnAddEmployee.TabIndex = 12;
            btnAddEmployee.Text = "AGREGAR";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // btnEditEmployee
            // 
            btnEditEmployee.Location = new System.Drawing.Point(550, 259);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.Size = new System.Drawing.Size(144, 54);
            btnEditEmployee.TabIndex = 13;
            btnEditEmployee.Text = "EDITAR";
            btnEditEmployee.UseVisualStyleBackColor = true;
            btnEditEmployee.Click += btnEditEmployee_Click;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.Location = new System.Drawing.Point(722, 259);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new System.Drawing.Size(144, 54);
            btnDeleteEmployee.TabIndex = 14;
            btnDeleteEmployee.Text = "ELIMINAR";
            btnDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // dgvEmployeesList
            // 
            dgvEmployeesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployeesList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { id, names, fSurname, sSurname, dept, email });
            dgvEmployeesList.Location = new System.Drawing.Point(12, 351);
            dgvEmployeesList.Name = "dgvEmployeesList";
            dgvEmployeesList.RowHeadersWidth = 51;
            dgvEmployeesList.RowTemplate.Height = 29;
            dgvEmployeesList.Size = new System.Drawing.Size(1019, 215);
            dgvEmployeesList.TabIndex = 15;
            // 
            // id
            // 
            id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
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
            // dept
            // 
            dept.HeaderText = "Departamento";
            dept.MinimumWidth = 6;
            dept.Name = "dept";
            dept.Width = 125;
            // 
            // email
            // 
            email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            email.HeaderText = "Correo Electrónico";
            email.MinimumWidth = 6;
            email.Name = "email";
            // 
            // btnExam
            // 
            btnExam.Location = new System.Drawing.Point(48, 259);
            btnExam.Name = "btnExam";
            btnExam.Size = new System.Drawing.Size(263, 54);
            btnExam.TabIndex = 17;
            btnExam.Text = "EXAMINAR...";
            btnExam.UseVisualStyleBackColor = true;
            // 
            // cbDepartment
            // 
            cbDepartment.FormattingEnabled = true;
            cbDepartment.Location = new System.Drawing.Point(377, 191);
            cbDepartment.Name = "cbDepartment";
            cbDepartment.Size = new System.Drawing.Size(289, 28);
            cbDepartment.TabIndex = 18;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            lblDepartment.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDepartment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lblDepartment.Location = new System.Drawing.Point(377, 166);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new System.Drawing.Size(145, 22);
            lblDepartment.TabIndex = 19;
            lblDepartment.Text = "Departamento";
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(887, 259);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(144, 54);
            btnClear.TabIndex = 20;
            btnClear.Text = "LIMPIAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtID
            // 
            txtID.Location = new System.Drawing.Point(377, 39);
            txtID.Name = "txtID";
            txtID.Size = new System.Drawing.Size(209, 27);
            txtID.TabIndex = 21;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            lblID.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lblID.Location = new System.Drawing.Point(377, 14);
            lblID.Name = "lblID";
            lblID.Size = new System.Drawing.Size(30, 22);
            lblID.TabIndex = 22;
            lblID.Text = "ID";
            // 
            // FrmEmployees
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1055, 578);
            Controls.Add(lblID);
            Controls.Add(txtID);
            Controls.Add(btnClear);
            Controls.Add(lblDepartment);
            Controls.Add(cbDepartment);
            Controls.Add(btnExam);
            Controls.Add(dgvEmployeesList);
            Controls.Add(btnDeleteEmployee);
            Controls.Add(btnEditEmployee);
            Controls.Add(btnAddEmployee);
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
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "FrmEmployees";
            Load += FrmEmployees_Load;
            ((System.ComponentModel.ISupportInitialize)picEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeesList).EndInit();
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
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.DataGridView dgvEmployeesList;
        private System.Windows.Forms.Button btnExam;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn names;
        private System.Windows.Forms.DataGridViewTextBoxColumn fSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dept;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
    }
}