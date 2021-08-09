namespace TrabalhoVotacao.FormsAdiministrador.Eleitor
{
  partial class ELEITORCRUD
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
      this.textBoxTituloEleitor = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.comboBoxZona = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.comboBoxSecao = new System.Windows.Forms.ComboBox();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(30, 31);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(35, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Nome";
      // 
      // textBoxNome
      // 
      this.textBoxNome.Location = new System.Drawing.Point(33, 47);
      this.textBoxNome.Name = "textBoxNome";
      this.textBoxNome.Size = new System.Drawing.Size(219, 20);
      this.textBoxNome.TabIndex = 1;
      // 
      // textBoxTituloEleitor
      // 
      this.textBoxTituloEleitor.Location = new System.Drawing.Point(33, 96);
      this.textBoxTituloEleitor.Name = "textBoxTituloEleitor";
      this.textBoxTituloEleitor.Size = new System.Drawing.Size(219, 20);
      this.textBoxTituloEleitor.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(30, 80);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(75, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Título Eleitoral";
      // 
      // comboBoxZona
      // 
      this.comboBoxZona.FormattingEnabled = true;
      this.comboBoxZona.Location = new System.Drawing.Point(33, 148);
      this.comboBoxZona.Name = "comboBoxZona";
      this.comboBoxZona.Size = new System.Drawing.Size(95, 21);
      this.comboBoxZona.TabIndex = 4;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(30, 132);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(32, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Zona";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(155, 132);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(38, 13);
      this.label4.TabIndex = 8;
      this.label4.Text = "Seção";
      // 
      // comboBoxSecao
      // 
      this.comboBoxSecao.FormattingEnabled = true;
      this.comboBoxSecao.Location = new System.Drawing.Point(155, 148);
      this.comboBoxSecao.Name = "comboBoxSecao";
      this.comboBoxSecao.Size = new System.Drawing.Size(94, 21);
      this.comboBoxSecao.TabIndex = 7;
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(174, 196);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 9;
      this.btnSave.Text = "Salvar";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(33, 196);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 10;
      this.btnCancel.Text = "Cancelar";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // ELEITORCRUD
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(294, 261);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.comboBoxSecao);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.comboBoxZona);
      this.Controls.Add(this.textBoxTituloEleitor);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBoxNome);
      this.Controls.Add(this.label1);
      this.Name = "ELEITORCRUD";
      this.Text = "ELEITORCRUD";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBoxNome;
    private System.Windows.Forms.TextBox textBoxTituloEleitor;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox comboBoxZona;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox comboBoxSecao;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnCancel;
  }
}