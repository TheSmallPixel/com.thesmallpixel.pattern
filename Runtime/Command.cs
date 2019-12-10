using System.Collections.Generic;

namespace DesignPatterns.CommandPattern
{
    public class CommandList
    {
        private List<Command> items = new List<Command>();

        public void Push(Command item)
        {
            items.Add((Command)item);
        }
        public Command Pop()
        {
            if (items.Count > 0)
            {
                Command temp = items[items.Count - 1];
                items.RemoveAt(items.Count - 1);
                return temp;
            }
            else
            {
                return null;
            }
        }
        public void Remove(int itemAtPosition)
        {
            items.RemoveAt(itemAtPosition);
        }
    }
    public abstract class Command
    {
        private object ObjectData;

        public Command(object data)
        {
            this.ObjectData = data;
        }
        public T GetData<T>()
        {
            return (T)ObjectData;
        }
        public Command Undo()
        {
            CommandUndo();
            return this;

        }
        public Command Do()
        {
            CommandDo();
            return this;

        }
        protected abstract void CommandUndo();

        protected abstract void CommandDo();
    }

}