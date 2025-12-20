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
        }
    }
}
