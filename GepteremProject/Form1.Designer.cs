namespace GepteremProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_Balra = new System.Windows.Forms.Button();
            this.button_Jobbra = new System.Windows.Forms.Button();
            this.button_Mentes = new System.Windows.Forms.Button();
            this.pictureBox_Nevado = new System.Windows.Forms.PictureBox();
            this.panel_Ertekelesek = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Nevado)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Balra
            // 
            this.button_Balra.BackgroundImage = global::GepteremProject.Properties.Resources.bal;
            this.button_Balra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Balra.Location = new System.Drawing.Point(12, 87);
            this.button_Balra.Name = "button_Balra";
            this.button_Balra.Size = new System.Drawing.Size(73, 64);
            this.button_Balra.TabIndex = 0;
            this.button_Balra.UseVisualStyleBackColor = true;
            this.button_Balra.Click += new System.EventHandler(this.button_Balra_Click);
            // 
            // button_Jobbra
            // 
            this.button_Jobbra.BackgroundImage = global::GepteremProject.Properties.Resources.jobb;
            this.button_Jobbra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Jobbra.Location = new System.Drawing.Point(272, 87);
            this.button_Jobbra.Name = "button_Jobbra";
            this.button_Jobbra.Size = new System.Drawing.Size(73, 64);
            this.button_Jobbra.TabIndex = 0;
            this.button_Jobbra.UseVisualStyleBackColor = true;
            this.button_Jobbra.Click += new System.EventHandler(this.button_Jobbra_Click);
            // 
            // button_Mentes
            // 
            this.button_Mentes.BackgroundImage = global::GepteremProject.Properties.Resources.ment;
            this.button_Mentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Mentes.Location = new System.Drawing.Point(141, 257);
            this.button_Mentes.Name = "button_Mentes";
            this.button_Mentes.Size = new System.Drawing.Size(73, 64);
            this.button_Mentes.TabIndex = 0;
            this.button_Mentes.UseVisualStyleBackColor = true;
            this.button_Mentes.Click += new System.EventHandler(this.button_Mentes_Click);
            // 
            // pictureBox_Nevado
            // 
            this.pictureBox_Nevado.Location = new System.Drawing.Point(91, 36);
            this.pictureBox_Nevado.Name = "pictureBox_Nevado";
            this.pictureBox_Nevado.Size = new System.Drawing.Size(175, 215);
            this.pictureBox_Nevado.TabIndex = 1;
            this.pictureBox_Nevado.TabStop = false;
            // 
            // panel_Ertekelesek
            // 
            this.panel_Ertekelesek.Location = new System.Drawing.Point(362, 24);
            this.panel_Ertekelesek.Name = "panel_Ertekelesek";
            this.panel_Ertekelesek.Size = new System.Drawing.Size(438, 297);
            this.panel_Ertekelesek.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_Ertekelesek);
            this.Controls.Add(this.pictureBox_Nevado);
            this.Controls.Add(this.button_Mentes);
            this.Controls.Add(this.button_Jobbra);
            this.Controls.Add(this.button_Balra);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Nevado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Balra;
        private System.Windows.Forms.Button button_Jobbra;
        private System.Windows.Forms.Button button_Mentes;
        private System.Windows.Forms.PictureBox pictureBox_Nevado;
        private System.Windows.Forms.Panel panel_Ertekelesek;
    }
}

