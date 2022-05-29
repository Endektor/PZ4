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
//using System.Runtime.Remoting;
//using IServer;

namespace Client
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
            //var lol = new object() as IServer.IServer;

            //var objRemote = Activator.GetObject(lol.GetType(), "http://localhost/server/server.soap") as IServer.IServer;

            //Console.Write(objRemote.getServerTime());

        }
    }
}
