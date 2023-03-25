using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
namespace Ex3
{
    
    public partial class formServer : Form
    { 
    byte[] buff = new byte[1024];
    private delegate void updateUI(string massage);
    private updateUI updateUi;
    UdpClient Server = new UdpClient(9000);
    IPEndPoint ep;
        public formServer()
        {
            InitializeComponent();
            updateUi = new updateUI(update);
            CheckForIllegalCrossThreadCalls = false;
        }
        private void update(string m)
        {
            listview_ser.Items.Add(m);
        }
            private void Form1_Load(object sender, EventArgs e)
        {
            formClient fClient = new formClient();
            fClient.Show();  
        }
        private void startServer()
        {
            ep = new IPEndPoint(IPAddress.Any, 9000);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            Server.BeginReceive(new AsyncCallback(recv), null);
            updateUi("Listening, please wait for client ....");
        }
        void recv(IAsyncResult res)
        {
            byte[] rev = Server.EndReceive(res, ref ep);
            string revci = Encoding.UTF8.GetString(rev);
            Server.BeginReceive(new AsyncCallback(recv), null);
            updateUi("Client: " + revci);
        }
        private void sendata(IAsyncResult ia)
        {
            Server.EndSend(ia);
        }
        private void send()
        {
            Server.Connect(IPAddress.Any, 9000);
            string wc = txt_send.Text;
            byte[] ds = Encoding.UTF8.GetBytes(wc);
            Server.BeginSend(ds, ds.Length, new AsyncCallback(sendata), null);
            updateUi("Server: " + wc);
            txt_send.Clear();
        }
        private void btn_start_Click(object sender, EventArgs e)
        {
            startServer();
            txt_send.Focus();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            send();
            txt_send.Focus();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            updateUi("Disconected to client");
            Server.Close();
        }

    }
}
