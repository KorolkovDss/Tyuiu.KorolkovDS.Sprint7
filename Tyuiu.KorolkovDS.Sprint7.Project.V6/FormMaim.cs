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
                    MessageBox.Show("Пациент удален", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
