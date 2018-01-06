using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WifiTestTool
{
    public partial class Form1 : Form
    {
        private Socket clientSocket;
        private Socket serverSocket;
        private List<StateObject> ClientLists = new List<StateObject>();
        private ManualResetEvent connectDone = new ManualResetEvent(false);
        //创建一个委托，是为访问TextBox控件服务的。
        public delegate void UpdateTxt(string msg, TextBox txtBox);
        public delegate void UpdateListBox(Socket socket, ListBox txtBox);
        //定义一个委托变量
        public UpdateTxt updateTxt;

        public UpdateListBox updateListBox;

        private Thread clientConnetListThread;
        bool Islog;
        public Form1()
        {
           
            InitializeComponent();
            clientConnetListThread = new Thread(clientConnetList);
            Islog = checkBox1.Checked;
        }

        private void clientConnetList()
        {
            while (true) {
                if (ClientLists!=null&& ClientLists.Count>0)
                {
                    foreach (var item in ClientLists)
                    {
                        //if (item.workSocket!=null&&(!item.workSocket.)))
                        //{
                        //    ClientLists.Remove(item);
                        //    txtTcpRece.BeginInvoke(updateTxt, Environment.NewLine + item.workSocket.LocalEndPoint.ToString() + "连接断开", txtTcpRece);

                       
                        //    listBoxClient.Invoke(updateListBox, item.workSocket, listBoxClient);
                        //}
                    }
                }


            }
        }

        private void txtTcpSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSendCmd.Text == "")
                {
                    MessageBox.Show("请输入发送信息");
                    return;
                }


                byte[] byteData = Encoding.ASCII.GetBytes(txtSendCmd.Text.Trim());

                //如果是Client
                if (clientSocket != null && tabControl3.SelectedIndex == 0)

                {

                    if (clientSocket.Connected)
                    {


                        clientSocket.Send(byteData);

                        txtSendCmd.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("与服务器连接断开,请连接");
                    }

                }
                //如果是Server
                else if (tabControl3.SelectedIndex == 1)
                {
                    if (ClientLists.Count > 0 && listBoxClient.Items.Count > 0)
                    {
                        foreach (var clientList in ClientLists)
                        {

                            if (listBoxClient.SelectedItems.Count > 0)
                            {
                                if (clientList.workSocket.LocalEndPoint.ToString() == listBoxClient.SelectedItem.ToString())
                                {
                                    if (clientList.workSocket.Connected)
                                    {
                                        clientList.workSocket.Send(byteData);
                                    }
                                }
                            }

                        }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnTcpClearSend_Click(object sender, EventArgs e)
        {
            txtSendCmd.Text = "";
        }

        private void btnBrodcast_Click(object sender, EventArgs e)
        {
            byte[] byteData = Encoding.ASCII.GetBytes(txtSendCmd.Text);
            // 發佈給所有已連線的客戶端
            foreach (var c in ClientLists)
            {
                if (c.workSocket.Connected)
                {
                    c.workSocket.Send(byteData);
                }

            }
        }

        private void btnTcpClearRece_Click(object sender, EventArgs e)
        {
            txtTcpRece.Text = "";
        }

        private void btnNetConnect_Click(object sender, EventArgs e)
        {
            #region sokect 连接
            try
            {
                txtTcpRece.Text = "";
                int serverPort = 0;
                IPAddress ip;
                if (int.TryParse(txtNetServerPort.Text, out serverPort) && IPAddress.TryParse(txtNetServerIp.Text, out ip))
                {
                    IPEndPoint remoteEP = new IPEndPoint(ip, serverPort);

                    clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    clientSocket.BeginConnect(remoteEP, new AsyncCallback(ConnectCallBack), clientSocket);

                    connectDone.WaitOne();
                    Receive(clientSocket);

                    return;
                }
                else
                {
                    MessageBox.Show("请输入正确的ip地址或者端口号");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            #endregion
        }

        private void Receive(Socket client)
        {
            try
            {
                StateObject state = new StateObject();
                state.workSocket = client;
                // 開始非同步接收主機端資料
                if (state.workSocket.Connected)
                {
                    state.workSocket.BeginReceive(state.buffer, 0, state.BufferSize, 0, new AsyncCallback(ReceiveCallback), state);
                }
                else
                {

                    txtTcpRece.BeginInvoke(updateTxt, Environment.NewLine + "连接断开", txtTcpRece);

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            try
            {
                StateObject state = null;
                state = (StateObject)ar.AsyncState;
                Socket server = state.workSocket;
                //!tmpSocket.Poll(10, SelectMode.SelectRead)
            

                if (state.workSocket.Connected)
                {
                    // 從主機端讀取資料
                    int bytesRead = server.EndReceive(ar);
                    // 有資料
                    if (bytesRead > 0)
                    {


                        String MSG = Encoding.ASCII.GetString(state.buffer).Trim("\0".ToCharArray());
                        if (txtTcpRece.InvokeRequired)
                        {
                            txtTcpRece.BeginInvoke(updateTxt, MSG, txtTcpRece);

                           
                        }
                        else
                        {
                            txtTcpRece.AppendText(MSG + Environment.NewLine);
                        }
                        if (Islog)
                        {
                            NLogHelp.WriteLog("--" + MSG, server.LocalEndPoint.ToString());
                        }
                    }
                  
                    // 繼續等待主機回傳的資料
                    state.buffer = new byte[state.BufferSize];

                    state.workSocket.BeginReceive(state.buffer, 0, state.BufferSize, 0, new AsyncCallback(ReceiveCallback), state);
                }
                else
                {
                    txtTcpRece.BeginInvoke(updateTxt, Environment.NewLine + state.workSocket.LocalEndPoint.ToString()+"连接断开", txtTcpRece);
                   
                        ClientLists.Remove(state);
                        listBoxClient.Invoke(updateListBox, state.workSocket, listBoxClient);
                   
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void ConnectCallBack(IAsyncResult ar)
        {
            try
            {
                Socket client = (Socket)ar.AsyncState;
                if (!client.Connected)
                {
                    txtTcpRece.BeginInvoke(updateTxt, "无法连接服务器", txtTcpRece);

                    return;
                }
                // 完成连接
                client.EndConnect(ar);

                string str = "已连接到服务器: " + client.RemoteEndPoint.ToString();


                if (txtTcpRece.InvokeRequired)
                {
                    txtTcpRece.BeginInvoke(updateTxt, str, txtTcpRece);
                }
                else
                {
                    txtTcpRece.AppendText(str + Environment.NewLine);
                }

                // 狀態設定為未收到訊號
                connectDone.Set();
            }
            catch (Exception e)
            {
                connectDone.Set();
                MessageBox.Show(e.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateTxt = new UpdateTxt(UpdateTxtMethod);
            updateListBox = new UpdateListBox(UpdateListBoxMethod);
        }
        public void UpdateTxtMethod(string msg, TextBox txtBox)
        {
            if (txtBox.Text.Length>1024)
            {
                txtBox.Text = txtBox.Text.Substring(txtBox.Text.Length - 1024, txtBox.Text.Length );
            }
            txtBox.Text += (Environment.NewLine + msg);

            txtBox.SelectionStart = txtBox.Text.Length;

            txtBox.ScrollToCaret();
        }
        private void UpdateListBoxMethod(Socket socket, ListBox listbox)
        {
            if (socket.Connected)
            {
                listbox.Items.Add(socket.LocalEndPoint.ToString());
            }
            else
            {
                listbox.Items.Remove(socket.LocalEndPoint.ToString());
            }
           
        }

        private void btnNetServerStart_Click(object sender, EventArgs e)
        {
            //clientConnetListThread.Start();
            int port = 0;
            if (!int.TryParse(txtLocalServerPort.Text.Trim(), out port))
            {
                MessageBox.Show("请输入正确的端口号");
                return;
            }
            Islog = checkBox1.Checked;
            listBoxClient.Items.Clear();
            
             IPEndPoint localEP = new IPEndPoint(IPAddress.Any, port);
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                serverSocket.Bind(localEP);
                serverSocket.Listen(10);
                txtTcpRece.AppendText("等待客户端连接");
                serverSocket.BeginAccept(new AsyncCallback(ServerAcceptCallback), serverSocket);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void ServerAcceptCallback(IAsyncResult ar)
        {
            try
            {
                Socket handler = ((Socket)ar.AsyncState).EndAccept(ar);
                StateObject user = new StateObject();
                user.workSocket = handler;
                // 添加 User 到 list
                ClientLists.Add(user);
                // 開始接收訊息

                listBoxClient.Invoke(updateListBox, user.workSocket, listBoxClient);

                user.workSocket.BeginReceive(user.buffer, 0, user.BufferSize, 0, new AsyncCallback(TcpServerReceiveCallback), user);
                // 持續監聽
                serverSocket.BeginAccept(new AsyncCallback(ServerAcceptCallback), serverSocket);
            }
            catch (Exception)
            {

                //throw;
            }
        }
        private void TcpServerReceiveCallback(IAsyncResult ar)
        {
            StateObject user = new StateObject();
            user = (StateObject)ar.AsyncState;
            Socket tmpSocket = user.workSocket;
          
            // 從客戶端讀取資料
            int bytesRead = user.workSocket.EndReceive(ar);
            if (bytesRead > 0) // 有資料
            {

                // 客戶端資料
                String MSG = Encoding.ASCII.GetString(user.buffer).Trim("\0".ToCharArray());
                txtTcpRece.Invoke(updateTxt, MSG, txtTcpRece);
                if (Islog)
                {
                    NLogHelp.WriteLog("--" + MSG, tmpSocket.LocalEndPoint.ToString());
                }
             

            }
            // 清除舊資料
            user.buffer = new byte[user.BufferSize];
            // 等待客戶端再次傳送資料
            user.workSocket.BeginReceive(user.buffer, 0, user.BufferSize, 0, new AsyncCallback(ReceiveCallback), user);
        }

        private void btnServerStop_Click(object sender, EventArgs e)
        {
            var sd = SocketShutdown.Both;
            if (serverSocket!=null&& serverSocket.Connected)
            {
                serverSocket.Close();
            }
        
            serverSocket = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.serialPort1.IsOpen)
                {
                    this.serialPort1.Close();
                }
                else
                {
                    // 设置端口参数
                    this.serialPort1.BaudRate = int.Parse(this.comboBox2.Text);
                    this.serialPort1.DataBits = int.Parse(this.comboBox3.Text);
                    this.serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), this.comboBox4.Text);
                    this.serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), this.comboBox5.Text);
                    this.serialPort1.PortName = this.comportName.Text;
                    //comport.Encoding = Encoding.ASCII;

                    //打开端口
                    this.serialPort1.Open();
                }
                this.groupBox1.Enabled = !this.serialPort1.IsOpen;
                //txtsend.Enabled = btnsend.Enabled = comport.IsOpen;

                if (this.serialPort1.IsOpen)
                {
                    this.button1.Text = "&C关闭端口";
                }
                else
                {
                    this.button1.Text = "&O打开端口";
                }
                //if (this.serialPort1.IsOpen) txtsend.Focus();
            }
            catch (Exception er)
            {
                MessageBox.Show("端口打开失败！" + er.Message, "提示");
            }
        }
    }
}
