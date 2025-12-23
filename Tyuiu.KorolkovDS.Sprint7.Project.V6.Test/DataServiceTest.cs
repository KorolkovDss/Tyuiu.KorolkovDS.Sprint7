using System.Text;
using Tyuiu.KorolkovDS.Sprint7.Project.V6.Lib;
using static Tyuiu.KorolkovDS.Sprint7.Project.V6.Lib.DataService;

namespace Tyuiu.KorolkovDS.Sprint7.Project.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        private Patient CreatePatient(string surname = "Иванов")
        {
            return new Patient
            {
                Surname = surname,
                Name = "Иван",
                BDay = new DateTime(1990, 1, 1)
            };
        }

        
        [TestMethod]
        public void AddPatient_Success()
        {
            var repo = new PatientRepository();
            var patient = CreatePatient();

            repo.AddPatient(patient);

            Assert.AreEqual(1, repo.PatientCount);
        }

        [TestMethod]
        public void AddPatient_Null_ThrowsException()
        {
            var repo = new PatientRepository();

            Assert.ThrowsException<ArgumentNullException>(() => repo.AddPatient(null));
        }

        [TestMethod]
        public void AddPatient_NoSurname_ThrowsException()
        {
            var repo = new PatientRepository();
            var patient = CreatePatient();
            patient.Surname = "";

            Assert.ThrowsException<ArgumentException>(() => repo.AddPatient(patient));
        }

        
        [TestMethod]
        public void UpdatePatient_Success()
        {
            var repo = new PatientRepository();
            repo.AddPatient(CreatePatient("Иванов"));
            var newPatient = CreatePatient("Петров");

            var result = repo.UpdatePatient(0, newPatient);

            Assert.IsTrue(result);
            Assert.AreEqual("Петров", repo.GetPatient(0).Surname);
        }

        [TestMethod]
        public void UpdatePatient_InvalidIndex_Fails()
        {
            var repo = new PatientRepository();
            repo.AddPatient(CreatePatient());

            var result = repo.UpdatePatient(10, CreatePatient());

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void DeletePatient_Success()
        {
            var repo = new PatientRepository();
            repo.AddPatient(CreatePatient("Иванов"));
            repo.AddPatient(CreatePatient("Петров"));

            var result = repo.DeletePatient(0);

            Assert.IsTrue(result);
            Assert.AreEqual(1, repo.PatientCount);
            Assert.AreEqual("Петров", repo.GetPatient(0).Surname);
        }

        
        [TestMethod]
        public void GetAllPatients_ReturnsCopy()
        {
            var repo = new PatientRepository();
            repo.AddPatient(CreatePatient("Иванов"));
            repo.AddPatient(CreatePatient("Петров"));

            var patients = repo.GetAllPatients();
            patients.Clear(); 

            Assert.AreEqual(2, repo.PatientCount); 
        }

        
        [TestMethod]
        public void GetPatient_ValidIndex()
        {
            var repo = new PatientRepository();
            var patient = CreatePatient("Иванов");
            repo.AddPatient(patient);

            var result = repo.GetPatient(0);

            Assert.IsNotNull(result);
            Assert.AreEqual("Иванов", result.Surname);
        }

        [TestMethod]
        public void GetPatient_InvalidIndex_ReturnsNull()
        {
            var repo = new PatientRepository();
            repo.AddPatient(CreatePatient());

            var result = repo.GetPatient(5);

            Assert.IsNull(result);
        }

        
        [TestMethod]
        public void LoadFromCsv_SimpleFile()
        {
            var repo = new PatientRepository();
            var tempFile = Path.GetTempFileName();

            try
            {
                
                File.WriteAllText(tempFile,
                    "Фамилия;Имя\n" +
                    "Иванов;Иван\n" +
                    "Петров;Петр");

                var patients = repo.LoadFromCsv(tempFile);

                Assert.AreEqual(2, patients.Count);
                Assert.AreEqual("Иванов", patients[0].Surname);
                Assert.AreEqual("Петров", patients[1].Surname);
            }
            catch
            {
                File.Delete(tempFile);
            }
        }

        [TestMethod]
        public void LoadFromCsv_FileNotFound_ThrowsException()
        {
            var repo = new PatientRepository();

            Assert.ThrowsException<FileNotFoundException>(() => repo.LoadFromCsv("nonexistent.csv"));
        }

        
        [TestMethod]
        public void SaveToCsv_Success()
        {
            var repo = new PatientRepository();
            var tempFile = Path.GetTempFileName();
            var patients = new List<Patient>
        {
            CreatePatient("Иванов"),
            CreatePatient("Петров")
        };

            try
            {
                repo.SaveToCsv(tempFile, patients);

                Assert.IsTrue(File.Exists(tempFile));
                var content = File.ReadAllText(tempFile);
                Assert.IsTrue(content.Contains("Иванов"));
                Assert.IsTrue(content.Contains("Петров"));
            }
            catch
            {
                File.Delete(tempFile);
            }
        }

        
        [TestMethod]
        public void ReplaceAllPatients_Success()
        {
            var repo = new PatientRepository();
            repo.AddPatient(CreatePatient("Иванов"));

            var newPatients = new List<Patient>
        {
            CreatePatient("Петров"),
            CreatePatient("Сидоров")
        };

            repo.ReplaceAllPatients(newPatients);

            Assert.AreEqual(2, repo.PatientCount);
            Assert.AreEqual("Петров", repo.GetPatient(0).Surname);
        }

        
        [TestMethod]
        public void AnalyzeDiagnoses_SimpleCase()
        {
            var patients = new List<Patient>
        {
            new Patient { Diagnoz = "Грипп" },
            new Patient { Diagnoz = "Грипп" },
            new Patient { Diagnoz = "Ангина" }
        };

            var result = PatientRepository.DiagnosisAnalyzer.AnalyzeDiagnoses(patients);

            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("Грипп", result[0].Diagnoz);
            Assert.AreEqual(2, result[0].Count);
            Assert.AreEqual(67, result[0].Percentage, 1); 
        }

        [TestMethod]
        public void AnalyzeDiagnoses_EmptyList()
        {
            var result = PatientRepository.DiagnosisAnalyzer.AnalyzeDiagnoses(new List<Patient>());

            Assert.IsNotNull(result);
           
        }
    }
}

