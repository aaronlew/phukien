using System;
using System.Collections.Generic;
using System.Xml;

namespace GiaPhuc.Utility
{
    //Next I needed a manager class that would read any RSS feed and populate a list of the above rss feed item object with the relevant data. To achieve this I created the following static class:

    /// <summary>
    /// RSS manager to read rss feeds
    /// </summary>
    public static class RssManager
    {
        /// <summary>
        /// Reads the relevant Rss feed and returns a list off RssFeedItems
        /// </summary>
        /// <param name="feedUrl"> </param>
        /// <returns></returns>
        public static IList<RssFeedItem> ReadFeed(string feedUrl)
        {
            IList<RssFeedItem> rssFeedItems = new List<RssFeedItem>();

            using (var feedReader = XmlReader.Create(feedUrl))
            {
                var feedContent = System.ServiceModel.Syndication.SyndicationFeed.Load(feedReader);

                if (null == feedContent) throw new NullReferenceException();

                int i = 1;

                foreach (var item in feedContent.Items)
                {
                    rssFeedItems.Add(new RssFeedItem
                                         {
                                             ItemId = i++,
                                             Title = item.Title.Text,
                                             Description = item.Summary.Text,
                                             PublishDate = item.PublishDate.DateTime,
                                             Link = item.Links[0].Uri.AbsoluteUri
                                         });
                }
            }

            //return the rss feed items
            return rssFeedItems;
        }

        public class SyndicationFeed
        {
        }
    }
}