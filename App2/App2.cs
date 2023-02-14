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
using uPLibrary.Networking.M2Mqtt.Utility;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App2
{
    public partial class App2 : Form
    {
        MqttClient mqttClient;

        public App2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                mqttClient = new MqttClient("222.111.55.6");
                mqttClient.MqttMsgPublishReceived += MqttClient_MqttMsgPublishReceived;
                mqttClient.Subscribe(new string[] { "Application2/Message" }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                mqttClient.Connect("APP2", "vinammqtt", "Vinam@12345",false, 0 , true, "LWT/APP2", "OffLine", true, 60);
                mqttClient.Publish("LWT/APP2", Encoding.UTF8.GetBytes("OnLine"),0,false);
            });
        }

        private void MqttClient_MqttMsgPublishReceived(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {
            var message = Encoding.UTF8.GetString(e.Message);
            listBox1.Invoke((MethodInvoker)(() => listBox1.Items.Add(message)));
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                if (mqttClient != null && mqttClient.IsConnected)
                {
                    mqttClient.Publish("Application1/Message", Encoding.UTF8.GetBytes(txtMessage.Text));
                }
            });
        }

        private void btnSendAlarm_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                if (mqttClient != null && mqttClient.IsConnected)
                {
                    mqttClient.Publish("Application1/Alarm", Encoding.UTF8.GetBytes(txtAlarm.Text));
                }
            });
        }
    }
}
