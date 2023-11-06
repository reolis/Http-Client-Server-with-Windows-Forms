using Azure;
using Microsoft.Kiota.Abstractions;
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
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Krasnyanskaya221327Sem3Lab04Var1
{
    public partial class Krasnyanskaya221327Lab04Client : Form
    {
        HttpClient client = new HttpClient();
        string command, ipAddres, port, url;

        string jsonString, infoJson;

        Dictionary<string, string> messages;

        public static HttpListenerResponse response;

        public Krasnyanskaya221327Lab04Client()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {

            var task = Task.Factory.StartNew(() => Task.Run(SendToServer));

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

        private void richTextBoxChat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCommand_TextChanged(object sender, EventArgs e)
        {
            try
            {
                command = textBoxCommand.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPort_TextChanged(object sender, EventArgs e)
        {
            try
            {
                port = textBoxPort.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBoxIP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ipAddres = textBoxIP.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBoxF_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxE_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxD_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxC_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            url = "http://" + ipAddres.ToString() + ":" + port.ToString() + "/connection/";
            client.BaseAddress = new Uri(url);

           

            
        }

        private async Task SendToServer()
        {
            SerializeMessage();

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url);

            request.Headers.Add("Message", infoJson);


            HttpResponseMessage response = await client.SendAsync(request);


            string responseBody = await response.Content.ReadAsStringAsync();

            richTextBoxChat.Text = richTextBoxChat.Text + "\r\n" + "Вы: " + jsonString;
        }

        private void SerializeMessage()
        {
            messages = new Dictionary<string, string>()
            {
                {"A", textBoxA.Text },
                {"B", textBoxB.Text },
                {"C", textBoxC.Text },
            };

            jsonString = JsonSerializer.Serialize(messages);
            byte[] data = Encoding.UTF8.GetBytes(jsonString);
            infoJson = Convert.ToBase64String(data);

        }
    }
}
