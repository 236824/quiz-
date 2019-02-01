namespace milion
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.A_btt = new System.Windows.Forms.RadioButton();
            this.B_btt = new System.Windows.Forms.RadioButton();
            this.C_btt = new System.Windows.Forms.RadioButton();
            this.D_btt = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(87, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(700, 206);
            this.textBox1.TabIndex = 1;
            // 
            // A_btt
            // 
            this.A_btt.AutoSize = true;
            this.A_btt.Location = new System.Drawing.Point(87, 285);
            this.A_btt.Name = "A_btt";
            this.A_btt.Size = new System.Drawing.Size(14, 13);
            this.A_btt.TabIndex = 2;
            this.A_btt.TabStop = true;
            this.A_btt.UseVisualStyleBackColor = true;
            this.A_btt.CheckedChanged += new System.EventHandler(this.A_btt_CheckedChanged);
            // 
            // B_btt
            // 
            this.B_btt.AutoSize = true;
            this.B_btt.Location = new System.Drawing.Point(87, 323);
            this.B_btt.Name = "B_btt";
            this.B_btt.Size = new System.Drawing.Size(14, 13);
            this.B_btt.TabIndex = 3;
            this.B_btt.TabStop = true;
            this.B_btt.UseVisualStyleBackColor = true;
            this.B_btt.CheckedChanged += new System.EventHandler(this.B_btt_CheckedChanged);
            // 
            // C_btt
            // 
            this.C_btt.AutoSize = true;
            this.C_btt.Location = new System.Drawing.Point(87, 362);
            this.C_btt.Name = "C_btt";
            this.C_btt.Size = new System.Drawing.Size(14, 13);
            this.C_btt.TabIndex = 4;
            this.C_btt.TabStop = true;
            this.C_btt.UseVisualStyleBackColor = true;
            this.C_btt.CheckedChanged += new System.EventHandler(this.C_btt_CheckedChanged);
            // 
            // D_btt
            // 
            this.D_btt.AutoSize = true;
            this.D_btt.Location = new System.Drawing.Point(87, 405);
            this.D_btt.Name = "D_btt";
            this.D_btt.Size = new System.Drawing.Size(14, 13);
            this.D_btt.TabIndex = 5;
            this.D_btt.TabStop = true;
            this.D_btt.UseVisualStyleBackColor = true;
            this.D_btt.CheckedChanged += new System.EventHandler(this.D_btt_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(645, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Następne";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::milion.Properties.Resources.maxresdefaultdd;
            this.ClientSize = new System.Drawing.Size(891, 519);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.D_btt);
            this.Controls.Add(this.C_btt);
            this.Controls.Add(this.B_btt);
            this.Controls.Add(this.A_btt);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "Form1";
            this.Text = "Milion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton A_btt;
        private System.Windows.Forms.RadioButton B_btt;
        private System.Windows.Forms.RadioButton C_btt;
        private System.Windows.Forms.RadioButton D_btt;
        private System.Windows.Forms.Button button1;
    }
}

