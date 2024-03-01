namespace Managarr.Server.Types
{
    public class Queue
    {
        public int id { get; set; }
        public QueueType type { get; set; }
        public bool completed { get; set; }

        public Queue() { }

        public Queue(int id, QueueType type, bool completed)
        {
            this.id = id;
            this.type = type;
            this.completed = completed;
        }
    }
}
