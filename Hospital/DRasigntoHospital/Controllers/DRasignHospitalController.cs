using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Mvc;
using DRasigntoHospital.Data;
using DRasigntoHospital.Models;
using DRasigntoHospital.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DRasigntoHospital.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DRasignHospitalController : ControllerBase
    {
        private readonly IDRasignhospitalService _dRasignhospitalService;

        public DRasignHospitalController(IDRasignhospitalService dRasignhospitalService)
        {
            _dRasignhospitalService = dRasignhospitalService ?? throw new ArgumentNullException(nameof(dRasignhospitalService));
        }


        /// <summary>
        /// Get all Doctors
        /// </summary>
        /// <returns>return the list of Patient</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dRasignhospitalService.GetDoctors());
        }

        /// <summary>
        /// Get Doctor by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the Doctor with the passed ID</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _dRasignhospitalService.GetDoctor(id) != null ? Ok(_dRasignhospitalService.GetDoctor(id)) : NoContent();
        }

        /// <summary>
        /// Add Doctors
        /// </summary>
        /// <param name="Doctor"></param>
        /// <returns>Return the added Doctor</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Models.DRasignHospital Doctor)
        {
            return Ok(_dRasignhospitalService.AddDoctor(Doctor));
        }

        /// <summary>
        /// Update the Doctor
        /// </summary>
        /// <param name="Patient"></param>
        /// <returns>Return the updated Doctor</returns>
        [HttpPut]
        public IActionResult Put([FromBody] Models.DRasignHospital Patient)
        {
            return Ok(_dRasignhospitalService.UpdateDoctor(Patient));
        }

        /// <summary>
        /// Delete the Doctor with the passed ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _dRasignhospitalService.DeleteDoctor(id);

            return result.HasValue & result == true ? Ok($"Doctor with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the Patient with ID:{id}.");
        }
    }
}
