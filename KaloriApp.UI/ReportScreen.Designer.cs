namespace KaloriApp.UI
{
    partial class ReportScreen
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
            btnGunluk = new Button();
            btnHaftalik = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label2 = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            SuspendLayout();
            // 
            // btnGunluk
            // 
            btnGunluk.Location = new Point(120, 80);
            btnGunluk.Name = "btnGunluk";
            btnGunluk.Size = new Size(137, 47);
            btnGunluk.TabIndex = 0;
            btnGunluk.Text = "Günlük Rapor";
            btnGunluk.UseVisualStyleBackColor = true;
            // 
            // btnHaftalik
            // 
            btnHaftalik.Location = new Point(263, 80);
            btnHaftalik.Name = "btnHaftalik";
            btnHaftalik.Size = new Size(136, 47);
            btnHaftalik.TabIndex = 0;
            btnHaftalik.Text = "Haftalık Rapor";
            btnHaftalik.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(120, 151);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(520, 100);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 130);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 2;
            label1.Text = "Kalori Bilgileri";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(120, 297);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(520, 100);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(120, 276);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 2;
            label2.Text = "Egzersiz Bilgileri";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Location = new Point(120, 450);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(520, 100);
            flowLayoutPanel3.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(120, 429);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 2;
            label3.Text = "TüKetilen Besin Bilgileri";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(696, 183);
            label4.Name = "label4";
            label4.Size = new Size(334, 15);
            label4.TabIndex = 2;
            label4.Text = "Yakılan ve alınan kalori ||  Yakılacak günlük ya da haftalık kalori";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(696, 341);
            label5.Name = "label5";
            label5.Size = new Size(241, 15);
            label5.TabIndex = 2;
            label5.Text = "Hangi alet ||  ne kadar süre ||  ne kadar yakım";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(696, 493);
            label6.Name = "label6";
            label6.Size = new Size(177, 15);
            label6.TabIndex = 2;
            label6.Text = "Besinlerin adı ve kalori miktarları";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(658, 493);
            label7.Name = "label7";
            label7.Size = new Size(23, 15);
            label7.TabIndex = 2;
            label7.Text = "=>";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(658, 341);
            label8.Name = "label8";
            label8.Size = new Size(23, 15);
            label8.TabIndex = 2;
            label8.Text = "=>";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(658, 183);
            label9.Name = "label9";
            label9.Size = new Size(23, 15);
            label9.TabIndex = 2;
            label9.Text = "=>";
            // 
            // ReportScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1583, 798);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(flowLayoutPanel3);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnHaftalik);
            Controls.Add(btnGunluk);
            Name = "ReportScreen";
            Text = "ReportScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGunluk;
        private Button btnHaftalik;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}