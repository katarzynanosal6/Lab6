namespace Lab6
{
    partial class MenuForm
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
            lblTytul = new Label();
            btnStart = new Button();
            btnUstawienia = new Button();
            btnKoniec = new Button();
            SuspendLayout();
            // 
            // lblTytul
            // 
            lblTytul.AutoSize = true;
            lblTytul.Location = new Point(296, 78);
            lblTytul.Name = "lblTytul";
            lblTytul.Size = new Size(196, 30);
            lblTytul.TabIndex = 0;
            lblTytul.Text = "GDZIE JEST DYDELF";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(324, 153);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(131, 40);
            btnStart.TabIndex = 1;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnUstawienia
            // 
            btnUstawienia.Location = new Point(308, 255);
            btnUstawienia.Name = "btnUstawienia";
            btnUstawienia.Size = new Size(168, 40);
            btnUstawienia.TabIndex = 2;
            btnUstawienia.Text = "USTAWIENIA";
            btnUstawienia.UseVisualStyleBackColor = true;
            btnUstawienia.Click += btnUstawienia_Click;
            // 
            // btnKoniec
            // 
            btnKoniec.Location = new Point(333, 355);
            btnKoniec.Name = "btnKoniec";
            btnKoniec.Size = new Size(131, 40);
            btnKoniec.TabIndex = 3;
            btnKoniec.Text = "KONIEC";
            btnKoniec.UseVisualStyleBackColor = true;
            btnKoniec.Click += btnKoniec_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKoniec);
            Controls.Add(btnUstawienia);
            Controls.Add(btnStart);
            Controls.Add(lblTytul);
            Name = "MenuForm";
            Text = "MenuForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTytul;
        private Button btnStart;
        private Button btnUstawienia;
        private Button btnKoniec;
    }
}