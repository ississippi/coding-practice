using System;
using System.Collections.Generic;
using System.Diagnostics;
using HtmlAgilityPack;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace coding_practice
{
    internal class WebCrawler
    {

        static async Task<string> GetHtmlAsync(string url)
        {
            using HttpClient client = new HttpClient();
            return await client.GetStringAsync(url);
        }

        public async Task<List<string>> GetLinks(string url)
        {
            var list = new List<string>();
            using HttpClient client = new HttpClient();
            try
            {
                string html = await GetHtmlAsync(url);

                HtmlDocument doc = new HtmlDocument();
                doc.LoadHtml(html);

                // Extract the title
                var title = doc.DocumentNode.SelectSingleNode("//title")?.InnerText;
                Console.WriteLine("Title: " + title);

                // Extract all links
                foreach (var link in doc.DocumentNode.SelectNodes("//a[@href]"))
                {
                    var hrefValue = link.GetAttributeValue("href", string.Empty);
                    if (!string.IsNullOrEmpty(hrefValue))
                    {
                        list.Add(hrefValue);
                    }
                }

                //foreach (var link in links)
                //{
                //    list.Append(link.InnerText);
                //}


                return list;
            }
            catch (HttpRequestException e)
            {
                throw new Exception($"Request error: {e.Message}");
            }
        }

        public async Task<List<string>> GetAllLinks(string rootUrl)
        {
            var frontier = new Stack<string>();
            var newLinks = new List<string>();
            frontier.Push(rootUrl);
            while (frontier != null)
            {
                var node = frontier.Pop();
                Debug.WriteLine($"Visiting {node}");
                
                newLinks = await GetLinks(node);
            }

            return newLinks;
        }
    }
}