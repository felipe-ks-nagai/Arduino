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
            cmbPortas = new ComboBox();
            txtReceber = new TextBox();
            tmrPortas = new System.Windows.Forms.Timer(components);
            lblVerde = new Label();
            lblVermelho = new Label();
            lblAmarelo = new Label();
            cmbVerde = new ComboBox();
            cmbVermelho = new ComboBox();
            cmbAmarelo = new ComboBox();
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
            // cmbPortas
            // 
            cmbPortas.FormattingEnabled = true;
            cmbPortas.Location = new Point(116, 12);
            cmbPortas.Name = "cmbPortas";
            cmbPortas.Size = new Size(121, 23);
            cmbPortas.TabIndex = 2;
            // 
            // txtReceber
            // 
            txtReceber.Location = new Point(12, 158);
            txtReceber.Multiline = true;
            txtReceber.Name = "txtReceber";
            txtReceber.ScrollBars = ScrollBars.Vertical;
            txtReceber.Size = new Size(448, 208);
            txtReceber.TabIndex = 4;
            // 
            // tmrPortas
            // 
            tmrPortas.Interval = 1000;
            // 
            // lblVerde
            // 
            lblVerde.AutoSize = true;
            lblVerde.Location = new Point(46, 61);
            lblVerde.Name = "lblVerde";
            lblVerde.Size = new Size(36, 15);
            lblVerde.TabIndex = 5;
            lblVerde.Text = "Verde";
            lblVerde.Click += label1_Click;
            // 
            // lblVermelho
            // 
            lblVermelho.AutoSize = true;
            lblVermelho.Location = new Point(202, 61);
            lblVermelho.Name = "lblVermelho";
            lblVermelho.Size = new Size(57, 15);
            lblVermelho.TabIndex = 6;
            lblVermelho.Text = "Vermelho";
            // 
            // lblAmarelo
            // 
            lblAmarelo.AutoSize = true;
            lblAmarelo.Location = new Point(376, 61);
            lblAmarelo.Name = "lblAmarelo";
            lblAmarelo.Size = new Size(52, 15);
            lblAmarelo.TabIndex = 7;
            lblAmarelo.Text = "Amarelo";
            // 
            // cmbVerde
            // 
            cmbVerde.FormattingEnabled = true;
            cmbVerde.Items.AddRange(new object[] { "ATIVARverde", "DESATIVARverde" });
            cmbVerde.Location = new Point(12, 95);
            cmbVerde.Name = "cmbVerde";
            cmbVerde.Size = new Size(121, 23);
            cmbVerde.TabIndex = 8;
            cmbVerde.SelectedIndexChanged += cmbVerde_SelectedIndexChanged;
            // 
            // cmbVermelho
            // 
            cmbVermelho.FormattingEnabled = true;
            cmbVermelho.Items.AddRange(new object[] { "ATIVARvermelho", "DESATIVARvermelho" });
            cmbVermelho.Location = new Point(173, 95);
            cmbVermelho.Name = "cmbVermelho";
            cmbVermelho.Size = new Size(121, 23);
            cmbVermelho.TabIndex = 9;
            cmbVermelho.SelectedIndexChanged += cmbVermelho_SelectedIndexChanged;
            // 
            // cmbAmarelo
            // 
            cmbAmarelo.FormattingEnabled = true;
            cmbAmarelo.Items.AddRange(new object[] { "ATIVARamarelo", "DESATIVARamarelo" });
            cmbAmarelo.Location = new Point(339, 95);
            cmbAmarelo.Name = "cmbAmarelo";
            cmbAmarelo.Size = new Size(121, 23);
            cmbAmarelo.TabIndex = 10;
            cmbAmarelo.SelectedIndexChanged += cmbAmarelo_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 379);
            Controls.Add(cmbAmarelo);
            Controls.Add(cmbVermelho);
            Controls.Add(cmbVerde);
            Controls.Add(lblAmarelo);
            Controls.Add(lblVermelho);
            Controls.Add(lblVerde);
            Controls.Add(txtReceber);
            Controls.Add(cmbPortas);
            Controls.Add(btnConectar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConectar;
        private ComboBox cmbPortas;
        private TextBox txtReceber;
        private System.Windows.Forms.Timer tmrPortas;
        private Label lblVerde;
        private Label lblVermelho;
        private Label lblAmarelo;
        private ComboBox cmbVerde;
        private ComboBox cmbVermelho;
        private ComboBox cmbAmarelo;
    }
}
