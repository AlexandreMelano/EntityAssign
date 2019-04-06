using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleDealership
{
    public partial class ViewVehicleForm : Form
    {
        public ViewVehicleForm()
        {
            InitializeComponent();
        }

        private void MakeNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void makeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.makeBindingSource.EndEdit();
             

        }

        private void ViewVehicleForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vehiclesDataSet1.VehicleType' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'vehiclesDataSet1.Vehicle' table. You can move, or remove it, as needed.
            this.vehicleTableAdapter.Fill(this.vehiclesDataSet1.Vehicle);
            // TODO: This line of code loads data into the 'vehiclesDataSet1.Model' table. You can move, or remove it, as needed.
            this.modelTableAdapter.Fill(this.vehiclesDataSet1.Model);
            // TODO: This line of code loads data into the 'vehiclesDataSet1.Make' table. You can move, or remove it, as needed.
            this.makeTableAdapter.Fill(this.vehiclesDataSet1.Make);
            // TODO: This line of code loads data into the 'vehiclesDataSet1.Model' table. You can move, or remove it, as needed.
            this.modelTableAdapter.Fill(this.vehiclesDataSet1.Model);
            // TODO: This line of code loads data into the 'vehiclesDataSet1.Make' table. You can move, or remove it, as needed.
             
            // TODO: This line of code loads data into the 'vehiclesDataSet.Make' table. You can move, or remove it, as needed.
           

        }

        private void makeBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.makeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vehiclesDataSet1);

        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {

           
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {

            /*VehiclesEntities1 crm = new VehiclesEntities1();
            crm.Vehicles.Add(vehicle);
            crm.Models.Add(model);
            crm.Makes.Add(make);
            crm.VehicleTypes.Add(vehicleType);
            crm.SaveChanges();*/
            VehiclesEntities1 crm = new VehiclesEntities1();
            string hello = "hi";
            
            using (var context = new VehiclesEntities1())
            {
                Vehicle std = context.Vehicles.First<Vehicle>();
                //std.Make = nameTextBox.Text           
                    context.SaveChanges();
            }
        }
    }
}
