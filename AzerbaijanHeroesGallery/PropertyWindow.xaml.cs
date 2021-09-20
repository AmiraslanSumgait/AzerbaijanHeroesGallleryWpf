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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace AzerbaijanHeroesGallery
{
    /// <summary>
    /// Interaction logic for PropertyWindow.xaml
    /// </summary>
    public partial class PropertyWindow : Window
    {
        public int index;

        public Image Image;
        public List<Image> ImageCopy { get; set; }

        DispatcherTimer timer = new DispatcherTimer();
        public PropertyWindow()
        {
            InitializeComponent();
        }
        public void autoplay()
        {
            timer.Start();
            try
            {
                timer.Interval = new TimeSpan(0, 0, 0, 3);
                mainImage.Source = new BitmapImage(new Uri(ImageCopy[index].ImagePath, UriKind.RelativeOrAbsolute));
                nameTxtBlk.Text = ImageCopy[index].Name;
               
                dateTxtBlk.Text = ImageCopy[index].Date.ToString();
                descriptionTxtb.Text = ImageCopy[index].Description;
                index++;
            }
            catch (Exception)
            {
                index = 0;
                autoplay();
            }

        }
        private void t_tick(object sender, EventArgs e)
        {
            autoplay();
        }
        private void prevBtn_Click(object sender, RoutedEventArgs e)
        {
            if (index > 0)
            {
                Image = ImageCopy[index - 1];
                index -= 1;
                mainImage.Source = new BitmapImage(new Uri(Image.ImagePath, UriKind.RelativeOrAbsolute));
                nameTxtBlk.Text = ImageCopy[index].Name ;
               
                dateTxtBlk.Text = ImageCopy[index].Date.ToString();
                descriptionTxtb.Text = ImageCopy[index].Description;
            }
            else
            {
                index = ImageCopy.Count-1;
                Image = ImageCopy[index];
                mainImage.Source = new BitmapImage(new Uri(Image.ImagePath, UriKind.RelativeOrAbsolute));
                nameTxtBlk.Text = ImageCopy[index].Name;
             
                dateTxtBlk.Text = ImageCopy[index].Date.ToString();
                descriptionTxtb.Text = ImageCopy[index].Description;
            }
        }

        private void nextBtn_Click(object sender, RoutedEventArgs e)
        {
            if (index < ImageCopy.Count - 1)
            {
                Image = ImageCopy[index + 1];
                index += 1;
                mainImage.Source = new BitmapImage(new Uri(Image.ImagePath, UriKind.RelativeOrAbsolute));
                nameTxtBlk.Text = ImageCopy[index].Name ;
                dateTxtBlk.Text = ImageCopy[index].Date.ToString();
                descriptionTxtb.Text = ImageCopy[index].Description;
            }
            else
            {
                index = 1;
                Image = ImageCopy[index];
                mainImage.Source = new BitmapImage(new Uri(Image.ImagePath, UriKind.RelativeOrAbsolute));
                nameTxtBlk.Text = ImageCopy[index].Name;
                dateTxtBlk.Text = ImageCopy[index].Date.ToString();
                descriptionTxtb.Text = ImageCopy[index].Description;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void autoPlayBtn_Click(object sender, RoutedEventArgs e)
        {
            autoplay();
            timer.Tick += new EventHandler(t_tick);
        }
        private void pauseBtn_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch (Exception)
            {
            }
        }
    }
}
