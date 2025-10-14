namespace Latihan_LKS
{
    partial class FormMasterStudent
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbClass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.cbogender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(295, 406);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 32);
            this.btnUpdate.TabIndex = 39;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(457, 406);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 32);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(139, 406);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(103, 32);
            this.btnInsert.TabIndex = 37;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(184, 267);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(155, 26);
            this.tbName.TabIndex = 36;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(184, 351);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(155, 26);
            this.tbAddress.TabIndex = 35;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(566, 270);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(155, 26);
            this.tbPhone.TabIndex = 34;
            // 
            // tbClass
            // 
            this.tbClass.Location = new System.Drawing.Point(566, 313);
            this.tbClass.Name = "tbClass";
            this.tbClass.Size = new System.Drawing.Size(155, 26);
            this.tbClass.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Class";
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(34, 132);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 62;
            this.dgvData.RowTemplate.Height = 28;
            this.dgvData.Size = new System.Drawing.Size(687, 121);
            this.dgvData.TabIndex = 25;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(175, 86);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(155, 26);
            this.tbSearch.TabIndex = 24;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // cbogender
            // 
            this.cbogender.FormattingEnabled = true;
            this.cbogender.Location = new System.Drawing.Point(184, 313);
            this.cbogender.Name = "cbogender";
            this.cbogender.Size = new System.Drawing.Size(121, 28);
            this.cbogender.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Search by Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 37);
            this.label1.TabIndex = 21;
            this.label1.Text = "Master Student";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(685, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(103, 32);
            this.btnLogout.TabIndex = 40;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormMasterStudent
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
            this.Controls.Add(this.tbClass);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.cbogender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMasterStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMasterStudent";
            this.Load += new System.EventHandler(this.FormMasterStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbClass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ComboBox cbogender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
    }
}