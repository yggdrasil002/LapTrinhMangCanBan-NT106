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
        private List<string> extractedNews;
        private async void btnGet_Click(object sender, EventArgs e)
        {
            URL = txbURL.Text.ToString();
            // Clear the previous extracted news
            extractedNews = new List<string>();
            listBox1.Items.Clear();

            // Start the extraction process
            ExtractNewsAsync();
        }
        private async void ExtractNewsAsync()
        {
            string url = URL;

            // Create a WebClient to download the webpage content
            using (WebClient client = new WebClient())
            {
                try
                {
                    // Download the webpage content as a string
                    string html = await client.DownloadStringTaskAsync(url);

                    // Parse the HTML using HtmlAgilityPack
                    HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
                    document.LoadHtml(html);

                    // Extract the news articles from the webpage
                    var newsNodes = document.DocumentNode.SelectNodes("//article[contains(@class, 'item-news')]");

                    if (newsNodes != null)
                    {
                        int totalArticles = newsNodes.Count;
                        int completedArticles = 0;

                        foreach (var newsNode in newsNodes)
                        {
                            // Extract the news article content
                            string article = newsNode.InnerText;

                            // Add the extracted news article to the list
                            extractedNews.Add(article);

                            // Update the progress bar
                            completedArticles++;
                            int progress = (completedArticles * 100) / totalArticles;
                            pgbLoad.Value = progress;
                        }

                        // Display the extracted news articles in the list
                        foreach (var article in extractedNews)
                        {
                            listBox1.Items.Add(article);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No news articles found on the webpage.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize the progress bar
            pgbLoad.Minimum = 0;
            pgbLoad.Maximum = 100;
            pgbLoad.Step = 10;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                string selectedArticle = extractedNews[listBox1.SelectedIndex];
                
                string fullArticleUrl = URL + selectedArticle;

                // Open the full article in the default web browser
                System.Diagnostics.Process.Start(fullArticleUrl);
            }
        }
    }
}