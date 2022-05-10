using System;
using System.Windows.Forms;
using System.Net.Http;
using System.IO;
using System.Management;
using System.Windows.Input;
using System.Windows;
using System.Collections.Generic;

namespace Login
{
    public partial class Form1 : Form
    {
        readonly HttpClient client = new HttpClient();


        public Form1()
        {
            InitializeComponent();
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            var values = new Dictionary<string, string>
            {
                { "userName", LoginUsername.Text },
                { "passWord", LoginPassword.Text },
            };

            var data = new FormUrlEncodedContent(values);
            var ray = Functions.RandomString(20);
            var expectedData = Functions.Hash(LoginPassword.Text + ray + "secretCode");

            var response = await client.PostAsync("http://127.0.0.1:4200/signin?ray=" + ray, data);
            var responseString = await response.Content.ReadAsStringAsync();

            if (expectedData == responseString)
            {
                MessageBox.Show("Successfully logged in!");
            }
            else if (responseString != "Unknown Error!")
            {
                MessageBox.Show(responseString);
            }
            else
            {
                MessageBox.Show("Unknown Error!\n", responseString);
            }
        }

        private async void RegisterButton_Click(object sender, EventArgs e)
        {

            var values = new Dictionary<string, string>
            {
                { "userName", RegisterUsername.Text },
                { "passWord", RegisterPassword.Text },
                { "discordId", RegisterDiscordId.Text },
                { "serialKey", RegisterSerialKey.Text },
            };

            var data = new FormUrlEncodedContent(values);
            var ray = Functions.RandomString(20);
            var expectedData = Functions.Hash(RegisterPassword.Text + ray + "secretCode");

            var response = await client.PostAsync("http://127.0.0.1:4200/createAccount?ray=" + ray, data);
            var responseString = await response.Content.ReadAsStringAsync();



            if (expectedData == responseString)
            {
                MessageBox.Show("Succesfully created account, you can now log-in!");
            }
            else if (responseString != "Unknown Error!")
            {
                MessageBox.Show(responseString);
            }
            else
            {
                MessageBox.Show("Unknown Error!\n", responseString);
            }
        }

        private async void ResetButton_Click(object sender, EventArgs e)
        {
            var values = new Dictionary<string, string>
            {
                { "userName", ResetUsername.Text },
                { "newPassword", ResetPassword.Text },
                { "repeatPassword", ResetRepeatPassword.Text }
            };

            var data = new FormUrlEncodedContent(values);
            var ray = Functions.RandomString(20);
            var expectedData = Functions.Hash(ResetRepeatPassword.Text + ray + "secretCode");

            var response = await client.PostAsync("http://127.0.0.1:4200/changePassword?ray=" + ray, data);
            var responseString = await response.Content.ReadAsStringAsync();



            if (expectedData == responseString)
            {
                MessageBox.Show("Succesfully created account, you can now log-in!");
            }
            else if (responseString != "Unknown Error!")
            {
                MessageBox.Show(responseString);
            }
            else
            {
                MessageBox.Show("Unknown Error!\n", responseString);
            }
        }
    }
}
