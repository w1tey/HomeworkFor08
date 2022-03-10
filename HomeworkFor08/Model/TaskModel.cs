using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkFor08.Model
{
    public class TaskModel
    {
        private string Description;

        public string MyProperty
        {
            get { return Description; }
            set { Description = value; }
        }

        private bool isFinished;

        public bool IsFinished
        {
            get { return isFinished; }
            set { isFinished = value; }
        }



        public TaskModel(string _Description)
        {
            Description = _Description;
            isFinished = false;
        }
    }
}
