namespace Arduino
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnConectar = new Button();
            btnEnviar = new Button();
            cmbPortas = new ComboBox();
            txtEnviar = new TextBox();
            txtReceber = new TextBox();
            tmrPortas = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(12, 12);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(98, 23);
            btnConectar.TabIndex = 0;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(12, 40);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(98, 23);
            btnEnviar.TabIndex = 1;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            // 
            // cmbPortas
            // 
            cmbPortas.FormattingEnabled = true;
            cmbPortas.Location = new Point(116, 12);
            cmbPortas.Name = "cmbPortas";
            cmbPortas.Size = new Size(121, 23);
            cmbPortas.TabIndex = 2;
            // 
            // txtEnviar
            // 
            txtEnviar.Location = new Point(116, 40);
            txtEnviar.Name = "txtEnviar";
            txtEnviar.Size = new Size(344, 23);
            txtEnviar.TabIndex = 3;
            // 
            // txtReceber
            // 
            txtReceber.Location = new Point(12, 69);
            txtReceber.Multiline = true;
            txtReceber.Name = "txtReceber";
            txtReceber.ScrollBars = ScrollBars.Vertical;
            txtReceber.Size = new Size(448, 297);
            txtReceber.TabIndex = 4;
            // 
            // tmrPortas
            // 
            tmrPortas.Interval = 1000;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 379);
            Controls.Add(txtReceber);
            Controls.Add(txtEnviar);
            Controls.Add(cmbPortas);
            Controls.Add(btnEnviar);
            Controls.Add(btnConectar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConectar;
        private Button btnEnviar;
        private ComboBox cmbPortas;
        private TextBox txtEnviar;
        private TextBox txtReceber;
        private System.Windows.Forms.Timer tmrPortas;
    }
}
