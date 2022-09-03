namespace AttendanceRegister
{
    partial class frmClassAllocation
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.txtAdmNo = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtFirsName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBackToDashBoard = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.cmbClass);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.txtAdmNo);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.txtFirsName);
            this.panel3.Controls.Add(this.txtLastName);
            this.panel3.Location = new System.Drawing.Point(11, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(439, 243);
            this.panel3.TabIndex = 6;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.label18.Location = new System.Drawing.Point(15, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 21);
            this.label18.TabIndex = 23;
            this.label18.Text = "Student ID:";
            // 
            // txtAdmNo
            // 
            this.txtAdmNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdmNo.Location = new System.Drawing.Point(147, 23);
            this.txtAdmNo.Multiline = true;
            this.txtAdmNo.Name = "txtAdmNo";
            this.txtAdmNo.Size = new System.Drawing.Size(237, 25);
            this.txtAdmNo.TabIndex = 22;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.label22.Location = new System.Drawing.Point(14, 149);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(96, 21);
            this.label22.TabIndex = 16;
            this.label22.Text = "First Name:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.label23.Location = new System.Drawing.Point(16, 87);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(94, 21);
            this.label23.TabIndex = 15;
            this.label23.Text = "Last Name:";
            // 
            // txtFirsName
            // 
            this.txtFirsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirsName.Location = new System.Drawing.Point(147, 147);
            this.txtFirsName.Multiline = true;
            this.txtFirsName.Name = "txtFirsName";
            this.txtFirsName.Size = new System.Drawing.Size(237, 25);
            this.txtFirsName.TabIndex = 13;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(147, 83);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(237, 25);
            this.txtLastName.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnBackToDashBoard);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Location = new System.Drawing.Point(11, 273);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 64);
            this.panel2.TabIndex = 7;
            // 
            // btnBackToDashBoard
            // 
            this.btnBackToDashBoard.BackColor = System.Drawing.Color.Transparent;
            this.btnBackToDashBoard.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBackToDashBoard.FlatAppearance.BorderSize = 3;
            this.btnBackToDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToDashBoard.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBackToDashBoard.Location = new System.Drawing.Point(226, 8);
            this.btnBackToDashBoard.Name = "btnBackToDashBoard";
            this.btnBackToDashBoard.Size = new System.Drawing.Size(181, 39);
            this.btnBackToDashBoard.TabIndex = 3;
            this.btnBackToDashBoard.Text = "Exit";
            this.btnBackToDashBoard.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSave.FlatAppearance.BorderSize = 3;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(21, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(181, 39);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(147, 194);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(237, 21);
            this.cmbClass.TabIndex = 48;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(176)))), ((int)(((byte)(255)))));
            this.label21.Location = new System.Drawing.Point(30, 191);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 21);
            this.label21.TabIndex = 47;
            this.label21.Text = "Class:";
            // 
            // frmClassAllocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(461, 351);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClassAllocation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Class Allocation";
            this.Load += new System.EventHandler(this.ClassAllocation_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtAdmNo;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtFirsName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBackToDashBoard;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label label21;
    }
}