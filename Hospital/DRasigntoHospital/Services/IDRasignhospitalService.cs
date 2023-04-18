namespace DRasigntoHospital.Services
{
    public interface IDRasignhospitalService
    {
        List<Models.DRasignHospital> GetDoctors();
        Models.DRasignHospital? GetDoctor(int id);
        Models.DRasignHospital? AddDoctor(Models.DRasignHospital PDoctor);
        Models.DRasignHospital? UpdateDoctor(Models.DRasignHospital Doctor);
        bool? DeleteDoctor(int id);
    }
}
