namespace TrabalhoVotacao.FormsAdiministrador.Menu
{
  partial class Menu
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
      this.CadastrarPartidos = new System.Windows.Forms.Button();
      this.CadastrarCandidatos = new System.Windows.Forms.Button();
      this.CadastrarUrna = new System.Windows.Forms.Button();
      this.CadastrarEleitor = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // CadastrarPartidos
      // 
      this.CadastrarPartidos.Location = new System.Drawing.Point(37, 32);
      this.CadastrarPartidos.Name = "CadastrarPartidos";
      this.CadastrarPartidos.Size = new System.Drawing.Size(128, 48);
      this.CadastrarPartidos.TabIndex = 0;
      this.CadastrarPartidos.Text = "Cadastrar Partidos";
      this.CadastrarPartidos.UseVisualStyleBackColor = true;
      this.CadastrarPartidos.Click += new System.EventHandler(this.CadastrarPartidos_Click);
      // 
      // CadastrarCandidatos
      // 
      this.CadastrarCandidatos.Location = new System.Drawing.Point(196, 32);
      this.CadastrarCandidatos.Name = "CadastrarCandidatos";
      this.CadastrarCandidatos.Size = new System.Drawing.Size(128, 48);
      this.CadastrarCandidatos.TabIndex = 1;
      this.CadastrarCandidatos.Text = "Cadastrar Candidatos";
      this.CadastrarCandidatos.UseVisualStyleBackColor = true;
      this.CadastrarCandidatos.Click += new System.EventHandler(this.CadastrarCandidatos_Click);
      // 
      // CadastrarUrna
      // 
      this.CadastrarUrna.Location = new System.Drawing.Point(37, 109);
      this.CadastrarUrna.Name = "CadastrarUrna";
      this.CadastrarUrna.Size = new System.Drawing.Size(128, 48);
      this.CadastrarUrna.TabIndex = 2;
      this.CadastrarUrna.Text = "Cadastrar Urna";
      this.CadastrarUrna.UseVisualStyleBackColor = true;
      this.CadastrarUrna.Visible = false;
      this.CadastrarUrna.Click += new System.EventHandler(this.CadastrarUrna_Click);
      // 
      // CadastrarEleitor
      // 
      this.CadastrarEleitor.Location = new System.Drawing.Point(196, 109);
      this.CadastrarEleitor.Name = "CadastrarEleitor";
      this.CadastrarEleitor.Size = new System.Drawing.Size(128, 48);
      this.CadastrarEleitor.TabIndex = 3;
      this.CadastrarEleitor.Text = "Cadastrar Eleitor";
      this.CadastrarEleitor.UseVisualStyleBackColor = true;
      this.CadastrarEleitor.Visible = false;
      this.CadastrarEleitor.Click += new System.EventHandler(this.CadastrarEleitor_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(37, 192);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(287, 28);
      this.button1.TabIndex = 4;
      this.button1.Text = "Sair";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Menu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(353, 243);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.CadastrarEleitor);
      this.Controls.Add(this.CadastrarUrna);
      this.Controls.Add(this.CadastrarCandidatos);
      this.Controls.Add(this.CadastrarPartidos);
      this.Name = "Menu";
      this.Text = "Menu";
      this.Load += new System.EventHandler(this.Menu_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button CadastrarPartidos;
    private System.Windows.Forms.Button CadastrarCandidatos;
    private System.Windows.Forms.Button CadastrarUrna;
    private System.Windows.Forms.Button CadastrarEleitor;
    private System.Windows.Forms.Button button1;
  }
}