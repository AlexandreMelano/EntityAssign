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
            this.vehicleTypeTableAdapter.Fill(this.vehiclesDataSet1.VehicleType);
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
            //ViewVehicleForm vehicleForm();
            //vehicleForm.Show();
            Form.ActiveForm.Close();
        }


        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.vehicleBindingSource.EndEdit();
                this.makeBindingSource.EndEdit();
                this.modelBindingSource.EndEdit();
                //this.vehiclesDataSet1.AcceptChanges();

                this.vehicleTableAdapter.Update(this.vehiclesDataSet1.Vehicle);
                this.makeTableAdapter.Update(this.vehiclesDataSet1.Make);
                this.modelTableAdapter.Update(this.vehiclesDataSet1.Model);
              

                MessageBox.Show("Vehicle Updated");
            }
            catch(System.Exception ex)
            {
                MessageBox.Show("Update Failed");
            }
        }

       

        private void DeleteButton_Click(object sender, EventArgs e)
        {

            //int makeID = int.Parse(makeIdTextBox1.Text);

            //currently deletes from form but not database
            this.makeBindingSource.RemoveCurrent();
            this.modelBindingSource.RemoveCurrent();
            this.vehicleBindingSource.RemoveCurrent();
            this.vehicleTypeBindingSource.RemoveCurrent();


            this.vehicleTableAdapter.Update(this.vehiclesDataSet1.Vehicle);
            this.makeTableAdapter.Update(this.vehiclesDataSet1.Make);
            this.modelTableAdapter.Update(this.vehiclesDataSet1.Model);

            MessageBox.Show("Vehicle Deleted");
            /*(Make make = new Make()
            {
                Name = nameTextBox.Text
                
            };
            
            //int x = Original;
            //this.vehicleTableAdapter.Delete();
            //this.vehicleTableAdapter.Delete(vehicleId);
            makeTableAdapter.Delete(Original_MakeID,Name);
            this.makeTableAdapter.Fill(this.vehiclesDataSet1.Make);

            this.makeTableAdapter.Delete(Convert.ToInt32(nameTextBox.Text, makeIDTextBox.Text);
            this.vehicleTableAdapter.Delete(Original_Cost, Original_MakeId);
            this.modelTableAdapter.Update(this.vehiclesDataSet1.Model);
            */


        }
    }
}
