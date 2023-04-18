using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using DRappointment.Data;
using DRappointment.Models;
using DRappointment.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DRappointment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DRappointmentController : ControllerBase
    {
        private readonly IDRappointmentService _dRappointmentService;

        public DRappointmentController(IDRappointmentService dRappointmentService)
        {
            _dRappointmentService = dRappointmentService ?? throw new ArgumentNullException(nameof(dRappointmentService));
        }


        /// <summary>
        /// Get all Patients
        /// </summary>
        /// <returns>return the list of Patient</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dRappointmentService.GetPatients());
        }

        /// <summary>
        /// Get student by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the student with the passed ID</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _dRappointmentService.GetPatient(id) != null ? Ok(_dRappointmentService.GetPatient(id)) : NoContent();
        }

        /// <summary>
        /// Add Patients
        /// </summary>
        /// <param name="Patient"></param>
        /// <returns>Return the added Patient</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Models.DRappointment Patient)
        {
            return Ok(_dRappointmentService.AddPatient(Patient));
        }

        /// <summary>
        /// Update the Patient
        /// </summary>
        /// <param name="Patient"></param>
        /// <returns>Return the updated Patient</returns>
        [HttpPut]
        public IActionResult Put([FromBody] Models.DRappointment Patient)
        {
            return Ok(_dRappointmentService.UpdatePatient(Patient));
        }

        /// <summary>
        /// Delete the Patient with the passed ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _dRappointmentService.DeletePatient(id);

            return result.HasValue & result == true ? Ok($"Patient with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the Patient with ID:{id}.");
        }
    }
}
