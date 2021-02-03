namespace database
{
    partial class shipmentCompanyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(shipmentCompanyForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.supplier_button = new System.Windows.Forms.Button();
            this.part_button = new System.Windows.Forms.Button();
            this.shipment_button = new System.Windows.Forms.Button();
            this.Sno_text = new System.Windows.Forms.TextBox();
            this.City_text = new System.Windows.Forms.TextBox();
            this.Status_text = new System.Windows.Forms.TextBox();
            this.Sname_text = new System.Windows.Forms.TextBox();
            this.insert_supplier = new System.Windows.Forms.Button();
            this.insert_part = new System.Windows.Forms.Button();
            this.pname_text = new System.Windows.Forms.TextBox();
            this.color_text = new System.Windows.Forms.TextBox();
            this.weight_text = new System.Windows.Forms.TextBox();
            this.part_pno_text = new System.Windows.Forms.TextBox();
            this.part_city_text = new System.Windows.Forms.TextBox();
            this.ship_pno_text = new System.Windows.Forms.TextBox();
            this.qty_text = new System.Windows.Forms.TextBox();
            this.price_text = new System.Windows.Forms.TextBox();
            this.ship_sno_text = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.display_supplier_lable = new System.Windows.Forms.Label();
            this.pno_to_display_supplier = new System.Windows.Forms.TextBox();
            this.increase_by10 = new System.Windows.Forms.Label();
            this.display_supplier_from_pno = new System.Windows.Forms.Button();
            this.yes_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sno_lable = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.sname_lable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(624, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(458, 440);
            this.dataGridView1.TabIndex = 0;
            // 
            // supplier_button
            // 
            this.supplier_button.BackColor = System.Drawing.Color.ForestGreen;
            this.supplier_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.supplier_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.supplier_button.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplier_button.Location = new System.Drawing.Point(23, 102);
            this.supplier_button.Name = "supplier_button";
            this.supplier_button.Size = new System.Drawing.Size(95, 40);
            this.supplier_button.TabIndex = 1;
            this.supplier_button.Text = "SUPPLIERS";
            this.supplier_button.UseVisualStyleBackColor = false;
            this.supplier_button.Click += new System.EventHandler(this.supplier_button_Click);
            // 
            // part_button
            // 
            this.part_button.BackColor = System.Drawing.Color.ForestGreen;
            this.part_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.part_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.part_button.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.part_button.Location = new System.Drawing.Point(23, 220);
            this.part_button.Name = "part_button";
            this.part_button.Size = new System.Drawing.Size(95, 41);
            this.part_button.TabIndex = 2;
            this.part_button.Text = "PARTS";
            this.part_button.UseVisualStyleBackColor = false;
            this.part_button.Click += new System.EventHandler(this.part_button_Click);
            // 
            // shipment_button
            // 
            this.shipment_button.BackColor = System.Drawing.Color.ForestGreen;
            this.shipment_button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.shipment_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.shipment_button.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipment_button.Location = new System.Drawing.Point(23, 350);
            this.shipment_button.Name = "shipment_button";
            this.shipment_button.Size = new System.Drawing.Size(95, 42);
            this.shipment_button.TabIndex = 3;
            this.shipment_button.Text = "SHIPMENT";
            this.shipment_button.UseVisualStyleBackColor = false;
            this.shipment_button.Click += new System.EventHandler(this.shipment_button_Click);
            // 
            // Sno_text
            // 
            this.Sno_text.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sno_text.ForeColor = System.Drawing.Color.DarkGreen;
            this.Sno_text.Location = new System.Drawing.Point(23, 176);
            this.Sno_text.Name = "Sno_text";
            this.Sno_text.Size = new System.Drawing.Size(73, 22);
            this.Sno_text.TabIndex = 4;
            this.Sno_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Sno_text.TextChanged += new System.EventHandler(this.Sno_text_TextChanged);
            // 
            // City_text
            // 
            this.City_text.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City_text.ForeColor = System.Drawing.Color.DarkGreen;
            this.City_text.Location = new System.Drawing.Point(260, 176);
            this.City_text.Name = "City_text";
            this.City_text.Size = new System.Drawing.Size(73, 22);
            this.City_text.TabIndex = 5;
            this.City_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Status_text
            // 
            this.Status_text.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_text.ForeColor = System.Drawing.Color.DarkGreen;
            this.Status_text.Location = new System.Drawing.Point(181, 176);
            this.Status_text.Name = "Status_text";
            this.Status_text.Size = new System.Drawing.Size(73, 22);
            this.Status_text.TabIndex = 6;
            this.Status_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Sname_text
            // 
            this.Sname_text.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sname_text.ForeColor = System.Drawing.Color.DarkGreen;
            this.Sname_text.Location = new System.Drawing.Point(102, 176);
            this.Sname_text.Name = "Sname_text";
            this.Sname_text.Size = new System.Drawing.Size(73, 22);
            this.Sname_text.TabIndex = 7;
            this.Sname_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // insert_supplier
            // 
            this.insert_supplier.BackColor = System.Drawing.Color.MediumAquamarine;
            this.insert_supplier.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_supplier.ForeColor = System.Drawing.Color.DarkGreen;
            this.insert_supplier.Location = new System.Drawing.Point(506, 161);
            this.insert_supplier.Name = "insert_supplier";
            this.insert_supplier.Size = new System.Drawing.Size(93, 48);
            this.insert_supplier.TabIndex = 8;
            this.insert_supplier.Text = "Insert into Supplier";
            this.insert_supplier.UseVisualStyleBackColor = false;
            this.insert_supplier.Click += new System.EventHandler(this.insert_supplier_Click);
            // 
            // insert_part
            // 
            this.insert_part.BackColor = System.Drawing.Color.MediumAquamarine;
            this.insert_part.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_part.ForeColor = System.Drawing.Color.DarkGreen;
            this.insert_part.Location = new System.Drawing.Point(506, 302);
            this.insert_part.Name = "insert_part";
            this.insert_part.Size = new System.Drawing.Size(93, 47);
            this.insert_part.TabIndex = 13;
            this.insert_part.Text = "Insert into Part";
            this.insert_part.UseVisualStyleBackColor = false;
            this.insert_part.Click += new System.EventHandler(this.insert_part_Click);
            // 
            // pname_text
            // 
            this.pname_text.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pname_text.ForeColor = System.Drawing.Color.DarkGreen;
            this.pname_text.Location = new System.Drawing.Point(102, 302);
            this.pname_text.Name = "pname_text";
            this.pname_text.Size = new System.Drawing.Size(73, 22);
            this.pname_text.TabIndex = 12;
            this.pname_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // color_text
            // 
            this.color_text.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color_text.ForeColor = System.Drawing.Color.DarkGreen;
            this.color_text.Location = new System.Drawing.Point(181, 302);
            this.color_text.Name = "color_text";
            this.color_text.Size = new System.Drawing.Size(73, 22);
            this.color_text.TabIndex = 11;
            this.color_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // weight_text
            // 
            this.weight_text.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_text.ForeColor = System.Drawing.Color.DarkGreen;
            this.weight_text.Location = new System.Drawing.Point(260, 302);
            this.weight_text.Name = "weight_text";
            this.weight_text.Size = new System.Drawing.Size(73, 22);
            this.weight_text.TabIndex = 10;
            this.weight_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // part_pno_text
            // 
            this.part_pno_text.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.part_pno_text.ForeColor = System.Drawing.Color.DarkGreen;
            this.part_pno_text.Location = new System.Drawing.Point(23, 302);
            this.part_pno_text.Name = "part_pno_text";
            this.part_pno_text.Size = new System.Drawing.Size(73, 22);
            this.part_pno_text.TabIndex = 9;
            this.part_pno_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // part_city_text
            // 
            this.part_city_text.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.part_city_text.ForeColor = System.Drawing.Color.DarkGreen;
            this.part_city_text.Location = new System.Drawing.Point(339, 302);
            this.part_city_text.Name = "part_city_text";
            this.part_city_text.Size = new System.Drawing.Size(73, 22);
            this.part_city_text.TabIndex = 14;
            this.part_city_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ship_pno_text
            // 
            this.ship_pno_text.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ship_pno_text.ForeColor = System.Drawing.Color.DarkGreen;
            this.ship_pno_text.Location = new System.Drawing.Point(102, 431);
            this.ship_pno_text.Name = "ship_pno_text";
            this.ship_pno_text.Size = new System.Drawing.Size(73, 22);
            this.ship_pno_text.TabIndex = 18;
            this.ship_pno_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // qty_text
            // 
            this.qty_text.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty_text.ForeColor = System.Drawing.Color.DarkGreen;
            this.qty_text.Location = new System.Drawing.Point(181, 431);
            this.qty_text.Name = "qty_text";
            this.qty_text.Size = new System.Drawing.Size(73, 22);
            this.qty_text.TabIndex = 17;
            this.qty_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // price_text
            // 
            this.price_text.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_text.ForeColor = System.Drawing.Color.DarkGreen;
            this.price_text.Location = new System.Drawing.Point(260, 431);
            this.price_text.Name = "price_text";
            this.price_text.Size = new System.Drawing.Size(73, 22);
            this.price_text.TabIndex = 16;
            this.price_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ship_sno_text
            // 
            this.ship_sno_text.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ship_sno_text.ForeColor = System.Drawing.Color.DarkGreen;
            this.ship_sno_text.Location = new System.Drawing.Point(23, 431);
            this.ship_sno_text.Name = "ship_sno_text";
            this.ship_sno_text.Size = new System.Drawing.Size(73, 22);
            this.ship_sno_text.TabIndex = 15;
            this.ship_sno_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkGreen;
            this.button1.Location = new System.Drawing.Point(506, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 47);
            this.button1.TabIndex = 19;
            this.button1.Text = "Insert into Shipment";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // display_supplier_lable
            // 
            this.display_supplier_lable.AutoSize = true;
            this.display_supplier_lable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.display_supplier_lable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.display_supplier_lable.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_supplier_lable.ForeColor = System.Drawing.Color.SeaGreen;
            this.display_supplier_lable.Location = new System.Drawing.Point(23, 526);
            this.display_supplier_lable.Name = "display_supplier_lable";
            this.display_supplier_lable.Size = new System.Drawing.Size(381, 18);
            this.display_supplier_lable.TabIndex = 20;
            this.display_supplier_lable.Text = "Please insert a Part Number to display who supplies it:";
            // 
            // pno_to_display_supplier
            // 
            this.pno_to_display_supplier.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pno_to_display_supplier.ForeColor = System.Drawing.Color.DarkGreen;
            this.pno_to_display_supplier.Location = new System.Drawing.Point(410, 525);
            this.pno_to_display_supplier.Name = "pno_to_display_supplier";
            this.pno_to_display_supplier.Size = new System.Drawing.Size(73, 22);
            this.pno_to_display_supplier.TabIndex = 21;
            this.pno_to_display_supplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pno_to_display_supplier.TextChanged += new System.EventHandler(this.pno_to_display_supplier_TextChanged);
            // 
            // increase_by10
            // 
            this.increase_by10.AutoSize = true;
            this.increase_by10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.increase_by10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.increase_by10.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increase_by10.ForeColor = System.Drawing.Color.SeaGreen;
            this.increase_by10.Location = new System.Drawing.Point(23, 621);
            this.increase_by10.Name = "increase_by10";
            this.increase_by10.Size = new System.Drawing.Size(430, 18);
            this.increase_by10.TabIndex = 22;
            this.increase_by10.Text = "Would you like to increase the status of each supplier by 10%?";
            // 
            // display_supplier_from_pno
            // 
            this.display_supplier_from_pno.BackColor = System.Drawing.Color.MediumAquamarine;
            this.display_supplier_from_pno.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_supplier_from_pno.ForeColor = System.Drawing.Color.DarkGreen;
            this.display_supplier_from_pno.Location = new System.Drawing.Point(506, 511);
            this.display_supplier_from_pno.Name = "display_supplier_from_pno";
            this.display_supplier_from_pno.Size = new System.Drawing.Size(93, 47);
            this.display_supplier_from_pno.TabIndex = 23;
            this.display_supplier_from_pno.Text = "Display Supplier(s)";
            this.display_supplier_from_pno.UseVisualStyleBackColor = false;
            this.display_supplier_from_pno.Click += new System.EventHandler(this.display_supplier_from_pno_Click);
            // 
            // yes_button
            // 
            this.yes_button.BackColor = System.Drawing.Color.LimeGreen;
            this.yes_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.yes_button.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yes_button.Location = new System.Drawing.Point(539, 614);
            this.yes_button.Name = "yes_button";
            this.yes_button.Size = new System.Drawing.Size(60, 33);
            this.yes_button.TabIndex = 24;
            this.yes_button.Text = "Yes";
            this.yes_button.UseVisualStyleBackColor = false;
            this.yes_button.Click += new System.EventHandler(this.yes_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(260, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // sno_lable
            // 
            this.sno_lable.AutoSize = true;
            this.sno_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sno_lable.ForeColor = System.Drawing.Color.SeaGreen;
            this.sno_lable.Location = new System.Drawing.Point(42, 158);
            this.sno_lable.Name = "sno_lable";
            this.sno_lable.Size = new System.Drawing.Size(32, 15);
            this.sno_lable.TabIndex = 27;
            this.sno_lable.Text = "Sno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(281, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(201, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Qty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(120, 413);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 30;
            this.label3.Text = "Pno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SeaGreen;
            this.label4.Location = new System.Drawing.Point(42, 413);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 31;
            this.label4.Text = "Sno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(360, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 32;
            this.label5.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SeaGreen;
            this.label6.Location = new System.Drawing.Point(281, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 15);
            this.label6.TabIndex = 33;
            this.label6.Text = "Weight";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SeaGreen;
            this.label7.Location = new System.Drawing.Point(201, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 34;
            this.label7.Text = "Color";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SeaGreen;
            this.label8.Location = new System.Drawing.Point(120, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 35;
            this.label8.Text = "Pname";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SeaGreen;
            this.label9.Location = new System.Drawing.Point(42, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 15);
            this.label9.TabIndex = 36;
            this.label9.Text = "Pno";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SeaGreen;
            this.label10.Location = new System.Drawing.Point(281, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 15);
            this.label10.TabIndex = 37;
            this.label10.Text = "City";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SeaGreen;
            this.label11.Location = new System.Drawing.Point(201, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 15);
            this.label11.TabIndex = 38;
            this.label11.Text = "Status";
            // 
            // sname_lable
            // 
            this.sname_lable.AutoSize = true;
            this.sname_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sname_lable.ForeColor = System.Drawing.Color.SeaGreen;
            this.sname_lable.Location = new System.Drawing.Point(120, 158);
            this.sname_lable.Name = "sname_lable";
            this.sname_lable.Size = new System.Drawing.Size(52, 15);
            this.sname_lable.TabIndex = 39;
            this.sname_lable.Text = "Sname";
            // 
            // shipmentCompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1094, 690);
            this.Controls.Add(this.sname_lable);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sno_lable);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.yes_button);
            this.Controls.Add(this.display_supplier_from_pno);
            this.Controls.Add(this.increase_by10);
            this.Controls.Add(this.pno_to_display_supplier);
            this.Controls.Add(this.display_supplier_lable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ship_pno_text);
            this.Controls.Add(this.qty_text);
            this.Controls.Add(this.price_text);
            this.Controls.Add(this.ship_sno_text);
            this.Controls.Add(this.part_city_text);
            this.Controls.Add(this.insert_part);
            this.Controls.Add(this.pname_text);
            this.Controls.Add(this.color_text);
            this.Controls.Add(this.weight_text);
            this.Controls.Add(this.part_pno_text);
            this.Controls.Add(this.insert_supplier);
            this.Controls.Add(this.Sname_text);
            this.Controls.Add(this.Status_text);
            this.Controls.Add(this.City_text);
            this.Controls.Add(this.Sno_text);
            this.Controls.Add(this.shipment_button);
            this.Controls.Add(this.part_button);
            this.Controls.Add(this.supplier_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "shipmentCompanyForm";
            this.Text = "Shipment Database";
            this.Load += new System.EventHandler(this.shipmentCompanyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button supplier_button;
        private System.Windows.Forms.Button part_button;
        private System.Windows.Forms.Button shipment_button;
        private System.Windows.Forms.TextBox Sno_text;
        private System.Windows.Forms.TextBox City_text;
        private System.Windows.Forms.TextBox Status_text;
        private System.Windows.Forms.TextBox Sname_text;
        private System.Windows.Forms.Button insert_supplier;
        private System.Windows.Forms.Button insert_part;
        private System.Windows.Forms.TextBox pname_text;
        private System.Windows.Forms.TextBox color_text;
        private System.Windows.Forms.TextBox weight_text;
        private System.Windows.Forms.TextBox part_pno_text;
        private System.Windows.Forms.TextBox part_city_text;
        private System.Windows.Forms.TextBox ship_pno_text;
        private System.Windows.Forms.TextBox qty_text;
        private System.Windows.Forms.TextBox price_text;
        private System.Windows.Forms.TextBox ship_sno_text;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label display_supplier_lable;
        private System.Windows.Forms.TextBox pno_to_display_supplier;
        private System.Windows.Forms.Label increase_by10;
        private System.Windows.Forms.Button display_supplier_from_pno;
        private System.Windows.Forms.Button yes_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label sno_lable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label sname_lable;
    }
}

