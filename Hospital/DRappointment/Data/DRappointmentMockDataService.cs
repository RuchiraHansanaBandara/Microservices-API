namespace DRappointment.Data
{
    public class DRappointmentMockDataService
    {
        public static List<Models.DRappointment> DRappointments = new List<Models.DRappointment>()
        {
            new Models.DRappointment { Id = 1, Name = "Ruchira", Address = "123 Main St Kurunegala", Age = 20 },
            new Models.DRappointment { Id = 2, Name = "Hansana", Address = "456 Wariyapola ", Age = 22 },
            new Models.DRappointment { Id = 3, Name = "Bandara", Address = "789 Malambe", Age = 21 },
            new Models.DRappointment { Id = 4, Name = "Kasun", Address = "321 Kandy", Age = 23 },
            new Models.DRappointment { Id = 5, Name = "Pasan", Address = "654 Fifth St", Age = 19 }
        };

    }
}
