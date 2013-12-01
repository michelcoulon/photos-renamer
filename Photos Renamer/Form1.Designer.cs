namespace Photos_Renamer
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.bgWrk = new System.ComponentModel.BackgroundWorker();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.lblSrc = new System.Windows.Forms.Label();
            this.btnSource = new System.Windows.Forms.Button();
            this.btnCible = new System.Windows.Forms.Button();
            this.lblCible = new System.Windows.Forms.Label();
            this.txtCible = new System.Windows.Forms.TextBox();
            this.chkRecurse = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.Photo = new System.Windows.Forms.PictureBox();
            this.pgBar = new System.Windows.Forms.ProgressBar();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtlog = new System.Windows.Forms.TextBox();
            this.lblprogress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // bgWrk
            // 
            this.bgWrk.WorkerReportsProgress = true;
            this.bgWrk.WorkerSupportsCancellation = true;
            this.bgWrk.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWrk_DoWork);
            this.bgWrk.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWrk_ProgressChanged);
            this.bgWrk.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWrk_RunWorkerCompleted);
            // 
            // txtSource
            // 
            this.txtSource.BackColor = System.Drawing.Color.White;
            this.txtSource.Location = new System.Drawing.Point(12, 21);
            this.txtSource.Name = "txtSource";
            this.txtSource.ReadOnly = true;
            this.txtSource.Size = new System.Drawing.Size(174, 20);
            this.txtSource.TabIndex = 0;
            // 
            // lblSrc
            // 
            this.lblSrc.AutoSize = true;
            this.lblSrc.Location = new System.Drawing.Point(9, 5);
            this.lblSrc.Name = "lblSrc";
            this.lblSrc.Size = new System.Drawing.Size(41, 13);
            this.lblSrc.TabIndex = 1;
            this.lblSrc.Text = "Source";
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(187, 21);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(26, 20);
            this.btnSource.TabIndex = 2;
            this.btnSource.Text = "...";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnsrc_Click);
            // 
            // btnCible
            // 
            this.btnCible.Location = new System.Drawing.Point(187, 84);
            this.btnCible.Name = "btnCible";
            this.btnCible.Size = new System.Drawing.Size(26, 20);
            this.btnCible.TabIndex = 5;
            this.btnCible.Text = "...";
            this.btnCible.UseVisualStyleBackColor = true;
            this.btnCible.Click += new System.EventHandler(this.btnCible_Click);
            // 
            // lblCible
            // 
            this.lblCible.AutoSize = true;
            this.lblCible.Location = new System.Drawing.Point(9, 68);
            this.lblCible.Name = "lblCible";
            this.lblCible.Size = new System.Drawing.Size(30, 13);
            this.lblCible.TabIndex = 4;
            this.lblCible.Text = "Cible";
            // 
            // txtCible
            // 
            this.txtCible.BackColor = System.Drawing.Color.White;
            this.txtCible.Location = new System.Drawing.Point(12, 84);
            this.txtCible.Name = "txtCible";
            this.txtCible.ReadOnly = true;
            this.txtCible.Size = new System.Drawing.Size(174, 20);
            this.txtCible.TabIndex = 3;
            // 
            // chkRecurse
            // 
            this.chkRecurse.AutoSize = true;
            this.chkRecurse.Checked = true;
            this.chkRecurse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRecurse.Location = new System.Drawing.Point(139, 47);
            this.chkRecurse.Name = "chkRecurse";
            this.chkRecurse.Size = new System.Drawing.Size(74, 17);
            this.chkRecurse.TabIndex = 6;
            this.chkRecurse.Text = "Recursive";
            this.chkRecurse.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnStart.Location = new System.Drawing.Point(219, 21);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(77, 83);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Photo
            // 
            this.Photo.Location = new System.Drawing.Point(302, 21);
            this.Photo.Name = "Photo";
            this.Photo.Size = new System.Drawing.Size(133, 118);
            this.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Photo.TabIndex = 8;
            this.Photo.TabStop = false;
            // 
            // pgBar
            // 
            this.pgBar.Location = new System.Drawing.Point(12, 145);
            this.pgBar.Name = "pgBar";
            this.pgBar.Size = new System.Drawing.Size(423, 23);
            this.pgBar.TabIndex = 9;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.White;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Red;
            this.btnStop.Location = new System.Drawing.Point(219, 21);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(77, 83);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtlog
            // 
            this.txtlog.BackColor = System.Drawing.Color.White;
            this.txtlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlog.Location = new System.Drawing.Point(12, 174);
            this.txtlog.Multiline = true;
            this.txtlog.Name = "txtlog";
            this.txtlog.ReadOnly = true;
            this.txtlog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtlog.Size = new System.Drawing.Size(423, 275);
            this.txtlog.TabIndex = 11;
            // 
            // lblprogress
            // 
            this.lblprogress.AutoSize = true;
            this.lblprogress.Location = new System.Drawing.Point(12, 126);
            this.lblprogress.Name = "lblprogress";
            this.lblprogress.Size = new System.Drawing.Size(0, 13);
            this.lblprogress.TabIndex = 12;
            this.lblprogress.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 462);
            this.Controls.Add(this.lblprogress);
            this.Controls.Add(this.txtlog);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.pgBar);
            this.Controls.Add(this.Photo);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.chkRecurse);
            this.Controls.Add(this.btnCible);
            this.Controls.Add(this.lblCible);
            this.Controls.Add(this.txtCible);
            this.Controls.Add(this.btnSource);
            this.Controls.Add(this.lblSrc);
            this.Controls.Add(this.txtSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgWrk;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label lblSrc;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.Button btnCible;
        private System.Windows.Forms.Label lblCible;
        private System.Windows.Forms.TextBox txtCible;
        private System.Windows.Forms.CheckBox chkRecurse;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox Photo;
        private System.Windows.Forms.ProgressBar pgBar;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtlog;
        private System.Windows.Forms.Label lblprogress;
    }
}

