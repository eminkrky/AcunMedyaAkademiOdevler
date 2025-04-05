namespace WinFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            markaText = new TextBox();
            modelText = new TextBox();
            label2 = new Label();
            renkText = new TextBox();
            label3 = new Label();
            kapiSayisiText = new TextBox();
            label4 = new Label();
            pencereSayisiText = new TextBox();
            label5 = new Label();
            yüzKmdeYakit = new TextBox();
            label6 = new Label();
            Button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(204, 73);
            label1.Name = "label1";
            label1.Size = new Size(80, 32);
            label1.TabIndex = 0;
            label1.Text = "Marka";
            // 
            // markaText
            // 
            markaText.Location = new Point(291, 70);
            markaText.Name = "markaText";
            markaText.Size = new Size(200, 39);
            markaText.TabIndex = 1;
            // 
            // modelText
            // 
            modelText.Location = new Point(291, 115);
            modelText.Name = "modelText";
            modelText.Size = new Size(200, 39);
            modelText.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 118);
            label2.Name = "label2";
            label2.Size = new Size(83, 32);
            label2.TabIndex = 2;
            label2.Text = "Model";
            // 
            // renkText
            // 
            renkText.Location = new Point(291, 160);
            renkText.Name = "renkText";
            renkText.Size = new Size(200, 39);
            renkText.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 163);
            label3.Name = "label3";
            label3.Size = new Size(66, 32);
            label3.TabIndex = 4;
            label3.Text = "Renk";
            // 
            // kapiSayisiText
            // 
            kapiSayisiText.Location = new Point(291, 205);
            kapiSayisiText.Name = "kapiSayisiText";
            kapiSayisiText.Size = new Size(200, 39);
            kapiSayisiText.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(158, 212);
            label4.Name = "label4";
            label4.Size = new Size(126, 32);
            label4.TabIndex = 6;
            label4.Text = "Kapı Sayısı";
            // 
            // pencereSayisiText
            // 
            pencereSayisiText.Location = new Point(291, 250);
            pencereSayisiText.Name = "pencereSayisiText";
            pencereSayisiText.Size = new Size(200, 39);
            pencereSayisiText.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(121, 257);
            label5.Name = "label5";
            label5.Size = new Size(164, 32);
            label5.TabIndex = 8;
            label5.Text = "Pencere Sayısı";
            // 
            // yüzKmdeYakit
            // 
            yüzKmdeYakit.Location = new Point(291, 295);
            yüzKmdeYakit.Name = "yüzKmdeYakit";
            yüzKmdeYakit.Size = new Size(200, 39);
            yüzKmdeYakit.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 298);
            label6.Name = "label6";
            label6.Size = new Size(258, 32);
            label6.TabIndex = 10;
            label6.Text = "100 km’de Yaktığı Yakıt";
            // 
            // Button
            // 
            Button.Location = new Point(158, 374);
            Button.Name = "Button";
            Button.Size = new Size(238, 46);
            Button.TabIndex = 12;
            Button.Text = "Bilgileri Göster";
            Button.UseVisualStyleBackColor = true;
            Button.Click += Button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 465);
            Controls.Add(Button);
            Controls.Add(yüzKmdeYakit);
            Controls.Add(label6);
            Controls.Add(pencereSayisiText);
            Controls.Add(label5);
            Controls.Add(kapiSayisiText);
            Controls.Add(label4);
            Controls.Add(renkText);
            Controls.Add(label3);
            Controls.Add(modelText);
            Controls.Add(label2);
            Controls.Add(markaText);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox markaText;
        private TextBox modelText;
        private Label label2;
        private TextBox renkText;
        private Label label3;
        private TextBox kapiSayisiText;
        private Label label4;
        private TextBox pencereSayisiText;
        private Label label5;
        private TextBox yüzKmdeYakit;
        private Label label6;
        private Button Button;
    }
}
