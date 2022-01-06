namespace ToListBlazor.Model
{
    public class Tarefa
    {
        public string Descricao { get; set; }
        public TimeOnly TempoEstimado { get; set; } = new TimeOnly();


        public static List<Tarefa> Tarefas = new List<Tarefa>();

        public static void AddTarefa(Tarefa tarefa)
        {
            Tarefas.Add(tarefa);
        }

        public static void RemoveTarefa(Tarefa tarefa)
        {
            Tarefas.Remove(tarefa);
        }
    }
}
