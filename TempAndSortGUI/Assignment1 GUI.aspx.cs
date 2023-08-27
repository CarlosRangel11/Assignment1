using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TempAndSort_consumer {
    
    public partial class Assignment1_GUI : System.Web.UI.Page {
        private TempAndSortGUI.TempAndSortService.TempAndSortingClient temp_and_sort = new TempAndSortGUI.TempAndSortService.TempAndSortingClient();
        
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void f2cButton_Click(object sender, EventArgs e) {
            string temperature = f2cBox.Text;
            int f_temp = int.Parse(temperature);
            int c_temp = temp_and_sort.f2c(f_temp);
            outputLabel.Text = $"{temperature}\u00B0 to Celcius: {c_temp.ToString()}\u00B0";
        }

        protected void c2fButton_Click(object sender, EventArgs e) {
            string temperature = c2fBox.Text;
            int c_temp = int.Parse(temperature);
            int f_temp = temp_and_sort.c2f(c_temp);
            outputLabel.Text = $"{temperature}\u00B0 to Fahrenheit: {f_temp.ToString()}\u00B0";
        }

        protected void stringButton_Click(object sender, EventArgs e) {
            string sortedString = temp_and_sort.sort(stringBox.Text);
            outputLabel.Text = $"{stringBox.Text} Sorted: {sortedString}";
        }
    }
}