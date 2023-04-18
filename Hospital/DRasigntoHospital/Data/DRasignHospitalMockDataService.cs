namespace DRasigntoHospital.Data
{
    public class DRasignHospitalMockDataService
    {
        public static List<Models.DRasignHospital> DRasignHospitals = new List<Models.DRasignHospital>()
        {
            new Models.DRasignHospital { Id = 1, Name = "Bandara", Address = "Colombo 6", Age = 30 },
            new Models.DRasignHospital { Id = 2, Name = "Handagala", Address = "Panadura", Age = 42 },
            new Models.DRasignHospital { Id = 3, Name = "Nihal", Address = "Kandy", Age = 41 },
            new Models.DRasignHospital { Id = 4, Name = "Kasuni", Address = "Warakapola", Age = 35 },
            new Models.DRasignHospital { Id = 5, Name = "Rohitha", Address = "Padeniya", Age = 45 }
        };
    }
}
