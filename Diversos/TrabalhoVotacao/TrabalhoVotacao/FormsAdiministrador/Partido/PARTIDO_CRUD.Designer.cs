namespace TrabalhoVotacao.FormsAdiministrador.Partido
{
  partial class PARTIDO_CRUD
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
      this.textBoxNome = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.textBoxSigla = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.textBoxNumero = new System.Windows.Forms.TextBox();
      this.SavePartido = new System.Windows.Forms.Button();
      this.CancelarPartido = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // textBoxNome
      // 
      this.textBoxNome.Location = new System.Drawing.Point(64, 29);
      this.textBoxNome.Multiline = true;
      this.textBoxNome.Name = "textBoxNome";
      this.textBoxNome.Size = new System.Drawing.Size(223, 20);
      this.textBoxNome.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(20, 32);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(38, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Nome:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(20, 58);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(33, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Sigla:";
      // 
      // textBoxSigla
      // 
      this.textBoxSigla.Location = new System.Drawing.Point(64, 55);
      this.textBoxSigla.Multiline = true;
      this.textBoxSigla.Name = "textBoxSigla";
      this.textBoxSigla.Size = new System.Drawing.Size(60, 20);
      this.textBoxSigla.TabIndex = 2;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(167, 62);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(47, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Número:";
      this.label3.Click += new System.EventHandler(this.label3_Click);
      // 
      // textBoxNumero
      // 
      this.textBoxNumero.Location = new System.Drawing.Point(220, 58);
      this.textBoxNumero.MaxLength = 2;
      this.textBoxNumero.Multiline = true;
      this.textBoxNumero.Name = "textBoxNumero";
      this.textBoxNumero.Size = new System.Drawing.Size(67, 20);
      this.textBoxNumero.TabIndex = 4;
      // 
      // SavePartido
      // 
      this.SavePartido.Location = new System.Drawing.Point(212, 105);
      this.SavePartido.Name = "SavePartido";
      this.SavePartido.Size = new System.Drawing.Size(75, 23);
      this.SavePartido.TabIndex = 6;
      this.SavePartido.Text = "Salvar";
      this.SavePartido.UseVisualStyleBackColor = true;
      this.SavePartido.Click += new System.EventHandler(this.SavePartido_Click);
      // 
      // CancelarPartido
      // 
      this.CancelarPartido.Location = new System.Drawing.Point(15, 105);
      this.CancelarPartido.Name = "CancelarPartido";
      this.CancelarPartido.Size = new System.Drawing.Size(75, 23);
      this.CancelarPartido.TabIndex = 7;
      this.CancelarPartido.Text = "Cancelar";
      this.CancelarPartido.UseVisualStyleBackColor = true;
      this.CancelarPartido.Click += new System.EventHandler(this.CancelarPartido_Click);
      // 
      // PARTIDO_CRUD
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(311, 141);
      this.Controls.Add(this.CancelarPartido);
      this.Controls.Add(this.SavePartido);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textBoxNumero);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBoxSigla);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBoxNome);
      this.Name = "PARTIDO_CRUD";
      this.Text = "Cadastro de Partido";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBoxNome;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBoxSigla;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBoxNumero;
    private System.Windows.Forms.Button SavePartido;
    private System.Windows.Forms.Button CancelarPartido;
  }
}