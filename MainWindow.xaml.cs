using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MrsKlyuvdia
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            JournalMrsKlyuvdia journalMrsKlyuvdia = new JournalMrsKlyuvdia();

            CurrentConditionDisplay currentConditionDisplay = new CurrentConditionDisplay(journalMrsKlyuvdia);

            journalMrsKlyuvdia.setJournal(false, "английскому", "самому искать информацию в интернете");
            journalMrsKlyuvdia.setJournal(false, "программированию", "с раннего дества развить интерес к окружающему миру");
            journalMrsKlyuvdia.setJournal(false, "музыке", "развить в себе индивидуальность, необычно подходить к разным задачам");
        }
    }
}
