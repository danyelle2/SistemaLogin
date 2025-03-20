namespace SistemaLogin
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.btnPagina1 = new System.Windows.Forms.Button();
            this.btnPagina2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPagina1
            // 
            this.btnPagina1.BackColor = System.Drawing.Color.Transparent;
            this.btnPagina1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagina1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPagina1.Location = new System.Drawing.Point(453, 12);
            this.btnPagina1.Name = "btnPagina1";
            this.btnPagina1.Size = new System.Drawing.Size(258, 343);
            this.btnPagina1.TabIndex = 0;
            this.btnPagina1.UseVisualStyleBackColor = false;
            this.btnPagina1.Click += new System.EventHandler(this.btnPagina1_Click);
            // 
            // btnPagina2
            // 
            this.btnPagina2.BackColor = System.Drawing.Color.Transparent;
            this.btnPagina2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagina2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPagina2.Location = new System.Drawing.Point(2, 12);
            this.btnPagina2.Name = "btnPagina2";
            this.btnPagina2.Size = new System.Drawing.Size(240, 333);
            this.btnPagina2.TabIndex = 1;
            this.btnPagina2.UseVisualStyleBackColor = false;
            this.btnPagina2.Click += new System.EventHandler(this.btnPagina2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(207, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escolha uma estante";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(711, 440);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPagina2);
            this.Controls.Add(this.btnPagina1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPagina1;
        private System.Windows.Forms.Button btnPagina2;
        private System.Windows.Forms.Label label1;
    }
}