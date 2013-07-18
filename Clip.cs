using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SkypeQuote
{
    /// <summary>
    /// The Clip class makes a clipboard entry from a Quote.
    /// </summary>
    internal class Clip
    {
        private Quote quote;

        /// <summary>
        /// Sets the quote.
        /// </summary>
        /// <param name="quote">The quote.</param>
        public void setQuote(Quote quote)
        {
            this.quote = quote;
        }

        /// <summary>
        /// Copy a Quote to the clipboard.
        /// </summary>
        public void toClipboard()
        {
            // Empty the clipboard first.
            Clipboard.SetText(" ");

            // Retrieve the Quote as a string.
            string skypeMessageFragment = this.quote.toString();

            // Create a new DataObject (a format-independent mechanism for transferring data).
            IDataObject dataObject = new DataObject();

            // Set the quote for pasting outside Skype.
            dataObject.SetData("System.String", this.quote.getText());
            dataObject.SetData("Text", this.quote.getText());
            dataObject.SetData("UnicodeText", this.quote.getText());
            dataObject.SetData("OEMText", this.quote.getText());

            // Set the quote for pasting in Skype.
            dataObject.SetData("SkypeMessageFragment", new MemoryStream(Encoding.UTF8.GetBytes(skypeMessageFragment)));

            // Send the DataObject to the clipboard.
            Clipboard.SetDataObject(dataObject);
        }
    }
}