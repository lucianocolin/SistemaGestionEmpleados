namespace SistemaGestionEmpleados.PL
{
    partial class FrmDepartment
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
            lblID = new System.Windows.Forms.Label();
            lblDeptName = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            btnAdd = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            dgvDeptList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDeptList).BeginInit();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.Location = new System.Drawing.Point(12, 22);
            lblID.Name = "lblID";
            lblID.Size = new System.Drawing.Size(154, 25);
            lblID.TabIndex = 0;
            lblID.Text = "ID";
            // 
            // lblDeptName
            // 
            lblDeptName.Location = new System.Drawing.Point(230, 22);
            lblDeptName.Name = "lblDeptName";
            lblDeptName.Size = new System.Drawing.Size(228, 25);
            lblDeptName.TabIndex = 1;
            lblDeptName.Text = "Nombre Departamento";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(12, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(191, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(230, 50);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(374, 27);
            textBox2.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(12, 103);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(124, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(167, 103);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(124, 29);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Editar";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(323, 103);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(124, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(480, 103);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(124, 29);
            btnClear.TabIndex = 7;
            btnClear.Text = "Limpiar";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // dgvDeptList
            // 
            dgvDeptList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDeptList.Location = new System.Drawing.Point(12, 155);
            dgvDeptList.Name = "dgvDeptList";
            dgvDeptList.RowHeadersWidth = 51;
            dgvDeptList.RowTemplate.Height = 29;
            dgvDeptList.Size = new System.Drawing.Size(592, 416);
            dgvDeptList.TabIndex = 8;
            // 
            // FrmDepartment
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(631, 583);
            Controls.Add(dgvDeptList);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblDeptName);
            Controls.Add(lblID);
            Name = "FrmDepartment";
            Text = "FrmDepartment";
            ((System.ComponentModel.ISupportInitialize)dgvDeptList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDeptName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvDeptList;
    }
}