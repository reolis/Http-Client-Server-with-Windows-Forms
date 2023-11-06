using Microsoft.Graph.Models;
using Newtonsoft.Json;
using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Telerik.JustMock;
using static System.Net.Mime.MediaTypeNames;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Krasnyanskaya221327Sem3Lab04Var1
{
    

    public partial class Krasnyanskaya221327Lab04Server : Form
    {
        HttpListener server = new HttpListener();
        HttpClient client = new HttpClient();
        int port;
        HttpListenerResponse response;
        HttpListenerContext context;
        
        HttpListenerRequest request;
        

        string responseText;

        string url;

        public Krasnyanskaya221327Lab04Server()
        {
            InitializeComponent();
            
        }

        private void Krasnyanskaya221327Lab04Server_Load(object sender, EventArgs e)
        {
            Form form = new Krasnyanskaya221327Lab04Client();
            form.Show();
        }

        private void textBoxPort_TextChanged(object sender, EventArgs e)
        {
            try
            {
                port = int.Parse(textBoxPort.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            url = "http://127.0.0.1:" + port.ToString() + "/connection/";
            client.BaseAddress = new Uri(url);
            server.Prefixes.Add(url);
            server.Start();
            if (server.IsListening)
            {
                backgroundWorker1.RunWorkerAsync();
                richTextBoxChat.Text = richTextBoxChat.Text + "\r\n" + "Сервер запущен";
            }
            else if (buttonSend.Text == "Отключить")
            {
                server.Stop();
            }
        }

        private void Receive()
        {
            context = server.GetContext();

            response = context.Response;
            request = context.Request;

            richTextBoxChat.Text = richTextBoxChat.Text + "\r\n" + "Приняты данные";
        }

        private async Task Send()
        {
            var responseData = request.Headers.GetValues("Message");
            responseText = string.Join(",", responseData);
            richTextBoxChat.Text = richTextBoxChat.Text + "\r\n" + "Клиент: " + responseText;

            var decodeData = Convert.FromBase64String(responseText);
            string decodeText = Encoding.UTF8.GetString(decodeData);
            richTextBoxChat.Text = richTextBoxChat.Text + "\r\n" + "Клиент: " + decodeText;

            Dictionary<string, object> values = JsonConvert.DeserializeObject<Dictionary<string, object>>(decodeText);
            var lines = values.Select(kv => kv.Key + ": " + kv.Value.ToString());
            richTextBoxChat.Text = richTextBoxChat.Text + "\r\n" + "Клиент: " + string.Join(Environment.NewLine, lines);

            ToTextBoxes(values);

            byte[] buffer = Encoding.UTF8.GetBytes(responseText);

            response.ContentLength64 = buffer.Length;
            Stream output = response.OutputStream;

            await output.WriteAsync(buffer, 0, buffer.Length);
            await output.FlushAsync();

            var responseString = await client.GetStringAsync(url);
            richTextBoxChat.Text = richTextBoxChat.Text + "\r\n" + "Клиент: " + responseString;

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                buttonSend.Text = "Отключить";
                Receive();
                if (context != null)
                {
                    var task = Task.Factory.StartNew(() => Task.Run(Send));

                    task.Wait();
                    if (task.IsCompleted)
                    {
                        richTextBoxChat.Text = richTextBoxChat.Text + "\r\n" + "Сообщение отправлено";
                    }
                    else
                    {
                        richTextBoxChat.Text = richTextBoxChat.Text + "\r\n" + "Сообщение не отправлено";
                    }
                }
            }
        }

        private void ToTextBoxes(Dictionary<string, object> packing)
        {
            if (packing.ContainsKey("A"))
            {
                textBoxA.Text = packing["A"].ToString();
            }
            if (packing.ContainsKey("B"))
            {
                textBoxB.Text = packing["B"].ToString();
            }
            if (packing.ContainsKey("C"))
            {
                textBoxC.Text = packing["C"].ToString();
            }
        }
    }
}
