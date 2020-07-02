namespace Reserver
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listFolders = new MetroFramework.Controls.MetroListView();
            this.btnListAdd = new MetroFramework.Controls.MetroTile();
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.btnClear = new MetroFramework.Controls.MetroTile();
            this.btnCheck = new MetroFramework.Controls.MetroTile();
            this.btnCreate = new MetroFramework.Controls.MetroTile();
            this.btnRecover = new MetroFramework.Controls.MetroTile();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.metroProgressBar2 = new MetroFramework.Controls.MetroProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Choose a folder to backup";
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "(*.back)|*.back";
            this.openFileDialog1.Title = "Выберите файл бэкапа";
            // 
            // listFolders
            // 
            this.listFolders.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listFolders.FullRowSelect = true;
            this.listFolders.Location = new System.Drawing.Point(314, 106);
            this.listFolders.MultiSelect = false;
            this.listFolders.Name = "listFolders";
            this.listFolders.OwnerDraw = true;
            this.listFolders.Size = new System.Drawing.Size(284, 250);
            this.listFolders.Style = MetroFramework.MetroColorStyle.Teal;
            this.listFolders.TabIndex = 0;
            this.listFolders.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.listFolders.UseCompatibleStateImageBehavior = false;
            this.listFolders.UseSelectable = true;
            this.listFolders.View = System.Windows.Forms.View.List;
            // 
            // btnListAdd
            // 
            this.btnListAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnListAdd.ActiveControl = null;
            this.btnListAdd.Location = new System.Drawing.Point(169, 83);
            this.btnListAdd.Name = "btnListAdd";
            this.btnListAdd.Size = new System.Drawing.Size(139, 87);
            this.btnListAdd.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnListAdd.TabIndex = 1;
            this.btnListAdd.Text = "Добавить";
            this.btnListAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnListAdd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnListAdd.UseSelectable = true;
            this.btnListAdd.Click += new System.EventHandler(this.btnListAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnDelete.ActiveControl = null;
            this.btnDelete.Location = new System.Drawing.Point(169, 176);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 87);
            this.btnDelete.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnClear.ActiveControl = null;
            this.btnClear.Location = new System.Drawing.Point(169, 269);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(139, 87);
            this.btnClear.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Очистить";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnCheck.ActiveControl = null;
            this.btnCheck.Location = new System.Drawing.Point(23, 269);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(139, 87);
            this.btnCheck.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Проверить\r\nбэкап";
            this.btnCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCheck.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCheck.UseSelectable = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnCreate.ActiveControl = null;
            this.btnCreate.Location = new System.Drawing.Point(23, 83);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(139, 87);
            this.btnCreate.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Создать\r\nбэкап";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCreate.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnCreate.UseSelectable = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnRecover
            // 
            this.btnRecover.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnRecover.ActiveControl = null;
            this.btnRecover.Location = new System.Drawing.Point(23, 176);
            this.btnRecover.Name = "btnRecover";
            this.btnRecover.Size = new System.Drawing.Size(139, 87);
            this.btnRecover.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnRecover.TabIndex = 9;
            this.btnRecover.Text = "Восстановить\r\nданные";
            this.btnRecover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRecover.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRecover.UseSelectable = true;
            this.btnRecover.Click += new System.EventHandler(this.btnRecover_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(314, 83);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 20);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Папки:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "(*.back)|*.back";
            this.saveFileDialog1.Title = "Выберите, куда сохранить бэкап";
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Location = new System.Drawing.Point(23, 365);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(575, 23);
            this.metroProgressBar1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroProgressBar1.TabIndex = 11;
            this.metroProgressBar1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroProgressBar2
            // 
            this.metroProgressBar2.Location = new System.Drawing.Point(23, 394);
            this.metroProgressBar2.Name = "metroProgressBar2";
            this.metroProgressBar2.Size = new System.Drawing.Size(575, 23);
            this.metroProgressBar2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroProgressBar2.TabIndex = 12;
            this.metroProgressBar2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 440);
            this.Controls.Add(this.metroProgressBar2);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnRecover);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnListAdd);
            this.Controls.Add(this.listFolders);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Reserver";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroListView listFolders;
        private MetroFramework.Controls.MetroTile btnListAdd;
        private MetroFramework.Controls.MetroTile btnDelete;
        private MetroFramework.Controls.MetroTile btnClear;
        private MetroFramework.Controls.MetroTile btnCheck;
        private MetroFramework.Controls.MetroTile btnCreate;
        private MetroFramework.Controls.MetroTile btnRecover;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar2;
    }
}

