using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp10.Models;

namespace WpfApp10.ViewModel
{
    internal partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty] private Car selectedCar;

        [RelayCommand]
        private void GenerateRandomCar()
        {
            string[] marks = { "Kia", "Lada" };
            string[] colors = { "red", "green" };

            Car car = new Car()
            {
                Color = colors[new Random().Next(0, colors.Length)],
                Marka = marks[new Random().Next(0, marks.Length)]
            };
            SelectedCar = car;
        }
    }
}
