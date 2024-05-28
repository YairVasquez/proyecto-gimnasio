namespace proyecto_gimnasio
{
    partial class Rutina
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
            this.label1 = new System.Windows.Forms.Label();
            this.Pecho = new System.Windows.Forms.Button();
            this.Espalda = new System.Windows.Forms.Button();
            this.Pierna = new System.Windows.Forms.Button();
            this.Bicep = new System.Windows.Forms.Button();
            this.Tricep = new System.Windows.Forms.Button();
            this.Antebrazo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elige el musculo a entrenar";
            // 
            // Pecho
            // 
            this.Pecho.Location = new System.Drawing.Point(122, 136);
            this.Pecho.Name = "Pecho";
            this.Pecho.Size = new System.Drawing.Size(75, 23);
            this.Pecho.TabIndex = 2;
            this.Pecho.Text = "Pecho";
            this.Pecho.UseVisualStyleBackColor = true;
            this.Pecho.Click += new System.EventHandler(this.Pecho_Click);
            // 
            // Espalda
            // 
            this.Espalda.Location = new System.Drawing.Point(338, 136);
            this.Espalda.Name = "Espalda";
            this.Espalda.Size = new System.Drawing.Size(75, 23);
            this.Espalda.TabIndex = 3;
            this.Espalda.Text = "Espalda";
            this.Espalda.UseVisualStyleBackColor = true;
            this.Espalda.Click += new System.EventHandler(this.Espalda_Click);
            // 
            // Pierna
            // 
            this.Pierna.Location = new System.Drawing.Point(564, 136);
            this.Pierna.Name = "Pierna";
            this.Pierna.Size = new System.Drawing.Size(75, 23);
            this.Pierna.TabIndex = 4;
            this.Pierna.Text = "Pierna";
            this.Pierna.UseVisualStyleBackColor = true;
            this.Pierna.Click += new System.EventHandler(this.Pierna_Click);
            // 
            // Bicep
            // 
            this.Bicep.Location = new System.Drawing.Point(122, 232);
            this.Bicep.Name = "Bicep";
            this.Bicep.Size = new System.Drawing.Size(75, 23);
            this.Bicep.TabIndex = 5;
            this.Bicep.Text = "Bicep";
            this.Bicep.UseVisualStyleBackColor = true;
            this.Bicep.Click += new System.EventHandler(this.Bicep_Click);
            // 
            // Tricep
            // 
            this.Tricep.Location = new System.Drawing.Point(338, 232);
            this.Tricep.Name = "Tricep";
            this.Tricep.Size = new System.Drawing.Size(75, 23);
            this.Tricep.TabIndex = 6;
            this.Tricep.Text = "Tricep";
            this.Tricep.UseVisualStyleBackColor = true;
            this.Tricep.Click += new System.EventHandler(this.button5_Click);
            // 
            // Antebrazo
            // 
            this.Antebrazo.Location = new System.Drawing.Point(564, 232);
            this.Antebrazo.Name = "Antebrazo";
            this.Antebrazo.Size = new System.Drawing.Size(75, 23);
            this.Antebrazo.TabIndex = 7;
            this.Antebrazo.Text = "Antebrazo";
            this.Antebrazo.UseVisualStyleBackColor = true;
            this.Antebrazo.Click += new System.EventHandler(this.Antebrazo_Click);
            // 
            // Rutina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Antebrazo);
            this.Controls.Add(this.Tricep);
            this.Controls.Add(this.Bicep);
            this.Controls.Add(this.Pierna);
            this.Controls.Add(this.Espalda);
            this.Controls.Add(this.Pecho);
            this.Controls.Add(this.label1);
            this.Name = "Rutina";
            this.Text = "Rutina";
            this.Load += new System.EventHandler(this.Rutina_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Pecho;
        private System.Windows.Forms.Button Espalda;
        private System.Windows.Forms.Button Pierna;
        private System.Windows.Forms.Button Bicep;
        private System.Windows.Forms.Button Tricep;
        private System.Windows.Forms.Button Antebrazo;
    }
}