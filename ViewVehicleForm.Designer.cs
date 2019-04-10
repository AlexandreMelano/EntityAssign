namespace VehicleDealership
{
    partial class ViewVehicleForm
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label makeIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label modelIdLabel;
            System.Windows.Forms.Label engineSizeLabel1;
            System.Windows.Forms.Label numOfDoorsLabel;
            System.Windows.Forms.Label colourLabel1;
            System.Windows.Forms.Label vehicleIdLabel;
            System.Windows.Forms.Label yearLabel1;
            System.Windows.Forms.Label priceLabel1;
            System.Windows.Forms.Label costLabel1;
            System.Windows.Forms.Label soldDateLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewVehicleForm));
            this.MakeLabel = new System.Windows.Forms.Label();
            this.VehicleTypeLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.VehicleLabel = new System.Windows.Forms.Label();
            this.vehiclesDataSet1 = new VehicleDealership.VehiclesDataSet1();
            this.makeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.makeTableAdapter = new VehicleDealership.VehiclesDataSet1TableAdapters.MakeTableAdapter();
            this.tableAdapterManager = new VehicleDealership.VehiclesDataSet1TableAdapters.TableAdapterManager();
            this.modelTableAdapter = new VehicleDealership.VehiclesDataSet1TableAdapters.ModelTableAdapter();
            this.vehicleTableAdapter = new VehicleDealership.VehiclesDataSet1TableAdapters.VehicleTableAdapter();
            this.makeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.makeBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.makeIDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelIdTextBox = new System.Windows.Forms.TextBox();
            this.engineSizeTextBox1 = new System.Windows.Forms.TextBox();
            this.numOfDoorsTextBox = new System.Windows.Forms.TextBox();
            this.colourTextBox1 = new System.Windows.Forms.TextBox();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleIdTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox1 = new System.Windows.Forms.TextBox();
            this.priceTextBox1 = new System.Windows.Forms.TextBox();
            this.costTextBox1 = new System.Windows.Forms.TextBox();
            this.soldDateDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.vehicleTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleTypeTableAdapter = new VehicleDealership.VehiclesDataSet1TableAdapters.VehicleTypeTableAdapter();
            this.DeleteButton = new System.Windows.Forms.Button();
            makeIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            modelIdLabel = new System.Windows.Forms.Label();
            engineSizeLabel1 = new System.Windows.Forms.Label();
            numOfDoorsLabel = new System.Windows.Forms.Label();
            colourLabel1 = new System.Windows.Forms.Label();
            vehicleIdLabel = new System.Windows.Forms.Label();
            yearLabel1 = new System.Windows.Forms.Label();
            priceLabel1 = new System.Windows.Forms.Label();
            costLabel1 = new System.Windows.Forms.Label();
            soldDateLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makeBindingNavigator)).BeginInit();
            this.makeBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // makeIDLabel
            // 
            makeIDLabel.AutoSize = true;
            makeIDLabel.Location = new System.Drawing.Point(19, 176);
            makeIDLabel.Name = "makeIDLabel";
            makeIDLabel.Size = new System.Drawing.Size(63, 17);
            makeIDLabel.TabIndex = 25;
            makeIDLabel.Text = "Make ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(19, 204);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(49, 17);
            nameLabel.TabIndex = 27;
            nameLabel.Text = "Name:";
            // 
            // modelIdLabel
            // 
            modelIdLabel.AutoSize = true;
            modelIdLabel.Location = new System.Drawing.Point(320, 166);
            modelIdLabel.Name = "modelIdLabel";
            modelIdLabel.Size = new System.Drawing.Size(65, 17);
            modelIdLabel.TabIndex = 29;
            modelIdLabel.Text = "Model Id:";
            // 
            // engineSizeLabel1
            // 
            engineSizeLabel1.AutoSize = true;
            engineSizeLabel1.Location = new System.Drawing.Point(320, 197);
            engineSizeLabel1.Name = "engineSizeLabel1";
            engineSizeLabel1.Size = new System.Drawing.Size(87, 17);
            engineSizeLabel1.TabIndex = 31;
            engineSizeLabel1.Text = "Engine Size:";
            // 
            // numOfDoorsLabel
            // 
            numOfDoorsLabel.AutoSize = true;
            numOfDoorsLabel.Location = new System.Drawing.Point(320, 225);
            numOfDoorsLabel.Name = "numOfDoorsLabel";
            numOfDoorsLabel.Size = new System.Drawing.Size(102, 17);
            numOfDoorsLabel.TabIndex = 33;
            numOfDoorsLabel.Text = "Num Of Doors:";
            // 
            // colourLabel1
            // 
            colourLabel1.AutoSize = true;
            colourLabel1.Location = new System.Drawing.Point(320, 253);
            colourLabel1.Name = "colourLabel1";
            colourLabel1.Size = new System.Drawing.Size(53, 17);
            colourLabel1.TabIndex = 35;
            colourLabel1.Text = "Colour:";
            // 
            // vehicleIdLabel
            // 
            vehicleIdLabel.AutoSize = true;
            vehicleIdLabel.Location = new System.Drawing.Point(648, 166);
            vehicleIdLabel.Name = "vehicleIdLabel";
            vehicleIdLabel.Size = new System.Drawing.Size(73, 17);
            vehicleIdLabel.TabIndex = 39;
            vehicleIdLabel.Text = "Vehicle Id:";
            // 
            // yearLabel1
            // 
            yearLabel1.AutoSize = true;
            yearLabel1.Location = new System.Drawing.Point(648, 201);
            yearLabel1.Name = "yearLabel1";
            yearLabel1.Size = new System.Drawing.Size(42, 17);
            yearLabel1.TabIndex = 45;
            yearLabel1.Text = "Year:";
            // 
            // priceLabel1
            // 
            priceLabel1.AutoSize = true;
            priceLabel1.Location = new System.Drawing.Point(648, 229);
            priceLabel1.Name = "priceLabel1";
            priceLabel1.Size = new System.Drawing.Size(44, 17);
            priceLabel1.TabIndex = 47;
            priceLabel1.Text = "Price:";
            // 
            // costLabel1
            // 
            costLabel1.AutoSize = true;
            costLabel1.Location = new System.Drawing.Point(648, 257);
            costLabel1.Name = "costLabel1";
            costLabel1.Size = new System.Drawing.Size(40, 17);
            costLabel1.TabIndex = 49;
            costLabel1.Text = "Cost:";
            // 
            // soldDateLabel1
            // 
            soldDateLabel1.AutoSize = true;
            soldDateLabel1.Location = new System.Drawing.Point(648, 286);
            soldDateLabel1.Name = "soldDateLabel1";
            soldDateLabel1.Size = new System.Drawing.Size(74, 17);
            soldDateLabel1.TabIndex = 51;
            soldDateLabel1.Text = "Sold Date:";
            // 
            // MakeLabel
            // 
            this.MakeLabel.AutoSize = true;
            this.MakeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeLabel.Location = new System.Drawing.Point(21, 103);
            this.MakeLabel.Name = "MakeLabel";
            this.MakeLabel.Size = new System.Drawing.Size(61, 25);
            this.MakeLabel.TabIndex = 3;
            this.MakeLabel.Text = "Make";
            // 
            // VehicleTypeLabel
            // 
            this.VehicleTypeLabel.AutoSize = true;
            this.VehicleTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleTypeLabel.Location = new System.Drawing.Point(318, 103);
            this.VehicleTypeLabel.Name = "VehicleTypeLabel";
            this.VehicleTypeLabel.Size = new System.Drawing.Size(127, 25);
            this.VehicleTypeLabel.TabIndex = 5;
            this.VehicleTypeLabel.Text = "Vehicle Type";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(418, 30);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(546, 32);
            this.TitleLabel.TabIndex = 6;
            this.TitleLabel.Text = "Welcome To Our Used Vehicle Dealership";
            // 
            // VehicleLabel
            // 
            this.VehicleLabel.AutoSize = true;
            this.VehicleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehicleLabel.Location = new System.Drawing.Point(644, 103);
            this.VehicleLabel.Name = "VehicleLabel";
            this.VehicleLabel.Size = new System.Drawing.Size(77, 25);
            this.VehicleLabel.TabIndex = 17;
            this.VehicleLabel.Text = "Vehicle";
            // 
            // vehiclesDataSet1
            // 
            this.vehiclesDataSet1.DataSetName = "VehiclesDataSet1";
            this.vehiclesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // makeBindingSource
            // 
            this.makeBindingSource.DataMember = "Make";
            this.makeBindingSource.DataSource = this.vehiclesDataSet1;
            // 
            // makeTableAdapter
            // 
            this.makeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MakeTableAdapter = this.makeTableAdapter;
            this.tableAdapterManager.ModelTableAdapter = this.modelTableAdapter;
            this.tableAdapterManager.UpdateOrder = VehicleDealership.VehiclesDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehicleTableAdapter = this.vehicleTableAdapter;
            this.tableAdapterManager.VehicleTypeTableAdapter = null;
            // 
            // modelTableAdapter
            // 
            this.modelTableAdapter.ClearBeforeFill = true;
            // 
            // vehicleTableAdapter
            // 
            this.vehicleTableAdapter.ClearBeforeFill = true;
            // 
            // makeBindingNavigator
            // 
            this.makeBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.makeBindingNavigator.BindingSource = this.makeBindingSource;
            this.makeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.makeBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.makeBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.makeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.makeBindingNavigatorSaveItem});
            this.makeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.makeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.makeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.makeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.makeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.makeBindingNavigator.Name = "makeBindingNavigator";
            this.makeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.makeBindingNavigator.Size = new System.Drawing.Size(1340, 27);
            this.makeBindingNavigator.TabIndex = 25;
            this.makeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // makeBindingNavigatorSaveItem
            // 
            this.makeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.makeBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("makeBindingNavigatorSaveItem.Image")));
            this.makeBindingNavigatorSaveItem.Name = "makeBindingNavigatorSaveItem";
            this.makeBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.makeBindingNavigatorSaveItem.Text = "Save Data";
            this.makeBindingNavigatorSaveItem.Click += new System.EventHandler(this.makeBindingNavigatorSaveItem_Click_1);
            // 
            // makeIDTextBox
            // 
            this.makeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makeBindingSource, "MakeID", true));
            this.makeIDTextBox.Location = new System.Drawing.Point(88, 173);
            this.makeIDTextBox.Name = "makeIDTextBox";
            this.makeIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.makeIDTextBox.TabIndex = 26;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.makeBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(88, 201);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 28;
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataMember = "Model";
            this.modelBindingSource.DataSource = this.vehiclesDataSet1;
            // 
            // modelIdTextBox
            // 
            this.modelIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelBindingSource, "ModelId", true));
            this.modelIdTextBox.Location = new System.Drawing.Point(435, 166);
            this.modelIdTextBox.Name = "modelIdTextBox";
            this.modelIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.modelIdTextBox.TabIndex = 30;
            // 
            // engineSizeTextBox1
            // 
            this.engineSizeTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelBindingSource, "EngineSize", true));
            this.engineSizeTextBox1.Location = new System.Drawing.Point(435, 194);
            this.engineSizeTextBox1.Name = "engineSizeTextBox1";
            this.engineSizeTextBox1.Size = new System.Drawing.Size(100, 22);
            this.engineSizeTextBox1.TabIndex = 32;
            // 
            // numOfDoorsTextBox
            // 
            this.numOfDoorsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelBindingSource, "NumOfDoors", true));
            this.numOfDoorsTextBox.Location = new System.Drawing.Point(435, 222);
            this.numOfDoorsTextBox.Name = "numOfDoorsTextBox";
            this.numOfDoorsTextBox.Size = new System.Drawing.Size(100, 22);
            this.numOfDoorsTextBox.TabIndex = 34;
            // 
            // colourTextBox1
            // 
            this.colourTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.modelBindingSource, "Colour", true));
            this.colourTextBox1.Location = new System.Drawing.Point(435, 250);
            this.colourTextBox1.Name = "colourTextBox1";
            this.colourTextBox1.Size = new System.Drawing.Size(100, 22);
            this.colourTextBox1.TabIndex = 36;
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataMember = "Vehicle";
            this.vehicleBindingSource.DataSource = this.vehiclesDataSet1;
            // 
            // vehicleIdTextBox
            // 
            this.vehicleIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "VehicleId", true));
            this.vehicleIdTextBox.Location = new System.Drawing.Point(728, 163);
            this.vehicleIdTextBox.Name = "vehicleIdTextBox";
            this.vehicleIdTextBox.Size = new System.Drawing.Size(200, 22);
            this.vehicleIdTextBox.TabIndex = 40;
            // 
            // yearTextBox1
            // 
            this.yearTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Year", true));
            this.yearTextBox1.Location = new System.Drawing.Point(728, 198);
            this.yearTextBox1.Name = "yearTextBox1";
            this.yearTextBox1.Size = new System.Drawing.Size(200, 22);
            this.yearTextBox1.TabIndex = 46;
            // 
            // priceTextBox1
            // 
            this.priceTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Price", true));
            this.priceTextBox1.Location = new System.Drawing.Point(728, 226);
            this.priceTextBox1.Name = "priceTextBox1";
            this.priceTextBox1.Size = new System.Drawing.Size(200, 22);
            this.priceTextBox1.TabIndex = 48;
            // 
            // costTextBox1
            // 
            this.costTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Cost", true));
            this.costTextBox1.Location = new System.Drawing.Point(728, 254);
            this.costTextBox1.Name = "costTextBox1";
            this.costTextBox1.Size = new System.Drawing.Size(200, 22);
            this.costTextBox1.TabIndex = 50;
            // 
            // soldDateDateTimePicker1
            // 
            this.soldDateDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.vehicleBindingSource, "SoldDate", true));
            this.soldDateDateTimePicker1.Location = new System.Drawing.Point(728, 282);
            this.soldDateDateTimePicker1.Name = "soldDateDateTimePicker1";
            this.soldDateDateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.soldDateDateTimePicker1.TabIndex = 52;
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(627, 505);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(130, 23);
            this.GoBackButton.TabIndex = 53;
            this.GoBackButton.Text = "Go Back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(404, 505);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(130, 23);
            this.SaveButton.TabIndex = 54;
            this.SaveButton.Text = "Update Vehicle";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // vehicleTypeBindingSource
            // 
            this.vehicleTypeBindingSource.DataMember = "VehicleType";
            this.vehicleTypeBindingSource.DataSource = this.vehiclesDataSet1;
            // 
            // vehicleTypeTableAdapter
            // 
            this.vehicleTypeTableAdapter.ClearBeforeFill = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(850, 505);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(130, 23);
            this.DeleteButton.TabIndex = 55;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ViewVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 774);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(vehicleIdLabel);
            this.Controls.Add(this.vehicleIdTextBox);
            this.Controls.Add(yearLabel1);
            this.Controls.Add(this.yearTextBox1);
            this.Controls.Add(priceLabel1);
            this.Controls.Add(this.priceTextBox1);
            this.Controls.Add(costLabel1);
            this.Controls.Add(this.costTextBox1);
            this.Controls.Add(soldDateLabel1);
            this.Controls.Add(this.soldDateDateTimePicker1);
            this.Controls.Add(modelIdLabel);
            this.Controls.Add(this.modelIdTextBox);
            this.Controls.Add(engineSizeLabel1);
            this.Controls.Add(this.engineSizeTextBox1);
            this.Controls.Add(numOfDoorsLabel);
            this.Controls.Add(this.numOfDoorsTextBox);
            this.Controls.Add(colourLabel1);
            this.Controls.Add(this.colourTextBox1);
            this.Controls.Add(makeIDLabel);
            this.Controls.Add(this.makeIDTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.makeBindingNavigator);
            this.Controls.Add(this.VehicleLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.VehicleTypeLabel);
            this.Controls.Add(this.MakeLabel);
            this.Name = "ViewVehicleForm";
            this.Text = "Used Vehicles";
            this.Load += new System.EventHandler(this.ViewVehicleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makeBindingNavigator)).EndInit();
            this.makeBindingNavigator.ResumeLayout(false);
            this.makeBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MakeLabel;
        private System.Windows.Forms.Label VehicleTypeLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label VehicleLabel;
        private VehiclesDataSet1 vehiclesDataSet1;
        private System.Windows.Forms.BindingSource makeBindingSource;
        private VehiclesDataSet1TableAdapters.MakeTableAdapter makeTableAdapter;
        private VehiclesDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator makeBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton makeBindingNavigatorSaveItem;
        private VehiclesDataSet1TableAdapters.ModelTableAdapter modelTableAdapter;
        private System.Windows.Forms.TextBox makeIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private VehiclesDataSet1TableAdapters.VehicleTableAdapter vehicleTableAdapter;
        private System.Windows.Forms.TextBox modelIdTextBox;
        private System.Windows.Forms.TextBox engineSizeTextBox1;
        private System.Windows.Forms.TextBox numOfDoorsTextBox;
        private System.Windows.Forms.TextBox colourTextBox1;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private System.Windows.Forms.TextBox vehicleIdTextBox;
        private System.Windows.Forms.TextBox yearTextBox1;
        private System.Windows.Forms.TextBox priceTextBox1;
        private System.Windows.Forms.TextBox costTextBox1;
        private System.Windows.Forms.DateTimePicker soldDateDateTimePicker1;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.BindingSource vehicleTypeBindingSource;
        private VehiclesDataSet1TableAdapters.VehicleTypeTableAdapter vehicleTypeTableAdapter;
        private System.Windows.Forms.Button DeleteButton;
    }
}

