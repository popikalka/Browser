using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Login : Form
    {
        private string _userName;
        private int _counter;
        private string _connectionString;

        public Login()
        {
            InitializeComponent();
            _counter = 0;
            webBrowser.Navigate("https://www.google.com");
            webBrowser.Dock = DockStyle.Fill;
            _connectionString = @"Data Source=MILKEY-ПК\SQLEXPRESS;Initial Catalog=PersonalBrowser;Integrated Security=true";
            linksMenu.Visible = false;
        }

        private void SurfBtn_Click(object sender, EventArgs e)
        {
            nameTextBox.Visible = false;
            surfBtn.Visible = false;
            _userName = nameTextBox.Text;
            GetLinks(_userName);
            linksPanel.Visible = true;
            linksMenu.Visible = true;
        }

        private void GetLinks(string name)
        {
            string queryString =
                "SELECT Address, Title FROM PersonalBrowser.dbo.Links WHERE UserId = (SELECT Id FROM PersonalBrowser.dbo.Users WHERE Name = @name)";
            using (SqlConnection connection =
                new SqlConnection(_connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@name", name);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    AddLink(reader[0].ToString().Trim(), reader[1].ToString().Trim(), "link" +_counter);
                    _counter++;
                }
                reader.Close();
            }
        }

        private void AddLink(string url, string title, string name)
        {
            Point location = new Point(20, 25 * _counter);
            LinkLabel link = new LinkLabel();
            link.Links.Add(0, title.Length, url);
            link.Name = name;
            link.Text = title;
            link.Location = location;
            link.LinkClicked += new LinkLabelLinkClickedEventHandler(this.LinkClicked);
            linksPanel.Controls.Add(link);
        }

        private void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            webBrowser.Navigate((sender as LinkLabel).Links[0].LinkData.ToString());
            webBrowser.Dock = DockStyle.Fill;
        }

        private void closeMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            _counter = 0;
            linksPanel.Visible = false;
            linksPanel.Controls.Clear();
            nameTextBox.Visible = true;
            surfBtn.Visible = true;
            _userName = string.Empty;
            webBrowser.Navigate("https://www.google.com");
            webBrowser.Dock = DockStyle.Fill;
        }

        private void addlinkMenuItem_Click(object sender, EventArgs e)
        {
            Form children = new AddLink(_userName, _connectionString);
            children.ShowDialog(this);
        }
    }
}
