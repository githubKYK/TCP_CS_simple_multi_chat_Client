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
using System.IO;
using System.Threading;

namespace ClientClient
{
    public partial class Form1 : Form
    {

        public TcpClient m_client;
        public NetworkStream m_stream;
        public BinaryReader m_reader;
        public BinaryWriter m_writer;

        public Thread m_thread;

        public delegate void dlgFunc(string text);

        public void invokeFn(string text)
        {
            this.Invoke(new dlgFunc(updateChat), new object[] { text });
        }
        public void updateChat(string text)
        {
            this.list_chats.Items.Add(text);
        }
        public void listenServer()
        {
            try
            {
                string text;
                while ((text = m_reader.ReadString()) != string.Empty)
                {
                    invokeFn(text);
                }
            }
            catch (Exception)
            {
                invokeFn("Disconnect server");
            }
        }
        public void start()
        {
            try
            {
                m_client = new TcpClient();
                m_client.Connect("127.0.0.1", 3000);
                m_stream = m_client.GetStream();
                m_reader = new BinaryReader(m_stream, Encoding.UTF8);
                m_writer = new BinaryWriter(m_stream, Encoding.UTF8);

                m_thread = new Thread(listenServer);
                m_thread.Start();

                updateChat("Conecting server...");

            }
            catch (Exception ex)
            {
                updateChat("Conect fail.");
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            string text = this.txt_msg.Text;
            if(text != string.Empty)
            {
                try
                {
                    m_writer.Write(text);
                }
                catch (Exception ex)
                {
                    updateChat("Server disconnect.");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            this.start();
        }
    }
}
