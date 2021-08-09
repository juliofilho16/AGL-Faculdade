namespace TrabalhoVotacao.Eleicao.MenuEleitor
{
  partial class MENU_ELEITOR
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
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.btnPresidente = new System.Windows.Forms.Button();
      this.btnPrefeito = new System.Windows.Forms.Button();
      this.btnVereador = new System.Windows.Forms.Button();
      this.btnFinaly = new System.Windows.Forms.Button();
      this.labelNome = new System.Windows.Forms.Label();
      this.labelZona = new System.Windows.Forms.Label();
      this.labelSecao = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(21, 44);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(41, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Nome: ";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(165, 44);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(38, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Zona: ";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(247, 44);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(44, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Seção: ";
      // 
      // btnPresidente
      // 
      this.btnPresidente.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnPresidente.Location = new System.Drawing.Point(24, 93);
      this.btnPresidente.Name = "btnPresidente";
      this.btnPresidente.Size = new System.Drawing.Size(288, 30);
      this.btnPresidente.TabIndex = 6;
      this.btnPresidente.Text = "Presidente";
      this.btnPresidente.UseVisualStyleBackColor = true;
      this.btnPresidente.Click += new System.EventHandler(this.btnPresidente_Click);
      // 
      // btnPrefeito
      // 
      this.btnPrefeito.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnPrefeito.Location = new System.Drawing.Point(24, 93);
      this.btnPrefeito.Name = "btnPrefeito";
      this.btnPrefeito.Size = new System.Drawing.Size(116, 30);
      this.btnPrefeito.TabIndex = 7;
      this.btnPrefeito.Text = "Prefeito";
      this.btnPrefeito.UseVisualStyleBackColor = true;
      this.btnPrefeito.Click += new System.EventHandler(this.btnPrefeito_Click);
      // 
      // btnVereador
      // 
      this.btnVereador.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnVereador.Location = new System.Drawing.Point(204, 93);
      this.btnVereador.Name = "btnVereador";
      this.btnVereador.Size = new System.Drawing.Size(108, 30);
      this.btnVereador.TabIndex = 8;
      this.btnVereador.Text = "Vereador";
      this.btnVereador.UseVisualStyleBackColor = true;
      this.btnVereador.Click += new System.EventHandler(this.btnVereador_Click);
      // 
      // btnFinaly
      // 
      this.btnFinaly.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnFinaly.Location = new System.Drawing.Point(24, 143);
      this.btnFinaly.Name = "btnFinaly";
      this.btnFinaly.Size = new System.Drawing.Size(288, 30);
      this.btnFinaly.TabIndex = 9;
      this.btnFinaly.Text = "Sair";
      this.btnFinaly.UseVisualStyleBackColor = true;
      this.btnFinaly.Click += new System.EventHandler(this.btnFinaly_Click);
      // 
      // labelNome
      // 
      this.labelNome.AutoSize = true;
      this.labelNome.Location = new System.Drawing.Point(62, 44);
      this.labelNome.Name = "labelNome";
      this.labelNome.Size = new System.Drawing.Size(35, 13);
      this.labelNome.TabIndex = 10;
      this.labelNome.Text = "Nome";
      // 
      // labelZona
      // 
      this.labelZona.AutoSize = true;
      this.labelZona.Location = new System.Drawing.Point(201, 44);
      this.labelZona.Name = "labelZona";
      this.labelZona.Size = new System.Drawing.Size(32, 13);
      this.labelZona.TabIndex = 11;
      this.labelZona.Text = "Zona";
      // 
      // labelSecao
      // 
      this.labelSecao.AutoSize = true;
      this.labelSecao.Location = new System.Drawing.Point(286, 44);
      this.labelSecao.Name = "labelSecao";
      this.labelSecao.Size = new System.Drawing.Size(38, 13);
      this.labelSecao.TabIndex = 12;
      this.labelSecao.Text = "Seção";
      // 
      // MENU_ELEITOR
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(339, 184);
      this.Controls.Add(this.labelSecao);
      this.Controls.Add(this.labelZona);
      this.Controls.Add(this.labelNome);
      this.Controls.Add(this.btnFinaly);
      this.Controls.Add(this.btnVereador);
      this.Controls.Add(this.btnPrefeito);
      this.Controls.Add(this.btnPresidente);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "MENU_ELEITOR";
      this.Text = "MENU ELEITOR";
      this.Load += new System.EventHandler(this.MENU_ELEITOR_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnPresidente;
    private System.Windows.Forms.Button btnPrefeito;
    private System.Windows.Forms.Button btnVereador;
    private System.Windows.Forms.Button btnFinaly;
    private System.Windows.Forms.Label labelNome;
    private System.Windows.Forms.Label labelZona;
    private System.Windows.Forms.Label labelSecao;
  }
}