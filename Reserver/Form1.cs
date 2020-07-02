/// <summary>
/// Reserver - это утилита для резервного копирования
/// Утилита может создавать резервные копии директорий на компьютере, а также восстанавливать их из резервный копий.
/// Программа создаёт резервные копии в виде архиве с расширением back
/// Главный back-архив содержит внутренние архивы с рандомными названиями и хранящие те папки, которые выбрал пользователь
/// Кроме того, главный архив содержит файл backup.dat, который указывает, какой путь на диске соответствует имени внутреннего архива
/// </summary>

using System;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

/// <summary>
/// Главное пространство имён утилиты
/// </summary>
namespace Reserver
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        /// <summary>
        /// Главная форма утилиты
        /// </summary>
        /// 
        public Form1()
        {
            InitializeComponent();
        }

        /// <value>В данной строке хранится путь, по которому нужно открыть или сохранить резервную копию</value>
        protected static string path = "";

        /// <summary>
        /// Структура, хранящая пару значений: путь к папке - имя внутреннего архива
        /// </summary>
        protected struct BackDir
        {
            /// <summary>
            /// Конструктор структуры BackDir
            /// </summary>
            /// <param name="path">Путь до резервируемой папки на диске</param>
            /// <param name="name">Имя внутреннего архива, который хранит данные этой папки</param>
            public BackDir(string path, string name)
            {
                Path = path;
                Name = name;
            }

            /// <value>Путь до папки на диске</value>
            public string Path { get; set; }

            /// <value>Имя внутреннего архива, хранящего данные этой папки</value>
            public string Name { get; set; }
        }

        /// <summary>
        /// Событие главной формы: загрузка
        /// При загрузке формы устанавливается заголовок Reserver
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Reserser";
        }

        /// <summary>
        /// Кнопка для добавления папки в список
        /// Событие: клик
        /// Действие: запускается диалог выбора папки, выбранная папка добавляется в список
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnListAdd_Click(object sender, EventArgs e)
        {
            try
            {
                folderBrowserDialog1.ShowDialog();
                listFolders.Items.Add(folderBrowserDialog1.SelectedPath);
            }

            catch { }
        }

        /// <summary>
        /// Кнопка для удаления из списка выбранной папки
        /// Событие: клик
        /// Действие: удаление указанного пункта меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //listFolders.SelectedItems.IndexOf(listFolders.); // Не придумал, как это сделать
            }

            catch (Exception)
            {
                MessageBox.Show("Не выбран элемент в списке", "Произошла ошибка");
            }
        }

        /// <summary>
        /// Кнопка для очищения списка
        /// Событие: клик
        /// Действие: удаляет все пункты из списка папок
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            listFolders.Items.Clear();
        }

        /// <summary>
        /// Кнопка для создания резервной копии
        /// Событие: клик
        /// Действие: созданиётся резервная копия указанной папки (или папок) с расширением back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            /*try
            {*/
                Directory.CreateDirectory("tmp");

                string BackData = "";

                for (int i = 0; i < listFolders.Items.Count; i++)
                {
                    string tmp_fn = Path.GetRandomFileName();
                    ZipFile.CreateFromDirectory(Convert.ToString(listFolders.Items[i].Text), "tmp\\" + tmp_fn);
                    BackData += listFolders.Items[i] + ";" + tmp_fn + "\n";
                    this.Text = "Reserving " + listFolders.Items[i] + "as" + tmp_fn;
                }

                File.WriteAllText("tmp\\backup.dat", BackData);

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog1.FileName))
                        File.Delete(saveFileDialog1.FileName);

                    path = saveFileDialog1.FileName;
                }

                else
                {
                    MessageBox.Show("Error saving file");
                    Directory.Delete("tmp", true);
                    return;
                }

                ZipFile.CreateFromDirectory("tmp", path);
                Directory.Delete("tmp", true);
            //}

            /*catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error of creating backup");
                Directory.Delete("tmp", true);
                return;
            }*/
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Кнопка для восстановления данных из бэкапа
        /// Событие: клик
        /// Действие: данные из указанного бэкапа извлекаются и сохраняются на диск по тому пути, по которому они хранились на компьютере
        /// до резервного копирования.
        /// </summary>
        /// 
        /// <remarks>
        /// Если файл, который содержится в бэкапе, уже существует на диске, он будет заменён на тот, что находится в резервной копии.
        /// </remarks>
        /// 
        /// <remarks>
        /// Кроме того, программа отображает время создания, а также последнего изменения и доступа к файлу, по чём можно определить, изменял ли
        /// бэкап кто-то посторонний. Проверка целостности файла на основе подсчёта хэш-суммы будет реализована в следующей версии программы.
        /// </remarks>
        /// 
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecover_Click(object sender, EventArgs e)
        {
            string[] BackData;

            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog1.FileName;
                    this.Text = "Reserver: recovering from [" + path + "]";
                }

                else
                {
                    MessageBox.Show("Error opening file");
                    this.Text = "Reserver: error";
                    return;
                }

                // Здесь добавим полный пробив информации о бэкапе
                //fcreate.Text = Convert.ToString(File.GetCreationTime(path));
                //faccess.Text = Convert.ToString(File.GetLastAccessTime(path));
                //fchange.Text = Convert.ToString(File.GetLastWriteTime(path));
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Text = "Reserver: opening error";
                return;
            }

            string tmp = "tmp\\";

            /*try
            {*/
                if (Directory.Exists(tmp))
                    Directory.Delete(tmp, true);

                using (ZipArchive back = ZipFile.Open(path, ZipArchiveMode.Read))
                {
                    back.ExtractToDirectory(tmp);
                }

                if (File.Exists(tmp + "backup.dat"))
                    BackData = File.ReadAllLines(tmp + "backup.dat");
                else
                    BackData = null;

                BackDir[] BDData = new BackDir[BackData.Length];

                for (int i = 0; i < BackData.Length; i++)
                {
                    BDData[i].Path = BackData[i].Split(';')[0];
                    BDData[i].Name = BackData[i].Split(';')[1];
                }

                BackData = null;

                this.Text = "Reserver: unpacking started, please wait...";

                listFolders.Items.Clear();

                foreach (BackDir dir in BDData)
                {
                    using (ZipArchive back = ZipFile.Open(tmp + dir.Name, ZipArchiveMode.Read))
                    {
                        foreach (ZipArchiveEntry entry in back.Entries)
                        {
                            if (Directory.Exists(dir.Path))
                                Directory.Delete(dir.Path, true);

                            back.ExtractToDirectory(dir.Path);
                        }
                    }

                    this.Text = dir.Name + " as " + dir.Path + "successfully unpacked";
                }

                foreach (BackDir dir in BDData)
                {
                    listFolders.Items.Add(dir.Path);
                }

                BDData = null;

                Directory.Delete(tmp, true);
            //}

            /*catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Text = "Reserver: extracting error";
                Directory.Delete(tmp, true);
                return;
            }*/

            this.Text = "Reserver: all execute";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

        }
    }
}
