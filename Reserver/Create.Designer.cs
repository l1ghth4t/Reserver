namespace Reserver
{
    partial class Create
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.stFile = new MetroFramework.Controls.MetroLabel();
            this.stArchive = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "(*.back)|*.back";
            this.saveFileDialog1.Title = "Выберите, куда сохранить бэкап";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(23, 204);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(161, 29);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Начать";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(342, 204);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(161, 29);
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "Отмена";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // stFile
            // 
            this.stFile.AutoSize = true;
            this.stFile.Location = new System.Drawing.Point(23, 70);
            this.stFile.Name = "stFile";
            this.stFile.Size = new System.Drawing.Size(27, 20);
            this.stFile.TabIndex = 6;
            this.stFile.Text = "---";
            this.stFile.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // stArchive
            // 
            this.stArchive.AutoSize = true;
            this.stArchive.Location = new System.Drawing.Point(23, 99);
            this.stArchive.Name = "stArchive";
            this.stArchive.Size = new System.Drawing.Size(27, 20);
            this.stArchive.TabIndex = 7;
            this.stArchive.Text = "---";
            this.stArchive.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 256);
            this.ControlBox = false;
            this.Controls.Add(this.stArchive);
            this.Controls.Add(this.stFile);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Name = "Create";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Создание бэкапа";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel stFile;
        private MetroFramework.Controls.MetroLabel stArchive;
    }
}