using GalaSoft.MvvmLight.Command;
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
    public class TaskViewModel : ViewModelBase
    {
        List<TaskModel> Tasks = new();
        string description = "";


        private RelayCommand? addCommand;
        public RelayCommand? AddCommand
        {
            get => addCommand ??= new RelayCommand(
                () =>
                {
                    Tasks.Add(new TaskModel(description));
                });
        }


        private RelayCommand deleteCommand;
        public RelayCommand DeleteCommand
        {
            get => addCommand ??= new RelayCommand(
                () =>
                {
                   //chosen one shoujld be deleted
                });
        }

        private RelayCommand finishCommand;
        public RelayCommand FinishCommand
        {
            get => addCommand ??= new RelayCommand(
                () =>
                {
                    //chosen one should be deleted
                });
        }
    }
}
