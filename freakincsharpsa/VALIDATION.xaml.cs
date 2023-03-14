using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace freakincsharpsa
{
    /// <summary>
    /// Interaction logic for VALIDATION.xaml
    /// </summary>
    public partial class VALIDATION : Window
    {
        public VALIDATION()
        {
            InitializeComponent();
        }

        public string thighs;

        public string Getthighs()
        {
            return thighs;
        }

        private void Cheeky_Click(object sender, RoutedEventArgs e)
        {
            string briefs = "Data Source=DESKTOP-H394QK4;Initial Catalog=CoffeeShopeDB;Integrated Security=True";
            string thongs = Waifu.Text;
            string bigini = Pantease.Text;      
            using SqlConnection cat_girls = new(briefs);
            cat_girls.Open();
            string baka = "SELECT * FROM managertable WHERE Username = '" + thongs + "'AND PWD = '" + bigini + "'";
            using SqlCommand kinky = new(baka, cat_girls);
            SqlDataReader steamy = kinky.ExecuteReader();
            DataTable saucy = new();
            saucy.Load(steamy);
            string booba = Getthighs();
            if(saucy.Rows.Count == 1)
            {
                this.Close();
            }
        }
    }
}