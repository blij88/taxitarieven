namespace taxi
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.distance = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.arrival = new System.Windows.Forms.DateTimePicker();
            this.departure = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.distance)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "vertrektijd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "aankomsttijd";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 124);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(193, 120);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // distance
            // 
            this.distance.Location = new System.Drawing.Point(121, 85);
            this.distance.Margin = new System.Windows.Forms.Padding(4);
            this.distance.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(87, 22);
            this.distance.TabIndex = 5;
            this.distance.ValueChanged += new System.EventHandler(this.distance_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "afstand";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(31, 252);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(193, 43);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "bereken tarief";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // arrival
            // 
            this.arrival.CalendarForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.arrival.CustomFormat = "MM/dd HH:mm";
            this.arrival.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.arrival.Location = new System.Drawing.Point(121, 36);
            this.arrival.Margin = new System.Windows.Forms.Padding(4);
            this.arrival.Name = "arrival";
            this.arrival.ShowUpDown = true;
            this.arrival.Size = new System.Drawing.Size(118, 22);
            this.arrival.TabIndex = 8;
            this.arrival.Value = new System.DateTime(2020, 9, 4, 10, 29, 6, 0);
            this.arrival.ValueChanged += new System.EventHandler(this.arrival_ValueChanged);
            // 
            // departure
            // 
            this.departure.CalendarForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.departure.CustomFormat = "MM/dd HH:mm";
            this.departure.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.departure.Location = new System.Drawing.Point(121, 4);
            this.departure.Margin = new System.Windows.Forms.Padding(4);
            this.departure.Name = "departure";
            this.departure.ShowUpDown = true;
            this.departure.Size = new System.Drawing.Size(118, 22);
            this.departure.TabIndex = 9;
            this.departure.Value = new System.DateTime(2020, 9, 4, 10, 29, 17, 0);
            this.departure.ValueChanged += new System.EventHandler(this.departure_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 308);
            this.Controls.Add(this.departure);
            this.Controls.Add(this.arrival);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.distance);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "tarief berekenen";
            ((System.ComponentModel.ISupportInitialize)(this.distance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown distance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.DateTimePicker arrival;
        private System.Windows.Forms.DateTimePicker departure;
    }
}

