using Microsoft.Maui.Controls;
using System;
using FleetMonitoring.Models;

namespace FleetMonitoring.ViewModels;

public partial class AddRecordPage : ContentPage
{
    public AddRecordPage()
    {
        InitializeComponent();
    }

    

        private async void SaveRecordBtn_Clicked(object sender, EventArgs e)
        {
            var id = DriverInput.Text;
            var date = DateInput.Date;
            var roadDriven = TripInput.Text;
            //var startTime = new DateTime(date.Year, date.Month, date.Day, StartTimeInput.Time.Hours, StartTimeInput.Time.Minutes, 0);
            //var endTime = new DateTime(date.Year, date.Month, date.Day, EndTimeInput.Time.Hours, EndTimeInput.Time.Minutes, 0);

            using (var context = new RecordContext())
            {
                var record = new Record()
                {
                    TripDate = date,
                    TripLength = roadDriven
                };

                context.Records.Add(record);
                context.SaveChanges();
            }

            await DisplayAlert("Success", "Record has been added successfully.", "OK");
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("///dashboard");
        }
    }
