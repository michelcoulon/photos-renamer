using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Photos_Renamer
{
    public partial class frmMain : Form
    {
        List<string> valStrings = new List<string>();
        bool annulation = false;
        int erreur = 0;
        int reussite = 0;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = Application.ProductName;
            this.Icon = icon.photo_renamer;
            Photo.Image = icon.logo;
        }

        private void btnsrc_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderChoice = new FolderBrowserDialog();
            DialogResult result = FolderChoice.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtSource.Text = FolderChoice.SelectedPath;
                string dossiersource = FolderChoice.SelectedPath;
                foreach (string f in Directory.GetFiles(dossiersource, "*.jpg", SearchOption.AllDirectories))
                {
                    valStrings.Add(f);
                }
            }
        }

        private void btnCible_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FolderChoice = new FolderBrowserDialog();
            DialogResult result = FolderChoice.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtCible.Text = FolderChoice.SelectedPath;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtSource.Text) && Directory.Exists(txtCible.Text))
            {
                valStrings.Clear();
                chkRecurse.Enabled = false;
                btnCible.Enabled = false;
                btnSource.Enabled = false;
                txtCible.Enabled = false;
                txtSource.Enabled = false;
                btnStart.Visible = false;
                btnStop.Visible = true;
                lblprogress.Visible = true;
                foreach (string f in Directory.GetFiles(txtSource.Text, "*.jpg", SearchOption.AllDirectories))
                {
                    valStrings.Add(f);
                }
                pgBar.Maximum = valStrings.Count;
                bgWrk.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("Veuillez indiquer des chemins existants...", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bgWrk_DoWork(object sender, DoWorkEventArgs e)
        {
            erreur = 0;
            reussite = 0;
            int i=0;
            if (chkRecurse.Checked)
            {
                string Source = txtSource.Text;
                string Cible = txtCible.Text;
                string[] FilesInFolder = Directory.GetFiles(Source, "*.jpg", SearchOption.AllDirectories);
                if (!Directory.Exists(Cible))
                {
                    Directory.CreateDirectory(Cible);
                }
                foreach (string file in FilesInFolder)
                {
                    PropertyItem test = null;
                    string date = "";
                    string fileName = "";
                    DateTime dateCreated;
                    FileInfo f = new FileInfo(file);
                    bgWrk.ReportProgress(i);
                    i += 1;
                    try
                    {
                        Bitmap image = new Bitmap(f.FullName);
                        test = image.GetPropertyItem(0x132);
                        System.Text.ASCIIEncoding a = new ASCIIEncoding();
                        date = a.GetString(test.Value, 0, test.Len - 1);
                        System.Globalization.CultureInfo provider = CultureInfo.InvariantCulture;
                        dateCreated = DateTime.ParseExact(date, "yyyy:MM:d H:m:s", provider);
                        fileName = dateCreated.ToString("yyyy-MM-dd-Hms");
                        Photo.Load(f.FullName);
                    }
                    catch (Exception err)
                    {
                        erreur += 1;
                        lblprogress.Invoke((MethodInvoker)delegate { lblprogress.Text = reussite + " copie(s) réussie(s) | " + erreur + " erreur(s)"; });
                        txtlog.Invoke((MethodInvoker)delegate { txtlog.AppendText("[" + f.FullName + "] " + err.Message + "\r\n"); });
                    }
                    finally
                    {
                        if (test != null && fileName.Length != 0)
                        {
                            File.Copy(f.FullName, Cible + @"\" + fileName + ".jpg", true);
                            if (File.Exists(Cible + @"\" + fileName + ".jpg"))
                            {
                                reussite += 1;
                                lblprogress.Invoke((MethodInvoker)delegate { lblprogress.Text = reussite + " copie(s) réussie(s) | " + erreur + " erreur(s)"; });
                            }
                            txtlog.Invoke((MethodInvoker)delegate { txtlog.AppendText("[" + f.FullName + "] Copie réussie\r\n"); });
                        }
                    }
                    if (bgWrk.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
                }
            }
            else
            {
                string Source = txtSource.Text;
                string Cible = txtCible.Text;
                string[] FilesInFolder = Directory.GetFiles(Source, "*.jpg", SearchOption.TopDirectoryOnly);
                if (!Directory.Exists(Cible))
                {
                    Directory.CreateDirectory(Cible);
                }
                foreach (string file in FilesInFolder)
                {
                    PropertyItem test = null;
                    string date = "";
                    string fileName = "";
                    DateTime dateCreated;
                    FileInfo f = new FileInfo(file);
                    bgWrk.ReportProgress(i);
                    i += 1;
                    try
                    {
                        Bitmap image = new Bitmap(f.FullName);
                        test = image.GetPropertyItem(0x132);
                        System.Text.ASCIIEncoding a = new ASCIIEncoding();
                        date = a.GetString(test.Value, 0, test.Len - 1);
                        System.Globalization.CultureInfo provider = CultureInfo.InvariantCulture;
                        dateCreated = DateTime.ParseExact(date, "yyyy:MM:d H:m:s", provider);
                        fileName = dateCreated.ToString("yyyy-MM-dd-Hms");
                        Photo.Load(f.FullName);
                    }
                    catch (Exception err)
                    {
                        erreur += 1;
                        lblprogress.Invoke((MethodInvoker)delegate { lblprogress.Text = reussite + " copie(s) réussie(s) | " + erreur + " erreur(s)"; });
                        txtlog.Invoke((MethodInvoker)delegate { txtlog.AppendText("[" + f.FullName + "] " + err.Message + "\r\n"); });
                    }
                    finally
                    {
                        if (test != null && fileName.Length != 0)
                        {
                            File.Copy(f.FullName, Cible + @"\" + fileName + ".jpg", true);
                            if (File.Exists(Cible + @"\" + fileName + ".jpg"))
                            {
                                reussite += 1;
                                lblprogress.Invoke((MethodInvoker)delegate { lblprogress.Text = reussite + " copie(s) réussie(s) | " + erreur + " erreur(s)"; });
                            }
                            txtlog.Invoke((MethodInvoker)delegate { txtlog.AppendText("[" + f.FullName + "] Copie réussie\r\n"); });
                        }
                    }
                    if (bgWrk.CancellationPending)
                    {
                        e.Cancel = true;
                        return;
                    }
                }
            }
        }

        private void bgWrk_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgBar.Value = e.ProgressPercentage;
        }

        private void bgWrk_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Photo.Image = icon.logo;
            if (annulation)
            {
                MessageBox.Show("Opération annulée par l'utilisateur.\r\n\r\n" + reussite + " copie(s) réussie(s)\r\n" + erreur + " erreur(s)", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Opération terminée!\r\n\r\n" + reussite + " copie(s) réussie(s)\r\n" + erreur + " erreur(s)", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnCible.Enabled = true;
            btnSource.Enabled = true;
            txtCible.Enabled = true;
            txtSource.Enabled = true;
            btnStart.Visible = true;
            chkRecurse.Enabled = true;
            btnStop.Visible = false;
            lblprogress.Visible = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            annulation = true;
            bgWrk.CancelAsync();
        }
    }
}
