using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;
using HtmlAgilityPack;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Task6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string URL;
        private List<NewsItem> newsList;
        private void btnGet_Click(object sender, EventArgs e)
        {
            URL = txbURL.Text.ToString();
            ExtractNews();
        }
        private void DisplayNewsList()
        {
            listView1.Items.Clear();

            foreach (NewsItem newsItem in newsList)
            {
                ListViewItem item = new ListViewItem(newsItem.Title);
                item.SubItems.Add(newsItem.Summary);
                listView1.Items.Add(item);
            }
        }
        private void ExtractNews()
        {
            newsList = new List<NewsItem>();

            try
            {
                using (WebClient client = new WebClient())
                {
                    string html = client.DownloadString(URL);

                    HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                    doc.LoadHtml(html);

                    // Extract news articles or headlines
                    HtmlNodeCollection articleNodes = doc.DocumentNode.SelectNodes("//section[contains(@class, 'section section_container')]/article");

                    if (articleNodes != null)
                    {
                        foreach (HtmlNode articleNode in articleNodes)
                        {
                            string title = articleNode.SelectSingleNode(".//h3[@class='title-news']/a")?.InnerText.Trim();
                            string summary = articleNode.SelectSingleNode(".//p[@class='description']")?.InnerText.Trim();

                            NewsItem newsItem = new NewsItem
                            {
                                Title = title,
                                Summary = summary
                            };

                            newsList.Add(newsItem);
                        }
                    }

                    DisplayNewsList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while extracting news: " + ex.Message);
            }
        }


        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Perform the web scraping and news extraction
            newsList = new List<NewsItem>();

            string url = URL; // Replace with the actual URL of the news page

            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url);

            // Extract news articles or headlines
            HtmlNodeCollection articleNodes = doc.DocumentNode.SelectNodes("//article[@class='item-news']"); // Adjust this based on the HTML structure of the page

            if (articleNodes != null)
            {
                int totalCount = articleNodes.Count;
                int progress = 0;

                foreach (HtmlNode articleNode in articleNodes)
                {
                    string title = articleNode.SelectSingleNode(".//h3[@class='title-news']")?.InnerText.Trim();
                    string summary = articleNode.SelectSingleNode(".//p[@class='description']")?.InnerText.Trim();

                    // Extract additional information like author, date, etc., if available

                    NewsItem newsItem = new NewsItem
                    {
                        Title = title,
                        Summary = summary
                        // Add other relevant fields to the NewsItem object
                    };

                    newsList.Add(newsItem);

                    progress++;

                    // Report the progress to the background worker
                    ((BackgroundWorker)sender).ReportProgress((int)((progress / (double)totalCount) * 100));
                }
            }
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Display the extracted news in the list view
            DisplayNewsList();
        }
        

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Get the selected news item
                NewsItem selectedNewsItem = newsList[listView1.SelectedIndices[0]];

                // Open the website to read the full text of the article
                string url = URL + selectedNewsItem.Id; // Replace with the actual URL for the news article

                try
                {
                    System.Diagnostics.Process.Start(url);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to open the website: " + ex.Message);
                }
            }
        }
        public class NewsItem
        {
            public string Title { get; set; }
            public string Summary { get; set; }
            public string Id { get; set; }
            // Add other relevant fields for a news item, like author, date, etc.
        }
    }
}
