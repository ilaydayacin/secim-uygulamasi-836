namespace seçim_uygulaması
{
    partial class Form1
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
            this.lbPc = new System.Windows.Forms.ListBox();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPc
            // 
            this.lbPc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbPc.FormattingEnabled = true;
            this.lbPc.ItemHeight = 24;
            this.lbPc.Items.AddRange(new object[] {
            "Mouse",
            "Yazıcı",
            "Klavye",
            "Hoparlör",
            "Kamera",
            "Tarayıcı",
            "Projeksiyon"});
            this.lbPc.Location = new System.Drawing.Point(12, 12);
            this.lbPc.Name = "lbPc";
            this.lbPc.Size = new System.Drawing.Size(173, 172);
            this.lbPc.TabIndex = 0;
            // 
            // btnKontrol
            // 
            this.btnKontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKontrol.Location = new System.Drawing.Point(29, 215);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(134, 80);
            this.btnKontrol.TabIndex = 1;
            this.btnKontrol.Text = "Kontrol et";
            this.btnKontrol.UseVisualStyleBackColor = true;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 327);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.lbPc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbPc;
        private System.Windows.Forms.Button btnKontrol;
    }
}

