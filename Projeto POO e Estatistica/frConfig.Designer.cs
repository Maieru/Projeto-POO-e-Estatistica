
namespace Projeto_POO_e_Estatistica
{
    partial class frConfig
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
            this.trbVolume = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.chkMusica = new System.Windows.Forms.CheckBox();
            this.chkLimitador = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(64, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Volume: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 1;
            // 
            // trbVolume
            // 
            this.trbVolume.Location = new System.Drawing.Point(154, 245);
            this.trbVolume.Name = "trbVolume";
            this.trbVolume.Size = new System.Drawing.Size(351, 45);
            this.trbVolume.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(41, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 3;
            // 
            // chkMusica
            // 
            this.chkMusica.AutoSize = true;
            this.chkMusica.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F);
            this.chkMusica.ForeColor = System.Drawing.Color.White;
            this.chkMusica.Location = new System.Drawing.Point(67, 42);
            this.chkMusica.Name = "chkMusica";
            this.chkMusica.Size = new System.Drawing.Size(118, 22);
            this.chkMusica.TabIndex = 4;
            this.chkMusica.Text = "Musica ativada";
            this.chkMusica.UseVisualStyleBackColor = true;
            // 
            // chkLimitador
            // 
            this.chkLimitador.AutoSize = true;
            this.chkLimitador.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F);
            this.chkLimitador.ForeColor = System.Drawing.Color.White;
            this.chkLimitador.Location = new System.Drawing.Point(67, 146);
            this.chkLimitador.Name = "chkLimitador";
            this.chkLimitador.Size = new System.Drawing.Size(155, 22);
            this.chkLimitador.TabIndex = 5;
            this.chkLimitador.Text = "Limitador de apostas";
            this.chkLimitador.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(18)))), ((int)(((byte)(58)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(34)))), ((int)(((byte)(100)))));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F);
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.Image = global::Projeto_POO_e_Estatistica.Properties.Resources.iconfinder_save_3325027;
            this.btnSalvar.Location = new System.Drawing.Point(137, 354);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(250, 35);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(550, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.chkLimitador);
            this.Controls.Add(this.chkMusica);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trbVolume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frConfig";
            this.Text = "frConfig";
            ((System.ComponentModel.ISupportInitialize)(this.trbVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trbVolume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkMusica;
        private System.Windows.Forms.CheckBox chkLimitador;
        private System.Windows.Forms.Button btnSalvar;
    }
}