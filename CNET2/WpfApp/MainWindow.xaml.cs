using Data;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Wait;
            Stopwatch s = Stopwatch.StartNew();

            TextBlock1.Text = "Nacti subory";
            var files = Directory.EnumerateFiles(@"C:\Users\StudentEN\Desktop\yip");
            foreach (var file in files)
            {
                var result = FreqAnalysis.FreqAnalysisFromFile(file);

                TextBlock1.Text += result.Source;


                foreach (var word in result.GetTop10())
                {
                    TextBlock1.Text += $"{word.Key}: {word.Value}\n";
                }


            }
            s.Stop();
            Mouse.OverrideCursor = null;
            TextBlock1.Text = s.ElapsedMilliseconds + "\n" + "\n" + TextBlock1.Text;

        }

        private async void Button2_Click(object sender, RoutedEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Wait;
            Stopwatch s = Stopwatch.StartNew();

            TextBlock1.Text = "Nacti subory";
            var files = Directory.EnumerateFiles(@"C:\Users\StudentEN\Desktop\yip");


            IProgress<string> progress = new Progress<string>(message => { TextBlock1.Text += message; });

          await   Parallel.ForEachAsync (files, async (file, cancellationToken) =>
            {
                var result = FreqAnalysis.FreqAnalysisFromFile(file);
                string message = "";
                 
               message +=  result.Source;


                foreach (var word in result.GetTop10())
                {
                    message += $"{word.Key}: {word.Value}\n";
                }

progress.Report(message);
            });





            s.Stop();

            TextBlock1.Text = s.ElapsedMilliseconds + "\n" + "\n" + TextBlock1.Text;
            
            Mouse.OverrideCursor = null;

        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Wait;
            Stopwatch s = Stopwatch.StartNew();

            TextBlock1.Text = "Nacti subory";

            string url1 = "https://seznam.cz";
            string url2 = "https://seznamzpravy.cz";
            string url3 = "https://ictpro.cz";

          var t1 = Task.Run(() => Webload.LoadUrl(url1));
          var t2 = Task.Run(() => Webload.LoadUrl(url2));
          var t3 = Task.Run(() => Webload.LoadUrl(url3));
            Task.WaitAny(t1, t2, t3);
            TextBlock1.Text = "dobehol prvy task";
            TextBlock1.Text = s.ElapsedMilliseconds + "\n" + "\n" + TextBlock1.Text;
            s.Stop();

          

            Mouse.OverrideCursor = null;

        }

        private async void Button4_Click(object sender, RoutedEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Wait;
            Stopwatch s = Stopwatch.StartNew();

            TextBlock1.Text = "Nacti subory";

            string url1 = "https://seznam.cz";
            string url2 = "https://seznamzpravy.cz";
            string url3 = "https://ictpro.cz";

            var t1 = Task.Run(() => Webload.LoadUrl(url1));
            var t2 = Task.Run(() => Webload.LoadUrl(url2));
            var t3 = Task.Run(() => Webload.LoadUrl(url3));
            var firstDone = await Task.WhenAny(t1, t2, t3);

            TextBlock1.Text += "dobehol prvy task";


            TextBlock1.Text = "dobehol prvy task";
            TextBlock1.Text = s.ElapsedMilliseconds + "\n" + "\n" + TextBlock1.Text;
            s.Stop();



            Mouse.OverrideCursor = null;



        }
    }
}
