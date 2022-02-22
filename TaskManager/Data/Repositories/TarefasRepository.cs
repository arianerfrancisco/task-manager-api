using TaskManager.Models;

namespace TaskManager.Data.Repositories;

public class TarefasRepository : ITarefasRepository
{
    public void Adicionar(Tarefa tarefa)
    {

    }

    public void Atualizar(String id, Tarefa tarefaAtualizada)
    {

    }

    public IEnumerable<Tarefa> Buscar()
    {
        return new List<Tarefa>();
    }

    public Tarefa Buscar(string id)
    {
        return new Tarefa("teste", "teste");
    }
}
