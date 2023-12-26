using BuckeyeClinic.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BuckeyeClinic.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientInfoController : ControllerBase
    {
        private readonly PatientInfoService _patientInfoService;

        public PatientInfoController(PatientInfoService patientInfoService)
        {
            _patientInfoService = patientInfoService;
        }

        [HttpGet]
        public IActionResult GetAllPatientInfos()
        {
            var patientInfos = _patientInfoService.GetAllPatientInfos();
            return Ok(patientInfos);
        }

        [HttpGet("{id}")]
        public IActionResult GetPatientInfoById(int id)
        {
            var patientInfo = _patientInfoService.GetPatientInfoById(id);

            if (patientInfo == null)
            {
                return NotFound();
            }

            return Ok(patientInfo);
        }

        [HttpPost]
        public IActionResult CreatePatientInfo([FromBody] PatientInfo patientInfo)
        {
            _patientInfoService.CreatePatientInfo(patientInfo);
            return CreatedAtAction(nameof(GetPatientInfoById), new { id = patientInfo.Id }, patientInfo);
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePatientInfo(int id, [FromBody] PatientInfo updatedPatientInfo)
        {
            if (id != updatedPatientInfo.Id)
            {
                return BadRequest();
            }

            _patientInfoService.UpdatePatientInfo(updatedPatientInfo);
            return NoContent();
        }

    }
}
