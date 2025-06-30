using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class ToDoList
    {
        public string Task { get; set; }
        public string Priority { get; set; }

        ArrayList todoarrylist = new ArrayList();

        //adding
        internal void AddTask(string userTask, string userPriority)
        {
            todoarrylist.Add(new ToDoList { Task = userTask, Priority = userPriority });
        }

        //display
        internal ArrayList DisplayToDoList()
        {
            return todoarrylist;
        }

        //delete

        internal void RemoveTask(string userTask)
        {
            foreach(ToDoList item in todoarrylist)
            {
                if(item.Task == userTask)
                {
                    todoarrylist.Remove(userTask);
                }
            }
        }
    }
    class TodoList_Al
    {
        static void Main()
        {
            
            ToDoList toDoList = new ToDoList();
            int ch;
            do
            {


                Console.WriteLine("Enter your choice 1. Add 2. display 3.delete");
                 ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                    {
                    case 1:
                        toDoList.AddTask("Meeting 1", "1");
                        toDoList.AddTask("Training", "2");
                        toDoList.AddTask("Meeting 2", "3");
                        Console.WriteLine("Data Added Successfully");
                        break;

                    case 2:
                       ArrayList listelement = toDoList.DisplayToDoList();

                        foreach(ToDoList item in listelement)
                        {
                            Console.WriteLine(item.Task +" "+ item.Priority);
                        }


                        break;

                    case 3:
                        toDoList.RemoveTask("Training");
                        Console.WriteLine("Element Deleted Successfully!!");
                        break;

                    default:
                        break;
                    }

            } while (ch <= 3);
        }
    }
}
