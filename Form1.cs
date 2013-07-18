using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SkypeQuote
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set the username placeholder.
            username.Text = "Username";

            // Set the quote text placeholder.
            richTextBox1.Text = "Quote text";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new (empty) Skype quote.
            Quote quote = new Quote();

            // Set the author, date and text using the values from Form1.
            quote.setAuthor(username.Text);
            quote.setDate(dateTimePicker1.Value);
            quote.setText(richTextBox1.Text);

            // Create a new clipboard entry.
            Clip clip = new Clip();

            // Set the quote for the clipboard.
            clip.setQuote(quote);

            // Copy quote to clipboard.
            clip.toClipboard();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Open default browser on twitter.com/ly_gs.
            Process.Start("https://github.com/12k/");
        }
    }
}