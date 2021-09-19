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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ShipperLogic shippersLogic = new ShipperLogic();

            ShippersList.ItemsSource = shippersLogic.GetAll();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CustomersLogic customerslogic = new CustomersLogic();
            CustomersList.ItemsSource = customerslogic.GetAll();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ShipperLogic shippersLogic = new ShipperLogic();

            try
            {
                string companyName = txtShipperName.Text;
                string companyPhone = txtPhone.Text;
                ShipperLogic.SetShipperDetails(companyName, companyPhone);
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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ShipperLogic shipperslogic = new ShipperLogic();
            try
            {
                int ID = int.Parse(txtShipperID.Text);
                shipperslogic.Delete(ID);
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

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            try
            {
                ShipperLogic shippersLogic = new ShipperLogic();
                shippersLogic.Update(new Shipper
                {
                    CompanyName = B.Text,
                    Phone = A.Text,                    
                    ShipperID = int.Parse(ComboBox.SelectedValue.ToString())
                });

                MessageBox.Show("Shipper info updated.");
                ShippersList.ItemsSource = shippersLogic.GetAll();
                
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Error.");

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

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ShipperLogic shippersLogic = new ShipperLogic();
            List<Shipper> shipper = shippersLogic.GetAll();
            ComboBox.ItemsSource = shipper;
            ComboBox.SelectedValuePath = "ShipperID";
            ComboBox.DisplayMemberPath = "CompanyName";
        }

        private void ComboBox_DropDownOpened(object sender, EventArgs e)
        {
            ShipperLogic shippersLogic = new ShipperLogic();
            ComboBox.ItemsSource = shippersLogic.GetAll();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
