namespace Lab6
{
    partial class SettingsForm
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
            lblDydelfy = new Label();
            numDydelfy = new NumericUpDown();
            lblX = new Label();
            numX = new NumericUpDown();
            lblY = new Label();
            numY = new NumericUpDown();
            lblPlansza = new Label();
            lblSzopy = new Label();
            numSzopy = new NumericUpDown();
            lblKrokodyle = new Label();
            numKrokodyle = new NumericUpDown();
            lblCzas = new Label();
            numCzas = new NumericUpDown();
            btnZapisz = new Button();
            ((System.ComponentModel.ISupportInitialize)numDydelfy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSzopy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numKrokodyle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCzas).BeginInit();
            SuspendLayout();
            // 
            // lblDydelfy
            // 
            lblDydelfy.AutoSize = true;
            lblDydelfy.Location = new Point(561, 39);
            lblDydelfy.Name = "lblDydelfy";
            lblDydelfy.Size = new Size(83, 30);
            lblDydelfy.TabIndex = 0;
            lblDydelfy.Text = "Dydelfy";
            // 
            // numDydelfy
            // 
            numDydelfy.Location = new Point(505, 93);
            numDydelfy.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            numDydelfy.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDydelfy.Name = "numDydelfy";
            numDydelfy.Size = new Size(210, 35);
            numDydelfy.TabIndex = 1;
            numDydelfy.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.Location = new Point(33, 98);
            lblX.Name = "lblX";
            lblX.Size = new Size(25, 30);
            lblX.TabIndex = 2;
            lblX.Text = "X";
            // 
            // numX
            // 
            numX.Location = new Point(113, 98);
            numX.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numX.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            numX.Name = "numX";
            numX.Size = new Size(210, 35);
            numX.TabIndex = 3;
            numX.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // lblY
            // 
            lblY.AutoSize = true;
            lblY.Location = new Point(34, 178);
            lblY.Name = "lblY";
            lblY.Size = new Size(25, 30);
            lblY.TabIndex = 4;
            lblY.Text = "Y";
            // 
            // numY
            // 
            numY.Location = new Point(113, 178);
            numY.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numY.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            numY.Name = "numY";
            numY.Size = new Size(210, 35);
            numY.TabIndex = 5;
            numY.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // lblPlansza
            // 
            lblPlansza.AutoSize = true;
            lblPlansza.Location = new Point(33, 39);
            lblPlansza.Name = "lblPlansza";
            lblPlansza.Size = new Size(83, 30);
            lblPlansza.TabIndex = 6;
            lblPlansza.Text = "Plansza";
            // 
            // lblSzopy
            // 
            lblSzopy.AutoSize = true;
            lblSzopy.Location = new Point(561, 147);
            lblSzopy.Name = "lblSzopy";
            lblSzopy.Size = new Size(67, 30);
            lblSzopy.TabIndex = 7;
            lblSzopy.Text = "Szopy";
            // 
            // numSzopy
            // 
            numSzopy.Location = new Point(505, 197);
            numSzopy.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            numSzopy.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            numSzopy.Name = "numSzopy";
            numSzopy.Size = new Size(210, 35);
            numSzopy.TabIndex = 8;
            numSzopy.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // lblKrokodyle
            // 
            lblKrokodyle.AutoSize = true;
            lblKrokodyle.Location = new Point(551, 254);
            lblKrokodyle.Name = "lblKrokodyle";
            lblKrokodyle.Size = new Size(104, 30);
            lblKrokodyle.TabIndex = 9;
            lblKrokodyle.Text = "Krokodyle";
            // 
            // numKrokodyle
            // 
            numKrokodyle.Location = new Point(505, 297);
            numKrokodyle.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numKrokodyle.Name = "numKrokodyle";
            numKrokodyle.Size = new Size(210, 35);
            numKrokodyle.TabIndex = 10;
            // 
            // lblCzas
            // 
            lblCzas.AutoSize = true;
            lblCzas.Location = new Point(34, 297);
            lblCzas.Name = "lblCzas";
            lblCzas.Size = new Size(56, 30);
            lblCzas.TabIndex = 11;
            lblCzas.Text = "Czas";
            // 
            // numCzas
            // 
            numCzas.Location = new Point(168, 295);
            numCzas.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            numCzas.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numCzas.Name = "numCzas";
            numCzas.Size = new Size(210, 35);
            numCzas.TabIndex = 12;
            numCzas.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btnZapisz
            // 
            btnZapisz.Location = new Point(345, 382);
            btnZapisz.Name = "btnZapisz";
            btnZapisz.Size = new Size(131, 40);
            btnZapisz.TabIndex = 13;
            btnZapisz.Text = "Zapisz";
            btnZapisz.UseVisualStyleBackColor = true;
            btnZapisz.Click += btnZapisz_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnZapisz);
            Controls.Add(numCzas);
            Controls.Add(lblCzas);
            Controls.Add(numKrokodyle);
            Controls.Add(lblKrokodyle);
            Controls.Add(numSzopy);
            Controls.Add(lblSzopy);
            Controls.Add(lblPlansza);
            Controls.Add(numY);
            Controls.Add(lblY);
            Controls.Add(numX);
            Controls.Add(lblX);
            Controls.Add(numDydelfy);
            Controls.Add(lblDydelfy);
            Name = "SettingsForm";
            Text = "SettingsForm";
            ((System.ComponentModel.ISupportInitialize)numDydelfy).EndInit();
            ((System.ComponentModel.ISupportInitialize)numX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSzopy).EndInit();
            ((System.ComponentModel.ISupportInitialize)numKrokodyle).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCzas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDydelfy;
        private NumericUpDown numDydelfy;
        private Label lblX;
        private NumericUpDown numX;
        private Label lblY;
        private NumericUpDown numY;
        private Label lblPlansza;
        private Label lblSzopy;
        private NumericUpDown numSzopy;
        private Label lblKrokodyle;
        private NumericUpDown numKrokodyle;
        private Label lblCzas;
        private NumericUpDown numCzas;
        private Button btnZapisz;
    }
}