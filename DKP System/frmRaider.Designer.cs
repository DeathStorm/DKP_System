namespace DKP_System
{
    partial class frmRaider
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbDKP_T1 = new System.Windows.Forms.TextBox();
            this.lblDKP_T1 = new System.Windows.Forms.Label();
            this.tbDKP_T2 = new System.Windows.Forms.TextBox();
            this.lblDKP_T2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(63, 12);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(100, 20);
            this.tbID.TabIndex = 99;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 15);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(63, 38);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(15, 116);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(93, 116);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 23);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbDKP_T1
            // 
            this.tbDKP_T1.Location = new System.Drawing.Point(63, 64);
            this.tbDKP_T1.Name = "tbDKP_T1";
            this.tbDKP_T1.Size = new System.Drawing.Size(100, 20);
            this.tbDKP_T1.TabIndex = 101;
            // 
            // lblDKP_T1
            // 
            this.lblDKP_T1.AutoSize = true;
            this.lblDKP_T1.Location = new System.Drawing.Point(12, 71);
            this.lblDKP_T1.Name = "lblDKP_T1";
            this.lblDKP_T1.Size = new System.Drawing.Size(45, 13);
            this.lblDKP_T1.TabIndex = 100;
            this.lblDKP_T1.Text = "DKP T1";
            // 
            // tbDKP_T2
            // 
            this.tbDKP_T2.Location = new System.Drawing.Point(63, 90);
            this.tbDKP_T2.Name = "tbDKP_T2";
            this.tbDKP_T2.Size = new System.Drawing.Size(100, 20);
            this.tbDKP_T2.TabIndex = 103;
            // 
            // lblDKP_T2
            // 
            this.lblDKP_T2.AutoSize = true;
            this.lblDKP_T2.Location = new System.Drawing.Point(12, 97);
            this.lblDKP_T2.Name = "lblDKP_T2";
            this.lblDKP_T2.Size = new System.Drawing.Size(45, 13);
            this.lblDKP_T2.TabIndex = 102;
            this.lblDKP_T2.Text = "DKP T2";
            // 
            // frmRaider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 148);
            this.Controls.Add(this.tbDKP_T2);
            this.Controls.Add(this.lblDKP_T2);
            this.Controls.Add(this.tbDKP_T1);
            this.Controls.Add(this.lblDKP_T1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.tbID);
            this.Name = "frmRaider";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Raider";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.TextBox tbID;
        public System.Windows.Forms.TextBox tbName;
        public System.Windows.Forms.TextBox tbDKP_T1;
        private System.Windows.Forms.Label lblDKP_T1;
        public System.Windows.Forms.TextBox tbDKP_T2;
        private System.Windows.Forms.Label lblDKP_T2;
    }
}