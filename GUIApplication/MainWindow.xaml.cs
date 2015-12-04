using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using GUIApplication.UserServiceReference;
using User = GUIApplication.UserServiceReference.User;
using GUIApplication.SellerServiceReference;
using Seller = GUIApplication.SellerServiceReference.Seller;
using GUIApplication.BuyerServiceReference;
using Buyer = GUIApplication.BuyerServiceReference.Buyer;
using GUIApplication.AppointmentServiceReference;
using Appointment = GUIApplication.UserServiceReference.Appointment;

namespace GUIApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static IUserService iUser = new UserServiceClient();
        static ISellerService iSeller = new SellerServiceClient();
        static IBuyerService iBuyer = new BuyerServiceClient();
        static IAppointmentService iAppointment = new AppointmentServiceClient();
        private User currentUser;

        public MainWindow(User user)
        {
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            currentUser = user;
            InitializeComponent();
            txtUser.Text = currentUser.Name + ", " + DateTime.Today.Day + "/" + DateTime.Today.Month + "-" + DateTime.Today.Year;
        }

        private void sellerData_Loaded(object sender, RoutedEventArgs e)
        {
            List<Seller> sellers = iSeller.GetAllSellers();
            var grid = sender as DataGrid;
            grid.ItemsSource = sellers;
        }

        //Viser info om en kunde, både fra buyer og seller tab
        private void BtnVisInfo(object sender, RoutedEventArgs e)
        {
            if (buyerTab.IsSelected)
            {
                Buyer buyer = (Buyer)buyerData.SelectedItem;
                MessageBox.Show("KøberID: " + buyer.Id + "\nNavn: " + buyer.Name + "\nAdresse: " + buyer.Address + "\nPostnummer: " + buyer.ZipCode + " By: " + "\nTelefon: " + buyer.Phone + "\nMobil: " + buyer.Mobile + "\nEmail: " + buyer.Email + "\nMisc: " + buyer.Misc);
            }
            else
            {
                Seller seller = (Seller)sellerData.SelectedItem;
                MessageBox.Show("SælgerID: " + seller.Id + "\nNavn: " + seller.Name + "\nAdresse: " + seller.Address + "\nPostnummer: " + seller.ZipCode + " By: " + "\nTelefon: " + seller.Phone + "\nMobil: " + seller.Mobile + "\nEmail: " + seller.Email + "\nMisc: " + seller.Misc);
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Print!");
        }

        private void Refresh_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Refresh!");
        }

        //Opret kunde; buyer eller seller
        private void BtnCreateCustomer(object sender, RoutedEventArgs e)
        {
            CreateSeller window = new CreateSeller();
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Topmost = true;
            window.Show();
        }

        private void buyerData_Loaded(object sender, RoutedEventArgs e)
        {
            List<Buyer> buyers = iBuyer.GetAllBuyers().ToList();
            var grid = sender as DataGrid;
            grid.ItemsSource = buyers;
        }

        private void BtnUpdateCustomer(object sender, RoutedEventArgs e)
        {
            UpdateCustomer window = new UpdateCustomer();
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Topmost = true;
            window.Show();
        }

        private void BtnCreateAppointment(object sender, RoutedEventArgs e)
        {
            CreateAppointment window = new CreateAppointment();
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.Topmost = true;
            window.Show();
        }

        private void calendar_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            DateTime date = calendar.SelectedDate.Value;
            List<Appointment> appointments = currentUser.Appointments.ToList();
            List<Appointment> appointmentsToShow = new List<Appointment>();
            foreach (Appointment ap in appointments)
            {
                if (ap.Date == date)
                {
                    appointmentsToShow.Add(ap);
                }
            }
            var grid = appointmentData as DataGrid;
            grid.ItemsSource = appointmentsToShow;
        }

        private void appointmentData_Loaded(object sender, RoutedEventArgs e)
        {
            DateTime date = DateTime.Today;
            List<Appointment> appointments = currentUser.Appointments.ToList();

            List<Appointment> appointmentsToShow = new List<Appointment>();
            foreach (Appointment ap in appointments)
            {
                if (ap.Date >= date)
                {
                    appointmentsToShow.Add(ap);
                }
            }
            var grid = appointmentData as DataGrid;
            grid.ItemsSource = appointmentsToShow;

        }

        private void Button_VisInfo(object sender, RoutedEventArgs e)
        {
            Appointment ap = (Appointment)appointmentData.SelectedItem;
            MessageBox.Show(appointmentInfo());
        }

        private string appointmentInfo()
        {
            Appointment ap = (Appointment)appointmentData.SelectedItem;
            string formatDate = "dd.MM-yy";
            string formatTime = "HH.mm";
            string info = "ID: " + ap.Id + "\nDato: " + ap.Date.ToString(formatDate) + "\tVarighed: " 
                   + ap.StarTime.ToString(formatTime) + " - " + ap.EndTime.ToString(formatTime) + "\nKategori: "
                   + ap.Category + "\nBeskrivelse: " + ap.Description + "\nStatus: " + ap.Status;
            if(ap.Buyer != null)
            {
                info += "\nKunde(køber): " + ap.Buyer.Name;
            }
            else if(ap.Seller != null)
            {
                info += "\nKunde(sælger): " + ap.Seller.Name;
            }
            return info;
        }
    }
}
