namespace TrabalhoVotacao.Eleicao.LoginEleitor
{
  partial class TIPO_ELEICAO
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
      this.btnMunicipais = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnMunicipais
      // 
      this.btnMunicipais.Location = new System.Drawing.Point(12, 49);
      this.btnMunicipais.Name = "btnMunicipais";
      this.btnMunicipais.Size = new System.Drawing.Size(117, 45);
      this.btnMunicipais.TabIndex = 0;
      this.btnMunicipais.Text = "Eleições Municipais";
      this.btnMunicipais.UseVisualStyleBackColor = true;
      this.btnMunicipais.Click += new System.EventHandler(this.btnMunicipais_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(155, 49);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(117, 45);
      this.button2.TabIndex = 1;
      this.button2.Text = "Eleições Estaduais/Federais";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // TIPO_ELEICAO
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 117);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.btnMunicipais);
      this.Name = "TIPO_ELEICAO";
      this.Text = "TIPO ELEIÇÃO";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnMunicipais;
    private System.Windows.Forms.Button button2;
  }
}