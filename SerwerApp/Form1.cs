using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SerwerApp
{
    public partial class Form1 : Form
    {

        private static List<Socket> _clietSockets = new List<Socket>();
        private Socket _serwerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private byte[] _buffer = new byte[1024];
        private Thread _thread;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupSerwer();
            CheckForIllegalCrossThreadCalls = false;

            textAdressIP.Enabled = false;
            textAdressIP.Text = _serwerSocket.AddressFamily.ToString();
        }

        private void SetupSerwer()
        {
            MessageList.Items.Add("Serwer aktywny. Oczekiwanie na hosty..");
            _serwerSocket.Bind(new IPEndPoint(IPAddress.Any, 100));
            _serwerSocket.Listen(5); // ilość oczekujących połączeń, 6 i kolejne zostanie odrzucone
            _serwerSocket.BeginAccept(new AsyncCallback(AcceptCallback), null); // NULL - początkowy stan obiektu

            _thread = new Thread(Listening); // Rozpoczęcie nasłuchiwania w sposób ciągły 
            _thread.Start();
        }

        private void AcceptCallback(IAsyncResult AR)
        {
            Socket socket = _serwerSocket.EndAccept(AR);
            _clietSockets.Add(socket);
            //MessageList.Items.Add("Ktoś właśnie się połączył");

            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);
            _serwerSocket.BeginAccept(new AsyncCallback(AcceptCallback), null); // NULL - początkowy stan obiektu

        }

        private void ReceiveCallback(IAsyncResult AR)
        {

            Socket socket = (Socket)AR.AsyncState;
            int received = socket.EndReceive(AR);
            byte[] dataBuf = new byte[received];
            Array.Copy(_buffer, dataBuf, received);

            string text = Encoding.ASCII.GetString(dataBuf);
            if (text != " ") MessageList.Items.Add(text);


        }


        private void SendCallback(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            //socket.EndSend(AR);
        }

        private void btnSendServer_Click(object sender, EventArgs e)
        {
            if (txtNickSerwer.TextLength > 0)
            {
                if (MessageText.TextLength > 0)
                {
                    string txt = txtNickSerwer.Text + ": " + MessageText.Text;
                    byte[] data = Encoding.ASCII.GetBytes(txt);

                    MessageList.Items.Add(txt);

                    // Multi wysyłanie 

                    foreach (var item in _clietSockets)
                    {
                        item.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(SendCallback), item);
                    };
                }
                else return;
            }
            else MessageBox.Show("Podaj nick aby wysłać wiadomość!");




            /*Socket socket = (Socket)_serwerSocket.EndAccept(AR);
            string response = MessageText.Text;
            byte[] data = Encoding.ASCII.GetBytes(response);
            socket.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(SendCallback), socket);
            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallback), socket);*/
        }

        private void Listening()
        {
            while (true)
            {
                /*byte[] receiveBuf = new byte[1024];
                int rec = _clietSockets[0].Receive(receiveBuf);

                byte[] data = new byte[rec];
                Array.Copy(receiveBuf, data, rec);
                var _msg = Encoding.ASCII.GetString(data);
                MessageList.Items.Add(_msg);*/

                // Multi nasłuchiwanie
                /*
                 MultiListening(0);
                MultiListening(1);
                 */

                // Nasłuchiwanie wszystkich klientó serwera 
                for (int i = 0; i < _clietSockets.Count; i++)
                {
                    MultiListening(i); 
                }
            }
        }

        private void MultiListening(int IDClient)
        {
            byte[] receiveBuf = new byte[1024];
            int rec = _clietSockets[IDClient].Receive(receiveBuf);

            byte[] data = new byte[rec];
            Array.Copy(receiveBuf, data, rec);
            var _msg = Encoding.ASCII.GetString(data);
            if (_msg != " ") MessageList.Items.Add(_msg);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string txt = "Serwer nieaktywny";
            byte[] data = Encoding.ASCII.GetBytes(txt);
            foreach (var item in _clietSockets)
            {
                item.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(SendCallback), item);
            };
            _serwerSocket.Close();
        }
    }
}

