
namespace Projeto_POO_e_Estatistica
{
    partial class frMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frMain));
            this.lblInformacoes = new System.Windows.Forms.Label();
            this.pnlSideMenu = new System.Windows.Forms.Panel();
            this.wmpTocadorPrincipal = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnAbrirConfiguracoes = new System.Windows.Forms.Button();
            this.btnAbrirCacaNiquel = new System.Windows.Forms.Button();
            this.btnTelaDoCassino = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMainForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpTocadorPrincipal)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlMainForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInformacoes
            // 
            this.lblInformacoes.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacoes.ForeColor = System.Drawing.Color.White;
            this.lblInformacoes.Location = new System.Drawing.Point(0, 30);
            this.lblInformacoes.Name = "lblInformacoes";
            this.lblInformacoes.Size = new System.Drawing.Size(250, 18);
            this.lblInformacoes.TabIndex = 8;
            this.lblInformacoes.Text = "Olá, ";
            this.lblInformacoes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSideMenu
            // 
            this.pnlSideMenu.AutoScroll = true;
            this.pnlSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            this.pnlSideMenu.Controls.Add(this.wmpTocadorPrincipal);
            this.pnlSideMenu.Controls.Add(this.btnSobre);
            this.pnlSideMenu.Controls.Add(this.btnAbrirConfiguracoes);
            this.pnlSideMenu.Controls.Add(this.btnAbrirCacaNiquel);
            this.pnlSideMenu.Controls.Add(this.btnTelaDoCassino);
            this.pnlSideMenu.Controls.Add(this.panel1);
            this.pnlSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlSideMenu.Name = "pnlSideMenu";
            this.pnlSideMenu.Size = new System.Drawing.Size(250, 450);
            this.pnlSideMenu.TabIndex = 13;
            // 
            // wmpTocadorPrincipal
            // 
            this.wmpTocadorPrincipal.Enabled = true;
            this.wmpTocadorPrincipal.Location = new System.Drawing.Point(27, 270);
            this.wmpTocadorPrincipal.Name = "wmpTocadorPrincipal";
            this.wmpTocadorPrincipal.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpTocadorPrincipal.OcxState")));
            this.wmpTocadorPrincipal.Size = new System.Drawing.Size(193, 141);
            this.wmpTocadorPrincipal.TabIndex = 1;
            this.wmpTocadorPrincipal.Visible = false;
            // 
            // btnSobre
            // 
            this.btnSobre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(18)))), ((int)(((byte)(58)))));
            this.btnSobre.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSobre.FlatAppearance.BorderSize = 0;
            this.btnSobre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(34)))), ((int)(((byte)(100)))));
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobre.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F);
            this.btnSobre.ForeColor = System.Drawing.Color.White;
            this.btnSobre.Image = global::Projeto_POO_e_Estatistica.Properties.Resources.iconfinder_icon_ios7_information_outline_211761;
            this.btnSobre.Location = new System.Drawing.Point(0, 180);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(250, 35);
            this.btnSobre.TabIndex = 19;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSobre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSobre.UseVisualStyleBackColor = false;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnAbrirConfiguracoes
            // 
            this.btnAbrirConfiguracoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(18)))), ((int)(((byte)(58)))));
            this.btnAbrirConfiguracoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbrirConfiguracoes.FlatAppearance.BorderSize = 0;
            this.btnAbrirConfiguracoes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(34)))), ((int)(((byte)(100)))));
            this.btnAbrirConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirConfiguracoes.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F);
            this.btnAbrirConfiguracoes.ForeColor = System.Drawing.Color.White;
            this.btnAbrirConfiguracoes.Image = global::Projeto_POO_e_Estatistica.Properties.Resources.iconfinder_gear_innovation_process_setting_engine_3209343;
            this.btnAbrirConfiguracoes.Location = new System.Drawing.Point(0, 145);
            this.btnAbrirConfiguracoes.Name = "btnAbrirConfiguracoes";
            this.btnAbrirConfiguracoes.Size = new System.Drawing.Size(250, 35);
            this.btnAbrirConfiguracoes.TabIndex = 18;
            this.btnAbrirConfiguracoes.Text = "Configuração";
            this.btnAbrirConfiguracoes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrirConfiguracoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbrirConfiguracoes.UseVisualStyleBackColor = false;
            this.btnAbrirConfiguracoes.Click += new System.EventHandler(this.btnAbrirConfiguracoes_Click);
            // 
            // btnAbrirCacaNiquel
            // 
            this.btnAbrirCacaNiquel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(18)))), ((int)(((byte)(58)))));
            this.btnAbrirCacaNiquel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbrirCacaNiquel.FlatAppearance.BorderSize = 0;
            this.btnAbrirCacaNiquel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(34)))), ((int)(((byte)(100)))));
            this.btnAbrirCacaNiquel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirCacaNiquel.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F);
            this.btnAbrirCacaNiquel.ForeColor = System.Drawing.Color.White;
            this.btnAbrirCacaNiquel.Image = global::Projeto_POO_e_Estatistica.Properties.Resources.iconfinder_Videogames_casino_seven_lucky_slot_machine_6646232;
            this.btnAbrirCacaNiquel.Location = new System.Drawing.Point(0, 110);
            this.btnAbrirCacaNiquel.Name = "btnAbrirCacaNiquel";
            this.btnAbrirCacaNiquel.Size = new System.Drawing.Size(250, 35);
            this.btnAbrirCacaNiquel.TabIndex = 17;
            this.btnAbrirCacaNiquel.Text = "Caça Niquel";
            this.btnAbrirCacaNiquel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrirCacaNiquel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbrirCacaNiquel.UseVisualStyleBackColor = false;
            this.btnAbrirCacaNiquel.Click += new System.EventHandler(this.btnAbrirCacaNiquel_Click);
            // 
            // btnTelaDoCassino
            // 
            this.btnTelaDoCassino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(18)))), ((int)(((byte)(58)))));
            this.btnTelaDoCassino.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTelaDoCassino.FlatAppearance.BorderSize = 0;
            this.btnTelaDoCassino.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(34)))), ((int)(((byte)(100)))));
            this.btnTelaDoCassino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelaDoCassino.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F);
            this.btnTelaDoCassino.ForeColor = System.Drawing.Color.White;
            this.btnTelaDoCassino.Image = global::Projeto_POO_e_Estatistica.Properties.Resources.iconfinder_home_2561449__1____Copia;
            this.btnTelaDoCassino.Location = new System.Drawing.Point(0, 75);
            this.btnTelaDoCassino.Name = "btnTelaDoCassino";
            this.btnTelaDoCassino.Size = new System.Drawing.Size(250, 35);
            this.btnTelaDoCassino.TabIndex = 14;
            this.btnTelaDoCassino.Text = "Voltar a Tela Principal";
            this.btnTelaDoCassino.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTelaDoCassino.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTelaDoCassino.UseVisualStyleBackColor = false;
            this.btnTelaDoCassino.Click += new System.EventHandler(this.btnTelaDoCassino_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblInformacoes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 75);
            this.panel1.TabIndex = 14;
            // 
            // pnlMainForm
            // 
            this.pnlMainForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(33)))), ((int)(((byte)(101)))));
            this.pnlMainForm.Controls.Add(this.pictureBox1);
            this.pnlMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainForm.Location = new System.Drawing.Point(250, 0);
            this.pnlMainForm.Name = "pnlMainForm";
            this.pnlMainForm.Size = new System.Drawing.Size(550, 450);
            this.pnlMainForm.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Projeto_POO_e_Estatistica.Properties.Resources.CaçaNiquelCompleto;
            this.pictureBox1.Location = new System.Drawing.Point(97, -38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 585);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMainForm);
            this.Controls.Add(this.pnlSideMenu);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(750, 450);
            this.Name = "frMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Caça Niquel Mágico";
            this.pnlSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmpTocadorPrincipal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlMainForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblInformacoes;
        private System.Windows.Forms.Panel pnlSideMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTelaDoCassino;
        private System.Windows.Forms.Panel pnlMainForm;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Button btnAbrirConfiguracoes;
        private System.Windows.Forms.Button btnAbrirCacaNiquel;
        private System.Windows.Forms.PictureBox pictureBox1;
        public AxWMPLib.AxWindowsMediaPlayer wmpTocadorPrincipal;
    }
}

