namespace Laboratorio3
{
    partial class Problema2Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources shoo be disposed; osdlsdtherwise, false.</param>
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
            this.botonVer = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonVer
            // 
            this.botonVer.Location = new System.Drawing.Point(56, 161);
            this.botonVer.Margin = new System.Windows.Forms.Padding(1);
            this.botonVer.Name = "botonVer";
            this.botonVer.Size = new System.Drawing.Size(119, 31);
            this.botonVer.TabIndex = 0;
            this.botonVer.Text = "Ver números";
            this.botonVer.UseVisualStyleBackColor = true;
            this.botonVer.Click += new System.EventHandler(this.botonVer_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(161, 58);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 22);
            this.txtNumero.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(341, 44);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 356);
            this.listBox2.TabIndex = 4;
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(44, 61);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(111, 16);
            this.lb2.TabIndex = 5;
            this.lb2.Text = "Números del 0 al:";
            // 
            // Problema2Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 429);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.botonVer);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Problema2Form1";
            this.Text = "Problema2";
            this.Load += new System.EventHandler(this.Problema2Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonVer;
		private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label lb2;
    }
}

