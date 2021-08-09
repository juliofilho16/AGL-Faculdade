namespace TrabalhoVotacao
{
  partial class Form1
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
      this.Cadastros = new System.Windows.Forms.Button();
      this.eleicao = new System.Windows.Forms.Button();
      this.btnResult = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // Cadastros
      // 
      this.Cadastros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Cadastros.Location = new System.Drawing.Point(65, 43);
      this.Cadastros.Name = "Cadastros";
      this.Cadastros.Size = new System.Drawing.Size(199, 30);
      this.Cadastros.TabIndex = 0;
      this.Cadastros.Text = "Cadastros";
      this.Cadastros.UseVisualStyleBackColor = true;
      this.Cadastros.Click += new System.EventHandler(this.Cadastros_Click);
      // 
      // eleicao
      // 
      this.eleicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.eleicao.Location = new System.Drawing.Point(65, 96);
      this.eleicao.Name = "eleicao";
      this.eleicao.Size = new System.Drawing.Size(199, 30);
      this.eleicao.TabIndex = 1;
      this.eleicao.Text = "Eleição";
      this.eleicao.UseVisualStyleBackColor = true;
      this.eleicao.Click += new System.EventHandler(this.eleicao_Click);
      // 
      // btnResult
      // 
      this.btnResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnResult.Location = new System.Drawing.Point(65, 148);
      this.btnResult.Name = "btnResult";
      this.btnResult.Size = new System.Drawing.Size(199, 30);
      this.btnResult.TabIndex = 2;
      this.btnResult.Text = "Resultados";
      this.btnResult.UseVisualStyleBackColor = true;
      this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.Location = new System.Drawing.Point(65, 197);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(199, 30);
      this.button1.TabIndex = 3;
      this.button1.Text = "Fechar";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(330, 264);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.btnResult);
      this.Controls.Add(this.eleicao);
      this.Controls.Add(this.Cadastros);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "Form1";
      this.Text = "SISTEMA DE GERENCIAMENTO DE URNAS";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button Cadastros;
    private System.Windows.Forms.Button eleicao;
    private System.Windows.Forms.Button btnResult;
    private System.Windows.Forms.Button button1;
  }
}

