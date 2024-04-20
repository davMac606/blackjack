namespace blackjack
{
    partial class Tela
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela));
            this.label1 = new System.Windows.Forms.Label();
            this.btnHit = new System.Windows.Forms.Button();
            this.btnStand = new System.Windows.Forms.Button();
            this.pbCard = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.pbCard2 = new System.Windows.Forms.PictureBox();
            this.pnlCardsPl = new System.Windows.Forms.Panel();
            this.pbCard4 = new System.Windows.Forms.PictureBox();
            this.lblScoreE = new System.Windows.Forms.Label();
            this.pbCard3 = new System.Windows.Forms.PictureBox();
            this.pnlCardsE = new System.Windows.Forms.Panel();
            this.tmrDisplay = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard2)).BeginInit();
            this.pnlCardsPl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard3)).BeginInit();
            this.pnlCardsE.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 545);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btnHit
            // 
            this.btnHit.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHit.Location = new System.Drawing.Point(807, 334);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(220, 70);
            this.btnHit.TabIndex = 2;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStand.Location = new System.Drawing.Point(807, 410);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(220, 70);
            this.btnStand.TabIndex = 4;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
            // 
            // pbCard
            // 
            this.pbCard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCard.BackgroundImage")));
            this.pbCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCard.Location = new System.Drawing.Point(3, 48);
            this.pbCard.Name = "pbCard";
            this.pbCard.Size = new System.Drawing.Size(69, 105);
            this.pbCard.TabIndex = 5;
            this.pbCard.TabStop = false;
            this.pbCard.Click += new System.EventHandler(this.pbCard_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(807, 310);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(52, 21);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "label2";
            // 
            // pbCard2
            // 
            this.pbCard2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCard2.BackgroundImage")));
            this.pbCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCard2.Location = new System.Drawing.Point(78, 48);
            this.pbCard2.Name = "pbCard2";
            this.pbCard2.Size = new System.Drawing.Size(69, 105);
            this.pbCard2.TabIndex = 7;
            this.pbCard2.TabStop = false;
            // 
            // pnlCardsPl
            // 
            this.pnlCardsPl.Controls.Add(this.pbCard);
            this.pnlCardsPl.Controls.Add(this.pbCard2);
            this.pnlCardsPl.Location = new System.Drawing.Point(3, 334);
            this.pnlCardsPl.Name = "pnlCardsPl";
            this.pnlCardsPl.Size = new System.Drawing.Size(798, 156);
            this.pnlCardsPl.TabIndex = 8;
            // 
            // pbCard4
            // 
            this.pbCard4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCard4.BackgroundImage")));
            this.pbCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCard4.Location = new System.Drawing.Point(78, 3);
            this.pbCard4.Name = "pbCard4";
            this.pbCard4.Size = new System.Drawing.Size(69, 105);
            this.pbCard4.TabIndex = 9;
            this.pbCard4.TabStop = false;
            // 
            // lblScoreE
            // 
            this.lblScoreE.AutoSize = true;
            this.lblScoreE.Location = new System.Drawing.Point(807, 12);
            this.lblScoreE.Name = "lblScoreE";
            this.lblScoreE.Size = new System.Drawing.Size(52, 21);
            this.lblScoreE.TabIndex = 9;
            this.lblScoreE.Text = "label2";
            // 
            // pbCard3
            // 
            this.pbCard3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCard3.BackgroundImage")));
            this.pbCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbCard3.Location = new System.Drawing.Point(3, 3);
            this.pbCard3.Name = "pbCard3";
            this.pbCard3.Size = new System.Drawing.Size(69, 105);
            this.pbCard3.TabIndex = 8;
            this.pbCard3.TabStop = false;
            // 
            // pnlCardsE
            // 
            this.pnlCardsE.Controls.Add(this.pbCard3);
            this.pnlCardsE.Controls.Add(this.pbCard4);
            this.pnlCardsE.Location = new System.Drawing.Point(3, 1);
            this.pnlCardsE.Name = "pnlCardsE";
            this.pnlCardsE.Size = new System.Drawing.Size(798, 156);
            this.pnlCardsE.TabIndex = 10;
            // 
            // Tela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1039, 492);
            this.Controls.Add(this.pnlCardsE);
            this.Controls.Add(this.lblScoreE);
            this.Controls.Add(this.pnlCardsPl);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnStand);
            this.Controls.Add(this.btnHit);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Tela";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Tela_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard2)).EndInit();
            this.pnlCardsPl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard3)).EndInit();
            this.pnlCardsE.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHit;
        private System.Windows.Forms.Button btnStand;
        private System.Windows.Forms.PictureBox pbCard;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox pbCard2;
        private System.Windows.Forms.Panel pnlCardsPl;
        private System.Windows.Forms.PictureBox pbCard4;
        private System.Windows.Forms.Label lblScoreE;
        private System.Windows.Forms.PictureBox pbCard3;
        private System.Windows.Forms.Panel pnlCardsE;
        private System.Windows.Forms.Timer tmrDisplay;
    }
}

