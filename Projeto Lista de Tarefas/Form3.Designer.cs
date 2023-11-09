namespace Projeto_Lista_de_Tarefas
{
    partial class Form3
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
            this.btnTarefas = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTarefas
            // 
            this.btnTarefas.Location = new System.Drawing.Point(173, 51);
            this.btnTarefas.Name = "btnTarefas";
            this.btnTarefas.Size = new System.Drawing.Size(154, 137);
            this.btnTarefas.TabIndex = 0;
            this.btnTarefas.Text = "TAREFAS";
            this.btnTarefas.UseVisualStyleBackColor = true;
            this.btnTarefas.Click += new System.EventHandler(this.btnTarefas_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(3, 51);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(154, 137);
            this.btnCadastro.TabIndex = 1;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 231);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.btnTarefas);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnTarefas;
        private Button btnCadastro;
    }
}