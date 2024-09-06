namespace Laboratorio3
{
    partial class Problema1
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
            this.btLimpiar = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.lbVocales = new System.Windows.Forms.ListBox();
            this.btMostrarVocales = new System.Windows.Forms.Button();
            this.tbPalabra = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(356, 206);
            this.btLimpiar.Margin = new System.Windows.Forms.Padding(1);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(100, 46);
            this.btLimpiar.TabIndex = 0;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(68, 79);
            this.lb1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(130, 16);
            this.lb1.TabIndex = 1;
            this.lb1.Text = "Ingrese una palabra:";
            // 
            // lbVocales
            // 
            this.lbVocales.FormattingEnabled = true;
            this.lbVocales.ItemHeight = 16;
            this.lbVocales.Location = new System.Drawing.Point(365, 50);
            this.lbVocales.Margin = new System.Windows.Forms.Padding(1);
            this.lbVocales.Name = "lbVocales";
            this.lbVocales.Size = new System.Drawing.Size(95, 116);
            this.lbVocales.TabIndex = 2;
            // 
            // btMostrarVocales
            // 
            this.btMostrarVocales.Location = new System.Drawing.Point(227, 208);
            this.btMostrarVocales.Margin = new System.Windows.Forms.Padding(1);
            this.btMostrarVocales.Name = "btMostrarVocales";
            this.btMostrarVocales.Size = new System.Drawing.Size(88, 39);
            this.btMostrarVocales.TabIndex = 4;
            this.btMostrarVocales.Text = "Mostrar Vocales";
            this.btMostrarVocales.UseVisualStyleBackColor = true;
            this.btMostrarVocales.Click += new System.EventHandler(this.btMostrarVocales_Click);
            // 
            // tbPalabra
            // 
            this.tbPalabra.Location = new System.Drawing.Point(71, 111);
            this.tbPalabra.Margin = new System.Windows.Forms.Padding(1);
            this.tbPalabra.Name = "tbPalabra";
            this.tbPalabra.Size = new System.Drawing.Size(131, 22);
            this.tbPalabra.TabIndex = 5;
            this.tbPalabra.TextChanged += new System.EventHandler(this.tbPalabra_TextChanged);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(361, 33);
            this.lb2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(57, 16);
            this.lb2.TabIndex = 6;
            this.lb2.Text = "Vocales";
            // 
            // Problema1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 303);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.tbPalabra);
            this.Controls.Add(this.btMostrarVocales);
            this.Controls.Add(this.lbVocales);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btLimpiar);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Problema1";
            this.Text = "Problema1";
            this.Load += new System.EventHandler(this.Problema1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.ListBox lbVocales;
        private System.Windows.Forms.Button btMostrarVocales;
        private System.Windows.Forms.TextBox tbPalabra;
        private System.Windows.Forms.Label lb2;
    }
}