using MediatR;
using Microsoft.AspNetCore.Mvc;
using testswagger.Application.Commands;
using testswagger.Application.Parcours.Delete;
using testswagger.Application.Parcours.Update;
using testswagger.Application.Querries;
using testswagger.Data.Repositories.Parcours;

namespace testswagger.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParcoursController : ControllerBase
    {

        private readonly ISender sender;
        public ParcoursController(ISender sender)
        {
            this.sender = sender;
        }

        [HttpPost(Name = "AddParcours")]
        public IActionResult AddParcours([FromBody] CreateParcoursCommand command)
        {
            try
            {
                sender.Send(command);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }


        [HttpGet("parcours/{id}")]
        public IActionResult GetParcours(int id)
        {
            try
            {
                var result = sender.Send(new GetParcourQuery(id));
                return Ok(result);
            }
            catch (ParcourstNotFoundException e)
            {
                return NotFound(e.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }





        [HttpPut("parcours/{id}")]
        public IActionResult UpdateParcours(int id, [FromBody] UpdateParcoursRequest request)
        {
            try
            {
                var command = new UpdateParcoursCommand(
                    id,
                    request.ParcoursName,
                    request.ParcoursDescription,
                    request.DateCreation
                );

                sender.Send(command);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }


        [HttpDelete("parcours/{id}")]
        public IActionResult DeleteParcours(int id)
        {
            try
            {
                sender.Send(new DeleteParcourCommand(id));
                return NoContent();
            }
            catch (ParcourstNotFoundException e)
            {
                return NotFound(e.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
