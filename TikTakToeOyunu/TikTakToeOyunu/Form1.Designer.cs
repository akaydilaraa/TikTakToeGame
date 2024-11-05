namespace TikTakToeOyunu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.PlayerText = new System.Windows.Forms.Label();
            this.ComputerText = new System.Windows.Forms.Label();
            this.Yenileme = new System.Windows.Forms.Button();
            this.pcZaman = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(113, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 109);
            this.button1.TabIndex = 0;
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OyuncuTikla);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(241, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 109);
            this.button2.TabIndex = 0;
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OyuncuTikla);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(367, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 109);
            this.button3.TabIndex = 0;
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.OyuncuTikla);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(113, 236);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 109);
            this.button4.TabIndex = 0;
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.OyuncuTikla);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(241, 236);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(109, 109);
            this.button5.TabIndex = 0;
            this.button5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.OyuncuTikla);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(367, 236);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(109, 109);
            this.button6.TabIndex = 0;
            this.button6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.OyuncuTikla);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Location = new System.Drawing.Point(113, 363);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(109, 109);
            this.button7.TabIndex = 0;
            this.button7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.OyuncuTikla);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.Location = new System.Drawing.Point(241, 363);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(109, 109);
            this.button8.TabIndex = 0;
            this.button8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.OyuncuTikla);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Cambria", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.Location = new System.Drawing.Point(367, 363);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(109, 109);
            this.button9.TabIndex = 0;
            this.button9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.OyuncuTikla);
            // 
            // PlayerText
            // 
            this.PlayerText.AutoSize = true;
            this.PlayerText.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerText.ForeColor = System.Drawing.Color.White;
            this.PlayerText.Location = new System.Drawing.Point(124, 9);
            this.PlayerText.Name = "PlayerText";
            this.PlayerText.Size = new System.Drawing.Size(112, 36);
            this.PlayerText.TabIndex = 1;
            this.PlayerText.Text = "Player: ";
            // 
            // ComputerText
            // 
            this.ComputerText.AutoSize = true;
            this.ComputerText.Font = new System.Drawing.Font("Franklin Gothic Medium", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerText.ForeColor = System.Drawing.Color.White;
            this.ComputerText.Location = new System.Drawing.Point(107, 54);
            this.ComputerText.Name = "ComputerText";
            this.ComputerText.Size = new System.Drawing.Size(157, 36);
            this.ComputerText.TabIndex = 2;
            this.ComputerText.Text = "Computer: ";
            // 
            // Yenileme
            // 
            this.Yenileme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Yenileme.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Yenileme.ForeColor = System.Drawing.Color.Maroon;
            this.Yenileme.Location = new System.Drawing.Point(202, 501);
            this.Yenileme.Name = "Yenileme";
            this.Yenileme.Size = new System.Drawing.Size(195, 43);
            this.Yenileme.TabIndex = 3;
            this.Yenileme.Text = "RESTART";
            this.Yenileme.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Yenileme.UseVisualStyleBackColor = false;
            this.Yenileme.Click += new System.EventHandler(this.yenileButon);
            // 
            // pcZaman
            // 
            this.pcZaman.Interval = 1000;
            this.pcZaman.Tick += new System.EventHandler(this.OyuncuSure);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(620, 567);
            this.Controls.Add(this.Yenileme);
            this.Controls.Add(this.ComputerText);
            this.Controls.Add(this.PlayerText);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "TikTakToe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label PlayerText;
        private System.Windows.Forms.Label ComputerText;
        private System.Windows.Forms.Button Yenileme;
        private System.Windows.Forms.Timer pcZaman;
    }
}

