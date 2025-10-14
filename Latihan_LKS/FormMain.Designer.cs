namespace Latihan_LKS
{
    partial class FormMain
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMT = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(65, 35);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(238, 52);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome !";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(571, 41);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(133, 46);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMT
            // 
            this.btnMT.Location = new System.Drawing.Point(74, 171);
            this.btnMT.Name = "btnMT";
            this.btnMT.Size = new System.Drawing.Size(630, 78);
            this.btnMT.TabIndex = 2;
            this.btnMT.Text = "Master Teacher";
            this.btnMT.UseVisualStyleBackColor = true;
            this.btnMT.Click += new System.EventHandler(this.btnMT_Click);
            // 
            // btnMS
            // 
            this.btnMS.Location = new System.Drawing.Point(74, 279);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(630, 78);
            this.btnMS.TabIndex = 3;
            this.btnMS.Text = "Master Student";
            this.btnMS.UseVisualStyleBackColor = true;
            this.btnMS.Click += new System.EventHandler(this.btnMS_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMS);
            this.Controls.Add(this.btnMT);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblWelcome);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMT;
        private System.Windows.Forms.Button btnMS;
    }
}