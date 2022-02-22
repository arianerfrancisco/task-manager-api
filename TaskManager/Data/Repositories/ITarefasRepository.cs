using TaskManager.Models;

namespace TaskManager.Data.Repositories;

public interface ITarefasRepository
// primeiro cria-se a abstração/especificação com a Interface e depois implementa
// com a classe
{
    void Adicionar(Tarefa tarefa);
    void Atualizar(String id, Tarefa tarefaAtualizada);

    IEnumerable<Tarefa> Buscar();
    Tarefa Buscar(string id);
}