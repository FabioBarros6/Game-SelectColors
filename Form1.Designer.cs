namespace Joguinho
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoJogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbAzul = new System.Windows.Forms.PictureBox();
            this.pbVerde = new System.Windows.Forms.PictureBox();
            this.pbVermelho = new System.Windows.Forms.PictureBox();
            this.pbAmarelo = new System.Windows.Forms.PictureBox();
            this.lblPontos = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAzul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVermelho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAmarelo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(334, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoJogoToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.Opcoes);
            // 
            // novoJogoToolStripMenuItem
            // 
            this.novoJogoToolStripMenuItem.Name = "novoJogoToolStripMenuItem";
            this.novoJogoToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.novoJogoToolStripMenuItem.Text = "Novo Jogo";
            this.novoJogoToolStripMenuItem.Click += new System.EventHandler(this.Opcoes);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.Opcoes);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.Opcoes);
            // 
            // pbAzul
            // 
            this.pbAzul.BackColor = System.Drawing.Color.MediumBlue;
            this.pbAzul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAzul.Location = new System.Drawing.Point(64, 60);
            this.pbAzul.Name = "pbAzul";
            this.pbAzul.Size = new System.Drawing.Size(100, 91);
            this.pbAzul.TabIndex = 1;
            this.pbAzul.TabStop = false;
            this.pbAzul.Tag = "Azul";
            this.pbAzul.Click += new System.EventHandler(this.Clique);
            // 
            // pbVerde
            // 
            this.pbVerde.BackColor = System.Drawing.Color.DarkGreen;
            this.pbVerde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbVerde.Location = new System.Drawing.Point(179, 60);
            this.pbVerde.Name = "pbVerde";
            this.pbVerde.Size = new System.Drawing.Size(100, 91);
            this.pbVerde.TabIndex = 2;
            this.pbVerde.TabStop = false;
            this.pbVerde.Tag = "Verde";
            this.pbVerde.Click += new System.EventHandler(this.Clique);
            // 
            // pbVermelho
            // 
            this.pbVermelho.BackColor = System.Drawing.Color.DarkRed;
            this.pbVermelho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbVermelho.Location = new System.Drawing.Point(64, 171);
            this.pbVermelho.Name = "pbVermelho";
            this.pbVermelho.Size = new System.Drawing.Size(100, 91);
            this.pbVermelho.TabIndex = 3;
            this.pbVermelho.TabStop = false;
            this.pbVermelho.Tag = "Vermelho";
            this.pbVermelho.Click += new System.EventHandler(this.Clique);
            // 
            // pbAmarelo
            // 
            this.pbAmarelo.BackColor = System.Drawing.Color.Gold;
            this.pbAmarelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAmarelo.Location = new System.Drawing.Point(179, 171);
            this.pbAmarelo.Name = "pbAmarelo";
            this.pbAmarelo.Size = new System.Drawing.Size(100, 91);
            this.pbAmarelo.TabIndex = 4;
            this.pbAmarelo.TabStop = false;
            this.pbAmarelo.Tag = "Amarelo";
            this.pbAmarelo.Click += new System.EventHandler(this.Clique);
            // 
            // lblPontos
            // 
            this.lblPontos.AutoSize = true;
            this.lblPontos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontos.ForeColor = System.Drawing.Color.White;
            this.lblPontos.Location = new System.Drawing.Point(58, 308);
            this.lblPontos.Name = "lblPontos";
            this.lblPontos.Size = new System.Drawing.Size(92, 26);
            this.lblPontos.TabIndex = 5;
            this.lblPontos.Text = "Pontos: ";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.ControlBox = false;
            this.Controls.Add(this.lblPontos);
            this.Controls.Add(this.pbAmarelo);
            this.Controls.Add(this.pbVermelho);
            this.Controls.Add(this.pbVerde);
            this.Controls.Add(this.pbAzul);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Colors";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAzul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVermelho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAmarelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pbAzul;
        private System.Windows.Forms.PictureBox pbVerde;
        private System.Windows.Forms.PictureBox pbVermelho;
        private System.Windows.Forms.PictureBox pbAmarelo;
        private System.Windows.Forms.Label lblPontos;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoJogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

