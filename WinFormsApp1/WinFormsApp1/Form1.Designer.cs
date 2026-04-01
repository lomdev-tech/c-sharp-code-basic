namespace WinFormsApp1
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
            textBox1 = new TextBox();
            ButtonSayHello = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(298, 30);
            textBox1.TabIndex = 0;
            // 
            // ButtonSayHello
            // 
            ButtonSayHello.Location = new Point(77, 136);
            ButtonSayHello.Name = "ButtonSayHello";
            ButtonSayHello.Size = new Size(298, 34);
            ButtonSayHello.TabIndex = 1;
            ButtonSayHello.Text = "点击一下";
            ButtonSayHello.UseVisualStyleBackColor = true;
            ButtonSayHello.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 450);
            Controls.Add(ButtonSayHello);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button ButtonSayHello;
    }
}
