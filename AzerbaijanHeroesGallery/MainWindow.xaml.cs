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

namespace AzerbaijanHeroesGallery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Image Image;
        public List<Image> Images { get; set; }
        public MainWindow()
        {
            Images = new List<Image> {
            new Image
                {
                Name="Mübariz İbrahimov",
                ImagePath="Images/Mubariz_Ibrahimov.jpg",
                Date="1988-∞",
                Description="Mübariz İbrahimov 1988-ci il fevralın 7-də Biləsuvar rayonunun Əliabad kəndində anadan olub.1994-cü il şəhid olmuş M.Piriyev adına Əliabad kənd orta məktəbinə daxil olmuşdur.2005-ci ildə orta təhsilini başa vurub, hərbi xidmətə çağrılmışdır.Hərbi xidmətini Daxili Qoşunların N saylı hərbi hissəsinin Xüsusi Təyinatlı Bölüyündə keçirib"
                },
            new Image
                {
                Name="Albert Aqarunov",
                ImagePath="Images/AlbertAqarunov.jpg",
                Date="1969-∞",
                Description="Albert Aqarunoviç Aqarunov 1969-cu il aprelin 25-də Bakının Əmircan qəsəbəsində yəhudi ailəsində anadan olub. Çox erkən yaşlarından musiqilə maraqlanırdı. Musiqi məktəbində nəfəs aləti truba sinifini bitirmişdi.Suraxanı rayonundakı 154 saylı məktəbin səkkizinci sinifini bitirərək peşə məktəbində sürücü-mexanik ixtisasına yiyələnib."
                },
            new Image
                {
                Name="Əliyar Əliyev",
                ImagePath="Images/EliyarEliyev.jpg",
                Date="1957-∞",
                Description="Əliyar Əliyev 1957-ci il dekabrın 14-də Qubadlı rayonunun Qazyan kəndində anadan olub. 1979-cu ildə Azərbaycan Dövlət Bədən Tərbiyəsi İnstitutunu fərqlənmə diplomu ilə bitirərək, bir müddət Qubadlı rayonunun Dondarlı kənd orta məktəbində idman müəllimi işləyib"
                },
            new Image
                {
                Name="Xudayar Yusifzadə",
                ImagePath="Images/Xudayar.jpg",
                Date="1998-∞",
                Description="Xudayar Yusifzadə 1998-ci il iyulun 15-də Bərdə şəhərində anadan olub. Atası — Bərdənin tanınan qarmon ustası Müslüm Yusifoğlu, anası — Rada Yusifzadə isə evdar xanım idi. Ailədə dörd uşaq olublar — üç qardaş və bir bacı. Xudayar Yusifzadənin doğumundan 24 gün sonra atası vəfat edib."
                },
            new Image
                {
                Name="Polad Həşimov",
                ImagePath="Images/PoladHesimov.jpg",
                Date="1975-∞",
                Description="Polad Həşimov 1975-ci il yanvarın 2-də Qutqaşen rayonunun (hal-hazırda Qəbələ rayonu) Vəndam qəsəbəsində anadan olmuşdur. Atası — İsrayıl Həşimov metallurq idi və Sumqayıt şəhərinin Alüminium zavodunda əvvəlcə mühəndis, sonra isə növbə rəisi və sex rəisi vəzifələrində işləmişdir. O, 2005-ci ildə uzun sürən xəstəlikdən sonra vəfat etmişdir."
                },
            new Image
                {
                Name="Cəbrayıl Dövlətzadə",
                ImagePath="Images/Cebrayil.jpg",
                Date="2001-∞",
                Description="Cəbrayıl Dövlətzadə 2001-ci il sentyabrın 11-də Sumqayıt şəhərində Məleykə və Dövlət Dövlətzadələrin ailəsində anadan olub.Əslən Zəngilan rayonundan idi. Subay idi.Cəbrayıl Dövlətzadə sentyabrın 28-də Murovdağ döyüşləri zamanı Kəlbəcər rayonu ərazisində şəhid olub."
                },
            new Image
                {
                Name="Allahverdi Bağırov",
                ImagePath="Images/AllahverdiBagirov.jpg",
                Date="1946-∞",
                Description="Allahverdi Bağırov 1946-cı il aprel ayının 22-də Ağdamda anadan olub. Yeddi qız övladından sonra dünyaya gəlmişdi və buna görə də ailəsi Allahın payı sanıb, onun adını Allahverdi qoymuşdular. Bu ad həm də onun babasının (anası tərəfdən) adıdır.O, gənc yaşlarından cəsarətli, qorxmaz, sözübütöv, haqsızlığa dözməyən və davakar idi."
                },
            new Image
                {
                Name="Muxtar Qasımlı",
                ImagePath="Images/Muxtar_Qasımlı.jpg",
                Date="1993-∞",
                Description="Muxtar Qasımlı 23 fevral 1993-cü ildə Bakı şəhərində anadan olub. 1999-cu ildə Bakı şəhəri 318 nömrəli tam orta məktəbə daxil olmuşdur. 2009-cu ildə məktəbi bitirmişdir. 2009-2013-cü illərdə Azərbaycan Dövlət Bədən Tərbiyəsi və İdman Akademiyasının kikboksinq fakültəsi üzrə Bakalavr təhsili almışdır.Dəfələrlə yarışlarda iştirak edib və mükafaflara layiq görülüb"
                },
            new Image
                {
                Name="Asif Məhərrəmov",
                ImagePath="Images/Asif_Maharammov.jpg",
                Date="1952-∞",
                Description="Asif Yusif oğlu Məhərrəmov 1952-ci il iyulun 26-da Ağdam şəhərində anadan olub.Uşaqlığı yoxsulluq içində keçib.Uşaqlıqdan boks və futbolla məşğul olub 1976-cı ildə Asif qız qaçırıb və onunla qısa ömür sürəndən sonra qəfil avtomobil qəzasına tuş gəlir.Təsadüf nəticəsində Təcili yardım maşınını vurulmasına görə, ona 4,5 il iş veriblər."
                }
           
            };
            DataContext = this;
            InitializeComponent();
        }

        private void mainListbox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (mainListbox.SelectedItem is Image item)
            {
                PropertyWindow propertyWindow = new PropertyWindow();
                propertyWindow.ImageCopy = Images;
                propertyWindow.index = mainListbox.SelectedIndex;
                Image = item;
                propertyWindow.mainImage.Source = new BitmapImage(new Uri(item.ImagePath, UriKind.RelativeOrAbsolute));
                propertyWindow.descriptionTxtb.Text = item.Description;
                propertyWindow.dateTxtBlk.Text = item.Date;
                propertyWindow.nameTxtBlk.Text = item.Name;
                propertyWindow.ShowDialog();
            }

        }
        private void largeIcons_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["Size"] = 300.0;
        }

        private void mediumIcons_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["Size"] = 150.0;
        }

        private void smallIcons_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["Size"] = 50.0;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void About_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
