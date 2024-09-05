namespace WindowsFormsApp3
{
    partial class Form2
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
            this.SuspendLayout();
            // 
            // btLimpiar
            // 
            this.btLimpiar.Location = new System.Drawing.Point(847, 474);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(238, 104);
            this.btLimpiar.TabIndex = 0;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese una palabra:";
            // 
            // lbVocales
            // 
            this.lbVocales.FormattingEnabled = true;
            this.lbVocales.ItemHeight = 37;
            this.lbVocales.Location = new System.Drawing.Point(867, 116);
            this.lbVocales.Name = "lbVocales";
            this.lbVocales.Size = new System.Drawing.Size(218, 263);
            this.lbVocales.TabIndex = 2;
            // 
            // btMostrarVocales
            // 
            this.btMostrarVocales.Location = new System.Drawing.Point(538, 481);
            this.btMostrarVocales.Name = "btMostrarVocales";
            this.btMostrarVocales.Size = new System.Drawing.Size(210, 91);
            this.btMostrarVocales.TabIndex = 4;
            this.btMostrarVocales.Text = "Mostrar Vocales";
            this.btMostrarVocales.UseVisualStyleBackColor = true;
            this.btMostrarVocales.Click += new System.EventHandler(this.btMostrarVocales_Click);
            // 
            // tbPalabra
            // 
            this.tbPalabra.Location = new System.Drawing.Point(167, 256);
            this.tbPalabra.Name = "tbPalabra";
            this.tbPalabra.Size = new System.Drawing.Size(304, 44);
            this.tbPalabra.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 974);
            this.Controls.Add(this.tbPalabra);
            this.Controls.Add(this.btMostrarVocales);
            this.Controls.Add(this.lbVocales);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btLimpiar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbVocales;
        private System.Windows.Forms.Button btMostrarVocales;
        private System.Windows.Forms.TextBox tbPalabra;
    }
}