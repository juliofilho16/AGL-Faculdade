namespace TrabalhoVotacao.FormsAdiministrador.Candidatos
{
  partial class CANDIDATO_CRUD
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
      this.label1 = new System.Windows.Forms.Label();
      this.textBoxNome = new System.Windows.Forms.TextBox();
      this.textBoxCPF = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.comboBoxPartidos = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.comboBoxTipoCandidato = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.textBoxLegenda = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(14, 107);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Nome";
      // 
      // textBoxNome
      // 
      this.textBoxNome.Location = new System.Drawing.Point(14, 126);
      this.textBoxNome.Multiline = true;
      this.textBoxNome.Name = "textBoxNome";
      this.textBoxNome.Size = new System.Drawing.Size(303, 23);
      this.textBoxNome.TabIndex = 1;
      // 
      // textBoxCPF
      // 
      this.textBoxCPF.Location = new System.Drawing.Point(14, 171);
      this.textBoxCPF.Multiline = true;
      this.textBoxCPF.Name = "textBoxCPF";
      this.textBoxCPF.Size = new System.Drawing.Size(144, 23);
      this.textBoxCPF.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(14, 154);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(27, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "CPF";
      // 
      // comboBoxPartidos
      // 
      this.comboBoxPartidos.FormattingEnabled = true;
      this.comboBoxPartidos.Location = new System.Drawing.Point(14, 77);
      this.comboBoxPartidos.Name = "comboBoxPartidos";
      this.comboBoxPartidos.Size = new System.Drawing.Size(303, 21);
      this.comboBoxPartidos.TabIndex = 5;
      this.comboBoxPartidos.Text = "Selecione...";
      this.comboBoxPartidos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 61);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(40, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Partido";
      // 
      // comboBoxTipoCandidato
      // 
      this.comboBoxTipoCandidato.FormattingEnabled = true;
      this.comboBoxTipoCandidato.Location = new System.Drawing.Point(13, 28);
      this.comboBoxTipoCandidato.Name = "comboBoxTipoCandidato";
      this.comboBoxTipoCandidato.Size = new System.Drawing.Size(201, 21);
      this.comboBoxTipoCandidato.TabIndex = 7;
      this.comboBoxTipoCandidato.Text = "Selecione...";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(14, 9);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(28, 13);
      this.label4.TabIndex = 8;
      this.label4.Text = "Tipo";
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(210, 216);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(96, 29);
      this.btnSave.TabIndex = 9;
      this.btnSave.Text = "Salvar";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(18, 216);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(96, 29);
      this.btnCancel.TabIndex = 10;
      this.btnCancel.Text = "Cancelar";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // textBoxLegenda
      // 
      this.textBoxLegenda.Location = new System.Drawing.Point(173, 171);
      this.textBoxLegenda.Multiline = true;
      this.textBoxLegenda.Name = "textBoxLegenda";
      this.textBoxLegenda.Size = new System.Drawing.Size(144, 23);
      this.textBoxLegenda.TabIndex = 12;
      this.textBoxLegenda.Visible = false;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(173, 154);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(44, 13);
      this.label5.TabIndex = 11;
      this.label5.Text = "Número";
      this.label5.Visible = false;
      // 
      // CANDIDATO_CRUD
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(338, 258);
      this.Controls.Add(this.textBoxLegenda);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.comboBoxTipoCandidato);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.comboBoxPartidos);
      this.Controls.Add(this.textBoxCPF);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBoxNome);
      this.Controls.Add(this.label1);
      this.Name = "CANDIDATO_CRUD";
      this.Text = "Cadastro de Candidato";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBoxNome;
    private System.Windows.Forms.TextBox textBoxCPF;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox comboBoxPartidos;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox comboBoxTipoCandidato;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.TextBox textBoxLegenda;
    private System.Windows.Forms.Label label5;
  }
}