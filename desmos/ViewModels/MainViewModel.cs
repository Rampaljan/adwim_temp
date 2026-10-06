using CommunityToolkit.Maui;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using desmos.ViewModels;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView.Maui;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.Painting.Effects;
using Microsoft.Extensions.Logging;
using SkiaSharp;
using SkiaSharp.Views.Maui.Controls.Hosting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using LiveChartsCore;
using LiveChartsCore.Drawing;
using LiveChartsCore.Kernel;
using LiveChartsCore.Kernel.Events;
using LiveChartsCore.Measure;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Drawing;
using LiveChartsCore.SkiaSharpView.Drawing.Geometries;
using LiveChartsCore.SkiaSharpView.VisualElements;
using LiveChartsCore.VisualElements;


namespace desmos.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        string a_param;
        [ObservableProperty]
        string b_param;
        [ObservableProperty]
        string c_param;

        [ObservableProperty]
        string scale;

        [RelayCommand]
        public async Task resetuj()
        {
            await Shell.Current.DisplayAlert(a_param, b_param, c_param);
        }



        public QuadraticPlotDriver QuadraticPlot { get; } // <-- Adapter do obsługi wykresu

        public MainViewModel()
        {
            QuadraticPlot = new QuadraticPlotDriver(0.1, -10, 10);
        }




        //[ObservableProperty]
        //string pole;
        //[ObservableProperty]
        //string odpowiedz;

        //[RelayCommand]
        //public async Task dupa()
        //{
        //    await Shell.Current.DisplayAlert("dupa", odpowiedz, "ok");
        //    Odpowiedz = Pole;
        //}


    }

    public partial class QuadraticPlotDriver : ObservableObject
    {
        ObservablePoint[] Roots;
        ObservablePoint[] QuadraticPoints;
        ObservablePoint[] DerivativePoints;
        Axis QuadraticXAxis;



        public QuadraticPlotDriver(double resolution, double min, double max)
        {
            var pointsCount = (int)((max - min) / resolution) + 1;
            Roots = [new(), new()];
            QuadraticPoints = new ObservablePoint[pointsCount];
            DerivativePoints = new ObservablePoint[pointsCount];

            for (var i = 0; i < QuadraticPoints.Length; i++)
            {
                QuadraticPoints[i] = new(i * resolution + min, null);
                DerivativePoints[i] = new(i * resolution + min, null);
            }

            // Inicjalizacja osi X i Y dla wykresu funkcji kwadratowej
            QuadraticXAxis = new Axis()
            {
                MaxLimit = 10,
                MinLimit = -10,
                MinStep = 1,
                Name = "X",
                NamePaint = new SolidColorPaint(SKColor.Parse("#000000")),
                SeparatorsPaint = new SolidColorPaint(SKColor.Parse("#C8C8C8"))
                {
                    StrokeThickness = 1,
                    PathEffect = new DashEffect(new float[] { 5, 5 })
                }
            };

            // [...]

            // Obsługa zoomu na wykresie
            //QuadraticYAxis.PropertyChanged += AXisPropertyChanged;
            //QuadraticXAxis.PropertyChanged += AXisPropertyChanged;

            // [...]

            //YAxes = [QuadraticYAxis];
            //XAxes = [QuadraticXAxis];
        }

    }
}
