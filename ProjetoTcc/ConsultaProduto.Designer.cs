namespace ProjetoTcc
{
    partial class ConsultaProduto
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
            plu = new TextBox();
            Text1 = new Label();
            dataGridView1 = new DataGridView();
            gridButton = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // plu
            // 
            plu.Location = new Point(113, 96);
            plu.Name = "plu";
            plu.Size = new Size(105, 25);
            plu.TabIndex = 0;
            // 
            // Text1
            // 
            Text1.AccessibleRole = AccessibleRole.None;
            Text1.AutoSize = true;
            Text1.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Text1.Location = new Point(269, 21);
            Text1.Name = "Text1";
            Text1.Size = new Size(251, 33);
            Text1.TabIndex = 1;
            Text1.Text = "Consulta Produto ";
            Text1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowDrop = true;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 129);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 27;
            dataGridView1.Size = new Size(778, 315);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // gridButton
            // 
            gridButton.Location = new Point(704, 92);
            gridButton.Name = "gridButton";
            gridButton.Size = new Size(75, 31);
            gridButton.TabIndex = 3;
            gridButton.Text = "Consultar";
            gridButton.UseVisualStyleBackColor = true;
            gridButton.Click += gridButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 99);
            label1.Name = "label1";
            label1.Size = new Size(79, 17);
            label1.TabIndex = 4;
            label1.Text = "Digite o Plu ";
            // 
            // ConsultaProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(gridButton);
            Controls.Add(dataGridView1);
            Controls.Add(Text1);
            Controls.Add(plu);
            Name = "ConsultaProduto";
            Text = "ConsultaProduto";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox plu;
        private Label Text1;
        private DataGridView dataGridView1;
        private Button gridButton;
        private Label label1;
    }
}