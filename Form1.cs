using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC.Logging;
using DiscordRPC.Message;
using System.Diagnostics;

namespace discord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public DiscordRpcClient client;
        bool initialized = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if(initialized == false)
            {
                MessageBox.Show("Inicia primeiro");
            }

            else
            {
                if(TmsCheckBox.Checked == true)
                {
                    client.SetPresence(new DiscordRPC.RichPresence()
                    {
                        Timestamps = Timestamps.Now,
                        Details = $"{ textBox1.Text }",
                        State = $"{ textBox4.Text }",
                        Assets = new Assets()
                        {
                            LargeImageKey = $"{ textBox3.Text }",
                            LargeImageText = largimgText.Text,
                            SmallImageKey = $"{ textBox5.Text }",
                            SmallImageText = smllimgText.Text,
                        },
                        
                    });
                }
                else
                {
                    client.SetPresence(new DiscordRPC.RichPresence()
                    {
                        //Timestamps = Timestamps.Now,
                        Details = $"{ textBox1.Text }",
                        State = $"{ textBox4.Text }",
                        Assets = new Assets()
                        {
                            LargeImageKey = $"{ textBox3.Text }",
                            LargeImageText = largimgText.Text,
                            SmallImageKey = $"{ textBox5.Text }",
                            SmallImageText = smllimgText.Text,
                        },
                        //Buttons = new DiscordRPC.Button[]
                        //{
                        //    new DiscordRPC.Button() { Label = ":D", Url = "https://youtu.be/dQw4w9WgXcQ"}
                        //}
                    });
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            initialized = true;
            client = new DiscordRpcClient($"{textBox2.Text}");
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
            client.Initialize();
        }
    }
}
