using HomeworkFor08.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HomeworkFor08.ViewModel
{
    public class TaskViewModel /*: INotifyPropertyChanged*/
    {
        List<TaskModel> tasks = new();


        public void addTask(string _description)
        {
            if (_description == null) {
                MessageBox.Show("No description, cannot create a Task."); 
            }

            else
            {
                TaskModel newTask = new TaskModel(_description);
                tasks.Add(newTask);
            }
        }

        public void deleteTask()
        {
           //delete chosen task
        }

        public void finishTask()
        {
           //check chosen task
        }


    }
}
