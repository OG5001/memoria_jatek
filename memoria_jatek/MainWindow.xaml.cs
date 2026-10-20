using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace memoria_jatek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int prob = 0;
        Button gomb1 = null;
        int point = 0;
        string cont = "";
        string cont2 = "";
        int ind = 0;
        List<string> palya = new List<string>() { "2x2", "4x4", "6x6" };
        List<string> tema = new List<string>() { "szamok", "italok", "csokik" };
        List<string> drinks = new List<string>() { "MountinDew", "Pepsi", "CocaCola", "IrnBru", "Kinley", "7Up", "DrPepper", "Schweppes", "Fanta", "Kofola", "Sprite", "Faygo", "LaCroixSparklingWater", "Shasta", "Kinnie", "Jarritos", "RedBull", "Monster", "Rockstar", "Burn", "Hell", "Tango", "Orangina", "Nestea", "LiptonIceTea", "Arizona", "Perrier", "SanPellegrino", "VitaCoco", "Snapple", "AriZonaGreenTea", "OceanSpray" };
        List<string> csokik = new List<string>() { "Boci", "Sport_szelet", "Milka", "Kinder", "Tibi", "Snickers", "Szerencsi", "Mars", "Szamos", "Twix", "Stühmer", "Bounty", "ChocoMe", "KitKat", "Vadász", "Heidi", "Hershey_s", "Cadbury", "Toblerone", "Ritter_Sport", "Schogetten", "Choceur", "Fin_Carré", "Lindt", "Ferrero_Rocher", "Merci", "Guylian", "Geisha", "Godiva", "Valrhona", "Galler", "Neuhaus" };
        public MainWindow()
        {
            InitializeComponent();
            lbox_palya.ItemsSource = palya;
            lbox_tema.ItemsSource = tema;
        }

        private void Kivalasztas(object sender, SelectionChangedEventArgs e)
        {
            Szoveg();
        }

        private void Kivalasztas2(object sender, SelectionChangedEventArgs e)
        {
            Szoveg();
        }

        private void Szoveg()
        {
            var parts = new List<string>();
            string szoveg = "";
            if (lbox_palya.SelectedItem != null)
            {
                parts.Add($" A kiválasztott pálya: {lbox_palya.SelectedItem}");
            }
            if (lbox_tema.SelectedItem != null)
            {
                parts.Add($" A kiválasztott téma: {lbox_tema.SelectedItem}");
            }
            tb.Text = string.Join("\n", parts);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            point = 0;

            if (lbox_palya.SelectedItem == null || lbox_tema.SelectedItem == null)
            {
                MessageBox.Show("Kérlek válassz pályát és témát!", "Hiályos adatok!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (lbox_palya.SelectedItem == "2x2" && lbox_tema.SelectedItem == "szamok")
            {
                List<string> szam = new List<string>();

                for (int i = 0; i < 2 * 2 / 2; i++)

                {

                    szam.Add(i.ToString());

                    szam.Add(i.ToString());

                }
                point = 0;
                tb_point.Text = "Próbálkozások: " + point;
                btn_palya.RowDefinitions.Clear();

                btn_palya.ColumnDefinitions.Clear();
                for (int i = 0; i < 2; i++)
                {
                    btn_palya.RowDefinitions.Add(new RowDefinition());
                    btn_palya.ColumnDefinitions.Add(new ColumnDefinition());
                }
                szam = szam.Shuffle().ToList();

                int index = 0;
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Button btn = new Button
                        {
                            Name = "b_" + szam[index++].ToString(),
                            Content = "?",
                            FontSize = 20,
                            FontWeight = FontWeights.Bold,
                            Margin = new Thickness(3)
                        };
                        btn.Click += button_cl;
                        Grid.SetRow(btn, i);
                        Grid.SetColumn(btn, j);
                        btn_palya.Children.Add(btn);
                    }

                }
            }

            else if (lbox_palya.SelectedItem == "4x4" && lbox_tema.SelectedItem == "szamok")
            {
                point = 0;
                tb_point.Text = "Próbálkozások: " + point;
                List<string> szam2 = new List<string>();

                for (int i = 0; i < 4 * 4 / 2; i++)

                {

                    szam2.Add(i.ToString());

                    szam2.Add(i.ToString());

                }
                btn_palya.RowDefinitions.Clear();

                btn_palya.ColumnDefinitions.Clear();
                for (int i = 0; i < 4; i++)
                {
                    btn_palya.RowDefinitions.Add(new RowDefinition());
                    btn_palya.ColumnDefinitions.Add(new ColumnDefinition());
                }

                szam2 = szam2.Shuffle().ToList();

                int index = 0;
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Button btn = new Button
                        {
                            Name = "b_" + szam2[index++].ToString(),
                            Content = "?",
                            FontSize = 20,
                            FontWeight = FontWeights.Bold,
                            Margin = new Thickness(3)
                        };
                        btn.Click += button_cl;
                        Grid.SetRow(btn, i);
                        Grid.SetColumn(btn, j);

                        btn_palya.Children.Add(btn);
                    }

                }
            }
            else if (lbox_palya.SelectedItem == "6x6" && lbox_tema.SelectedItem == "szamok")
            {
                point = 0;
                tb_point.Text = "Próbálkozások: " + point;
                List<string> szam3 = new List<string>();

                for (int i = 0; i < 6 * 6 / 2; i++)

                {

                    szam3.Add(i.ToString());

                    szam3.Add(i.ToString());

                }
                btn_palya.RowDefinitions.Clear();

                btn_palya.ColumnDefinitions.Clear();
                for (int i = 0; i < 6; i++)
                {
                    btn_palya.RowDefinitions.Add(new RowDefinition());
                    btn_palya.ColumnDefinitions.Add(new ColumnDefinition());
                }
                szam3 = szam3.Shuffle().ToList();

                int index = 0;
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        Button btn = new Button
                        {
                            Name = "b_" + szam3[index++].ToString(),
                            Content = "?",
                            FontSize = 20,
                            FontWeight = FontWeights.Bold,
                            Margin = new Thickness(3)
                        };
                        btn.Click += button_cl;

                        Grid.SetRow(btn, i);
                        Grid.SetColumn(btn, j);

                        btn_palya.Children.Add(btn);
                    }

                }
            }
            else if (lbox_palya.SelectedItem == "2x2" && lbox_tema.SelectedItem == "italok")
            {

                List<string> i1 = new List<string>();
                for (int i = 0; i < 2 * 2 / 2; i++)

                {

                    i1.Add(drinks[i].ToString());

                    i1.Add(drinks[i].ToString());

                }
                point = 0;
                tb_point.Text = "Próbálkozások: " + point;
                btn_palya.RowDefinitions.Clear();

                btn_palya.ColumnDefinitions.Clear();
                for (int i = 0; i < 2; i++)
                {
                    btn_palya.RowDefinitions.Add(new RowDefinition());
                    btn_palya.ColumnDefinitions.Add(new ColumnDefinition());
                }
                i1 = i1.Shuffle().ToList();

                int index = 0;
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Button btn = new Button
                        {
                            Name = "b_" + i1[index++].ToString(),
                            Content = "?",
                            FontSize = 20,
                            FontWeight = FontWeights.Bold,
                            Margin = new Thickness(3)
                        };
                        btn.Click += button_cl;
                        Grid.SetRow(btn, i);
                        Grid.SetColumn(btn, j);
                        btn_palya.Children.Add(btn);
                    }

                }
            }

            else if (lbox_palya.SelectedItem == "4x4" && lbox_tema.SelectedItem == "italok")
            {

                List<string> i2 = new List<string>();
                for (int i = 0; i < 4 * 4 / 2; i++)

                {

                    i2.Add(drinks[i].ToString());

                    i2.Add(drinks[i].ToString());

                }
                point = 0;
                tb_point.Text = "Próbálkozások: " + point;
                btn_palya.RowDefinitions.Clear();

                btn_palya.ColumnDefinitions.Clear();
                for (int i = 0; i < 4; i++)
                {
                    btn_palya.RowDefinitions.Add(new RowDefinition());
                    btn_palya.ColumnDefinitions.Add(new ColumnDefinition());
                }
                i2 = i2.Shuffle().ToList();

                int index = 0;
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Button btn = new Button
                        {
                            Name = "b_" + i2[index++].ToString(),
                            Content = "?",
                            FontSize = 20,
                            FontWeight = FontWeights.Bold,
                            Margin = new Thickness(3)
                        };
                        btn.Click += button_cl;
                        Grid.SetRow(btn, i);
                        Grid.SetColumn(btn, j);
                        btn_palya.Children.Add(btn);
                    }

                }
            }
            else if (lbox_palya.SelectedItem == "6x6" && lbox_tema.SelectedItem == "italok")
            {

                List<string> i3 = new List<string>();
                for (int i = 0; i < 6 * 6 / 2; i++)

                {

                    i3.Add(drinks[i].ToString());

                    i3.Add(drinks[i].ToString());

                }
                point = 0;
                tb_point.Text = "Próbálkozások: " + point;
                btn_palya.RowDefinitions.Clear();

                btn_palya.ColumnDefinitions.Clear();
                for (int i = 0; i < 6; i++)
                {
                    btn_palya.RowDefinitions.Add(new RowDefinition());
                    btn_palya.ColumnDefinitions.Add(new ColumnDefinition());
                }
                i3 = i3.Shuffle().ToList();

                int index = 0;
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        Button btn = new Button
                        {
                            Name = "b_" + i3[index++].ToString(),
                            Content = "?",
                            FontSize = 20,
                            FontWeight = FontWeights.Bold,
                            Margin = new Thickness(3)
                        };
                        btn.Click += button_cl;
                        Grid.SetRow(btn, i);
                        Grid.SetColumn(btn, j);
                        btn_palya.Children.Add(btn);
                    }

                }
            }
            else if (lbox_palya.SelectedItem == "2x2" && lbox_tema.SelectedItem == "csokik")
            {

                List<string> i1 = new List<string>();
                for (int i = 0; i < 2 * 2 / 2; i++)

                {

                    i1.Add(csokik[i].ToString());

                    i1.Add(csokik[i].ToString());

                }
                point = 0;
                tb_point.Text = "Próbálkozások: " + point;
                btn_palya.RowDefinitions.Clear();

                btn_palya.ColumnDefinitions.Clear();
                for (int i = 0; i < 2; i++)
                {
                    btn_palya.RowDefinitions.Add(new RowDefinition());
                    btn_palya.ColumnDefinitions.Add(new ColumnDefinition());
                }
                i1 = i1.Shuffle().ToList();

                int index = 0;
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Button btn = new Button
                        {
                            Name = "b_" + i1[index++].ToString(),
                            Content = "?",
                            FontSize = 20,
                            FontWeight = FontWeights.Bold,
                            Margin = new Thickness(3)
                        };
                        btn.Click += button_cl;
                        Grid.SetRow(btn, i);
                        Grid.SetColumn(btn, j);
                        btn_palya.Children.Add(btn);
                    }

                }
            }

            else if (lbox_palya.SelectedItem == "4x4" && lbox_tema.SelectedItem == "csokik")
            {

                List<string> i2 = new List<string>();
                for (int i = 0; i < 4 * 4 / 2; i++)

                {

                    i2.Add(csokik[i].ToString());

                    i2.Add(csokik[i].ToString());

                }
                point = 0;
                tb_point.Text = "Próbálkozások: " + point;
                btn_palya.RowDefinitions.Clear();

                btn_palya.ColumnDefinitions.Clear();
                for (int i = 0; i < 4; i++)
                {
                    btn_palya.RowDefinitions.Add(new RowDefinition());
                    btn_palya.ColumnDefinitions.Add(new ColumnDefinition());
                }
                i2 = i2.Shuffle().ToList();

                int index = 0;
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        Button btn = new Button
                        {
                            Name = "b_" + i2[index++].ToString(),
                            Content = "?",
                            FontSize = 20,
                            FontWeight = FontWeights.Bold,
                            Margin = new Thickness(3)
                        };
                        btn.Click += button_cl;
                        Grid.SetRow(btn, i);
                        Grid.SetColumn(btn, j);
                        btn_palya.Children.Add(btn);
                    }

                }
            }
            else if (lbox_palya.SelectedItem == "6x6" && lbox_tema.SelectedItem == "csokik")
            {

                List<string> i3 = new List<string>();
                for (int i = 0; i < 6 * 6 / 2; i++)

                {

                    i3.Add(csokik[i].ToString());

                    i3.Add(csokik[i].ToString());

                }
                point = 0;
                tb_point.Text = "Próbálkozások: " + point;
                btn_palya.RowDefinitions.Clear();

                btn_palya.ColumnDefinitions.Clear();
                for (int i = 0; i < 6; i++)
                {
                    btn_palya.RowDefinitions.Add(new RowDefinition());
                    btn_palya.ColumnDefinitions.Add(new ColumnDefinition());
                }
                i3 = i3.Shuffle().ToList();

                int index = 0;
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        Button btn = new Button
                        {
                            Name = "b_" + i3[index++].ToString(),
                            Content = "?",
                            FontSize = 20,
                            FontWeight = FontWeights.Bold,
                            Margin = new Thickness(3)
                        };
                        btn.Click += button_cl;
                        Grid.SetRow(btn, i);
                        Grid.SetColumn(btn, j);
                        btn_palya.Children.Add(btn);
                    }

                }
            }

        }
        private void button_cl(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            if (ind == 0)
            {
                btn.Content = btn.Name.Split('_')[1];
                cont = btn.Name.Split('_')[1];
                ind++;
                gomb1 = btn;
            }
            else if (ind == 1)
            {
                btn.Content = btn.Name.Split('_')[1];
                cont2 = btn.Name.Split('_')[1];
                ind++;
            }
            if (ind == 2)
            {
                if (cont == cont2)
                {
                    MessageBox.Show("Sikeres találat!", "Gratulálok!", MessageBoxButton.OK, MessageBoxImage.Information);
                    gomb1.Click -= button_cl;
                    btn.Click -= button_cl;
                    gomb1.Background = Brushes.LightGreen; 
                    btn.Background = Brushes.LightGreen;
                    ind = 0;
                    cont = "";
                    cont2 = "";
                    point++;
                    tb_point.Text = "Próbálkozások: " + point;
                    prob++;


                }
                else
                {
                    MessageBox.Show("Sikertelen találat!", "Próbálkozz tovább!", MessageBoxButton.OK, MessageBoxImage.Information);
                    ind = 0;
                    cont = "";
                    cont2 = "";
                    btn.Content = "?";
                    gomb1.Content = "?";
                    point++;
                    tb_point.Text = "Próbálkozások: " + point;


                }
            }
            if(prob == btn_palya.Children.Count / 2)
            {
                MessageBox.Show($"Gratulálok, Nyertél {point} próbálkozásból!", "Játék vége", MessageBoxButton.OK, MessageBoxImage.Information);
                point = 0;
                prob = 0;
                ind = 0;
                cont = "";
                cont2 = "";
                gomb1 = null;
                tb_point.Text = "Próbálkozások: 0";
                tb.Text = ""; 
                lbox_palya.SelectedItem = null;
                lbox_tema.SelectedItem = null;
                btn_palya.Children.Clear();
                btn_palya.RowDefinitions.Clear();
                btn_palya.ColumnDefinitions.Clear();
            }

        }
    }
}