// Kyrillos "Chris" Antoon
// Using SQL to query the weather through an XML file (comma separated)
// 10/22/2018
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SQL_Practice
{
    public partial class Form1 : Form
    {
        List<Observation> wxObs = new List<Observation>();                       // List of new Observation class, which contains the fields used in the XML file
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Welcome to my weather app query application \n" + 
                "You will find the XML file you need in the general folder for the project");
        }

        void ShowColdest()
        {
            list_ColdestCities.Items.Clear();                                   // Clear existing content

            var results = (from c in wxObs                                      // Query the list to get the first 5 cities in ascending order, to reflect coldest cities
                           orderby c.temperature ascending
                           select c).Take(5);

            foreach (var result in results)
            {
                list_ColdestCities.Items.Add                                    // Add results to the list box
                    (result.city + "," + result.pressure + "F");
            }
        }

        void ShowHottest()
        {
            list_HottestCities.Items.Clear();                                   // Clear existing content

            var results = (from c in wxObs
                           orderby c.temperature descending                     // Query the list to get the first 5 cities in deascending order, to reflect hottest cities
                           select c).Take(5);
            foreach (var result in results)
            {
                list_HottestCities.Items.Add                                    // Add results to the list box
                    (result.city + "," + result.pressure + "F");
            }
        }
        void ShowLowest()
        {
            list_Lowest.Items.Clear();                                          // Clear existing content

            var results = (from c in wxObs                                      // Query the list to get the first 5 cities in ascending order, to reflect lowest pressure
                           orderby c.pressure ascending
                           select c).Take(5);

            foreach (var result in results)
            {
                list_Lowest.Items.Add                                           // Add results to the list box
                    (result.city + "," + result.pressure + "Hg");
            }
        }
        void ShowHighest()
        {
            list_Highest.Items.Clear();                                         // Clear existing content

            var results = (from c in wxObs                                      // Query the list to get the first 5 cities in deascending order, to reflect highest pressure
                           orderby c.pressure descending
                           select c).Take(5);

            foreach (var result in results)                                             
            {
                list_Highest.Items.Add                                          // Add results to the list box
                    (result.city + "," + result.pressure + "Hg");
            }
        }
        /// <summary>
        /// calls the functions to show the data from the file
        /// </summary>
        void ShowData()
        {
            ShowColdest();
            ShowHottest();
            ShowLowest();
            ShowHighest();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string[] fields;                                                // String array to hold the contents of the items
                OpenFileDialog ofd = new OpenFileDialog();                      // Open file dialog to allow user to find their file
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string[] rows = File.ReadAllLines(ofd.FileName);            // Put all the contents of the file in the rows variable

                    foreach (string s in rows)
                    {
                        fields = s.Split(',');                                  // Break string up into fields

                        Observation o = new Observation()                       // Create a new Observation object
                        {
                            city = fields[0],                                   // Put the correct information in each object
                            pressure = Convert.ToSingle(fields[1]),
                            temperature = Convert.ToSingle(fields[2]),
                            Coverage = Convert.ToInt32(fields[3])
                        };
                        wxObs.Add(o);                                           // put the data in the list box
                    }
                }
                ShowData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error using the file");
            }

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            var results = from o in wxObs                                       // query from the list using the city name from the textbox
                          where o.city == txt_Search.Text
                          select o;

            if (results.Count() != 0)                                           // If the result is valid...
            {
                Observation result = results.First();                           // Return the first result

                txt_Result.Text = result.city + "\r\n";                         // Put info into the text boxes
                txt_Result.Text += "Temp: " + result.temperature + "F\r\n";
                txt_Result.Text += "Prsssure: " + result.pressure + "HG\r\n";
                txt_Result.Text += "Sky Coverage: " + result.Coverage + "%";
            }
            else
            {
                txt_Result.Text = "City not found!";                            // Else...print out the city was not found
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
