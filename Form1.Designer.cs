namespace discord
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.largimgText = new System.Windows.Forms.TextBox();
            this.smllimgText = new System.Windows.Forms.TextBox();
            this.TmsCheckBox = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Button_Box = new System.Windows.Forms.CheckBox();
            this.UrlTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Details";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(254, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "AppID";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(492, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(168, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Large Image Key";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 56);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(168, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "State";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(492, 56);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(168, 20);
            this.textBox5.TabIndex = 4;
            this.textBox5.Text = "Small Image Key";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 51);
            this.button1.TabIndex = 5;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // largimgText
            // 
            this.largimgText.Location = new System.Drawing.Point(492, 101);
            this.largimgText.Name = "largimgText";
            this.largimgText.Size = new System.Drawing.Size(168, 20);
            this.largimgText.TabIndex = 7;
            this.largimgText.Text = "Large Image Text";
            // 
            // smllimgText
            // 
            this.smllimgText.Location = new System.Drawing.Point(492, 143);
            this.smllimgText.Name = "smllimgText";
            this.smllimgText.Size = new System.Drawing.Size(168, 20);
            this.smllimgText.TabIndex = 8;
            this.smllimgText.Text = "Small Image Text";
            // 
            // TmsCheckBox
            // 
            this.TmsCheckBox.AutoSize = true;
            this.TmsCheckBox.Location = new System.Drawing.Point(12, 82);
            this.TmsCheckBox.Name = "TmsCheckBox";
            this.TmsCheckBox.Size = new System.Drawing.Size(77, 17);
            this.TmsCheckBox.TabIndex = 9;
            this.TmsCheckBox.Text = "Timestamp";
            this.TmsCheckBox.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(349, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 51);
            this.button2.TabIndex = 10;
            this.button2.Text = "Initialize";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Button_Box
            // 
            this.Button_Box.AutoSize = true;
            this.Button_Box.Location = new System.Drawing.Point(12, 125);
            this.Button_Box.Name = "Button_Box";
            this.Button_Box.Size = new System.Drawing.Size(57, 17);
            this.Button_Box.TabIndex = 11;
            this.Button_Box.Text = "Button";
            this.Button_Box.UseVisualStyleBackColor = true;
            // 
            // UrlTxt
            // 
            this.UrlTxt.Location = new System.Drawing.Point(12, 148);
            this.UrlTxt.Name = "UrlTxt";
            this.UrlTxt.Size = new System.Drawing.Size(152, 20);
            this.UrlTxt.TabIndex = 12;
            this.UrlTxt.Text = "Button URL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 173);
            this.Controls.Add(this.UrlTxt);
            this.Controls.Add(this.Button_Box);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TmsCheckBox);
            this.Controls.Add(this.smllimgText);
            this.Controls.Add(this.largimgText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox largimgText;
        private System.Windows.Forms.TextBox smllimgText;
        private System.Windows.Forms.CheckBox TmsCheckBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox Button_Box;
        private System.Windows.Forms.TextBox UrlTxt;
    }
}

