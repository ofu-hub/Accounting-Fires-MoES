using System.Windows;
using System.Windows.Controls;

namespace MoesApp.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для ReportWindow.xaml
    /// </summary>
    public partial class ReportWindow : Window
    {
        public ReportWindow()
        {
            InitializeComponent();
        }

        // - Общие сведения
        private void orgCode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = sender as ComboBox;

            orgCode.SelectedIndex = box.SelectedIndex;
        }

        private void typeCode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = sender as ComboBox;

            typeCode.SelectedIndex = box.SelectedIndex;
        }

        private void typeFireCode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = sender as ComboBox;

            typeFireCode.SelectedIndex = box.SelectedIndex;
        }

        // - Объект пожара
        private void subjectCode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = sender as ComboBox;

            subjectCode.SelectedIndex = box.SelectedIndex;
        }

        private void subTypeOwnerCode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = sender as ComboBox;

            subTypeOwnerCode.SelectedIndex = box.SelectedIndex;
        }

        private void objRiskCode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = sender as ComboBox;

            objRiskCode.SelectedIndex = box.SelectedIndex;
        }

        private void kindFireObjCode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = sender as ComboBox;

            kindFireObjCode.SelectedIndex = box.SelectedIndex;
        }

        private void locationFireCode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = sender as ComboBox;

            locationFireCode.SelectedIndex = box.SelectedIndex;
        }

        private void causeFireCode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = sender as ComboBox;

            causeFireCode.SelectedIndex = box.SelectedIndex;
        }

        private void guiltyPersonCode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = sender as ComboBox;

            guiltyPersonCode.SelectedIndex = box.SelectedIndex;
        }

        private void attitudePersonCode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = sender as ComboBox;

            attitudePersonCode.SelectedIndex = box.SelectedIndex;
        }

        private void statePersonCode_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = sender as ComboBox;

            statePersonCode.SelectedIndex = box.SelectedIndex;
        }

        // - Последствия пожара
    }
}
