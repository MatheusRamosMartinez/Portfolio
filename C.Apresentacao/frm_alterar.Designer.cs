namespace C.Apresentacao
{
    partial class frm_alterar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_alterar));
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbltelefone = new System.Windows.Forms.Label();
            this.lblcasa = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCasa = new System.Windows.Forms.TextBox();
            this.fotoMorador = new System.Windows.Forms.PictureBox();
            this.lblcpf = new System.Windows.Forms.Label();
            this.editar = new System.Windows.Forms.Button();
            this.pnl_background = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fotoMorador)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCPF
            // 
            this.txtCPF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtCPF.Location = new System.Drawing.Point(106, 255);
            this.txtCPF.Mask = "000.000.000/00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(235, 14);
            this.txtCPF.TabIndex = 74;
            // 
            // txtData
            // 
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtData.Location = new System.Drawing.Point(106, 333);
            this.txtData.Mask = "00/00/0000";
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(235, 14);
            this.txtData.TabIndex = 73;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 72;
            this.label7.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            this.txtEndereco.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(105, 203);
            this.txtEndereco.MaxLength = 50;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(235, 14);
            this.txtEndereco.TabIndex = 71;
            // 
            // Nome
            // 
            this.Nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nome.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.Nome.Location = new System.Drawing.Point(5, 141);
            this.Nome.MaxLength = 120;
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(344, 24);
            this.Nome.TabIndex = 70;
            this.Nome.Text = "Nome do Morador";
            this.Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(344, 21);
            this.label4.TabIndex = 69;
            this.label4.Text = "Código do Morador";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 65;
            this.label6.Text = "Email:";
            // 
            // lbltelefone
            // 
            this.lbltelefone.AutoSize = true;
            this.lbltelefone.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefone.Location = new System.Drawing.Point(10, 280);
            this.lbltelefone.Name = "lbltelefone";
            this.lbltelefone.Size = new System.Drawing.Size(65, 17);
            this.lbltelefone.TabIndex = 64;
            this.lbltelefone.Text = "Telefone:";
            // 
            // lblcasa
            // 
            this.lblcasa.AutoSize = true;
            this.lblcasa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcasa.Location = new System.Drawing.Point(10, 228);
            this.lblcasa.Name = "lblcasa";
            this.lblcasa.Size = new System.Drawing.Size(87, 17);
            this.lblcasa.TabIndex = 63;
            this.lblcasa.Text = "Nº da Casa:";
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldata.Location = new System.Drawing.Point(10, 332);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(90, 17);
            this.lbldata.TabIndex = 62;
            this.lbldata.Text = "Nascimento:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(105, 281);
            this.txtTelefone.MaxLength = 25;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(235, 14);
            this.txtTelefone.TabIndex = 61;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(105, 307);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(237, 14);
            this.txtEmail.TabIndex = 60;
            // 
            // txtCasa
            // 
            this.txtCasa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCasa.Location = new System.Drawing.Point(105, 229);
            this.txtCasa.MaxLength = 4;
            this.txtCasa.Name = "txtCasa";
            this.txtCasa.Size = new System.Drawing.Size(235, 14);
            this.txtCasa.TabIndex = 59;
            // 
            // fotoMorador
            // 
            this.fotoMorador.BackColor = System.Drawing.Color.Black;
            this.fotoMorador.ErrorImage = ((System.Drawing.Image)(resources.GetObject("fotoMorador.ErrorImage")));
            this.fotoMorador.Image = ((System.Drawing.Image)(resources.GetObject("fotoMorador.Image")));
            this.fotoMorador.Location = new System.Drawing.Point(125, 12);
            this.fotoMorador.Name = "fotoMorador";
            this.fotoMorador.Size = new System.Drawing.Size(120, 120);
            this.fotoMorador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoMorador.TabIndex = 66;
            this.fotoMorador.TabStop = false;
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpf.Location = new System.Drawing.Point(10, 255);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(37, 17);
            this.lblcpf.TabIndex = 75;
            this.lblcpf.Text = "CPF:";
            // 
            // editar
            // 
            this.editar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editar.BackColor = System.Drawing.Color.Navy;
            this.editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editar.ForeColor = System.Drawing.Color.White;
            this.editar.Location = new System.Drawing.Point(240, 384);
            this.editar.Margin = new System.Windows.Forms.Padding(0);
            this.editar.Name = "editar";
            this.editar.Padding = new System.Windows.Forms.Padding(1);
            this.editar.Size = new System.Drawing.Size(100, 32);
            this.editar.TabIndex = 307;
            this.editar.Text = "Alterar";
            this.editar.UseVisualStyleBackColor = false;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // pnl_background
            // 
            this.pnl_background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(80)))), ((int)(((byte)(163)))));
            this.pnl_background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_background.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_background.Location = new System.Drawing.Point(0, 0);
            this.pnl_background.Name = "pnl_background";
            this.pnl_background.Size = new System.Drawing.Size(354, 75);
            this.pnl_background.TabIndex = 308;
            // 
            // frm_alterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.fotoMorador);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbltelefone);
            this.Controls.Add(this.lblcasa);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCasa);
            this.Controls.Add(this.pnl_background);
            this.Name = "frm_alterar";
            this.Text = "frm_alterar";
            ((System.ComponentModel.ISupportInitialize)(this.fotoMorador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbltelefone;
        private System.Windows.Forms.Label lblcasa;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCasa;
        private System.Windows.Forms.PictureBox fotoMorador;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Panel pnl_background;
    }
}