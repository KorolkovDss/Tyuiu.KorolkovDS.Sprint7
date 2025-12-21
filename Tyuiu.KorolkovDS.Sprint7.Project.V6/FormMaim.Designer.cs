namespace Tyuiu.KorolkovDS.Sprint7.Project.V6
{
    partial class FormMain_KDS
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelDataPatient_KDS = new Panel();
            groupBoxDoctor_KDS = new GroupBox();
            buttonChange_KDS = new Button();
            buttonDelete_KDS = new Button();
            buttonSave_KDS = new Button();
            groupBoxNote_KDS = new GroupBox();
            textBoxNote_KDS = new TextBox();
            groupBoxDispY_KDS = new GroupBox();
            checkBoxDispY_KDS = new CheckBox();
            groupBoxBolList_KDS = new GroupBox();
            textBoxBolList_KDS = new TextBox();
            groupBoxAmbHeal_KDS = new GroupBox();
            checkBoxAmbHeal_KDS = new CheckBox();
            groupBoxDiagnoz_KDS = new GroupBox();
            textBoxDiagnoz_KDS = new TextBox();
            groupBoxSpec_KDS = new GroupBox();
            textBoxSpec_KDS = new TextBox();
            groupBoxFIO_KDS = new GroupBox();
            textBoxFIO_KDS = new TextBox();
            groupBoxDataPatient_KDS = new GroupBox();
            groupBoxBDay_KDS = new GroupBox();
            textBoxBDay_KDS = new TextBox();
            groupBoxOtschestvo__KDS = new GroupBox();
            textBoxOtchestvo_KDS = new TextBox();
            groupBoxName_KDS = new GroupBox();
            textBoxName_KDS = new TextBox();
            groupBoxSurName = new GroupBox();
            textBoxSurname_KDS = new TextBox();
            panelPatient_KDS = new Panel();
            dataGridView1 = new DataGridView();
            ColumnSurname = new DataGridViewTextBoxColumn();
            ColumnName = new DataGridViewTextBoxColumn();
            ColumnOtchestvo = new DataGridViewTextBoxColumn();
            ColumnBDay = new DataGridViewTextBoxColumn();
            ColumnFIO = new DataGridViewTextBoxColumn();
            ColumnSpec = new DataGridViewTextBoxColumn();
            ColumnDiagnoz = new DataGridViewTextBoxColumn();
            ColumnBolList = new DataGridViewTextBoxColumn();
            ColumnNote = new DataGridViewTextBoxColumn();
            panelINF_KDS = new Panel();
            chartINF_KDS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelWorkFile_KDS = new Panel();
            groupBoxWorkWFile_KDS = new GroupBox();
            buttonSaveFile_KDS = new Button();
            buttonOpenFile_KDS = new Button();
            panelDataPatient_KDS.SuspendLayout();
            groupBoxDoctor_KDS.SuspendLayout();
            groupBoxNote_KDS.SuspendLayout();
            groupBoxDispY_KDS.SuspendLayout();
            groupBoxBolList_KDS.SuspendLayout();
            groupBoxAmbHeal_KDS.SuspendLayout();
            groupBoxDiagnoz_KDS.SuspendLayout();
            groupBoxSpec_KDS.SuspendLayout();
            groupBoxFIO_KDS.SuspendLayout();
            groupBoxDataPatient_KDS.SuspendLayout();
            groupBoxBDay_KDS.SuspendLayout();
            groupBoxOtschestvo__KDS.SuspendLayout();
            groupBoxName_KDS.SuspendLayout();
            groupBoxSurName.SuspendLayout();
            panelPatient_KDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelINF_KDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartINF_KDS).BeginInit();
            panelWorkFile_KDS.SuspendLayout();
            groupBoxWorkWFile_KDS.SuspendLayout();
            SuspendLayout();
            // 
            // panelDataPatient_KDS
            // 
            panelDataPatient_KDS.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelDataPatient_KDS.Controls.Add(groupBoxDoctor_KDS);
            panelDataPatient_KDS.Controls.Add(groupBoxDataPatient_KDS);
            panelDataPatient_KDS.Dock = DockStyle.Left;
            panelDataPatient_KDS.Location = new Point(0, 0);
            panelDataPatient_KDS.Name = "panelDataPatient_KDS";
            panelDataPatient_KDS.Size = new Size(266, 635);
            panelDataPatient_KDS.TabIndex = 0;
            // 
            // groupBoxDoctor_KDS
            // 
            groupBoxDoctor_KDS.Controls.Add(buttonChange_KDS);
            groupBoxDoctor_KDS.Controls.Add(buttonDelete_KDS);
            groupBoxDoctor_KDS.Controls.Add(buttonSave_KDS);
            groupBoxDoctor_KDS.Controls.Add(groupBoxNote_KDS);
            groupBoxDoctor_KDS.Controls.Add(groupBoxDispY_KDS);
            groupBoxDoctor_KDS.Controls.Add(groupBoxBolList_KDS);
            groupBoxDoctor_KDS.Controls.Add(groupBoxAmbHeal_KDS);
            groupBoxDoctor_KDS.Controls.Add(groupBoxDiagnoz_KDS);
            groupBoxDoctor_KDS.Controls.Add(groupBoxSpec_KDS);
            groupBoxDoctor_KDS.Controls.Add(groupBoxFIO_KDS);
            groupBoxDoctor_KDS.Dock = DockStyle.Top;
            groupBoxDoctor_KDS.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxDoctor_KDS.Location = new Point(0, 193);
            groupBoxDoctor_KDS.Name = "groupBoxDoctor_KDS";
            groupBoxDoctor_KDS.Size = new Size(266, 442);
            groupBoxDoctor_KDS.TabIndex = 1;
            groupBoxDoctor_KDS.TabStop = false;
            groupBoxDoctor_KDS.Text = "Врач:";
            // 
            // buttonChange_KDS
            // 
            buttonChange_KDS.Location = new Point(6, 379);
            buttonChange_KDS.Name = "buttonChange_KDS";
            buttonChange_KDS.Size = new Size(122, 51);
            buttonChange_KDS.TabIndex = 9;
            buttonChange_KDS.Text = "Изменить";
            buttonChange_KDS.UseVisualStyleBackColor = true;
            buttonChange_KDS.Click += buttonChange_KDS_Click;
            // 
            // buttonDelete_KDS
            // 
            buttonDelete_KDS.Location = new Point(134, 320);
            buttonDelete_KDS.Name = "buttonDelete_KDS";
            buttonDelete_KDS.Size = new Size(122, 51);
            buttonDelete_KDS.TabIndex = 8;
            buttonDelete_KDS.Text = "Удалить";
            buttonDelete_KDS.UseVisualStyleBackColor = true;
            buttonDelete_KDS.Click += buttonDelete_KDS_Click;
            // 
            // buttonSave_KDS
            // 
            buttonSave_KDS.Location = new Point(6, 320);
            buttonSave_KDS.Name = "buttonSave_KDS";
            buttonSave_KDS.Size = new Size(122, 51);
            buttonSave_KDS.TabIndex = 7;
            buttonSave_KDS.Text = "Добавить";
            buttonSave_KDS.UseVisualStyleBackColor = true;
            buttonSave_KDS.Click += buttonSave_KDS_Click;
            // 
            // groupBoxNote_KDS
            // 
            groupBoxNote_KDS.Controls.Add(textBoxNote_KDS);
            groupBoxNote_KDS.Dock = DockStyle.Top;
            groupBoxNote_KDS.Location = new Point(3, 273);
            groupBoxNote_KDS.Name = "groupBoxNote_KDS";
            groupBoxNote_KDS.Size = new Size(260, 41);
            groupBoxNote_KDS.TabIndex = 6;
            groupBoxNote_KDS.TabStop = false;
            groupBoxNote_KDS.Text = "Примечание";
            // 
            // textBoxNote_KDS
            // 
            textBoxNote_KDS.Location = new Point(135, 6);
            textBoxNote_KDS.Name = "textBoxNote_KDS";
            textBoxNote_KDS.Size = new Size(125, 31);
            textBoxNote_KDS.TabIndex = 0;
            // 
            // groupBoxDispY_KDS
            // 
            groupBoxDispY_KDS.Controls.Add(checkBoxDispY_KDS);
            groupBoxDispY_KDS.Dock = DockStyle.Top;
            groupBoxDispY_KDS.Location = new Point(3, 232);
            groupBoxDispY_KDS.Name = "groupBoxDispY_KDS";
            groupBoxDispY_KDS.Size = new Size(260, 41);
            groupBoxDispY_KDS.TabIndex = 5;
            groupBoxDispY_KDS.TabStop = false;
            groupBoxDispY_KDS.Text = "Дисп. Учет";
            // 
            // checkBoxDispY_KDS
            // 
            checkBoxDispY_KDS.AutoSize = true;
            checkBoxDispY_KDS.Location = new Point(135, 6);
            checkBoxDispY_KDS.Name = "checkBoxDispY_KDS";
            checkBoxDispY_KDS.Size = new Size(18, 17);
            checkBoxDispY_KDS.TabIndex = 0;
            checkBoxDispY_KDS.UseVisualStyleBackColor = true;
            // 
            // groupBoxBolList_KDS
            // 
            groupBoxBolList_KDS.Controls.Add(textBoxBolList_KDS);
            groupBoxBolList_KDS.Dock = DockStyle.Top;
            groupBoxBolList_KDS.Location = new Point(3, 191);
            groupBoxBolList_KDS.Name = "groupBoxBolList_KDS";
            groupBoxBolList_KDS.Size = new Size(260, 41);
            groupBoxBolList_KDS.TabIndex = 4;
            groupBoxBolList_KDS.TabStop = false;
            groupBoxBolList_KDS.Text = "Бол. Лист";
            // 
            // textBoxBolList_KDS
            // 
            textBoxBolList_KDS.Location = new Point(135, 6);
            textBoxBolList_KDS.Name = "textBoxBolList_KDS";
            textBoxBolList_KDS.Size = new Size(125, 31);
            textBoxBolList_KDS.TabIndex = 0;
            // 
            // groupBoxAmbHeal_KDS
            // 
            groupBoxAmbHeal_KDS.Controls.Add(checkBoxAmbHeal_KDS);
            groupBoxAmbHeal_KDS.Dock = DockStyle.Top;
            groupBoxAmbHeal_KDS.Location = new Point(3, 150);
            groupBoxAmbHeal_KDS.Name = "groupBoxAmbHeal_KDS";
            groupBoxAmbHeal_KDS.Size = new Size(260, 41);
            groupBoxAmbHeal_KDS.TabIndex = 3;
            groupBoxAmbHeal_KDS.TabStop = false;
            groupBoxAmbHeal_KDS.Text = "Амб. Лечение";
            // 
            // checkBoxAmbHeal_KDS
            // 
            checkBoxAmbHeal_KDS.AutoSize = true;
            checkBoxAmbHeal_KDS.Location = new Point(135, 6);
            checkBoxAmbHeal_KDS.Name = "checkBoxAmbHeal_KDS";
            checkBoxAmbHeal_KDS.Size = new Size(18, 17);
            checkBoxAmbHeal_KDS.TabIndex = 0;
            checkBoxAmbHeal_KDS.UseVisualStyleBackColor = true;
            // 
            // groupBoxDiagnoz_KDS
            // 
            groupBoxDiagnoz_KDS.Controls.Add(textBoxDiagnoz_KDS);
            groupBoxDiagnoz_KDS.Dock = DockStyle.Top;
            groupBoxDiagnoz_KDS.Location = new Point(3, 109);
            groupBoxDiagnoz_KDS.Name = "groupBoxDiagnoz_KDS";
            groupBoxDiagnoz_KDS.Size = new Size(260, 41);
            groupBoxDiagnoz_KDS.TabIndex = 2;
            groupBoxDiagnoz_KDS.TabStop = false;
            groupBoxDiagnoz_KDS.Text = "Диагноз";
            // 
            // textBoxDiagnoz_KDS
            // 
            textBoxDiagnoz_KDS.Location = new Point(135, 6);
            textBoxDiagnoz_KDS.Name = "textBoxDiagnoz_KDS";
            textBoxDiagnoz_KDS.Size = new Size(125, 31);
            textBoxDiagnoz_KDS.TabIndex = 0;
            // 
            // groupBoxSpec_KDS
            // 
            groupBoxSpec_KDS.Controls.Add(textBoxSpec_KDS);
            groupBoxSpec_KDS.Dock = DockStyle.Top;
            groupBoxSpec_KDS.Location = new Point(3, 68);
            groupBoxSpec_KDS.Name = "groupBoxSpec_KDS";
            groupBoxSpec_KDS.Size = new Size(260, 41);
            groupBoxSpec_KDS.TabIndex = 1;
            groupBoxSpec_KDS.TabStop = false;
            groupBoxSpec_KDS.Text = "Спец-ия";
            // 
            // textBoxSpec_KDS
            // 
            textBoxSpec_KDS.Location = new Point(135, 6);
            textBoxSpec_KDS.Name = "textBoxSpec_KDS";
            textBoxSpec_KDS.Size = new Size(125, 31);
            textBoxSpec_KDS.TabIndex = 0;
            // 
            // groupBoxFIO_KDS
            // 
            groupBoxFIO_KDS.Controls.Add(textBoxFIO_KDS);
            groupBoxFIO_KDS.Dock = DockStyle.Top;
            groupBoxFIO_KDS.Location = new Point(3, 27);
            groupBoxFIO_KDS.Name = "groupBoxFIO_KDS";
            groupBoxFIO_KDS.Size = new Size(260, 41);
            groupBoxFIO_KDS.TabIndex = 0;
            groupBoxFIO_KDS.TabStop = false;
            groupBoxFIO_KDS.Text = "ФИО";
            // 
            // textBoxFIO_KDS
            // 
            textBoxFIO_KDS.Location = new Point(135, 0);
            textBoxFIO_KDS.Name = "textBoxFIO_KDS";
            textBoxFIO_KDS.Size = new Size(125, 31);
            textBoxFIO_KDS.TabIndex = 0;
            // 
            // groupBoxDataPatient_KDS
            // 
            groupBoxDataPatient_KDS.Controls.Add(groupBoxBDay_KDS);
            groupBoxDataPatient_KDS.Controls.Add(groupBoxOtschestvo__KDS);
            groupBoxDataPatient_KDS.Controls.Add(groupBoxName_KDS);
            groupBoxDataPatient_KDS.Controls.Add(groupBoxSurName);
            groupBoxDataPatient_KDS.Dock = DockStyle.Top;
            groupBoxDataPatient_KDS.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxDataPatient_KDS.Location = new Point(0, 0);
            groupBoxDataPatient_KDS.Name = "groupBoxDataPatient_KDS";
            groupBoxDataPatient_KDS.Size = new Size(266, 193);
            groupBoxDataPatient_KDS.TabIndex = 0;
            groupBoxDataPatient_KDS.TabStop = false;
            groupBoxDataPatient_KDS.Text = "Введите данные пациента";
            // 
            // groupBoxBDay_KDS
            // 
            groupBoxBDay_KDS.Controls.Add(textBoxBDay_KDS);
            groupBoxBDay_KDS.Dock = DockStyle.Top;
            groupBoxBDay_KDS.Location = new Point(3, 150);
            groupBoxBDay_KDS.Name = "groupBoxBDay_KDS";
            groupBoxBDay_KDS.Size = new Size(260, 41);
            groupBoxBDay_KDS.TabIndex = 3;
            groupBoxBDay_KDS.TabStop = false;
            groupBoxBDay_KDS.Text = "Дата Рождения";
            // 
            // textBoxBDay_KDS
            // 
            textBoxBDay_KDS.Location = new Point(135, 4);
            textBoxBDay_KDS.Name = "textBoxBDay_KDS";
            textBoxBDay_KDS.Size = new Size(125, 31);
            textBoxBDay_KDS.TabIndex = 0;
            // 
            // groupBoxOtschestvo__KDS
            // 
            groupBoxOtschestvo__KDS.Controls.Add(textBoxOtchestvo_KDS);
            groupBoxOtschestvo__KDS.Dock = DockStyle.Top;
            groupBoxOtschestvo__KDS.Location = new Point(3, 109);
            groupBoxOtschestvo__KDS.Name = "groupBoxOtschestvo__KDS";
            groupBoxOtschestvo__KDS.Size = new Size(260, 41);
            groupBoxOtschestvo__KDS.TabIndex = 2;
            groupBoxOtschestvo__KDS.TabStop = false;
            groupBoxOtschestvo__KDS.Text = "Отчество";
            // 
            // textBoxOtchestvo_KDS
            // 
            textBoxOtchestvo_KDS.Location = new Point(135, 6);
            textBoxOtchestvo_KDS.Name = "textBoxOtchestvo_KDS";
            textBoxOtchestvo_KDS.Size = new Size(125, 31);
            textBoxOtchestvo_KDS.TabIndex = 0;
            // 
            // groupBoxName_KDS
            // 
            groupBoxName_KDS.Controls.Add(textBoxName_KDS);
            groupBoxName_KDS.Dock = DockStyle.Top;
            groupBoxName_KDS.Location = new Point(3, 68);
            groupBoxName_KDS.Name = "groupBoxName_KDS";
            groupBoxName_KDS.Size = new Size(260, 41);
            groupBoxName_KDS.TabIndex = 1;
            groupBoxName_KDS.TabStop = false;
            groupBoxName_KDS.Text = "Имя";
            // 
            // textBoxName_KDS
            // 
            textBoxName_KDS.Location = new Point(135, 6);
            textBoxName_KDS.Name = "textBoxName_KDS";
            textBoxName_KDS.Size = new Size(125, 31);
            textBoxName_KDS.TabIndex = 0;
            // 
            // groupBoxSurName
            // 
            groupBoxSurName.Controls.Add(textBoxSurname_KDS);
            groupBoxSurName.Dock = DockStyle.Top;
            groupBoxSurName.Location = new Point(3, 27);
            groupBoxSurName.Name = "groupBoxSurName";
            groupBoxSurName.Size = new Size(260, 41);
            groupBoxSurName.TabIndex = 0;
            groupBoxSurName.TabStop = false;
            groupBoxSurName.Text = "Фамилия";
            // 
            // textBoxSurname_KDS
            // 
            textBoxSurname_KDS.Location = new Point(135, 4);
            textBoxSurname_KDS.Name = "textBoxSurname_KDS";
            textBoxSurname_KDS.Size = new Size(125, 31);
            textBoxSurname_KDS.TabIndex = 0;
            // 
            // panelPatient_KDS
            // 
            panelPatient_KDS.Controls.Add(dataGridView1);
            panelPatient_KDS.Dock = DockStyle.Left;
            panelPatient_KDS.Location = new Point(266, 0);
            panelPatient_KDS.Name = "panelPatient_KDS";
            panelPatient_KDS.Size = new Size(753, 635);
            panelPatient_KDS.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ColumnSurname, ColumnName, ColumnOtchestvo, ColumnBDay, ColumnFIO, ColumnSpec, ColumnDiagnoz, ColumnBolList, ColumnNote });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(753, 635);
            dataGridView1.TabIndex = 0;
            // 
            // ColumnSurname
            // 
            ColumnSurname.HeaderText = "Фамилия";
            ColumnSurname.MinimumWidth = 6;
            ColumnSurname.Name = "ColumnSurname";
            ColumnSurname.ReadOnly = true;
            ColumnSurname.Width = 125;
            // 
            // ColumnName
            // 
            ColumnName.HeaderText = "Имя";
            ColumnName.MinimumWidth = 6;
            ColumnName.Name = "ColumnName";
            ColumnName.ReadOnly = true;
            ColumnName.Width = 125;
            // 
            // ColumnOtchestvo
            // 
            ColumnOtchestvo.HeaderText = "Отчество";
            ColumnOtchestvo.MinimumWidth = 6;
            ColumnOtchestvo.Name = "ColumnOtchestvo";
            ColumnOtchestvo.ReadOnly = true;
            ColumnOtchestvo.Width = 125;
            // 
            // ColumnBDay
            // 
            ColumnBDay.HeaderText = "Дата Рождения";
            ColumnBDay.MinimumWidth = 6;
            ColumnBDay.Name = "ColumnBDay";
            ColumnBDay.ReadOnly = true;
            ColumnBDay.Width = 125;
            // 
            // ColumnFIO
            // 
            ColumnFIO.HeaderText = "Врач";
            ColumnFIO.MinimumWidth = 6;
            ColumnFIO.Name = "ColumnFIO";
            ColumnFIO.ReadOnly = true;
            ColumnFIO.Width = 125;
            // 
            // ColumnSpec
            // 
            ColumnSpec.HeaderText = "Специализация";
            ColumnSpec.MinimumWidth = 6;
            ColumnSpec.Name = "ColumnSpec";
            ColumnSpec.ReadOnly = true;
            ColumnSpec.Width = 125;
            // 
            // ColumnDiagnoz
            // 
            ColumnDiagnoz.HeaderText = "Дигноз";
            ColumnDiagnoz.MinimumWidth = 6;
            ColumnDiagnoz.Name = "ColumnDiagnoz";
            ColumnDiagnoz.ReadOnly = true;
            ColumnDiagnoz.Width = 125;
            // 
            // ColumnBolList
            // 
            ColumnBolList.HeaderText = "Бол. Лист";
            ColumnBolList.MinimumWidth = 6;
            ColumnBolList.Name = "ColumnBolList";
            ColumnBolList.ReadOnly = true;
            ColumnBolList.Width = 125;
            // 
            // ColumnNote
            // 
            ColumnNote.HeaderText = "Примечание";
            ColumnNote.MinimumWidth = 6;
            ColumnNote.Name = "ColumnNote";
            ColumnNote.ReadOnly = true;
            ColumnNote.Width = 125;
            // 
            // panelINF_KDS
            // 
            panelINF_KDS.Controls.Add(panelWorkFile_KDS);
            panelINF_KDS.Controls.Add(chartINF_KDS);
            panelINF_KDS.Dock = DockStyle.Fill;
            panelINF_KDS.Location = new Point(1019, 0);
            panelINF_KDS.Name = "panelINF_KDS";
            panelINF_KDS.Size = new Size(276, 635);
            panelINF_KDS.TabIndex = 2;
            // 
            // chartINF_KDS
            // 
            chartArea1.Name = "ChartArea1";
            chartINF_KDS.ChartAreas.Add(chartArea1);
            chartINF_KDS.Dock = DockStyle.Top;
            chartINF_KDS.Location = new Point(0, 0);
            chartINF_KDS.Name = "chartINF_KDS";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            chartINF_KDS.Series.Add(series1);
            chartINF_KDS.Size = new Size(276, 503);
            chartINF_KDS.TabIndex = 0;
            // 
            // panelWorkFile_KDS
            // 
            panelWorkFile_KDS.Controls.Add(groupBoxWorkWFile_KDS);
            panelWorkFile_KDS.Dock = DockStyle.Fill;
            panelWorkFile_KDS.Location = new Point(0, 503);
            panelWorkFile_KDS.Name = "panelWorkFile_KDS";
            panelWorkFile_KDS.Size = new Size(276, 132);
            panelWorkFile_KDS.TabIndex = 1;
            // 
            // groupBoxWorkWFile_KDS
            // 
            groupBoxWorkWFile_KDS.Controls.Add(buttonOpenFile_KDS);
            groupBoxWorkWFile_KDS.Controls.Add(buttonSaveFile_KDS);
            groupBoxWorkWFile_KDS.Dock = DockStyle.Fill;
            groupBoxWorkWFile_KDS.Location = new Point(0, 0);
            groupBoxWorkWFile_KDS.Name = "groupBoxWorkWFile_KDS";
            groupBoxWorkWFile_KDS.Size = new Size(276, 132);
            groupBoxWorkWFile_KDS.TabIndex = 0;
            groupBoxWorkWFile_KDS.TabStop = false;
            groupBoxWorkWFile_KDS.Text = "Работа с файлом";
            // 
            // buttonSaveFile_KDS
            // 
            buttonSaveFile_KDS.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSaveFile_KDS.Location = new Point(6, 41);
            buttonSaveFile_KDS.Name = "buttonSaveFile_KDS";
            buttonSaveFile_KDS.Size = new Size(122, 53);
            buttonSaveFile_KDS.TabIndex = 0;
            buttonSaveFile_KDS.Text = "Сохранить";
            buttonSaveFile_KDS.UseVisualStyleBackColor = true;
            // 
            // buttonOpenFile_KDS
            // 
            buttonOpenFile_KDS.Location = new Point(148, 41);
            buttonOpenFile_KDS.Name = "buttonOpenFile_KDS";
            buttonOpenFile_KDS.Size = new Size(122, 53);
            buttonOpenFile_KDS.TabIndex = 1;
            buttonOpenFile_KDS.Text = "Открыть";
            buttonOpenFile_KDS.UseVisualStyleBackColor = true;
            // 
            // FormMain_KDS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1295, 635);
            Controls.Add(panelINF_KDS);
            Controls.Add(panelPatient_KDS);
            Controls.Add(panelDataPatient_KDS);
            Name = "FormMain_KDS";
            Text = "Поликлиника";
            panelDataPatient_KDS.ResumeLayout(false);
            groupBoxDoctor_KDS.ResumeLayout(false);
            groupBoxNote_KDS.ResumeLayout(false);
            groupBoxNote_KDS.PerformLayout();
            groupBoxDispY_KDS.ResumeLayout(false);
            groupBoxDispY_KDS.PerformLayout();
            groupBoxBolList_KDS.ResumeLayout(false);
            groupBoxBolList_KDS.PerformLayout();
            groupBoxAmbHeal_KDS.ResumeLayout(false);
            groupBoxAmbHeal_KDS.PerformLayout();
            groupBoxDiagnoz_KDS.ResumeLayout(false);
            groupBoxDiagnoz_KDS.PerformLayout();
            groupBoxSpec_KDS.ResumeLayout(false);
            groupBoxSpec_KDS.PerformLayout();
            groupBoxFIO_KDS.ResumeLayout(false);
            groupBoxFIO_KDS.PerformLayout();
            groupBoxDataPatient_KDS.ResumeLayout(false);
            groupBoxBDay_KDS.ResumeLayout(false);
            groupBoxBDay_KDS.PerformLayout();
            groupBoxOtschestvo__KDS.ResumeLayout(false);
            groupBoxOtschestvo__KDS.PerformLayout();
            groupBoxName_KDS.ResumeLayout(false);
            groupBoxName_KDS.PerformLayout();
            groupBoxSurName.ResumeLayout(false);
            groupBoxSurName.PerformLayout();
            panelPatient_KDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelINF_KDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartINF_KDS).EndInit();
            panelWorkFile_KDS.ResumeLayout(false);
            groupBoxWorkWFile_KDS.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDataPatient_KDS;
        private GroupBox groupBoxDataPatient_KDS;
        private GroupBox groupBoxOtschestvo__KDS;
        private GroupBox groupBoxName_KDS;
        private GroupBox groupBoxSurName;
        private GroupBox groupBoxBDay_KDS;
        private GroupBox groupBoxDoctor_KDS;
        private GroupBox groupBoxSpec_KDS;
        private GroupBox groupBoxFIO_KDS;
        private Button buttonSave_KDS;
        private GroupBox groupBoxNote_KDS;
        private GroupBox groupBoxDispY_KDS;
        private GroupBox groupBoxBolList_KDS;
        private GroupBox groupBoxAmbHeal_KDS;
        private GroupBox groupBoxDiagnoz_KDS;
        private TextBox textBoxSurname_KDS;
        private TextBox textBoxNote_KDS;
        private TextBox textBoxBolList_KDS;
        private CheckBox checkBoxAmbHeal_KDS;
        private TextBox textBoxDiagnoz_KDS;
        private TextBox textBoxSpec_KDS;
        private TextBox textBoxFIO_KDS;
        private TextBox textBoxBDay_KDS;
        private TextBox textBoxOtchestvo_KDS;
        private TextBox textBoxName_KDS;
        private Button buttonChange_KDS;
        private Button buttonDelete_KDS;
        private Panel panelPatient_KDS;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ColumnSurname;
        private DataGridViewTextBoxColumn ColumnName;
        private DataGridViewTextBoxColumn ColumnOtchestvo;
        private DataGridViewTextBoxColumn ColumnBDay;
        private DataGridViewTextBoxColumn ColumnFIO;
        private DataGridViewTextBoxColumn ColumnSpec;
        private DataGridViewTextBoxColumn ColumnDiagnoz;
        private DataGridViewTextBoxColumn ColumnBolList;
        private DataGridViewTextBoxColumn ColumnNote;
        private Panel panelINF_KDS;
        private CheckBox checkBoxDispY_KDS;
        private Panel panelWorkFile_KDS;
        private GroupBox groupBoxWorkWFile_KDS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartINF_KDS;
        private Button buttonOpenFile_KDS;
        private Button buttonSaveFile_KDS;
    }
}
