using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App1
{
    public partial class App1 : Form
    {
        MqttClient mqttClient;

        public App1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                //label1.Text = "Connectting...";
                mqttClient = new MqttClient("222.111.55.6");
                mqttClient.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived;
                mqttClient.Subscribe(new string[] { "Application1/Message", "Application1/Alarm" }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE, MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                mqttClient.Connect("APP1", "vinammqtt", "Vinam@12345", false, 0, true, "LWT/APP1", "OffLine", true, 60);
                mqttClient.Publish("LWT/APP1", Encoding.UTF8.GetBytes("OnLine"), 0, false);
                //label1.Text = "Connectted...";
            });
        }

        private void MqttClient_MqttMsgPublishReceived(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {
            var message = Encoding.UTF8.GetString(e.Message);
            listBox1.Invoke((MethodInvoker)(() => listBox1.Items.Add(message)));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(mqttClient.IsConnected)
            {
                label1.Text = "is Conected";
            }
            else
            {
                label1.Text = "is Not Conected";
            }
            Task.Run(() =>
            {
                if (mqttClient != null && mqttClient.IsConnected)
                {
                    mqttClient.Publish("Application2/Message", Encoding.UTF8.GetBytes(textBox1.Text));
                }
            });
        }
    }
}
