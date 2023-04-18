using DRappointment.Data;
using DRappointment.Models;

namespace DRappointment.Services
{
    public class DRappoinmentService : IDRappointmentService
    {
        public List<Models.DRappointment> GetPatients()
        {
            return DRappointmentMockDataService.DRappointments;
        }

        public Models.DRappointment? GetPatient(int id)
        {
            return DRappointmentMockDataService.DRappointments.FirstOrDefault(x => x.Id == id);
        }

        public Models.DRappointment? AddPatient(Models.DRappointment Patient)
        {
            DRappointmentMockDataService.DRappointments.Add(Patient);
            return Patient;
        }

        public Models.DRappointment? UpdatePatient(Models.DRappointment Patient)
        {
            Models.DRappointment selectedPatient = DRappointmentMockDataService.DRappointments.FirstOrDefault(x => x.Id == Patient.Id);
            if (selectedPatient != null)
            {
                selectedPatient.Address = Patient.Address;
                selectedPatient.Age = Patient.Age;
                selectedPatient.Name = Patient.Name;
                return selectedPatient;
            }

            return selectedPatient;
        }

        public bool? DeletePatient(int id)
        {
            Models.DRappointment selectedPatient = DRappointmentMockDataService.DRappointments.FirstOrDefault(x => x.Id == id);
            if (selectedPatient != null)
            {
                DRappointmentMockDataService.DRappointments.Remove(selectedPatient);
                return true;
            }
            return false;
        }
    }
}
