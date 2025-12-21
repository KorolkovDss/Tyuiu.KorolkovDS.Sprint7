using Tyuiu.KorolkovDS.Sprint7.Project.V6.Lib;

namespace Tyuiu.KorolkovDS.Sprint7.Project.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Patient_ValidData_CreatesSuccessfully()
        {
            
            var patient = new Patient
            {
                Surname = "Иванов",
                Name = "Иван",
                Patronymic = "Иванович",
                BirthDate = new DateTime(1980, 5, 15),
                DoctorFullName = "Петров П.П.",
                Specialization = "Терапевт",
                Diagnosis = "ОРВИ",
                AmbulatoryTreatment = true,
                SickLeaveNumber = "БЛ-12345",
                Note = "Плановый осмотр"
            };

            
            Assert.AreEqual("Иванов", patient.Surname);
            Assert.AreEqual("Иван", patient.Name);
            Assert.AreEqual("Терапевт", patient.Specialization);
            Assert.IsTrue(patient.AmbulatoryTreatment);
        }

        [TestMethod]
        public void PatientRepository_AddPatient_ValidPatient_AddsSuccessfully()
        {
            
            var repository = new PatientRepository();
            var patient = new Patient { Surname = "Петров", Name = "Петр" };

           
            repository.AddPatient(patient);

            
            Assert.AreEqual(1, repository.PatientCount);
        }

        [TestMethod]
        public void PatientRepository_AddPatient_NullPatient_ThrowsException()
        {
            
            var repository = new PatientRepository();

            
            Assert.Throws<ArgumentNullException>(() => repository.AddPatient(null));
        }

        [TestMethod]
        public void PatientRepository_AddPatient_EmptySurname_ThrowsException()
        {
            var repository = new PatientRepository();
            var patient = new Patient { Surname = "", Name = "Иван" };

            Assert.Throws<ArgumentException>(() => repository.AddPatient(patient));
        }

        [TestMethod]
        public void PatientRepository_DeletePatient_ValidIndex_DeletesSuccessfully()
        {
            
            var repository = new PatientRepository();
            var patient = new Patient { Surname = "Сидоров" };
            repository.AddPatient(patient);

            
            bool result = repository.DeletePatient(0);

            Assert.IsTrue(result);
            Assert.AreEqual(0, repository.PatientCount);
        }

        [TestMethod]
        public void PatientRepository_DeletePatient_InvalidIndex_ReturnsFalse()
        {
            
            var repository = new PatientRepository();

            
            bool result = repository.DeletePatient(-1);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void PatientRepository_UpdatePatient_ValidData_UpdatesSuccessfully()
        {
            
            var repository = new PatientRepository();
            var patient1 = new Patient { Surname = "Старая", Name = "Запись" };
            var patient2 = new Patient { Surname = "Новая", Name = "Запись" };
            repository.AddPatient(patient1);

           
            bool result = repository.UpdatePatient(0, patient2);
            var updatedPatient = repository.GetPatient(0);

            Assert.IsTrue(result);
            Assert.AreEqual("Новая", updatedPatient.Surname);
        }

        [TestMethod]
        public void PatientRepository_GetAllPatients_ReturnsCopyOfList()
        {
           
            var repository = new PatientRepository();
            repository.AddPatient(new Patient { Surname = "Первый" });
            repository.AddPatient(new Patient { Surname = "Второй" });

            var patients = repository.GetAllPatients();
            patients.Clear();

            Assert.AreEqual(2, repository.PatientCount);
        }
    }
}

