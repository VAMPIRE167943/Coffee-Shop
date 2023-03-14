using System;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace freakincsharpsa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string mommy;

        public string Getmommy()
        {
            return mommy;
        }

        private void Senpai_Click(object sender, RoutedEventArgs e)
        {
            VALIDATION bussy = new();
            bussy.Show();
            _ = shawty.Text;
            string nyash = fishnets.SelectedDate.ToString();
            shawty.Text = nyash;
            string domme = "Data Source=DESKTOP-H394QK4;Initial Catalog=CoffeeShopeDB;Integrated Security=True";
            string feet = "insert into SalesTable(Id_Sale, DT)values('" + 6 + "', '" + nyash + "')";
            SqlConnection toes = new(domme);
            SqlCommand dominatrix = new(feet, toes);
            toes.Open();
            int futa = dominatrix.ExecuteNonQuery();
            if(futa > 0)
            {
                _ = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                using System.IO.StreamWriter choke = new(@"C:\Users\jason\OneDrive\Desktop\BackUpSales.txt", true);
                choke.WriteLine(shawty.Text);
            }
            toes.Close();
        }

        private void Loli_Click(object sender, RoutedEventArgs e)
        {
            if(uwu.IsChecked == false && owo.IsChecked == false && spicy.IsChecked == false)
            {
                MessageBox.Show("Where da date period at?");
            }
            else if(uwu.IsChecked == true || owo.IsChecked == true || spicy.IsChecked == true)
            {
                PrintDialog swallow = new();
                FlowDocument slurp = new(new Paragraph(new Run(fishnets.SelectedDate.ToString())))
                {
                    Name = "FlowDoc"
                };
                IDocumentPaginatorSource suck = slurp;
                swallow.PrintDocument(suck.DocumentPaginator, fishnets.SelectedDate.ToString());
            }
        }

        private DatePicker GetFishnets()
        {
            return fishnets;
        }

        private void Skirts_Click(object sender, RoutedEventArgs e, DatePicker fishnets)
        {
            if (sender is null)
            {
                throw new ArgumentNullException(nameof(sender));
            }

            if (e is null)
            {
                throw new ArgumentNullException(nameof(e));
            }

            VALIDATION kudasai = new();
            kudasai.Show();
            shawty.Text = fishnets.SelectedDate.ToString();
            string uncensored = "Data Source=DESKTOP-H394QK4;Initial Catalog=CoffeeShopeDB;Integrated Security=True";
            if(uwu.IsChecked != false)
            {
                string censored = fishnets.SelectedDate.ToString();
                string maidenless = "select * from SalesTable where DT = '" + censored + "'";
                SqlConnection skrrt = new(uncensored);
                SqlCommand yeet = new(maidenless, skrrt);
                skrrt.Open();
                SqlDataReader nyanpasu = yeet.ExecuteReader();
                nyanpasu.Read();
                shawty.Text = "\n" + nyanpasu["Id_Sale"].ToString() + " | " + nyanpasu["Quantity"].ToString() + " | " + nyanpasu["Descr"].ToString() + " | " + nyanpasu["Price"].ToString() + " | " + nyanpasu["Total"].ToString() + " | " + nyanpasu["DT"].ToString();
            }else if(owo.IsChecked != false)
            {
                string rule34 = fishnets.SelectedDate.ToString();
                string drip = "select * from SalesTable where DT = '" + rule34 + "'";
                SqlConnection step_on_me = new(uncensored);
                SqlCommand tanks = new(drip, step_on_me);
                step_on_me.Open();
                SqlDataReader stonks = tanks.ExecuteReader();
                stonks.Read();
                shawty.Text = "\n" + stonks["Id_Sale"].ToString() + " | " + stonks["Quantity"].ToString() + " | " + stonks["Descr"].ToString() + " | " + stonks["Price"].ToString() + " | " + stonks["Total"].ToString() + " | " + stonks["DT"].ToString();
            }else if(spicy.IsChecked != false)
            {
                string emotional_damage = fishnets.SelectedDate.ToString();
                string thicc = "select * from SalesTable where DT = '" + emotional_damage + "'";
                SqlConnection succubus = new(uncensored);
                SqlCommand simp = new(thicc, succubus);
                succubus.Open();
                SqlDataReader furry = simp.ExecuteReader();
                furry.Read();
                shawty.Text = "\n" + furry["Id_Sale"].ToString() + " | " + furry["Quantity"].ToString() + " | " + furry["Descr"].ToString() + " | " + furry["Price"].ToString() + " | " + furry["Total"].ToString() + " | " + furry["DT"].ToString();
            }
        }

        private void Step_Jason_Click(object sender, RoutedEventArgs e)
        {
            soulmates.Text = fishnets.SelectedDate.ToString() + "\nQtity    |Description    |Price    |Total    |\n";
            if(hide.SelectedItem.ToString() == "Late" && vibin.SelectedItem.ToString() == "1" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                soulmates.Text = fishnets.SelectedDate.ToString() + "\nQtity    |Description    |Price    |Total    |\n";
                soulmates.Text = vibin.SelectedItem.ToString() + hide.SelectedItem.ToString() + 18 + 18;
            }
            else if(hide.SelectedItem.ToString() == "Capuccino" && vibin.SelectedItem.ToString() == "1" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                soulmates.Text = fishnets.SelectedDate.ToString() + "\nQtity    |Description    |Price    |Total    |\n";
                soulmates.Text = vibin.SelectedItem.ToString() + hide.SelectedItem.ToString() + 22 + 22;
            }
            else if(hide.SelectedItem.ToString() == "Americano" && vibin.SelectedItem.ToString() == "1" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                soulmates.Text = fishnets.SelectedDate.ToString() + "\nQtity    |Description    |Price    |Total    |\n";
                soulmates.Text = vibin.SelectedItem.ToString() + hide.SelectedItem.ToString() + 19 + 19;
            }
            else if(hide.SelectedItem.ToString() == "Espresso" && vibin.SelectedItem.ToString() == "1" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                soulmates.Text = fishnets.SelectedDate.ToString() + "\nQtity    |Description    |Price    |Total    |\n";
                soulmates.Text = vibin.SelectedItem.ToString() + hide.SelectedItem.ToString() + 27 + 27;
            }
            else if(hide.SelectedItem.ToString() == "Machiato" && vibin.SelectedItem.ToString() == "1" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                soulmates.Text = fishnets.SelectedDate.ToString() + "\nQtity    |Description    |Price    |Total    |\n";
                soulmates.Text = vibin.SelectedItem.ToString() + hide.SelectedItem.ToString() + 23 + 23;
            }
            else if (hide.SelectedItem.ToString() == "Late" && vibin.SelectedItem.ToString() == "2" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                soulmates.Text = fishnets.SelectedDate.ToString() + "\nQtity    |Description    |Price    |Total    |\n";
                soulmates.Text = vibin.SelectedItem.ToString() + hide.SelectedItem.ToString() + 18 + 36;
            }
            else if (hide.SelectedItem.ToString() == "Capuccino" && vibin.SelectedItem.ToString() == "2" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                soulmates.Text = fishnets.SelectedDate.ToString() + "\nQtity    |Description    |Price    |Total    |\n";
                soulmates.Text = vibin.SelectedItem.ToString() + hide.SelectedItem.ToString() + 22 + 44;
            }
            else if (hide.SelectedItem.ToString() == "Americano" && vibin.SelectedItem.ToString() == "2" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                soulmates.Text = fishnets.SelectedDate.ToString() + "\nQtity    |Description    |Price    |Total    |\n";
                soulmates.Text = vibin.SelectedItem.ToString() + hide.SelectedItem.ToString() + 19 + 38;
            }
            else if (hide.SelectedItem.ToString() == "Espresso" && vibin.SelectedItem.ToString() == "2" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                soulmates.Text = fishnets.SelectedDate.ToString() + "\nQtity    |Description    |Price    |Total    |\n";
                soulmates.Text = vibin.SelectedItem.ToString() + hide.SelectedItem.ToString() + 27 + 54;
            }
            else if (hide.SelectedItem.ToString() == "Machiato" && vibin.SelectedItem.ToString() == "2" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                soulmates.Text = fishnets.SelectedDate.ToString() + "\nQtity    |Description    |Price    |Total    |\n";
                soulmates.Text = vibin.SelectedItem.ToString() + hide.SelectedItem.ToString() + 23 + 46;
            }
            else if (hide.SelectedItem.ToString() == "Late" && vibin.SelectedItem.ToString() == "3" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                soulmates.Text = fishnets.SelectedDate.ToString() + "\nQtity    |Description    |Price    |Total    |\n";
                soulmates.Text = vibin.SelectedItem.ToString() + hide.SelectedItem.ToString() + 18 + 54;
            }
            else if (hide.SelectedItem.ToString() == "Capuccino" && vibin.SelectedItem.ToString() == "3" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                soulmates.Text = fishnets.SelectedDate.ToString() + "\nQtity    |Description    |Price    |Total    |\n";
                soulmates.Text = vibin.SelectedItem.ToString() + hide.SelectedItem.ToString() + 22 + 66;
            }
            else if (hide.SelectedItem.ToString() == "Americano" && vibin.SelectedItem.ToString() == "3" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                soulmates.Text = fishnets.SelectedDate.ToString() + "\nQtity    |Description    |Price    |Total    |\n";
                soulmates.Text = vibin.SelectedItem.ToString() + hide.SelectedItem.ToString() + 19 + 57;
            }
            else if (hide.SelectedItem.ToString() == "Espresso" && vibin.SelectedItem.ToString() == "3" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                soulmates.Text = fishnets.SelectedDate.ToString() + "\nQtity    |Description    |Price    |Total    |\n";
                soulmates.Text = vibin.SelectedItem.ToString() + hide.SelectedItem.ToString() + 27 + 81;
            }
            else if (hide.SelectedItem.ToString() == "Machiato" && vibin.SelectedItem.ToString() == "3" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                soulmates.Text = fishnets.SelectedDate.ToString() + "\nQtity    |Description    |Price    |Total    |\n";
                soulmates.Text = vibin.SelectedItem.ToString() + hide.SelectedItem.ToString() + 23 + 69;
            }
            else if (hide.SelectedItem.ToString() == "Late" && vibin.SelectedItem.ToString() == "4" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                soulmates.Text = fishnets.SelectedDate.ToString() + "\nQtity    |Description    |Price    |Total    |\n";
                soulmates.Text = vibin.SelectedItem.ToString() + hide.SelectedItem.ToString() + 18 + 72;
            }
            else if (hide.SelectedItem.ToString() == "Capuccino" && vibin.SelectedItem.ToString() == "4" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                soulmates.Text = fishnets.SelectedDate.ToString() + "\nQtity    |Description    |Price    |Total    |\n";
                soulmates.Text = vibin.SelectedItem.ToString() + hide.SelectedItem.ToString() + 22 + 88;
            }
            else if (hide.SelectedItem.ToString() == "Americano" && vibin.SelectedItem.ToString() == "4" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                soulmates.Text = fishnets.SelectedDate.ToString() + "\nQtity    |Description    |Price    |Total    |\n";
                soulmates.Text = vibin.SelectedItem.ToString() + hide.SelectedItem.ToString() + 19 + 76;
            }
            else if (hide.SelectedItem.ToString() == "Espresso" && vibin.SelectedItem.ToString() == "4" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                soulmates.Text = fishnets.SelectedDate.ToString() + "\nQtity    |Description    |Price    |Total    |\n";
                soulmates.Text = vibin.SelectedItem.ToString() + hide.SelectedItem.ToString() + 27 + 108;
            }
            else if (hide.SelectedItem.ToString() == "Machiato" && vibin.SelectedItem.ToString() == "4" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                soulmates.Text = fishnets.SelectedDate.ToString() + "\nQtity    |Description    |Price    |Total    |\n";
                soulmates.Text = vibin.SelectedItem.ToString() + hide.SelectedItem.ToString() + 23 + 92;
            }
            else if (hide.SelectedItem.ToString() == "Late" && vibin.SelectedItem.ToString() == "5" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                soulmates.Text = fishnets.SelectedDate.ToString() + "\nQtity    |Description    |Price    |Total    |\n";
                soulmates.Text = vibin.SelectedItem.ToString() + hide.SelectedItem.ToString() + 18 + 90;
            }
            else if (hide.SelectedItem.ToString() == "Capuccino" && vibin.SelectedItem.ToString() == "5" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                soulmates.Text = fishnets.SelectedDate.ToString() + "\nQtity    |Description    |Price    |Total    |\n";
                soulmates.Text = vibin.SelectedItem.ToString() + hide.SelectedItem.ToString() + 22 + 110;
            }
            else if (hide.SelectedItem.ToString() == "Americano" && vibin.SelectedItem.ToString() == "5" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                soulmates.Text = fishnets.SelectedDate.ToString() + "\nQtity    |Description    |Price    |Total    |\n";
                soulmates.Text = vibin.SelectedItem.ToString() + hide.SelectedItem.ToString() + 19 + 95;
            }
            else if (hide.SelectedItem.ToString() == "Espresso" && vibin.SelectedItem.ToString() == "5" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                soulmates.Text = fishnets.SelectedDate.ToString() + "\nQtity    |Description    |Price    |Total    |\n";
                soulmates.Text = vibin.SelectedItem.ToString() + hide.SelectedItem.ToString() + 27 + 135;
            }
            else if (hide.SelectedItem.ToString() == "Machiato" && vibin.SelectedItem.ToString() == "5" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                soulmates.Text = fishnets.SelectedDate.ToString() + "\nQtity    |Description    |Price    |Total    |\n";
                soulmates.Text = vibin.SelectedItem.ToString() + hide.SelectedItem.ToString() + 23 + 115;
            }
        }

        private void Senpai_Jason_Click(object sender, RoutedEventArgs e)
        {
            if (hide.SelectedItem.ToString() == "Late" && vibin.SelectedItem.ToString() == "1" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                string genshin_impact = "Data Source=DESKTOP-H394QK4;Initial Catalog=CoffeeShopeDB;Integrated Security=True";
                string thicc_2Dgirls = "insert into SalesTable(Quantity, Descr, Price, Total)" +
                    "values('" + 1 + "', '" + "Late" + "', '" + 18 + "', '" + 18 + "')";
                SqlConnection need_more_luck_need_need_more_luck = new(genshin_impact);
                SqlCommand I_WANT_PRIMOS = new(thicc_2Dgirls, need_more_luck_need_need_more_luck);
                need_more_luck_need_need_more_luck.Open();
                _ = I_WANT_PRIMOS.ExecuteNonQuery();
            }
            else if (hide.SelectedItem.ToString() == "Capuccino" && vibin.SelectedItem.ToString() == "1" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                string genshin_impact = "Data Source=DESKTOP-H394QK4;Initial Catalog=CoffeeShopeDB;Integrated Security=True";
                string thicc_2Dgirls = "insert into SalesTable(Quantity, Descr, Price, Total)" +
                    "values('" + 1 + "', '" + "Late" + "', '" + 18 + "', '" + 18 + "')";
                SqlConnection need_more_luck_need_need_more_luck = new(genshin_impact);
                SqlCommand I_WANT_PRIMOS = new(thicc_2Dgirls, need_more_luck_need_need_more_luck);
                need_more_luck_need_need_more_luck.Open();
                _ = I_WANT_PRIMOS.ExecuteNonQuery();
            }
            else if (hide.SelectedItem.ToString() == "Americano" && vibin.SelectedItem.ToString() == "1" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                string genshin_impact = "Data Source=DESKTOP-H394QK4;Initial Catalog=CoffeeShopeDB;Integrated Security=True";
                string thicc_2Dgirls = "insert into SalesTable(Quantity, Descr, Price, Total)" +
                    "values('" + 1 + "', '" + "Late" + "', '" + 18 + "', '" + 18 + "')";
                SqlConnection need_more_luck_need_need_more_luck = new(genshin_impact);
                SqlCommand I_WANT_PRIMOS = new(thicc_2Dgirls, need_more_luck_need_need_more_luck);
                need_more_luck_need_need_more_luck.Open();
                _ = I_WANT_PRIMOS.ExecuteNonQuery();
            }
            else if (hide.SelectedItem.ToString() == "Espresso" && vibin.SelectedItem.ToString() == "1" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                string genshin_impact = "Data Source=DESKTOP-H394QK4;Initial Catalog=CoffeeShopeDB;Integrated Security=True";
                string thicc_2Dgirls = "insert into SalesTable(Quantity, Descr, Price, Total)" +
                    "values('" + 1 + "', '" + "Late" + "', '" + 18 + "', '" + 18 + "')";
                SqlConnection need_more_luck_need_need_more_luck = new(genshin_impact);
                SqlCommand I_WANT_PRIMOS = new(thicc_2Dgirls, need_more_luck_need_need_more_luck);
                need_more_luck_need_need_more_luck.Open();
                _ = I_WANT_PRIMOS.ExecuteNonQuery();
            }
            else if (hide.SelectedItem.ToString() == "Machiato" && vibin.SelectedItem.ToString() == "1" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                string genshin_impact = "Data Source=DESKTOP-H394QK4;Initial Catalog=CoffeeShopeDB;Integrated Security=True";
                string thicc_2Dgirls = "insert into SalesTable(Quantity, Descr, Price, Total)" +
                    "values('" + 1 + "', '" + "Late" + "', '" + 18 + "', '" + 18 + "')";
                SqlConnection need_more_luck_need_need_more_luck = new(genshin_impact);
                SqlCommand I_WANT_PRIMOS = new(thicc_2Dgirls, need_more_luck_need_need_more_luck);
                need_more_luck_need_need_more_luck.Open();
                _ = I_WANT_PRIMOS.ExecuteNonQuery();
            }
            else if (hide.SelectedItem.ToString() == "Late" && vibin.SelectedItem.ToString() == "2" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                string genshin_impact = "Data Source=DESKTOP-H394QK4;Initial Catalog=CoffeeShopeDB;Integrated Security=True";
                string thicc_2Dgirls = "insert into SalesTable(Quantity, Descr, Price, Total)" +
                    "values('" + 1 + "', '" + "Late" + "', '" + 18 + "', '" + 18 + "')";
                SqlConnection need_more_luck_need_need_more_luck = new(genshin_impact);
                SqlCommand I_WANT_PRIMOS = new(thicc_2Dgirls, need_more_luck_need_need_more_luck);
                need_more_luck_need_need_more_luck.Open();
                _ = I_WANT_PRIMOS.ExecuteNonQuery();
            }
            else if (hide.SelectedItem.ToString() == "Capuccino" && vibin.SelectedItem.ToString() == "2" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                string genshin_impact = "Data Source=DESKTOP-H394QK4;Initial Catalog=CoffeeShopeDB;Integrated Security=True";
                string thicc_2Dgirls = "insert into SalesTable(Quantity, Descr, Price, Total)" +
                    "values('" + 1 + "', '" + "Late" + "', '" + 18 + "', '" + 18 + "')";
                SqlConnection need_more_luck_need_need_more_luck = new(genshin_impact);
                SqlCommand I_WANT_PRIMOS = new(thicc_2Dgirls, need_more_luck_need_need_more_luck);
                need_more_luck_need_need_more_luck.Open();
                _ = I_WANT_PRIMOS.ExecuteNonQuery();
            }
            else if (hide.SelectedItem.ToString() == "Americano" && vibin.SelectedItem.ToString() == "2" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                string genshin_impact = "Data Source=DESKTOP-H394QK4;Initial Catalog=CoffeeShopeDB;Integrated Security=True";
                string thicc_2Dgirls = "insert into SalesTable(Quantity, Descr, Price, Total)" +
                    "values('" + 1 + "', '" + "Late" + "', '" + 18 + "', '" + 18 + "')";
                SqlConnection need_more_luck_need_need_more_luck = new(genshin_impact);
                SqlCommand I_WANT_PRIMOS = new(thicc_2Dgirls, need_more_luck_need_need_more_luck);
                need_more_luck_need_need_more_luck.Open();
                _ = I_WANT_PRIMOS.ExecuteNonQuery();
            }
            else if (hide.SelectedItem.ToString() == "Espresso" && vibin.SelectedItem.ToString() == "2" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                string genshin_impact = "Data Source=DESKTOP-H394QK4;Initial Catalog=CoffeeShopeDB;Integrated Security=True";
                string thicc_2Dgirls = "insert into SalesTable(Quantity, Descr, Price, Total)" +
                    "values('" + 1 + "', '" + "Late" + "', '" + 18 + "', '" + 18 + "')";
                SqlConnection need_more_luck_need_need_more_luck = new(genshin_impact);
                SqlCommand I_WANT_PRIMOS = new(thicc_2Dgirls, need_more_luck_need_need_more_luck);
                need_more_luck_need_need_more_luck.Open();
                _ = I_WANT_PRIMOS.ExecuteNonQuery();
            }
            else if (hide.SelectedItem.ToString() == "Machiato" && vibin.SelectedItem.ToString() == "2" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                string genshin_impact = "Data Source=DESKTOP-H394QK4;Initial Catalog=CoffeeShopeDB;Integrated Security=True";
                string thicc_2Dgirls = "insert into SalesTable(Quantity, Descr, Price, Total)" +
                    "values('" + 1 + "', '" + "Late" + "', '" + 18 + "', '" + 18 + "')";
                SqlConnection need_more_luck_need_need_more_luck = new(genshin_impact);
                SqlCommand I_WANT_PRIMOS = new(thicc_2Dgirls, need_more_luck_need_need_more_luck);
                need_more_luck_need_need_more_luck.Open();
                _ = I_WANT_PRIMOS.ExecuteNonQuery();
            }
            else if (hide.SelectedItem.ToString() == "Late" && vibin.SelectedItem.ToString() == "3" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                string genshin_impact = "Data Source=DESKTOP-H394QK4;Initial Catalog=CoffeeShopeDB;Integrated Security=True";
                string thicc_2Dgirls = "insert into SalesTable(Quantity, Descr, Price, Total)" +
                    "values('" + 1 + "', '" + "Late" + "', '" + 18 + "', '" + 18 + "')";
                SqlConnection need_more_luck_need_need_more_luck = new(genshin_impact);
                SqlCommand I_WANT_PRIMOS = new(thicc_2Dgirls, need_more_luck_need_need_more_luck);
                need_more_luck_need_need_more_luck.Open();
                _ = I_WANT_PRIMOS.ExecuteNonQuery();
            }
            else if (hide.SelectedItem.ToString() == "Capuccino" && vibin.SelectedItem.ToString() == "3" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                string genshin_impact = "Data Source=DESKTOP-H394QK4;Initial Catalog=CoffeeShopeDB;Integrated Security=True";
                string thicc_2Dgirls = "insert into SalesTable(Quantity, Descr, Price, Total)" +
                    "values('" + 1 + "', '" + "Late" + "', '" + 18 + "', '" + 18 + "')";
                SqlConnection need_more_luck_need_need_more_luck = new(genshin_impact);
                SqlCommand I_WANT_PRIMOS = new(thicc_2Dgirls, need_more_luck_need_need_more_luck);
                need_more_luck_need_need_more_luck.Open();
                _ = I_WANT_PRIMOS.ExecuteNonQuery();
            }
            else if (hide.SelectedItem.ToString() == "Americano" && vibin.SelectedItem.ToString() == "3" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                string genshin_impact = "Data Source=DESKTOP-H394QK4;Initial Catalog=CoffeeShopeDB;Integrated Security=True";
                string thicc_2Dgirls = "insert into SalesTable(Quantity, Descr, Price, Total)" +
                    "values('" + 1 + "', '" + "Late" + "', '" + 18 + "', '" + 18 + "')";
                SqlConnection need_more_luck_need_need_more_luck = new(genshin_impact);
                SqlCommand I_WANT_PRIMOS = new(thicc_2Dgirls, need_more_luck_need_need_more_luck);
                need_more_luck_need_need_more_luck.Open();
                _ = I_WANT_PRIMOS.ExecuteNonQuery();
            }
            else if (hide.SelectedItem.ToString() == "Espresso" && vibin.SelectedItem.ToString() == "3" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                string genshin_impact = "Data Source=DESKTOP-H394QK4;Initial Catalog=CoffeeShopeDB;Integrated Security=True";
                string thicc_2Dgirls = "insert into SalesTable(Quantity, Descr, Price, Total)" +
                    "values('" + 1 + "', '" + "Late" + "', '" + 18 + "', '" + 18 + "')";
                SqlConnection need_more_luck_need_need_more_luck = new(genshin_impact);
                SqlCommand I_WANT_PRIMOS = new(thicc_2Dgirls, need_more_luck_need_need_more_luck);
                need_more_luck_need_need_more_luck.Open();
                _ = I_WANT_PRIMOS.ExecuteNonQuery();
            }
            else if (hide.SelectedItem.ToString() == "Machiato" && vibin.SelectedItem.ToString() == "3" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                string genshin_impact = "Data Source=DESKTOP-H394QK4;Initial Catalog=CoffeeShopeDB;Integrated Security=True";
                string thicc_2Dgirls = "insert into SalesTable(Quantity, Descr, Price, Total)" +
                    "values('" + 1 + "', '" + "Late" + "', '" + 18 + "', '" + 18 + "')";
                SqlConnection need_more_luck_need_need_more_luck = new(genshin_impact);
                SqlCommand I_WANT_PRIMOS = new(thicc_2Dgirls, need_more_luck_need_need_more_luck);
                need_more_luck_need_need_more_luck.Open();
                _ = I_WANT_PRIMOS.ExecuteNonQuery();
            }
            else if (hide.SelectedItem.ToString() == "Late" && vibin.SelectedItem.ToString() == "4" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                string genshin_impact = "Data Source=DESKTOP-H394QK4;Initial Catalog=CoffeeShopeDB;Integrated Security=True";
                string thicc_2Dgirls = "insert into SalesTable(Quantity, Descr, Price, Total)" +
                    "values('" + 1 + "', '" + "Late" + "', '" + 18 + "', '" + 18 + "')";
                SqlConnection need_more_luck_need_need_more_luck = new(genshin_impact);
                SqlCommand I_WANT_PRIMOS = new(thicc_2Dgirls, need_more_luck_need_need_more_luck);
                need_more_luck_need_need_more_luck.Open();
                _ = I_WANT_PRIMOS.ExecuteNonQuery();
            }
            else if (hide.SelectedItem.ToString() == "Capuccino" && vibin.SelectedItem.ToString() == "4" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                string genshin_impact = "Data Source=DESKTOP-H394QK4;Initial Catalog=CoffeeShopeDB;Integrated Security=True";
                string thicc_2Dgirls = "insert into SalesTable(Quantity, Descr, Price, Total)" +
                    "values('" + 1 + "', '" + "Late" + "', '" + 18 + "', '" + 18 + "')";
                SqlConnection need_more_luck_need_need_more_luck = new(genshin_impact);
                SqlCommand I_WANT_PRIMOS = new(thicc_2Dgirls, need_more_luck_need_need_more_luck);
                need_more_luck_need_need_more_luck.Open();
                _ = I_WANT_PRIMOS.ExecuteNonQuery();
            }
            else if (hide.SelectedItem.ToString() == "Americano" && vibin.SelectedItem.ToString() == "4" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                string genshin_impact = "Data Source=DESKTOP-H394QK4;Initial Catalog=CoffeeShopeDB;Integrated Security=True";
                string thicc_2Dgirls = "insert into SalesTable(Quantity, Descr, Price, Total)" +
                    "values('" + 1 + "', '" + "Late" + "', '" + 18 + "', '" + 18 + "')";
                SqlConnection need_more_luck_need_need_more_luck = new(genshin_impact);
                SqlCommand I_WANT_PRIMOS = new(thicc_2Dgirls, need_more_luck_need_need_more_luck);
                need_more_luck_need_need_more_luck.Open();
                _ = I_WANT_PRIMOS.ExecuteNonQuery();
            }
            else if (hide.SelectedItem.ToString() == "Espresso" && vibin.SelectedItem.ToString() == "4" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                string genshin_impact = "Data Source=DESKTOP-H394QK4;Initial Catalog=CoffeeShopeDB;Integrated Security=True";
                string thicc_2Dgirls = "insert into SalesTable(Quantity, Descr, Price, Total)" +
                    "values('" + 1 + "', '" + "Late" + "', '" + 18 + "', '" + 18 + "')";
                SqlConnection need_more_luck_need_need_more_luck = new(genshin_impact);
                SqlCommand I_WANT_PRIMOS = new(thicc_2Dgirls, need_more_luck_need_need_more_luck);
                need_more_luck_need_need_more_luck.Open();
                _ = I_WANT_PRIMOS.ExecuteNonQuery();
            }
            else if (hide.SelectedItem.ToString() == "Machiato" && vibin.SelectedItem.ToString() == "4" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                string genshin_impact = "Data Source=DESKTOP-H394QK4;Initial Catalog=CoffeeShopeDB;Integrated Security=True";
                string thicc_2Dgirls = "insert into SalesTable(Quantity, Descr, Price, Total)" +
                    "values('" + 1 + "', '" + "Late" + "', '" + 18 + "', '" + 18 + "')";
                SqlConnection need_more_luck_need_need_more_luck = new(genshin_impact);
                SqlCommand I_WANT_PRIMOS = new(thicc_2Dgirls, need_more_luck_need_need_more_luck);
                need_more_luck_need_need_more_luck.Open();
                _ = I_WANT_PRIMOS.ExecuteNonQuery();
            }
            else if (hide.SelectedItem.ToString() == "Late" && vibin.SelectedItem.ToString() == "5" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                string genshin_impact = "Data Source=DESKTOP-H394QK4;Initial Catalog=CoffeeShopeDB;Integrated Security=True";
                string thicc_2Dgirls = "insert into SalesTable(Quantity, Descr, Price, Total)" +
                    "values('" + 1 + "', '" + "Late" + "', '" + 18 + "', '" + 18 + "')";
                SqlConnection need_more_luck_need_need_more_luck = new(genshin_impact);
                SqlCommand I_WANT_PRIMOS = new(thicc_2Dgirls, need_more_luck_need_need_more_luck);
                need_more_luck_need_need_more_luck.Open();
                _ = I_WANT_PRIMOS.ExecuteNonQuery();
            }
            else if (hide.SelectedItem.ToString() == "Capuccino" && vibin.SelectedItem.ToString() == "5" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                string genshin_impact = "Data Source=DESKTOP-H394QK4;Initial Catalog=CoffeeShopeDB;Integrated Security=True";
                string thicc_2Dgirls = "insert into SalesTable(Quantity, Descr, Price, Total)" +
                    "values('" + 1 + "', '" + "Late" + "', '" + 18 + "', '" + 18 + "')";
                SqlConnection need_more_luck_need_need_more_luck = new(genshin_impact);
                SqlCommand I_WANT_PRIMOS = new(thicc_2Dgirls, need_more_luck_need_need_more_luck);
                need_more_luck_need_need_more_luck.Open();
                _ = I_WANT_PRIMOS.ExecuteNonQuery();
            }
            else if (hide.SelectedItem.ToString() == "Americano" && vibin.SelectedItem.ToString() == "5" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                string genshin_impact = "Data Source=DESKTOP-H394QK4;Initial Catalog=CoffeeShopeDB;Integrated Security=True";
                string thicc_2Dgirls = "insert into SalesTable(Quantity, Descr, Price, Total)" +
                    "values('" + 1 + "', '" + "Late" + "', '" + 18 + "', '" + 18 + "')";
                SqlConnection need_more_luck_need_need_more_luck = new(genshin_impact);
                SqlCommand I_WANT_PRIMOS = new(thicc_2Dgirls, need_more_luck_need_need_more_luck);
                need_more_luck_need_need_more_luck.Open();
                _ = I_WANT_PRIMOS.ExecuteNonQuery();
            }
            else if (hide.SelectedItem.ToString() == "Espresso" && vibin.SelectedItem.ToString() == "5" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                string genshin_impact = "Data Source=DESKTOP-H394QK4;Initial Catalog=CoffeeShopeDB;Integrated Security=True";
                string thicc_2Dgirls = "insert into SalesTable(Quantity, Descr, Price, Total)" +
                    "values('" + 1 + "', '" + "Late" + "', '" + 18 + "', '" + 18 + "')";
                SqlConnection need_more_luck_need_need_more_luck = new(genshin_impact);
                SqlCommand I_WANT_PRIMOS = new(thicc_2Dgirls, need_more_luck_need_need_more_luck);
                need_more_luck_need_need_more_luck.Open();
                _ = I_WANT_PRIMOS.ExecuteNonQuery();
            }
            else if (hide.SelectedItem.ToString() == "Machiato" && vibin.SelectedItem.ToString() == "5" && (anime_playlist_be_bussin.IsChecked != false || virgins_dont_lose.IsChecked != false || copyright_my_ahh.IsChecked != false) && (you_wish_i_copied.IsChecked != false || im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false || (you_wish_i_copied.IsChecked != false && im_da_alpha_da_omega_and_everythin_in_between.IsChecked != false)))
            {
                string genshin_impact = "Data Source=DESKTOP-H394QK4;Initial Catalog=CoffeeShopeDB;Integrated Security=True";
                string thicc_2Dgirls = "insert into SalesTable(Quantity, Descr, Price, Total)" +
                    "values('" + 1 + "', '" + "Late" + "', '" + 18 + "', '" + 18 + "')";
                SqlConnection need_more_luck_need_need_more_luck = new(genshin_impact);
                SqlCommand I_WANT_PRIMOS = new(thicc_2Dgirls, need_more_luck_need_need_more_luck);
                need_more_luck_need_need_more_luck.Open();
                _ = I_WANT_PRIMOS.ExecuteNonQuery();
            }
        }
    }
}