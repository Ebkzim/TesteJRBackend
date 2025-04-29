
using apiToDo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace apiToDo.Models
{
    public class Tarefas
    {
        private static List<TarefaDTO> _tarefas = new List<TarefaDTO>
        {
            new TarefaDTO { ID_TAREFA = 1, DS_TAREFA = "Fazer Compras" },
            new TarefaDTO { ID_TAREFA = 2, DS_TAREFA = "Fazer Atividade Faculdade" },
            new TarefaDTO { ID_TAREFA = 3, DS_TAREFA = "Subir Projeto de Teste no GitHub" }
        };

        public List<TarefaDTO> lstTarefas()
        {
            try
            {
                return _tarefas;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<TarefaDTO> InserirTarefa(TarefaDTO Request)
        {
            try
            {
                _tarefas.Add(Request);
                return _tarefas;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<TarefaDTO> DeletarTarefa(int ID_TAREFA)
        {
            try
            {
                // Procura a tarefa com o ID especificado na lista
                var tarefa = _tarefas.FirstOrDefault(x => x.ID_TAREFA == ID_TAREFA);
                
                // Verifica se a tarefa foi encontrada
                if (tarefa == null)
                    throw new Exception($"Tarefa {ID_TAREFA} não encontrada");
                
                // Remove a tarefa da lista
                _tarefas.Remove(tarefa);
                
                // Retorna a lista atualizada
                return _tarefas;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<TarefaDTO> AtualizarTarefa(TarefaDTO tarefaAtualizada)
        {
            try
            {
                var tarefa = _tarefas.FirstOrDefault(x => x.ID_TAREFA == tarefaAtualizada.ID_TAREFA);
                if (tarefa == null)
                    throw new Exception($"Tarefa {tarefaAtualizada.ID_TAREFA} não encontrada");

                tarefa.DS_TAREFA = tarefaAtualizada.DS_TAREFA;
                return _tarefas;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public TarefaDTO ObterTarefa(int ID_TAREFA)
        {
            try
            {
                var tarefa = _tarefas.FirstOrDefault(x => x.ID_TAREFA == ID_TAREFA);
                if (tarefa == null)
                    throw new Exception($"Tarefa {ID_TAREFA} não encontrada");

                return tarefa;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
