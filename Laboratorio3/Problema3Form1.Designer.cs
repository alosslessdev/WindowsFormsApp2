namespace Lab_3
{
    partial class LbLab3
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
            this.lbTitulo = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbCedula = new System.Windows.Forms.Label();
            this.lbDepositar = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDepositar = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.txtPlazo = new System.Windows.Forms.TextBox();
            this.lbPlazo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(238, 9);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(319, 32);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Depósitos a Plazo Fijo";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(94, 113);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(74, 20);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre";
            // 
            // lbCedula
            // 
            this.lbCedula.AutoSize = true;
            this.lbCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbCedula.Location = new System.Drawing.Point(94, 202);
            this.lbCedula.Name = "lbCedula";
            this.lbCedula.Size = new System.Drawing.Size(67, 20);
            this.lbCedula.TabIndex = 2;
            this.lbCedula.Text = "Cedula";
            // 
            // lbDepositar
            // 
            this.lbDepositar.AutoSize = true;
            this.lbDepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbDepositar.Location = new System.Drawing.Point(94, 288);
            this.lbDepositar.Name = "lbDepositar";
            this.lbDepositar.Size = new System.Drawing.Size(91, 20);
            this.lbDepositar.TabIndex = 3;
            this.lbDepositar.Text = "Depositar";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(231, 110);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 22);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtDepositar
            // 
            this.txtDepositar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDepositar.Location = new System.Drawing.Point(231, 286);
            this.txtDepositar.Name = "txtDepositar";
            this.txtDepositar.Size = new System.Drawing.Size(100, 22);
            this.txtDepositar.TabIndex = 5;
            this.txtDepositar.TextChanged += new System.EventHandler(this.txtDepositar_TextChanged);
            // 
            // txtCedula
            // 
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCedula.Location = new System.Drawing.Point(231, 202);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 22);
            this.txtCedula.TabIndex = 6;
            // 
            // btAceptar
            // 
            this.btAceptar.BackColor = System.Drawing.Color.Red;
            this.btAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.Location = new System.Drawing.Point(255, 363);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(283, 61);
            this.btAceptar.TabIndex = 7;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = false;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // txtPlazo
            // 
            this.txtPlazo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPlazo.Location = new System.Drawing.Point(549, 203);
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.Size = new System.Drawing.Size(100, 22);
            this.txtPlazo.TabIndex = 8;
            // 
            // lbPlazo
            // 
            this.lbPlazo.AutoSize = true;
            this.lbPlazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlazo.Location = new System.Drawing.Point(439, 205);
            this.lbPlazo.Name = "lbPlazo";
            this.lbPlazo.Size = new System.Drawing.Size(56, 20);
            this.lbPlazo.TabIndex = 9;
            this.lbPlazo.Text = "Plazo";
            // 
            // LbLab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 467);
            this.Controls.Add(this.lbPlazo);
            this.Controls.Add(this.txtPlazo);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtDepositar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbDepositar);
            this.Controls.Add(this.lbCedula);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbTitulo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "LbLab3";
            this.Text = "Laboratorio #3 Ciclos de repetición";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbCedula;
        private System.Windows.Forms.Label lbDepositar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDepositar;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.TextBox txtPlazo;
        private System.Windows.Forms.Label lbPlazo;
    }
}

