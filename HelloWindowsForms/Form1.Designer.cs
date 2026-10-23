
namespace HelloWindowsForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            SuspendLayout();

            // label1
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(298, 27);
            label1.Name = "label1";
            label1.Size = new Size(197, 41);
            label1.TabIndex = 0;
            label1.Text = "SISTEMA IMC";

            // label2
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(195, 115);
            label2.Name = "label2";
            label2.Size = new Size(96, 41);
            label2.TabIndex = 1;
            label2.Text = "PESO:";

            // label3
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(195, 177);
            label3.Name = "label3";
            label3.Size = new Size(130, 41);
            label3.TabIndex = 2;
            label3.Text = "ALTURA:";

            // txtPeso
            txtPeso.Font = new Font("Segoe UI", 18F);
            txtPeso.Location = new Point(336, 115);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(201, 47);
            txtPeso.TabIndex = 3;

            // txtAltura
            txtAltura.Font = new Font("Segoe UI", 18F);
            txtAltura.Location = new Point(336, 191);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(201, 47);
            txtAltura.TabIndex = 4;

            // btnCalcular
            btnCalcular.Font = new Font("Segoe UI", 18F);
            btnCalcular.ForeColor = SystemColors.Highlight;
            btnCalcular.Location = new Point(315, 253);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(170, 45);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;

            // Evento do botão
            btnCalcular.Click += btnCalcular_Click;

            // lblResultado
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 18F);
            lblResultado.ForeColor = SystemColors.HotTrack;
            lblResultado.Location = new Point(195, 341);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(184, 41);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "RESULTADO:";

            // Form1
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);

            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);

            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private Button btnCalcular;
        private Label lblResultado;
    }
}
