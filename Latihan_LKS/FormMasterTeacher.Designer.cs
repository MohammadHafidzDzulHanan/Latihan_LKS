namespace Latihan_LKS
{
    partial class FormMasterTeacher
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbogender = new System.Windows.Forms.ComboBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Master Teacher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search by Name";
            // 
            // cbogender
            // 
            this.cbogender.FormattingEnabled = true;
            this.cbogender.Location = new System.Drawing.Point(202, 313);
            this.cbogender.Name = "cbogender";
            this.cbogender.Size = new System.Drawing.Size(121, 28);
            this.cbogender.TabIndex = 2;
            this.cbogender.SelectedIndexChanged += new System.EventHandler(this.cbogender_SelectedIndexChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(193, 86);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(155, 26);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(52, 132);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 62;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.Size = new System.Drawing.Size(687, 121);
            this.dgvData.TabIndex = 4;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Subject";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Name";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(584, 351);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(155, 26);
            this.tbPassword.TabIndex = 12;
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(584, 313);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(155, 26);
            this.tbSubject.TabIndex = 13;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(584, 270);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(155, 26);
            this.tbPhone.TabIndex = 14;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(202, 351);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(155, 26);
            this.tbAddress.TabIndex = 15;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(202, 267);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(155, 26);
            this.tbName.TabIndex = 16;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(157, 406);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(103, 32);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(475, 406);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 32);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(313, 406);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 32);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(685, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(103, 32);
            this.btnLogout.TabIndex = 20;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FormMasterTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.cbogender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMasterTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMasterTeacher";
            this.Load += new System.EventHandler(this.FormMasterTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbogender;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnLogout;
    }
}