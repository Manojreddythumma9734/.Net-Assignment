using Simple_Task_List_Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Simple_Task_List_Application
{   public class Task
    {
        public String task_title;
        public String task_description;
    }

    internal class Program
    {
        List<Task> tasks = new List<Task>();
        public void run()
        { int input_choice =0 ;
            do
            {
                
                Console.WriteLine("Welcome! This is a Simple Task List Application");
                Console.WriteLine("Below are the features:");
                Console.WriteLine("1. Add a new Task.");
                Console.WriteLine("2. Display the list of Tasks");
                Console.WriteLine("3. Update a task");
                Console.WriteLine("4. Delete a task");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your choice: ");
                try
                {
                    input_choice = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please Enter a Valid Input");
                    continue;
                }
                switch (input_choice)
                {
                    case 1:
                        add_task();
                        break;
                    case 2:
                        display_tasks();
                        break;
                    case 3:
                        update_task();
                        break;
                    case 4:
                        delete_task();
                        break;
                    case 5:
                        Console.WriteLine("Successfully Exited");
                        break;
                    default:
                        Console.WriteLine("Please Enter a Number with in the range");
                        break;

                }
                Console.WriteLine("\n\n");
            }
            while (input_choice != 5);
        }
        void add_task()
        {   
            Task new_task=new Task();
            Console.WriteLine("Enter the task title");
            new_task.task_title = Console.ReadLine();
            Console.WriteLine("Enter the task description");
            new_task.task_description = Console.ReadLine();
            tasks.Add(new_task);
            Console.WriteLine("Task is Successfully added");
        }
        void display_tasks()
        {
            if (tasks.Count() == 0)
            {
                Console.WriteLine("There are no tasks to display");

            }
            else {
                int i = 1;
                foreach ( var Task in tasks)
                {
                    Console.WriteLine($"Task {i} title is :{Task.task_title}");
                    Console.WriteLine($"Task {i} description is :{Task.task_description}");
                    i++;
                }
            }
        }
        
        void update_task()
        {
            int count = 0;
            if (tasks.Count()==0)
            {
                Console.WriteLine("There are no tasks to update");
            }
            else
            {
                Console.WriteLine("Enter the title of the task to update");
                String title_of_task= Console.ReadLine();
                for (int i = 0; i < tasks.Count; i++)
                {
                    if (title_of_task == tasks[i].task_title)
                    {
                        Console.WriteLine("Enter the new title of the task");
                        tasks[i].task_title = Console.ReadLine();
                        Console.WriteLine("Enter the new description of the task");
                        tasks[i].task_description = Console.ReadLine();
                        count++;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("There is no task with the given title");
                }
                else
                {
                    Console.WriteLine("Task is Successfully updated");
                }
            }
        }

        void delete_task()
        {
            int count = 0;
            if (tasks.Count() == 0)
            {
                Console.WriteLine("There are no tasks to delete");
            }
            else
            {
                Console.WriteLine("Enter the title of the task to delete");
                String title_of_task = Console.ReadLine();
                for (int i = 0; i < tasks.Count; i++)
                {
                    if (title_of_task == tasks[i].task_title)
                    {
                        tasks.RemoveAt(i);
                        count++;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("There is no task with the given title");
                }
                else
                {
                    Console.WriteLine("Task is Successfully deleted");
                }
            }
        }
        static void Main(string[] args)
        {
            Program Application = new Program();
            Application.run();
        }
    }
}
