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
    public partial class Works : Window
    {
        public ObservableCollection<object> work;
        XDocument doc;
        public Works()
        {
            InitializeComponent();
            Boo();
        }

        private void dg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Boo()
        {
            doc = XDocument.Load("C:\\Users\\petrv\\source\\repos\\FTA\\Works.xml");
            var Books = (from x in doc.Element("Works").Elements("Work")
                         orderby x.Element("id").Value
                         select new
                         {
                             Код__маршрута = x.Element("id").Value,
                             Код__водителя = x.Element("idv").Value,
                             Дата__отправки = x.Element("otpr").Value,
                             Дата__возвращения = x.Element("vozvr").Value,
                             Премия = x.Element("prem").Value
                         }).ToList();

            work = new ObservableCollection<object>(Books);

            dg.ItemsSource = work;
        }

        private void but1_Click(object sender, RoutedEventArgs e)
        {
            var booksCount = (from x in doc.Element("Works").Elements("Work")
                              where (string)x.Element("id") == text1.Text
                              select new
                              {
                                  Код__маршрута = x.Element("id").Value,
                                  Код__водителя = x.Element("idv").Value,
                                  Дата__отправки = x.Element("otpr").Value,
                                  Дата__возвращения = x.Element("vozvr").Value,
                                  Премия = x.Element("prem").Value
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
            doc = XDocument.Load("C:\\Users\\petrv\\source\\repos\\FTA\\Works.xml");

            XElement root = doc.Element("Works");
            XElement newWorki = null;

            foreach (XElement x in root.Elements("Work"))
            {
                if (x.Element("id").Value == textbox10.Text)
                {
                    String a = x.Element("idv").Value;
                    String b = x.Element("otpr").Value;
                    String c = x.Element("vozvr").Value;
                    String d = x.Element("prem").Value;

                    newWorki = new XElement("Work",
                                  new XElement("id", textbox10.Text),
                                  new XElement("idv", a),
                                  new XElement("otpr", b),
                                  new XElement("vozvr", c),
                                  new XElement("prem", textbox11.Text));                                  

                    MessageBox.Show("Новые данные добавлены");
                    work.Add(new Work { Код__маршрута = textbox10.Text, Код__водителя = a, Дата__отправки = b, Дата__возвращения = c, Премия = textbox11.Text });
                }
            }

            if (newWorki != null)
            {
                doc.Element("Works").Add(newWorki);
                doc.Save("C:\\Users\\petrv\\source\\repos\\FTA\\Works.xml");
                Boo();
            }
        }

        private void but6_Click(object sender, RoutedEventArgs e)
        {
            doc.Element("Works").Add(new XElement("Work",
                      new XElement("id", textbox12.Text),
                      new XElement("idv", textbox13.Text),
                      new XElement("otpr", textbox14.Text),
                      new XElement("vozvr", textbox15.Text),
                      new XElement("prem", textbox16.Text)));

            MessageBox.Show("Новые данные добавлены");
            work.Add(new Work { Код__маршрута = textbox12.Text, Код__водителя = textbox13.Text, Дата__отправки = textbox14.Text, Дата__возвращения = textbox15.Text, Премия = textbox16.Text });
            doc.Save("C:\\Users\\petrv\\source\\repos\\FTA\\Works.xml");
            Boo();
        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            Tables tables = new Tables();
            tables.Show();
            Hide();
        }
    }
    public class Work
    {
        public string Код__маршрута { get; set; }
        public string Код__водителя { get; set; }
        public string Дата__отправки { get; set; }
        public string Дата__возвращения { get; set; }
        public string Премия { get; set; }



    }
}
