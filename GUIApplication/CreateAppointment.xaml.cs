﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using GUIApplication.UserServiceReference;
using User = GUIApplication.UserServiceReference.User;
using GUIApplication.AppointmentServiceReference;
using Appointment = GUIApplication.AppointmentServiceReference.Appointment;

namespace GUIApplication
{
    /// <summary>
    /// Interaction logic for CreateAppointment.xaml
    /// </summary>
    public partial class CreateAppointment : Window
    {
        static IUserService iUser = new UserServiceClient();
        static IAppointmentService iAppointment = new AppointmentServiceClient();

        public CreateAppointment()
        {
            InitializeComponent();
        }

        private void Button_CreateAppointment(object sender, RoutedEventArgs e)
        {
            Appointment appointment = new Appointment()
            {
                //Buyer =
                //Seller =
                Category = cbCategory.Text,
                Date = Convert.ToDateTime(dpStartDate.Text),
                Description = txtBoxDescription.Text,
                StarTime = tpStartTime.Value.Value,
                EndTime = tpEndTime.Value.Value,
                Status = "I gang"
            };
            iAppointment.InsertAppointment(appointment);
            this.Close();
        }

        private void ComboBox_User(object sender, SelectionChangedEventArgs e)
        {
            cbUser = sender as ComboBox;
        }

        private void cbUser_Loaded(object sender, RoutedEventArgs e)
        {
            List<User> users = iUser.GetAllUsers().ToList();
            cbUser.ItemsSource = users;
            cbUser.DisplayMemberPath = "Name";
        }

        private void cbCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cbCategory = sender as ComboBox;
        }

        private void cbCategory_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> categories = new List<string>();
            categories.Add("Andet");
            categories.Add("ERFA-Møde");
            categories.Add("Eksternt møde");
            categories.Add("Ferie");
            categories.Add("Formidlingsaftalemøde");
            categories.Add("Fremvisning");
            categories.Add("Fri");
            categories.Add("Fritekst");
            categories.Add("HUSK");
            categories.Add("Internt møde");
            categories.Add("Kursus");
            categories.Add("Købermøde");
            categories.Add("Logbog");
            categories.Add("Nordeakredit");
            categories.Add("Opfølgning til sælger");
            categories.Add("Realkreditvurdering");
            categories.Add("Skole");
            categories.Add("Sælgermøde");
            categories.Add("Vurdering");
            categories.Add("Åbent husarrangement");

            cbCategory.ItemsSource = categories;
        }

        //Throws an exception if there is no appointments in the database.
        private void txtSagsnr_Loaded(object sender, RoutedEventArgs e)
        {
            List<Appointment> apps = iAppointment.GetAllAppointments().ToList();
            int sagsnr = apps.LastOrDefault().Id + 1;
            txtSagsnr.Text = sagsnr.ToString();
        }

        private void tpStartTime_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            try
            {
                DateTime time1 = tpStartTime.Value.Value;
                DateTime time2 = tpEndTime.Value.Value;
                TimeSpan span = time2.Subtract(time1);
                if (span.TotalHours >= 0)
                {
                    tpDuration.Text = span.ToString();
                }
                else
                {
                    tpDuration.Text = "00:00:00";
                }
            }
            catch (InvalidOperationException)
            {
                return;
            }
        }

        private void tpEndTime_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            try
            {
                DateTime time1 = tpStartTime.Value.Value;
                DateTime time2 = tpEndTime.Value.Value;
                TimeSpan span = time2.Subtract(time1);
                if (span.TotalHours >= 0)
                {
                    tpDuration.Text = span.ToString();
                }
                else
                {
                    tpDuration.Text = "00:00:00";
                }
            }
            catch (InvalidOperationException)
            {
                return;
            }
        }

        private void cbAlarm_Loaded(object sender, RoutedEventArgs e)
        {
            cbAlarm.Items.Add("Med Alarm");
            cbAlarm.Items.Add("Uden Alarm");
        }

        private void cbType_Loaded(object sender, RoutedEventArgs e)
        {
            cbType.Items.Add("Normal");
        }

        private void Button_Annuller(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void chkbxAllDay_Checked(object sender, RoutedEventArgs e)
        {
            tpStartTime.IsEnabled = false;
            tpEndTime.IsEnabled = false;
            tpDuration.Text = "08:00:00";
        }

        private void chkbxAllDay_Unchecked(object sender, RoutedEventArgs e)
        {
            tpStartTime.IsEnabled = true;
            tpEndTime.IsEnabled = true;
            tpDuration.Text = "00:00:00";
        }

        private void btnSearchProperty_Click(object sender, RoutedEventArgs e)
        {
            Window searchWin = new SearchProperty_Seller(this);
            searchWin.Owner = this;
            searchWin.Show();
        }
        //private void Button_SearchBuyer(object sender, RoutedEventArgs e)
        //{
        //    // open a search window for buyer
        //}
    }
}
