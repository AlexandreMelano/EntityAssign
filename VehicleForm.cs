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
    public partial class VehicleForm  : Form 
    {
        public VehicleForm()
        {
            InitializeComponent();
             
        }

        private void Vehicle_Load(object sender, EventArgs e)
        {

        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }
        /**
         * Method to add objects to db
         */
        private void button1_Click(object sender, EventArgs e)
        {
            //create an instance of vehicle
            Vehicle vehicle = new Vehicle()
            {
                
                Year = Convert.ToInt32(yearTextBox.Text),
                Price = Convert.ToInt32(PriceTextBox.Text),
                Cost = Convert.ToInt32(CostTextBox.Text),
                SoldDate = Convert.ToDateTime(SoldDateDateTimePicker.Text)
            };


            //create an instance of Make
            Make make = new Make()
            {
                Name = MakeNameTextBox.Text
            };

            //create an instance of Model
            Model model = new Model()
            {
                 EngineSize = Convert.ToDecimal(EngineSizeTextBox.Text),
                 NumOfDoors = Convert.ToInt32(NumberOfDoorsTextBox.Text),
                 Colour = ColourTextBox.Text
                 
            };

            //create an instance of VehicleType
            VehicleType vehicleType = new VehicleType()
            {
                Name = VehicleTypeNameTextBox.Text
            };

            //adds objects to db
            VehiclesEntities1 crm = new VehiclesEntities1();
            crm.Vehicles.Add(vehicle);
            crm.Models.Add(model);
            crm.Makes.Add(make);
            crm.VehicleTypes.Add(vehicleType);
            crm.SaveChanges();


            //test message to display vehicle added
            if (crm.Vehicles.Any(s => s.Make == vehicle.Make))
            {
                // MessageBox.Show(vehicle.Make.Name + " added");
                MessageBox.Show("new vehicle added");
            }

        }

        /** this on click will open Used Vehicle Form*/
        private void ViewVehiclesButton_Click(object sender, EventArgs e)
        {
            /*VehiclesEntities1 crm = new VehiclesEntities1();
            var topVehicles = crm.Vehicles.Where(s =>
            s.Price > 1000
            ).Take(10).ToList();
            string result = "The top 10 most expensive vehicles are: ";
            foreach (var item in topVehicles)
            {
                result = result + Environment.NewLine + item.Make;
            }

            MessageBox.Show(result);*/

            ViewVehicleForm vehicleForm = new ViewVehicleForm();
            vehicleForm.Show();
        }

    
    }
}
