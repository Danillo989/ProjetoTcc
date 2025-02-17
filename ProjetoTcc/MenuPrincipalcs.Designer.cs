namespace ProjetoTcc
{
    partial class MenuPrincipalcs
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
            Menu = new GroupBox();
            Fornecedor = new Button();
            Menu.SuspendLayout();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.Controls.Add(Fornecedor);
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(293, 248);
            Menu.TabIndex = 0;
            Menu.TabStop = false;
            Menu.Text = "Menu Principal";
            // 
            // Fornecedor
            // 
            Fornecedor.Location = new Point(3, 21);
            Fornecedor.Name = "Fornecedor";
            Fornecedor.Size = new Size(162, 23);
            Fornecedor.TabIndex = 0;
            Fornecedor.Text = "Cadastro Fornecedor";
            Fornecedor.UseVisualStyleBackColor = true;
            Fornecedor.Click += Fornecedor_Click;
            // 
            // MenuPrincipalcs
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Menu);
            Name = "MenuPrincipalcs";
            Text = "MenuPrincipalcs";
            Menu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Menu;
        private Button Fornecedor;
    }
}