
using apiToDo.DTO;
using apiToDo.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace apiToDo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TarefasController : ControllerBase
    {
        private readonly Tarefas _tarefas = new Tarefas();

        [HttpGet("lstTarefas")]
        public ActionResult lstTarefas()
        {
            try
            {
                var resultado = _tarefas.lstTarefas();
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                return BadRequest(new { msg = $"Erro ao listar tarefas: {ex.Message}" });
            }
        }

        [HttpPost("InserirTarefas")]
        public ActionResult InserirTarefas([FromBody] TarefaDTO Request)
        {
            try
            {
                var resultado = _tarefas.InserirTarefa(Request);
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                return BadRequest(new { msg = $"Erro ao inserir tarefa: {ex.Message}" });
            }
        }

        [HttpDelete("DeleteTask/{id}")]
        public ActionResult DeleteTask(int id)
        {
            try
            {
                var resultado = _tarefas.DeletarTarefa(id);
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                return NotFound(new { msg = ex.Message });
            }
        }

        [HttpPut("AtualizarTarefa")]
        public ActionResult AtualizarTarefa([FromBody] TarefaDTO tarefa)
        {
            try
            {
                var resultado = _tarefas.AtualizarTarefa(tarefa);
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                return NotFound(new { msg = ex.Message });
            }
        }

        [HttpGet("ObterTarefa/{id}")]
        public ActionResult ObterTarefa(int id)
        {
            try
            {
                var resultado = _tarefas.ObterTarefa(id);
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                return NotFound(new { msg = ex.Message });
            }
        }
    }
}
