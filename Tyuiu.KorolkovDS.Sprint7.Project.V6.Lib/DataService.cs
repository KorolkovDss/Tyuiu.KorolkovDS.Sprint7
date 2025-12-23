using System.Text;
using static Tyuiu.KorolkovDS.Sprint7.Project.V6.Lib.DataService;

namespace Tyuiu.KorolkovDS.Sprint7.Project.V6.Lib
{

    public class DataService
    {
        public class Patient
        {
            public string Surname { get; set; }
            public string Name { get; set; }
            public string Otchestvo { get; set; }
            public DateTime BDay { get; set; }
            public string DocFIO { get; set; }
            public string Spec { get; set; }
            public string Diagnoz { get; set; }
            public bool AmbHeal { get; set; }
            public string BolList { get; set; }
            public string DispY { get; set; }
            public string Note { get; set; }

        }


        public class PatientRepository
        {
            private List<Patient> patients = new List<Patient>();

            public void AddPatient(Patient patient)
            {
                if (patient == null)
                    throw new ArgumentNullException(nameof(patient));

                if (string.IsNullOrWhiteSpace(patient.Surname))
                    throw new ArgumentException("Фамилия обязательна");

                patients.Add(patient);
            }

            public bool UpdatePatient(int index, Patient patient)
            {
                if (index < 0 || index >= patients.Count)
                    return false;

                patients[index] = patient;
                return true;
            }

            public bool DeletePatient(int index)
            {
                if (index < 0 || index >= patients.Count)
                    return false;

                patients.RemoveAt(index);
                return true;
            }

            public List<Patient> GetAllPatients()
            {
                return new List<Patient>(patients);
            }

            public Patient GetPatient(int index)
            {
                if (index < 0 || index >= patients.Count)
                    return null;

                return patients[index];
            }

            public int PatientCount => patients.Count;

            public List<Patient> LoadFromCsv(string filePath, char delimiter = ';')
            {
                var loadedPatients = new List<Patient>();

                try
                {

                    if (!File.Exists(filePath))
                    {
                        throw new FileNotFoundException($"Файл не найден: {filePath}");
                    }


                    string[] lines = File.ReadAllLines(filePath, Encoding.UTF8);

                    
                    int startIndex = 0;
                    if (lines.Length > 0 && lines[0].Contains("Фамилия"))
                        startIndex = 1;

                    for (int i = startIndex; i < lines.Length; i++)
                    {
                        string line = lines[i].Trim();
                        if (string.IsNullOrEmpty(line))
                            continue;

                        string[] values = line.Split(delimiter);

                        var patient = new Patient
                        {
                            Surname = values.Length > 0 ? values[0] : "",
                            Name = values.Length > 1 ? values[1] : "",
                            Otchestvo = values.Length > 2 ? values[2] : "",
                            BDay = ParseDate(values.Length > 3 ? values[3] : ""),
                            DocFIO = values.Length > 4 ? values[4] : "",
                            Spec = values.Length > 5 ? values[5] : "",
                            Diagnoz = values.Length > 6 ? values[6] : "",
                            BolList = values.Length > 7 ? values[7] : "",
                            Note = values.Length > 8 ? values[8] : "",
                            AmbHeal = values.Length > 9 && bool.TryParse(values[9], out bool amb) ? amb : false
                        };

                        loadedPatients.Add(patient);
                    }
                }
                catch (FileNotFoundException) 
                {
                    throw;
                }

                catch (Exception ex)
                {
                    throw new Exception($"Ошибка при загрузке CSV: {ex.Message}", ex);
                }

                return loadedPatients;
            }

            public void SaveToCsv(string filePath, List<Patient> patientsToSave, char delimiter = ';')
            {
                try
                {
                    var csvLines = new List<string>();


                    csvLines.Add($"Фамилия{delimiter}Имя{delimiter}Отчество{delimiter}Дата рождения{delimiter}Врач{delimiter}Специализация{delimiter}Диагноз{delimiter}Больничный лист{delimiter}Примечание{delimiter}Амбулаторное лечение");


                    foreach (var patient in patientsToSave)
                    {
                        string line = string.Join(delimiter.ToString(),
                            EscapeCsvField(patient.Surname),
                            EscapeCsvField(patient.Name),
                            EscapeCsvField(patient.Otchestvo),
                            patient.BDay.ToString("dd.MM.yyyy"),
                            EscapeCsvField(patient.DocFIO),
                            EscapeCsvField(patient.Spec),
                            EscapeCsvField(patient.Diagnoz),
                            EscapeCsvField(patient.BolList),
                            EscapeCsvField(patient.Note),
                            patient.AmbHeal.ToString()
                        );

                        csvLines.Add(line);
                    }


                    File.WriteAllLines(filePath, csvLines, Encoding.UTF8);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Ошибка при сохранении CSV: {ex.Message}", ex);
                }
            }


            private DateTime ParseDate(string dateString)
            {
                if (string.IsNullOrWhiteSpace(dateString))
                    return DateTime.Now.Date;

                if (DateTime.TryParse(dateString, out DateTime result))
                    return result;


                string[] formats = { "dd.MM.yyyy", "dd/MM/yyyy", "dd-MM-yyyy", "yyyy-MM-dd" };
                if (DateTime.TryParseExact(dateString, formats,
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None, out DateTime exactResult))
                    return exactResult;

                return DateTime.Now.Date;
            }


            private string EscapeCsvField(string field)
            {
                if (string.IsNullOrEmpty(field))
                    return "";


                if (field.Contains(";") || field.Contains("\"") || field.Contains("\n") || field.Contains("\r"))
                {

                    field = field.Replace("\"", "\"\"");
                    return $"\"{field}\"";
                }

                return field;
            }


            public void ReplaceAllPatients(List<Patient> newPatients)
            {
                patients.Clear();
                patients.AddRange(newPatients);
            }

            public class DiagnozStats
            {
                public string Diagnoz { get; set; }
                public int Count { get; set; }
                public double Percentage { get; set; }
            }

            public class DiagnosisAnalyzer
            {
                public static List<DiagnozStats> AnalyzeDiagnoses(List<Patient> patients)
                {
                    var result = new List<DiagnozStats>();

                    if (patients == null || patients.Count == 0)
                        return result;


                    var grouped = patients
                        .Where(p => !string.IsNullOrWhiteSpace(p.Diagnoz))
                        .GroupBy(p => p.Diagnoz.Trim())
                        .Select(g => new DiagnozStats
                        {
                            Diagnoz = g.Key,
                            Count = g.Count()
                        })
                        .OrderByDescending(d => d.Count)
                        .ToList();


                    int total = grouped.Sum(g => g.Count);
                    foreach (var stat in grouped)
                    {
                        stat.Percentage = total > 0 ? Math.Round((double)stat.Count / total * 100, 1) : 0;
                    }

                    return grouped;
                }
            }
        }

    }
}


