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

namespace FTA
{
    public partial class Voditel : Window
    {
        public ObservableCollection<object> voditel;
        XDocument doc;
        public Voditel()
        {
            InitializeComponent();
            Boo();
        }

        private void Boo()
        {
            doc = XDocument.Load("C:\\Users\\petrv\\source\\repos\\FTA\\Voditels.xml");
            var Books = (from x in doc.Element("Voditels").Elements("Voditel")
                         orderby x.Element("idv").Value
                         select new
                         {
                             Код__водителя = x.Element("idv").Value,
                             Фамилия = x.Element("fam").Value,
                             Имя = x.Element("name").Value,
                             Отчество = x.Element("otch").Value,
                             Стаж = x.Element("staz").Value
                         }).ToList();

            voditel = new ObservableCollection<object>(Books);

            dg.ItemsSource = voditel;
        }


        private void dg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void but6_Click(object sender, RoutedEventArgs e)
        {
            var booksCount = (from x in doc.Element("Voditels").Elements("Voditel")
                              where (string)x.Element("idv") == text1.Text
                              select new
                              {
                                  Код__водителя = x.Element("idv").Value,
                                  Фамилия = x.Element("fam").Value,
                                  Имя = x.Element("name").Value,
                                  Отчество = x.Element("otch").Value,
                                  Стаж = x.Element("staz").Value
                              }).ToList();

            Boo();
            dg.ItemsSource = booksCount;
        }

        private void but5_Click(object sender, RoutedEventArgs e)
        {
            Boo();
        }

        private void but4_Click(object sender, RoutedEventArgs e)
        {
            doc = XDocument.Load("C:\\Users\\petrv\\source\\repos\\FTA\\Voditels.xml");

            XElement root = doc.Element("Voditels");
            XElement newVoditeli = null;

            foreach (XElement x in root.Elements("Voditel"))
            {
                if (x.Element("idv").Value == textbox10.Text)
                {
                    String a = x.Element("fam").Value;
                    String b = x.Element("name").Value;
                    String c = x.Element("otch").Value;
                    String d = x.Element("staz").Value;

                    newVoditeli = new XElement("Voditel",
                                  new XElement("idv", textbox10.Text),
                                  new XElement("fam", a),
                                  new XElement("name", b),
                                  new XElement("otch", c),
                                  new XElement("staz", textbox11.Text));

                    MessageBox.Show("Новые данные добавлены");
                    voditel.Add(new Voditels { Код__водителя = textbox10.Text, Фамилия = a, Имя = b, Отчество = c, Стаж = textbox11.Text });
                }
            }

            if (newVoditeli != null)
            {
                doc.Element("Voditels").Add(newVoditeli);
                doc.Save("C:\\Users\\petrv\\source\\repos\\FTA\\Voditels.xml");
                Boo();
            }
        }

        private void but7_Click(object sender, RoutedEventArgs e)
        {
            doc.Element("Voditels").Add(new XElement("Voditel",
                      new XElement("idv", textbox12.Text),
                      new XElement("fam", textbox13.Text),
                      new XElement("name", textbox14.Text),
                      new XElement("otch", textbox15.Text),
                      new XElement("staz", textbox16.Text)));                     

            MessageBox.Show("Новые данные добавлены");
            voditel.Add(new Voditels { Код__водителя = textbox12.Text, Фамилия = textbox13.Text, Имя = textbox14.Text, Отчество = textbox15.Text, Стаж = textbox16.Text });
            doc.Save("C:\\Users\\petrv\\source\\repos\\FTA\\Voditels.xml");
            Boo();
        }
        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            Tables tables = new Tables();
            tables.Show();
            Hide();
        }
    }
    public class Voditels
    {
        public string Код__водителя { get; set; }
        public string Фамилия { get; set; }
        public string Имя { get; set; }
        public string Отчество { get; set; }
        public string Стаж { get; set; }



    }
}
