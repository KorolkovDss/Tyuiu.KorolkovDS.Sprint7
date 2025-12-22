using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.KorolkovDS.Sprint7.Project.V6.Lib;
using static Tyuiu.KorolkovDS.Sprint7.Project.V6.Lib.DataService;

namespace Tyuiu.KorolkovDS.Sprint7.Project.V6
{
    public partial class FormMain_KDS : Form
    {
        private PatientRepository patientRepository;
        public FormMain_KDS()
        {
            InitializeComponent();
            patientRepository = new PatientRepository();
        }
        DataService ds = new DataService();
        private Patient GetPatientFromForm()
        {
            try
            {
                return new Patient
                {
                    Surname = textBoxSurname_KDS.Text.Trim(),
                    Name = textBoxName_KDS.Text.Trim(),
                    Otchestvo = textBoxOtchestvo_KDS.Text.Trim(),
                    BDay = ParseBirthDate(textBoxBDay_KDS.Text.Trim()),
                    DocFIO = textBoxFIO_KDS.Text.Trim(),
                    Spec = textBoxSpec_KDS.Text.Trim(),
                    Diagnoz = textBoxDiagnoz_KDS.Text.Trim(),
                    AmbHeal = checkBoxAmbHeal_KDS.Checked,
                    BolList = textBoxBolList_KDS.Text.Trim(),
                    Note = textBoxNote_KDS.Text.Trim()
                };
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Некорректный формат даты: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка в данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private DateTime ParseBirthDate(string dateText)
        {
            if (string.IsNullOrWhiteSpace(dateText))
                throw new FormatException("Дата рождения не может быть пустой");

            if (DateTime.TryParse(dateText, out DateTime result))
                return result;
            else
                throw new FormatException("Неверный формат даты. Используйте ДД.ММ.ГГГГ");
        }

        private void ClearForm()
        {
            textBoxSurname_KDS.Clear();
            textBoxName_KDS.Clear();
            textBoxOtchestvo_KDS.Clear();
            textBoxBDay_KDS.Clear();
            textBoxFIO_KDS.Clear();
            textBoxSpec_KDS.Clear();
            textBoxDiagnoz_KDS.Clear();
            textBoxBolList_KDS.Clear();
            textBoxNote_KDS.Clear();
            checkBoxAmbHeal_KDS.Checked = false;
        }
        private void RefreshDataGridView()
        {

            dataGridView1.Rows.Clear();


            var patients = patientRepository.GetAllPatients();
            foreach (var patient in patients)
            {
                AddPatientToDataGridView(patient);
            }
        }


        private void AddPatientToDataGridView(Patient patient)
        {
            int rowIndex = dataGridView1.Rows.Add();
            UpdateDataGridViewRow(rowIndex, patient);
        }

        private void UpdateDataGridViewRow(int rowIndex, Patient patient)
        {
            if (rowIndex < 0 || rowIndex >= dataGridView1.Rows.Count)
                return;

            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            row.Cells["ColumnSurname"].Value = patient.Surname;
            row.Cells["ColumnName"].Value = patient.Name;
            row.Cells["ColumnOtchestvo"].Value = patient.Otchestvo;
            row.Cells["ColumnBDay"].Value = patient.BDay;
            row.Cells["ColumnFIO"].Value = patient.DocFIO;
            row.Cells["ColumnSpec"].Value = patient.Spec;
            row.Cells["ColumnDiagnoz"].Value = patient.Diagnoz;
            row.Cells["ColumnBollist"].Value = patient.BolList;
            row.Cells["ColumnNote"].Value = patient.Note;


            row.Tag = patient;
        }



        private void buttonSave_KDS_Click(object sender, EventArgs e)
        {
            try
            {
                var patient = GetPatientFromForm();
                if (patient == null) return;

                patientRepository.AddPatient(patient);
                AddPatientToDataGridView(patient);
                ClearForm();
                UpdateChartFromDataGridView();

                MessageBox.Show("Пациент успешно добавлен", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка валидации",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonChange_KDS_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                MessageBox.Show("Выберите пациента для изменения", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int selectedIndex = dataGridView1.CurrentRow.Index;
                var patient = GetPatientFromForm();
                if (patient == null) return;

                if (patientRepository.UpdatePatient(selectedIndex, patient))
                {
                    UpdateDataGridViewRow(selectedIndex, patient);
                    UpdateChartFromDataGridView();
                    MessageBox.Show("Данные пациента обновлены", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_KDS_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
            {
                MessageBox.Show("Выберите пациента для удаления", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Вы уверены, что хотите удалить пациента?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int selectedIndex = dataGridView1.CurrentRow.Index;
                if (patientRepository.DeletePatient(selectedIndex))
                {
                    dataGridView1.Rows.RemoveAt(selectedIndex);
                    ClearForm();
                    UpdateChartFromDataGridView();
                    MessageBox.Show("Пациент удален", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private Dictionary<string, int> GetDiagnosisStatistics()
        {
            Dictionary<string, int> stats = new Dictionary<string, int>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ColumnDiagnoz"].Value != null)
                {
                    string diagnosis = row.Cells["ColumnDiagnoz"].Value.ToString().Trim();

                    if (!string.IsNullOrEmpty(diagnosis))
                    {
                        if (stats.ContainsKey(diagnosis))
                        {
                            stats[diagnosis]++;
                        }
                        else
                        {
                            stats[diagnosis] = 1;
                        }
                    }
                }
            }

            return stats;
        }

        private void UpdateChartFromDataGridView()
        {
            try
            {

                var diagnosisStats = GetDiagnosisStatistics();

                if (diagnosisStats.Count == 0)
                {

                    chartINF_KDS.Series.Clear();
                    chartINF_KDS.Titles.Clear();
                    chartINF_KDS.Titles.Add("Нет данных о диагнозах");
                    return;
                }


                chartINF_KDS.Series.Clear();


                Series series = new Series("Диагнозы");
                series.ChartType = SeriesChartType.Column;


                series.IsValueShownAsLabel = true;
                series.LabelFormat = "{#}";
                series.Color = Color.FromArgb(65, 105, 225);


                foreach (var stat in diagnosisStats.OrderByDescending(x => x.Value))
                {
                    DataPoint point = new DataPoint();
                    point.SetValueXY(stat.Key, stat.Value);
                    point.Label = stat.Value.ToString();
                    point.ToolTip = $"{stat.Key}: {stat.Value} пациентов";


                    series.Points.Add(point);
                }

                chartINF_KDS.Series.Add(series);


                if (chartINF_KDS.ChartAreas.Count > 0)
                {
                    chartINF_KDS.ChartAreas[0].AxisX.Title = "Диагнозы";
                    chartINF_KDS.ChartAreas[0].AxisY.Title = "Количество пациентов";
                    chartINF_KDS.ChartAreas[0].AxisX.Interval = 1;
                    chartINF_KDS.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
                    chartINF_KDS.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 9);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении графика: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveFile_KDS_Click(object sender, EventArgs e)
        {
            SaveCsvFile();
        }

        private void SaveCsvFile()
        {
            DataService ds = new DataService();
            try
            {
                if (patientRepository.PatientCount == 0)
                {
                    MessageBox.Show("Нет данных для сохранения", "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "CSV файлы (*.csv)|*.csv|Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                    saveFileDialog.FilterIndex = 1;
                    saveFileDialog.Title = "Сохранить данные пациентов в CSV файл";
                    saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    saveFileDialog.RestoreDirectory = true;
                    saveFileDialog.FileName = $"Пациенты_{DateTime.Now:yyyyMMdd_HHmm}.csv";
                    saveFileDialog.OverwritePrompt = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;


                        var patientsToSave = patientRepository.GetAllPatients();


                        patientRepository.SaveToCsv(filePath, patientsToSave);


                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Нет прав для сохранения файла в выбранную папку", "Ошибка доступа",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOpenFile_KDS_Click(object sender, EventArgs e)
        {
            OpenCsvFile();
        }

        private void OpenCsvFile()
        {
            DataService ds = new DataService();
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "CSV файлы (*.csv)|*.csv|Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                    openFileDialog.FilterIndex = 1;
                    openFileDialog.Title = "Выберите CSV файл с данными пациентов";
                    openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    openFileDialog.RestoreDirectory = true;


                    openFileDialog.ShowPreview = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = openFileDialog.FileName;


                        DialogResult confirmResult = MessageBox.Show(
                            "Текущие данные будут заменены. Продолжить?",
                            "Подтверждение загрузки",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (confirmResult == DialogResult.Yes)
                        {

                            var loadedPatients = patientRepository.LoadFromCsv(filePath);


                            patientRepository.ReplaceAllPatients(loadedPatients);


                            RefreshDataGridView();


                            UpdateChartFromDataGridView();


                        }
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"Файл не найден: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке файла: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAbout_KDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Разработал: Корольков Д.С. {Environment.NewLine}Программа для работы с данными по типу Поликлиники{Environment.NewLine}С разработкой Front-end  и Back-End частей", "О программе", MessageBoxButtons.OK);
        }

        private void buttonSpravka_KDS_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"")
        }
    }
}
