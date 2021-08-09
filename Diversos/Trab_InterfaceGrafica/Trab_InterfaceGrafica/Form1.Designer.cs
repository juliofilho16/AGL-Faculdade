namespace Trab_InterfaceGrafica
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
      this.labelCliente = new System.Windows.Forms.Label();
      this.labelNome = new System.Windows.Forms.Label();
      this.labelEmail = new System.Windows.Forms.Label();
      this.textBoxNome = new System.Windows.Forms.TextBox();
      this.textBoxEmail = new System.Windows.Forms.TextBox();
      this.btnSalvar = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnExibir = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // labelCliente
      // 
      this.labelCliente.AutoSize = true;
      this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.World, ((byte)(0)));
      this.labelCliente.ForeColor = System.Drawing.Color.Black;
      this.labelCliente.Location = new System.Drawing.Point(151, 18);
      this.labelCliente.Name = "labelCliente";
      this.labelCliente.Size = new System.Drawing.Size(87, 26);
      this.labelCliente.TabIndex = 0;
      this.labelCliente.Text = "Cliente";
      // 
      // labelNome
      // 
      this.labelNome.AutoSize = true;
      this.labelNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelNome.Location = new System.Drawing.Point(13, 67);
      this.labelNome.Name = "labelNome";
      this.labelNome.Size = new System.Drawing.Size(51, 20);
      this.labelNome.TabIndex = 1;
      this.labelNome.Text = "Nome";
      // 
      // labelEmail
      // 
      this.labelEmail.AutoSize = true;
      this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelEmail.Location = new System.Drawing.Point(13, 111);
      this.labelEmail.Name = "labelEmail";
      this.labelEmail.Size = new System.Drawing.Size(48, 20);
      this.labelEmail.TabIndex = 2;
      this.labelEmail.Text = "Email";
      // 
      // textBoxNome
      // 
      this.textBoxNome.Location = new System.Drawing.Point(70, 67);
      this.textBoxNome.Multiline = true;
      this.textBoxNome.Name = "textBoxNome";
      this.textBoxNome.Size = new System.Drawing.Size(291, 28);
      this.textBoxNome.TabIndex = 3;
      // 
      // textBoxEmail
      // 
      this.textBoxEmail.Location = new System.Drawing.Point(70, 109);
      this.textBoxEmail.Multiline = true;
      this.textBoxEmail.Name = "textBoxEmail";
      this.textBoxEmail.Size = new System.Drawing.Size(291, 28);
      this.textBoxEmail.TabIndex = 4;
      // 
      // btnSalvar
      // 
      this.btnSalvar.BackColor = System.Drawing.Color.Green;
      this.btnSalvar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSalvar.ForeColor = System.Drawing.Color.White;
      this.btnSalvar.Location = new System.Drawing.Point(263, 154);
      this.btnSalvar.Name = "btnSalvar";
      this.btnSalvar.Size = new System.Drawing.Size(127, 33);
      this.btnSalvar.TabIndex = 5;
      this.btnSalvar.Text = "Salvar";
      this.btnSalvar.UseVisualStyleBackColor = false;
      this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCancel.ForeColor = System.Drawing.Color.White;
      this.btnCancel.Location = new System.Drawing.Point(17, 154);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(119, 33);
      this.btnCancel.TabIndex = 6;
      this.btnCancel.Text = "Cancelar";
      this.btnCancel.UseVisualStyleBackColor = false;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnExibir
      // 
      this.btnExibir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
      this.btnExibir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnExibir.ForeColor = System.Drawing.Color.White;
      this.btnExibir.Location = new System.Drawing.Point(142, 154);
      this.btnExibir.Name = "btnExibir";
      this.btnExibir.Size = new System.Drawing.Size(115, 33);
      this.btnExibir.TabIndex = 7;
      this.btnExibir.Text = "Exibir";
      this.btnExibir.UseVisualStyleBackColor = false;
      this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
      // 
      // Form1
      // 
      this.AcceptButton = this.btnCancel;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveBorder;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(403, 191);
      this.Controls.Add(this.btnExibir);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSalvar);
      this.Controls.Add(this.textBoxEmail);
      this.Controls.Add(this.textBoxNome);
      this.Controls.Add(this.labelEmail);
      this.Controls.Add(this.labelNome);
      this.Controls.Add(this.labelCliente);
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "Cadastro de Cliente";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelCliente;
    private System.Windows.Forms.Label labelNome;
    private System.Windows.Forms.Label labelEmail;
    private System.Windows.Forms.TextBox textBoxNome;
    private System.Windows.Forms.TextBox textBoxEmail;
    private System.Windows.Forms.Button btnSalvar;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnExibir;
  }
}

