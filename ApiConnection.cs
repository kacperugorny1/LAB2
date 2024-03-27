using ScottPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LAB2
{
    public class ApiConnection : Form
    {
        private HttpClient _httpClient;
        private JsonFull? root;
        private ComboBox comboBox1;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private ScottPlot.Plot plot;
        private WeatherDbContext weatherDbContext;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Button button1;
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(46, 49);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(246, 339);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(46, 394);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Download";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(146, 395);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(146, 28);
            comboBox1.TabIndex = 2;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1.25F;
            formsPlot1.Location = new Point(313, 15);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(818, 373);
            formsPlot1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(898, 395);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Draw";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(52, 15);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 5;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(46, 429);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 6;
            button4.Text = "Load";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(146, 429);
            button5.Name = "button5";
            button5.Size = new Size(146, 29);
            button5.TabIndex = 7;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(998, 395);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 8;
            button6.Text = "Plot clear";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(46, 479);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 9;
            button7.Text = "Add City";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(146, 479);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(377, 479);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(94, 27);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(277, 479);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(94, 27);
            textBox4.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 461);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 13;
            label1.Text = "City";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 461);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 14;
            label2.Text = "Latitude";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(377, 461);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 15;
            label3.Text = "Longitude";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(216, 26);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 16;
            label4.Text = "Raw data";
            // 
            // ApiConnection
            // 
            ClientSize = new Size(1128, 553);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(formsPlot1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "ApiConnection";
            ResumeLayout(false);
            PerformLayout();
        }

        public ApiConnection()
        {
            weatherDbContext = new();
            InitializeComponent();
            plot = formsPlot1.Plot;
            plot.Axes.DateTimeTicksBottom();
            foreach (var loc in weatherDbContext.Cities)
            {
                comboBox1.Items.Add(loc.Name);
            }
            _httpClient = new HttpClient();
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "") return;
            try
            {
                textBox1.Text = "";
                string call = $"https://api.open-meteo.com/v1/forecast?latitude={weatherDbContext.Cities?.ToList().Find(u => u.Name == comboBox1.Text).Latitude.ToString().Replace(',', '.')}&longitude={weatherDbContext.Cities?.ToList().Find(u => u.Name == comboBox1.Text).Longitude.ToString().Replace(',', '.')}&hourly=temperature_2m&forecast_days=1&past_days=7";
                string response = await _httpClient.GetStringAsync(call);
                root = JsonSerializer.Deserialize<JsonFull>(response);
                if (root == null) return;
                List<Weather> weatherList = root.ToWeather(comboBox1.Text).ToList();
                foreach (Weather weather in weatherList)
                {
                    textBox1.Text += weather.ToString().Replace("\n", Environment.NewLine);
                    if (!weatherDbContext.Weathers.Any(u => u.DateTime == weather.DateTime && u.City == weather.City))
                        weatherDbContext.Weathers.Add(weather);
                }
                weatherDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                textBox1.Text = ex.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
                return;
            string city_name = comboBox1.Text;
            List<double> temps = new();
            List<DateTime> time = new();
            foreach (var weather in weatherDbContext.Weathers.Where(u => u.City == city_name))
            {
                temps.Add(weather.Temperature);
                time.Add(weather.DateTime);
            }
            //plot.Add.Scatter<double, double>(new List<double>(){ 10.0,15.0}, new List<double>() { 15.0,30.0});

            plot.Add.Scatter<DateTime, double>(time, temps);
            plot.Axes.AutoScale();
            formsPlot1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            foreach (var weather in weatherDbContext.Weathers.Where(u => u.City == comboBox1.Text))
            {
                textBox1.Text += weather.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string name = comboBox1.Text;
            if (name == "") return;
            foreach (var x in weatherDbContext.Weathers.Where(u => u.City == name))
            {
                weatherDbContext.Remove(x);
            }
            weatherDbContext.Cities.Remove(weatherDbContext.Cities.Where(u => u.Name == name).First());
            weatherDbContext.SaveChanges();
            comboBox1.Items.Clear();
            foreach (var loc in weatherDbContext.Cities)
            {
                comboBox1.Items.Add(loc.Name);
            }
            comboBox1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            plot.Clear();
            formsPlot1.Refresh();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = "";
                string name = textBox2.Text;
                double latitude = Convert.ToDouble(textBox4.Text.Replace('.', ','));
                double longitude = Convert.ToDouble(textBox3.Text.Replace('.', ','));
                if (name == "") throw new Exception("No name");
                if (weatherDbContext.Cities.Any(u => u.Name == name)) throw new Exception("This city exists in database");
                weatherDbContext.Cities.Add(new City(name, latitude, longitude));
                weatherDbContext.SaveChanges();
                comboBox1.Items.Add(name);
                textBox1.Text = "City added";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            catch (Exception ex)
            {
                textBox1.Text = "falied to add city ";
                textBox1.Text += ex.Message;
            }

        }


    }
}
