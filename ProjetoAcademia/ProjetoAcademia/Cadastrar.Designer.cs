namespace ProjetoAcademia
{
    partial class frmCadastrar
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Img_Foto = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCombo = new System.Windows.Forms.RadioButton();
            this.rbAnual = new System.Windows.Forms.RadioButton();
            this.rbMensal = new System.Windows.Forms.RadioButton();
            this.btn_Cadastrar = new System.Windows.Forms.Button();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbHit = new System.Windows.Forms.CheckBox();
            this.cbForça = new System.Windows.Forms.CheckBox();
            this.cbPontenciaM = new System.Windows.Forms.CheckBox();
            this.cboxResistencia = new System.Windows.Forms.CheckBox();
            this.cboxHipertrofia = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_Fechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Foto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 29);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(53, 26);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(184, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(249, 29);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(63, 13);
            this.lblIdade.TabIndex = 2;
            this.lblIdade.Text = "Nascimento";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(318, 26);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Img_Foto
            // 
            this.Img_Foto.Location = new System.Drawing.Point(513, 107);
            this.Img_Foto.Name = "Img_Foto";
            this.Img_Foto.Size = new System.Drawing.Size(238, 157);
            this.Img_Foto.TabIndex = 4;
            this.Img_Foto.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCombo);
            this.groupBox1.Controls.Add(this.rbAnual);
            this.groupBox1.Controls.Add(this.rbMensal);
            this.groupBox1.Location = new System.Drawing.Point(15, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 231);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plano Academia";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbCombo
            // 
            this.rbCombo.AutoSize = true;
            this.rbCombo.Location = new System.Drawing.Point(6, 131);
            this.rbCombo.Name = "rbCombo";
            this.rbCombo.Size = new System.Drawing.Size(150, 17);
            this.rbCombo.TabIndex = 8;
            this.rbCombo.TabStop = true;
            this.rbCombo.Text = " Combo 3 Anos   R$ 2.500";
            this.rbCombo.UseVisualStyleBackColor = true;
            // 
            // rbAnual
            // 
            this.rbAnual.AutoSize = true;
            this.rbAnual.Location = new System.Drawing.Point(6, 82);
            this.rbAnual.Name = "rbAnual";
            this.rbAnual.Size = new System.Drawing.Size(99, 17);
            this.rbAnual.TabIndex = 7;
            this.rbAnual.TabStop = true;
            this.rbAnual.Text = "Anual    R$ 750";
            this.rbAnual.UseVisualStyleBackColor = true;
            // 
            // rbMensal
            // 
            this.rbMensal.AutoSize = true;
            this.rbMensal.Location = new System.Drawing.Point(6, 36);
            this.rbMensal.Name = "rbMensal";
            this.rbMensal.Size = new System.Drawing.Size(100, 17);
            this.rbMensal.TabIndex = 6;
            this.rbMensal.TabStop = true;
            this.rbMensal.Text = "Mensal    R$ 90";
            this.rbMensal.UseVisualStyleBackColor = true;
            // 
            // btn_Cadastrar
            // 
            this.btn_Cadastrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Cadastrar.Location = new System.Drawing.Point(617, 393);
            this.btn_Cadastrar.Name = "btn_Cadastrar";
            this.btn_Cadastrar.Size = new System.Drawing.Size(147, 35);
            this.btn_Cadastrar.TabIndex = 10;
            this.btn_Cadastrar.Text = "Cadastrar";
            this.btn_Cadastrar.UseVisualStyleBackColor = false;
            this.btn_Cadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbSexo.Location = new System.Drawing.Point(586, 26);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(165, 21);
            this.cbSexo.TabIndex = 11;
            this.cbSexo.Text = "Sexo";
            this.cbSexo.SelectedIndexChanged += new System.EventHandler(this.cbSexo_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbHit);
            this.groupBox2.Controls.Add(this.cbForça);
            this.groupBox2.Controls.Add(this.cbPontenciaM);
            this.groupBox2.Controls.Add(this.cboxResistencia);
            this.groupBox2.Controls.Add(this.cboxHipertrofia);
            this.groupBox2.Location = new System.Drawing.Point(225, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 231);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Treino";
            // 
            // cbHit
            // 
            this.cbHit.AutoSize = true;
            this.cbHit.Location = new System.Drawing.Point(140, 36);
            this.cbHit.Name = "cbHit";
            this.cbHit.Size = new System.Drawing.Size(44, 17);
            this.cbHit.TabIndex = 4;
            this.cbHit.Text = "HIT";
            this.cbHit.UseVisualStyleBackColor = true;
            // 
            // cbForça
            // 
            this.cbForça.AutoSize = true;
            this.cbForça.Location = new System.Drawing.Point(7, 183);
            this.cbForça.Name = "cbForça";
            this.cbForça.Size = new System.Drawing.Size(99, 17);
            this.cbForça.TabIndex = 3;
            this.cbForça.Text = "Força Muscular";
            this.cbForça.UseVisualStyleBackColor = true;
            // 
            // cbPontenciaM
            // 
            this.cbPontenciaM.AutoSize = true;
            this.cbPontenciaM.Location = new System.Drawing.Point(7, 132);
            this.cbPontenciaM.Name = "cbPontenciaM";
            this.cbPontenciaM.Size = new System.Drawing.Size(111, 17);
            this.cbPontenciaM.TabIndex = 2;
            this.cbPontenciaM.Text = "PotênciaMuscular";
            this.cbPontenciaM.UseVisualStyleBackColor = true;
            // 
            // cboxResistencia
            // 
            this.cboxResistencia.AutoSize = true;
            this.cboxResistencia.Location = new System.Drawing.Point(7, 82);
            this.cboxResistencia.Name = "cboxResistencia";
            this.cboxResistencia.Size = new System.Drawing.Size(127, 17);
            this.cboxResistencia.TabIndex = 1;
            this.cboxResistencia.Text = "Resistencia Muscular";
            this.cboxResistencia.UseVisualStyleBackColor = true;
            // 
            // cboxHipertrofia
            // 
            this.cboxHipertrofia.AutoSize = true;
            this.cboxHipertrofia.Location = new System.Drawing.Point(6, 36);
            this.cboxHipertrofia.Name = "cboxHipertrofia";
            this.cboxHipertrofia.Size = new System.Drawing.Size(120, 17);
            this.cboxHipertrofia.TabIndex = 0;
            this.cboxHipertrofia.Text = "Hipertrofia Muscular";
            this.cboxHipertrofia.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(693, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 20);
            this.button2.TabIndex = 12;
            this.button2.Text = "Foto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Fechar.Location = new System.Drawing.Point(15, 393);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(147, 35);
            this.btn_Fechar.TabIndex = 13;
            this.btn_Fechar.Text = "voltar";
            this.btn_Fechar.UseVisualStyleBackColor = false;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // frmCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Fechar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.btn_Cadastrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Img_Foto);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "frmCadastrar";
            this.Text = "Voltar";
            ((System.ComponentModel.ISupportInitialize)(this.Img_Foto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox Img_Foto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCombo;
        private System.Windows.Forms.RadioButton rbAnual;
        private System.Windows.Forms.RadioButton rbMensal;
        private System.Windows.Forms.Button btn_Cadastrar;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbHit;
        private System.Windows.Forms.CheckBox cbForça;
        private System.Windows.Forms.CheckBox cbPontenciaM;
        private System.Windows.Forms.CheckBox cboxResistencia;
        private System.Windows.Forms.CheckBox cboxHipertrofia;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_Fechar;
    }
}