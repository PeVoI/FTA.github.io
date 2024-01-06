using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Xml.Linq;
using FTA;

namespace FTA
{
    public partial class Marshruti : Window
    {
        public ObservableCollection<object> marshrut;
        XDocument doc;
        public Marshruti()
        {
            InitializeComponent();
            Boo();
        }

        private void Boo()
        {
            doc = XDocument.Load("C:\\Users\\petrv\\source\\repos\\FTA\\Marshruti.xml");
            var Books = (from x in doc.Element("Marshruts").Elements("marshrut")
                         orderby x.Element("id").Value
                         select new
                         {
                             Код__маршрута = x.Element("id").Value,
                             Название = x.Element("nasvanie").Value,
                             Дальность = x.Element("dal").Value,
                             Количество__дней__в__пути = x.Element("days").Value,
                             Оплата = x.Element("cash").Value,
                         }).ToList();

            marshrut = new ObservableCollection<object>(Books);

            dg.ItemsSource = marshrut;
        }

        private void Marshrut_Click(object sender, RoutedEventArgs e)
        {
            Marshruti marshruti = new Marshruti();
            marshruti.Show();
            Hide();
        }

        private void dg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void but1_Click(object sender, RoutedEventArgs e)
        {
            var booksCount = (from x in doc.Element("Marshruts").Elements("marshrut")
                              where (string)x.Element("id") == text1.Text
                              select new
                              {
                                  Код__маршрута = x.Element("id").Value,
                                  Название = x.Element("nasvanie").Value,
                                  Дальность = x.Element("dal").Value,
                                  Количество__дней__в__пути = x.Element("days").Value,
                                  Оплата = x.Element("cash").Value,
                              }).ToList();

            Boo();
            dg.ItemsSource = booksCount;
        }

        private void but2_Click(object sender, RoutedEventArgs e)
        {
            Boo();
        }

        private void but3_Click(object sender, RoutedEventArgs e)
        {
            doc = XDocument.Load("C:\\Users\\petrv\\source\\repos\\FTA\\Marshruti.xml");

            XElement root = doc.Element("Marshruts");
            XElement newMarshruts = null;

            foreach (XElement x in root.Elements("marshrut"))
            {
                if (x.Element("id").Value == textbox10.Text)
                {
                    String a = x.Element("nasvanie").Value;
                    String b = x.Element("dal").Value;
                    String c = x.Element("days").Value;
                    String d = x.Element("cash").Value;

                    newMarshruts = new XElement("marshrut",
                                  new XElement("id", textbox10.Text),
                                  new XElement("nasvanie", a),
                                  new XElement("dal", b),
                                  new XElement("days", c),
                                  new XElement("cash", textbox11.Text));

                    MessageBox.Show("Новые данные добавлены");
                    marshrut.Add(new Marshrut { Код__маршрута = textbox10.Text, Название = a, Дальность = b, Количество__дней__в__пути = c, Оплата = textbox11.Text });
                }
            }

            if (newMarshruts != null)
            {
                doc.Element("Marshruts").Add(newMarshruts);
                doc.Save("C:\\Users\\petrv\\source\\repos\\FTA\\Marshruti.xml");
                Boo();
            }
        }

        private void but6_Click(object sender, RoutedEventArgs e)
        {
            doc.Element("Marshruts").Add(new XElement("marshrut",
                      new XElement("id", textbox12.Text),
                      new XElement("nasvanie", textbox13.Text),
                      new XElement("dal", textbox14.Text),
                      new XElement("days", textbox15.Text),
                      new XElement("cash", textbox16.Text)));

            MessageBox.Show("Новые данные добавлены");
            marshrut.Add(new Marshrut { Код__маршрута = textbox12.Text, Название = textbox13.Text, Дальность = textbox14.Text, Количество__дней__в__пути = textbox15.Text, Оплата = textbox16.Text });
            doc.Save("C:\\Users\\petrv\\source\\repos\\FTA\\Marshruti.xml");
            Boo();
        }
        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            Tables tables = new Tables();
            tables.Show();
            Hide();
        }
    }
    public class Marshrut
    {
        public string Код__маршрута { get; set; }
        public string Название { get; set; }
        public string Дальность { get; set; }
        public string Количество__дней__в__пути { get; set; }
        public string Оплата { get; set; }



    }
}

