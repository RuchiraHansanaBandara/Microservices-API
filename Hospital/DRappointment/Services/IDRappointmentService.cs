namespace DRappointment.Services
{
    public interface IDRappointmentService
    {
        List<Models.DRappointment> GetPatients();
        Models.DRappointment? GetPatient(int id);
        Models.DRappointment? AddPatient(Models.DRappointment Patient);
        Models.DRappointment? UpdatePatient(Models.DRappointment Patient);
        bool? DeletePatient(int id);
    }
}
