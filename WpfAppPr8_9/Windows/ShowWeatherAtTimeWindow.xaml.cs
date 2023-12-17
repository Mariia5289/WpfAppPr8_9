using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Serialization;
using WpfAppPr8_9.Classes;
using WpfAppPr8_9.DataModel;
using WpfAppPr8_9.CustomControls;

namespace WpfAppPr8_9.Windows
{
    /// <summary>
    /// Логика взаимодействия для ShowWeatherAtTimeWindow.xaml
    /// </summary>
    public partial class ShowWeatherAtTimeWindow : Window
    {
        private Prognosis prognosis;
        public ShowWeatherAtTimeWindow(Prognosis prog)
        {
            InitializeComponent();
            prognosis = prog;
            labelContent.Content += " " + prognosis.Date.Value.ToShortDateString();
            LoadDatalWrapPanel(prog.Time);
        }
        private void LoadDatalWrapPanel(string info)
        {
            List<ComplexWeatherInfo> infos;
                      
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<ComplexWeatherInfo>));
            using (StringReader reader = new StringReader(info))
            {
                infos = xmlSerializer.Deserialize(reader) as List<ComplexWeatherInfo>;
            }

            infos.ForEach(item => wrapPanelWeather.Children.Add(new WeatherCustomControl(item)));

        }


    }
}
