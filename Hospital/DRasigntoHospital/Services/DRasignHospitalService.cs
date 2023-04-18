using System.Numerics;
using DRasigntoHospital.Data;
using DRasigntoHospital.Models;
namespace DRasigntoHospital.Services
{
    public class DRasignHospitalService : IDRasignhospitalService
    {
        public List<Models.DRasignHospital> GetDoctors()
        {
            return DRasignHospitalMockDataService.DRasignHospitals;
        }

        public Models.DRasignHospital? GetDoctor(int id)
        {
            return DRasignHospitalMockDataService.DRasignHospitals.FirstOrDefault(x => x.Id == id);
        }

        public Models.DRasignHospital? AddDoctor(Models.DRasignHospital Doctor)
        {
            DRasignHospitalMockDataService.DRasignHospitals.Add(Doctor);
            return Doctor;
        }

        public Models.DRasignHospital? UpdateDoctor(Models.DRasignHospital Doctor)
        {
            Models.DRasignHospital selectedDoctor = DRasignHospitalMockDataService.DRasignHospitals.FirstOrDefault(x => x.Id == Doctor.Id);
            if (selectedDoctor != null)
            {
                selectedDoctor.Address = Doctor.Address;
                selectedDoctor.Age = Doctor.Age;
                selectedDoctor.Name = Doctor.Name;
                return selectedDoctor;
            }

            return selectedDoctor;
        }

        public bool? DeleteDoctor(int id)
        {
            Models.DRasignHospital selectedDoctor = DRasignHospitalMockDataService.DRasignHospitals.FirstOrDefault(x => x.Id == id);
            if (selectedDoctor != null)
            {
                DRasignHospitalMockDataService.DRasignHospitals.Remove(selectedDoctor);
                return true;
            }
            return false;
        }
    }
}
