using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GridAlignmentPage
{
    partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Grid grid = new Grid
            {
                RowSpacing = 0,
                ColumnSpacing = 0,
                RowDefinitions =
 {
 new RowDefinition(),
 new RowDefinition(),
 new RowDefinition()
 },
                ColumnDefinitions =
 {
 new ColumnDefinition(),
 new ColumnDefinition(),
 new ColumnDefinition()
 }
            };
            // Row 0
            grid.Children.Add(new BoxView
            {
                Color = Color.Red
            });
            grid.Children.Add(new Label
            {
                Text = "Каждый",
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Start
            });
            grid.Children.Add(new BoxView
            {
                Color = Color.Orange
            }, 1, 0);
            grid.Children.Add(new Label
            {
                Text = "Охотник",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Start
            }, 1, 0);
            grid.Children.Add(new BoxView
            {
                Color = Color.Yellow
            }, 2, 0);
            grid.Children.Add(new Label
            {
                Text = "Желает",
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.Start
            }, 2, 0);
            // Row 1
            grid.Children.Add(new BoxView
            {
                Color = Color.Green
            }, 0, 1);
            grid.Children.Add(new Label
            {
                Text = "Знать",
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Center
            }, 0, 1);
            grid.Children.Add(new BoxView
            {
                Color = Color.RoyalBlue
            }, 1, 1);
            grid.Children.Add(new Label
            {
                Text = "Где",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            }, 1, 1);
            grid.Children.Add(new BoxView
            {
                Color = Color.Blue
            }, 2, 1);
            grid.Children.Add(new Label
            {
                Text = "Сидит",
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.Center
            }, 2, 1);
            // Row 2
            grid.Children.Add(new BoxView
            {
                Color = Color.Purple
            }, 0, 2);
            grid.Children.Add(new Label
            {
                Text = "Фазан",
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.End
            }, 0, 2);
            grid.Children.Add(new BoxView
            {
                Color = Color.Aqua
            }, 1, 2);
            grid.Children.Add(new Label
            {
                Text = "Вот",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.End
            }, 1, 2);
            grid.Children.Add(new BoxView
            {
                Color = Color.Coral
            }, 2, 2);
            grid.Children.Add(new Label
            {
                Text = "Так",
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.End
            }, 2, 2);
            Title = "Grid alignment demo";
            Content = grid;
        }
    }

}
