using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using System.Threading;

namespace Reserver
{
    public partial class Create : MetroFramework.Forms.MetroForm
    {
        private string path;
        private string[] listFolders;
        private string BackData = "";


        public Create(string[] inp_list_folds)
        {
            InitializeComponent();
            listFolders = inp_list_folds;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog1.FileName))
                        File.Delete(saveFileDialog1.FileName);

                    path = saveFileDialog1.FileName;
                }

                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Error saving file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Directory.Delete("tmp", true);
                    this.Close();
                    return;
                }

                Directory.CreateDirectory("tmp");

                for (int i = 0; i < listFolders.Length; i++)
                {
                    string tmp_fn = Path.GetRandomFileName();
                    BackData += listFolders[i] + ";" + tmp_fn + "\n";
                    stFile.Text = "Reserving " + listFolders[i];
                    stArchive.Text = "As" + tmp_fn;
                    //.Value = (int)(((double)i / (double)listFolders.Length) * 100.0);
                    ZipFile.CreateFromDirectory(Convert.ToString(listFolders[i]), "tmp\\" + tmp_fn);
                }

                File.WriteAllText("tmp\\backup.dat", BackData);
                ZipFile.CreateFromDirectory("tmp", path);
                Directory.Delete("tmp", true);
            }

            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Error of creating backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Directory.Delete("tmp", true);
                this.Close();
                return;
            }

            MetroFramework.MetroMessageBox.Show(this, "Создание резервной копии", "Создание успешно завершено", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            return;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
