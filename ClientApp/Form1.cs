using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class Client : Form
    {
        private Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private Thread _thread; // Wątek dla nasłuchiwania komunikatów ze strony serwera
        private Thread _thread_2; // Wątek wysyłający w sposób ciągły komunikat do serwera, info że jest aktywny 
        public Client()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            // Obsługa front
            textSerwerIP.Enabled = false;
            textSerwerIP.Text = _clientSocket.AddressFamily.ToString();
        }

        private void SendLoop(string message) // Wysyłanie wiadomości do serwera
        {

            try
            {
                byte[] buffer = Encoding.ASCII.GetBytes(message);
                _clientSocket.Send(buffer);
            }
            catch (Exception q)
            {
                MessageListClient.Items.Clear();
                MessageListClient.Items.Add("Serwer nieaktywny");
            }
        }

        private void Listening() // Nasłuchiwanie komunikatów ze strony serwera
        {
            while (_clientSocket.Connected)
            {
                try
                {
                    byte[] receiveBuf = new byte[1024];
                    int rec = _clientSocket.Receive(receiveBuf);

                    byte[] data = new byte[rec];
                    Array.Copy(receiveBuf, data, rec);
                    var _msg = Encoding.ASCII.GetString(data);

                    MessageListClient.Items.Add(_msg);
                }
                catch (Exception q)
                {
                    MessageListClient.Items.Clear();
                    MessageListClient.Items.Add("Serwer nieaktywny. Wylaczanie aplikacji..");
                    throw;
                }
            }

        }

        private void Hibernate() // Wysyłanie komunikatu do serwera, info że jest aktywny, zapobieganie blokowaniu kolejki na serwerze "do odsłuchu"
        {
            var timer1 = new System.Threading.Timer(_ => SendLoop(" "), null, 0, 200);
        }


        private void LoopConnect() // Łączenie się z serwerem w sposób ciągły 
        {

            int connects = 0;
            while (!_clientSocket.Connected && connects != 2)
            {
                try
                {
                    connects++;
                    _clientSocket.Connect(IPAddress.Loopback, 100);
                }
                catch (Exception q)
                {
                    MessageBox.Show("Błąd połączenia nr" + connects);
                }
            }

            if (_clientSocket.Connected) MessageListClient.Items.Add("Połączony z serwerem");


        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            LoopConnect(); // łączenie do póki nie zamknie się aplikacji
            _thread = new Thread(Listening); // Rozpoczęcie wątku nasłuchiwanie
            _thread.Start();

            _thread_2 = new Thread(Hibernate); // Rozpoczęcie wątku informującego o aktywności klienta, hibernacji aktualnie, gotowość do działania
            _thread_2.Start();

            string txt = "Host " + txtNick.Text + " aktywny.";
            SendLoop(txt);


        }

        private void btnSendClient_Click(object sender, EventArgs e)
        {
            if (txtNick.TextLength > 0)
            {
                if (TextMessage.TextLength > 0)
                {
                    string txt = txtNick.Text + ": " + TextMessage.Text;

                    // Obsługa front
                    MessageListClient.Items.Add(txt);
                    TextMessage.Text = "";

                    // Wysyłanie wiadomosci
                    SendLoop(txt);
                }
                else return;
            }
            else MessageBox.Show("Podaj nick aby wysłać wiadomość!");

        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            string txt = "Host " + txtNick.Text + " nieaktywny.";
            SendLoop(txt);
            MessageBox.Show("Rozłączono");
        }
    }
}
