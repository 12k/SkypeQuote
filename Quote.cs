using System;

namespace SkypeQuote
{
    /// <summary>
    /// The Quote class is used to generate a Skype quote.
    /// </summary>
    internal class Quote
    {
        private String author;
        private DateTime date;
        private String text;

        /// <summary>
        /// Initializes a new instance of the <see cref="Quote"/> class.
        /// </summary>
        public Quote()
        {
        }

        /// <summary>
        /// Gets the author.
        /// </summary>
        /// <returns></returns>
        public String getAuthor()
        {
            return this.author;
        }

        /// <summary>
        /// Gets the date.
        /// </summary>
        /// <returns></returns>
        public DateTime getDate()
        {
            return this.date;
        }

        /// <summary>
        /// Gets the text.
        /// </summary>
        /// <returns></returns>
        public String getText()
        {
            return this.text;
        }

        /// <summary>
        /// Sets the author.
        /// </summary>
        /// <param name="author">The quote author (Skype username).</param>
        public void setAuthor(String author)
        {
            this.author = author;
        }

        /// <summary>
        /// Sets the date.
        /// </summary>
        /// <param name="date">The quote date.</param>
        public void setDate(DateTime date)
        {
            this.date = date;
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="text">The quote text.</param>
        public void setText(String text)
        {
            this.text = text;
        }

        /// <summary>
        /// Gets the timestamp.
        /// </summary>
        public int getTimestamp()
        {
            return (int)(this.date - new DateTime(1970, 1, 1).ToLocalTime()).TotalSeconds - 3600;
        }

        /// <summary>
        /// Returns the quote string (skypeMessageFragment format).
        /// </summary>
        public String toString()
        {
            return String.Format("<quote author=\"{0}\" timestamp=\"{1}\">{2}</quote>", this.getAuthor(), this.getTimestamp(), this.getText());
        }
    }
}