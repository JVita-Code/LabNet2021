using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using LabNet2021.Tp4.EF.Data;
using LabNet2021.Tp4.EF.Entities;
using LabNet2021.Tp4.EF.Logic;

namespace LabNet2021.Tp4.EF.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGetAllShippers(object sender, RoutedEventArgs e)
        {
            ShipperRepository shippersLogic = new ShipperRepository();

            ShippersList.ItemsSource = shippersLogic.GetAll();
        }

        private void btnGetAllCustomers(object sender, RoutedEventArgs e)
        {
            CustomersLogic customerslogic = new CustomersLogic();
            CustomersList.ItemsSource = customerslogic.GetAll();
        }

        private void btnSetShipper(object sender, RoutedEventArgs e)
        {
            ShipperRepository shippersLogic = new ShipperRepository();

            try
            {
                //string companyName = txtShipperName.Text;
                //string companyPhone = txtPhone.Text;
                //ShipperLogic.SetShipperDetails(companyName, companyPhone);
                shippersLogic.AddItem(new Shipper
                {
                    CompanyName = txtShipperName.Text,
                    Phone = txtPhone.Text
                });
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: Invalid format input. Please try again!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Company Name or/and Company phone field is/are empty");
            }
            finally
            {
                txtShipperName.Clear();
                txtPhone.Clear();
                ShippersList.ItemsSource = shippersLogic.GetAll();
            }
            
        }

        private void btnDeleteShipper(object sender, RoutedEventArgs e)
        {
            ShipperRepository shipperslogic = new ShipperRepository();
            try
            {
                int ID = int.Parse(txtShipperID.Text);
                shipperslogic.DeleteItem(ID);
                MessageBox.Show("Shipped deleted!");

            }
            catch (ArgumentNullException ex)
            {
                
                MessageBox.Show("Error: Shipper not found!");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("--Please write a valid ID--");
            }
            catch (Exception ex)
            {
                MessageBox.Show("You can only delete recently added shippers");
            }

            finally
            {
                txtShipperID.Clear();
                ShippersList.ItemsSource = shipperslogic.GetAll();
            }           

        }

        private void btnUpdateShipper(object sender, RoutedEventArgs e)
        {

            ShipperRepository shippersLogic = new ShipperRepository();
            try
            {
                
                shippersLogic.UpdateItem(new Shipper
                {
                    CompanyName = B.Text,
                    Phone = A.Text,                    
                    ShipperID = int.Parse(cmdShippers.SelectedValue.ToString())
                });

                MessageBox.Show("Shipper info updated.");
                ShippersList.ItemsSource = shippersLogic.GetAll();
                
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Please select a Shipper from the list");

            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input format.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Company Name or/and Company phone field is/are empty");
            }
            finally
            {
                B.Clear();
                A.Clear();                
            }
        }

        private void btnExit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ShipperRepository shippersLogic = new ShipperRepository();
            List<Shipper> shipper = shippersLogic.GetAll();
            cmdShippers.ItemsSource = shipper;
            cmdShippers.SelectedValuePath = "ShipperID";
            cmdShippers.DisplayMemberPath = "CompanyName";
        }

        private void ComboBox_DropDownOpened(object sender, EventArgs e)
        {
            ShipperRepository shippersLogic = new ShipperRepository();
            cmdShippers.ItemsSource = shippersLogic.GetAll();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
