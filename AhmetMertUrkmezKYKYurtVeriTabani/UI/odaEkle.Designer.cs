namespace AhmetMertUrkmezKYKYurtVeriTabani.UI
{
    partial class odaEkle
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
            this.components = new System.ComponentModel.Container();
            this.iptalBTN = new System.Windows.Forms.Button();
            this.tamamBTN = new System.Windows.Forms.Button();
            this.textOdaNo = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textKat = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // iptalBTN
            // 
            this.iptalBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.iptalBTN.Location = new System.Drawing.Point(173, 172);
            this.iptalBTN.Name = "iptalBTN";
            this.iptalBTN.Size = new System.Drawing.Size(75, 23);
            this.iptalBTN.TabIndex = 44;
            this.iptalBTN.Text = "İptal";
            this.iptalBTN.UseVisualStyleBackColor = true;
            this.iptalBTN.Click += new System.EventHandler(this.iptalBTN_Click);
            // 
            // tamamBTN
            // 
            this.tamamBTN.Location = new System.Drawing.Point(74, 172);
            this.tamamBTN.Name = "tamamBTN";
            this.tamamBTN.Size = new System.Drawing.Size(75, 23);
            this.tamamBTN.TabIndex = 43;
            this.tamamBTN.Text = " Tamam";
            this.tamamBTN.UseVisualStyleBackColor = true;
            this.tamamBTN.Click += new System.EventHandler(this.tamamBTN_Click);
            // 
            // textOdaNo
            // 
            this.textOdaNo.Location = new System.Drawing.Point(103, 68);
            this.textOdaNo.Name = "textOdaNo";
            this.textOdaNo.Size = new System.Drawing.Size(100, 22);
            this.textOdaNo.TabIndex = 34;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(103, 22);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(100, 22);
            this.textID.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Oda Numarası";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Kat";
            // 
            // textKat
            // 
            this.textKat.Location = new System.Drawing.Point(103, 106);
            this.textKat.Name = "textKat";
            this.textKat.Size = new System.Drawing.Size(100, 22);
            this.textKat.TabIndex = 35;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // odaEkle
            // 
            this.AcceptButton = this.tamamBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.iptalBTN;
            this.ClientSize = new System.Drawing.Size(314, 228);
            this.Controls.Add(this.iptalBTN);
            this.Controls.Add(this.tamamBTN);
            this.Controls.Add(this.textKat);
            this.Controls.Add(this.textOdaNo);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "odaEkle";
            this.Text = "odaEkle";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button iptalBTN;
        private System.Windows.Forms.Button tamamBTN;
        private System.Windows.Forms.TextBox textOdaNo;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textKat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}