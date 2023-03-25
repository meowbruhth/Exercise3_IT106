using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Ex3
{
    public partial class formClient : Form
    {
        byte[] buff = new byte[1024];
        private delegate void updateUI(string massage);
        private updateUI updateUi;
        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        IPEndPoint ep;
        
        public formClient()
        {
            InitializeComponent();
            updateUi = new updateUI(update);
            CheckForIllegalCrossThreadCalls = false;
        }
        private void update(string m)
        {
            listView_cl.Items.Add(m);
        }
        private void startClient()
        {
            ep = new IPEndPoint(IPAddress.Parse(txt_IP.Text), Int32.Parse(txt_port.Text));
            socket.Connect(ep);
            updateUi("Connected server!");
            socket.BeginReceive(buff, 0, buff.Length, SocketFlags.None, new AsyncCallback(recv), socket);
        }
        void recv(IAsyncResult res)
        {
            var rev = socket.EndReceive(res);
            byte[] bf = new byte[rev];
            string revc = Encoding.UTF8.GetString(bf);
            updateUi("Server: " + revc);
            socket.BeginReceive(buff, 0, buff.Length, SocketFlags.None, new AsyncCallback(recv), socket);
        }
        private void sendata(IAsyncResult ia)
        {
            socket.EndSend(ia);
        }

        private void send()
        {
            string wc = txt_send.Text;
            byte[] send = new byte[1024];
            send = Encoding.UTF8.GetBytes(wc);
            txt_send.Clear();
            updateUi("Client: " + wc);
            socket.BeginSend(send, 0, send.Length, SocketFlags.None, new AsyncCallback(sendata), socket);
        }
        private void fClient_Load(object sender, EventArgs e)
        {

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            send();
            txt_send.Focus();
        }

        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            updateUi("Disconnected server");
            this.Close();
        }

        private void txt_port_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                startClient();
            }
        }

        private void txt_send_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                send();
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            startClient();
            txt_send.Focus();
        }
    }
}
