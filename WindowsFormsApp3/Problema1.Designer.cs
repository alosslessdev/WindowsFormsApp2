namespace WindowsFormsApp3
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbVocales = new System.Windows.Forms.ListBox();
            this.btMostrarVocales = new System.Windows.Forms.Button();
            this.tbPalabra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(267, 167);
            this.btLimpiar.Margin = new System.Windows.Forms.Padding(1);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(75, 37);
            this.btLimpiar.TabIndex = 0;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese una palabra:";
            // 
            // lbVocales
            // 
            this.lbVocales.FormattingEnabled = true;
            this.lbVocales.Location = new System.Drawing.Point(274, 41);
            this.lbVocales.Margin = new System.Windows.Forms.Padding(1);
            this.lbVocales.Name = "lbVocales";
            this.lbVocales.Size = new System.Drawing.Size(72, 95);
            this.lbVocales.TabIndex = 2;
            // 
            // btMostrarVocales
            // 
            this.btMostrarVocales.Location = new System.Drawing.Point(170, 169);
            this.btMostrarVocales.Margin = new System.Windows.Forms.Padding(1);
            this.btMostrarVocales.Name = "btMostrarVocales";
            this.btMostrarVocales.Size = new System.Drawing.Size(66, 32);
            this.btMostrarVocales.TabIndex = 4;
            this.btMostrarVocales.Text = "Mostrar Vocales";
            this.btMostrarVocales.UseVisualStyleBackColor = true;
            this.btMostrarVocales.Click += new System.EventHandler(this.btMostrarVocales_Click);
            // 
            // tbPalabra
            // 
            this.tbPalabra.Location = new System.Drawing.Point(53, 90);
            this.tbPalabra.Margin = new System.Windows.Forms.Padding(1);
            this.tbPalabra.Name = "tbPalabra";
            this.tbPalabra.Size = new System.Drawing.Size(99, 20);
            this.tbPalabra.TabIndex = 5;
            this.tbPalabra.TextChanged += new System.EventHandler(this.tbPalabra_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Vocales";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 246);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPalabra);
            this.Controls.Add(this.btMostrarVocales);
            this.Controls.Add(this.lbVocales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btLimpiar);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.Text = "Problema1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbVocales;
        private System.Windows.Forms.Button btMostrarVocales;
        private System.Windows.Forms.TextBox tbPalabra;
        private System.Windows.Forms.Label label2;
    }
}