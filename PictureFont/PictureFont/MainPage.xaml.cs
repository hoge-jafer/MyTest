using PictureFont.DataPage;
using PictureFont.Model;
using PictureFont.Page;
using PictureFont.UserData;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using static PictureFont.MainPage;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PictureFont
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage 
    {
        string path;
        SQLite.SQLiteConnection conn;//创建一个SQLite的对象(全局的变量)
        //private ObservableCollection<Category> Categorys;
        private List<Category> category;
        public MainPage()
        {
            this.InitializeComponent();
            //Categorys = new ObservableCollection<Category>();
            //category = CategoryManager.GetCategorys();
            //利用path的变量从本地创建一个SQLite的数据库
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sqlite");
            //利用path变量的数据传给数据对象conn
            //conn = new SQLite.SQLiteConnection(new SQLite.WinRT.SQLitePlatformWinRT(), path);
            //从Message类中创建一个表
            //conn.CreateTable<UserSignUp>();
        }

        private void MainListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SettingListBoxItem.IsSelected)
            {
                Frame.Navigate(typeof(Setting));
            }
            if (SaferListBoxItem.IsSelected)
            {
                Frame.Navigate(typeof(Safer));
            }
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MainSplitView.IsPaneOpen = !MainSplitView.IsPaneOpen;
        }

        private void MainCategory_ItemClick(object sender, ItemClickEventArgs e)
        {
            //var cate = (Category)e.ClickedItem;
            //if (cate.Id==1)
            //{
               
            //}
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Home.IsSelected = true;
        }

        private void MainGridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (RedRectangle.IsTapEnabled)
            {
                Frame.Navigate(typeof(Red));
            }
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(SignIn));
        }
    }
}
