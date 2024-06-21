namespace Sap_Saep
{
    partial class frmTurmas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblNomeProfessor = new System.Windows.Forms.Label();
            this.gridTurmas = new System.Windows.Forms.DataGridView();
            this.btnCadastrarTurma = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTurmas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.lblNomeProfessor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 76);
            this.panel1.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(563, 23);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "button1";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // lblNomeProfessor
            // 
            this.lblNomeProfessor.AutoSize = true;
            this.lblNomeProfessor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeProfessor.ForeColor = System.Drawing.Color.White;
            this.lblNomeProfessor.Location = new System.Drawing.Point(23, 23);
            this.lblNomeProfessor.Name = "lblNomeProfessor";
            this.lblNomeProfessor.Size = new System.Drawing.Size(60, 24);
            this.lblNomeProfessor.TabIndex = 0;
            this.lblNomeProfessor.Text = "label1";
            // 
            // gridTurmas
            // 
            this.gridTurmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTurmas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridTurmas.Location = new System.Drawing.Point(0, 206);
            this.gridTurmas.Name = "gridTurmas";
            this.gridTurmas.Size = new System.Drawing.Size(650, 200);
            this.gridTurmas.TabIndex = 1;
            // 
            // btnCadastrarTurma
            // 
            this.btnCadastrarTurma.Location = new System.Drawing.Point(516, 155);
            this.btnCadastrarTurma.Name = "btnCadastrarTurma";
            this.btnCadastrarTurma.Size = new System.Drawing.Size(122, 23);
            this.btnCadastrarTurma.TabIndex = 2;
            this.btnCadastrarTurma.Text = "Cadastrar Turma";
            this.btnCadastrarTurma.UseVisualStyleBackColor = true;
            this.btnCadastrarTurma.Click += new System.EventHandler(this.btnCadastrarTurma_Click);
            // 
            // frmTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 406);
            this.Controls.Add(this.btnCadastrarTurma);
            this.Controls.Add(this.gridTurmas);
            this.Controls.Add(this.panel1);
            this.Name = "frmTurmas";
            this.Text = "frmTurmas";
            this.Load += new System.EventHandler(this.frmTurmas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTurmas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblNomeProfessor;
        private System.Windows.Forms.DataGridView gridTurmas;
        private System.Windows.Forms.Button btnCadastrarTurma;
    }
}