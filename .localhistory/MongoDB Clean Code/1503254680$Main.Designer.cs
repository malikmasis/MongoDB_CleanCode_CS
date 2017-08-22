namespace MongoDB_Clean_Code
{
    partial class Main
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurName = new System.Windows.Forms.Label();
            this.lblIdPerson = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurName = new System.Windows.Forms.TextBox();
            this.txtIdPerson = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(20, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Ad";
            // 
            // lblSurName
            // 
            this.lblSurName.AutoSize = true;
            this.lblSurName.Location = new System.Drawing.Point(25, 58);
            this.lblSurName.Name = "lblSurName";
            this.lblSurName.Size = new System.Drawing.Size(37, 13);
            this.lblSurName.TabIndex = 1;
            this.lblSurName.Text = "Soyad";
            // 
            // lblIdPerson
            // 
            this.lblIdPerson.AutoSize = true;
            this.lblIdPerson.Location = new System.Drawing.Point(25, 87);
            this.lblIdPerson.Name = "lblIdPerson";
            this.lblIdPerson.Size = new System.Drawing.Size(51, 13);
            this.lblIdPerson.TabIndex = 2;
            this.lblIdPerson.Text = "TC Kimlik";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(133, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtSurName
            // 
            this.txtSurName.Location = new System.Drawing.Point(133, 58);
            this.txtSurName.Name = "txtSurName";
            this.txtSurName.Size = new System.Drawing.Size(100, 20);
            this.txtSurName.TabIndex = 4;
            // 
            // txtIdPerson
            // 
            this.txtIdPerson.Location = new System.Drawing.Point(133, 87);
            this.txtIdPerson.Name = "txtIdPerson";
            this.txtIdPerson.Size = new System.Drawing.Size(100, 20);
            this.txtIdPerson.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(133, 115);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 7;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(25, 115);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(43, 13);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Telefon";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(180, 168);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(53, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(28, 168);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(54, 23);
            this.btnClean.TabIndex = 9;
            this.btnClean.Text = "Temizle";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(88, 168);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(86, 23);
            this.btnShow.TabIndex = 10;
            this.btnShow.Text = "Kayıtları Gsöter";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 234);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtIdPerson);
            this.Controls.Add(this.txtSurName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblIdPerson);
            this.Controls.Add(this.lblSurName);
            this.Controls.Add(this.lblName);
            this.Name = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurName;
        private System.Windows.Forms.Label lblIdPerson;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurName;
        private System.Windows.Forms.TextBox txtIdPerson;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button btnShow;
    }
}

