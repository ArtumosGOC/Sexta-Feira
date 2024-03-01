using System.Windows.Forms;

namespace Sexta_Feira
{
    partial class Frm_Principal
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
            this.PGB_Volume = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PGB_Volume
            // 
            this.PGB_Volume.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PGB_Volume.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PGB_Volume.Location = new System.Drawing.Point(0, 23);
            this.PGB_Volume.Name = "PGB_Volume";
            this.PGB_Volume.Size = new System.Drawing.Size(491, 34);
            this.PGB_Volume.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-20, -12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(523, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Lista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BT_LIST);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 57);
            this.Controls.Add(this.PGB_Volume);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Frm_Principal";
            this.Text = "Sexta Feira";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar PGB_Volume;
        private Button button1;
    }
}

