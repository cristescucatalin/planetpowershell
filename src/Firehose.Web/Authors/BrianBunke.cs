﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;

namespace Firehose.Web.Authors
{
    public class BrianBunke : IAmACommunityMember, IFilterMyBlogPosts
    {
        public string FirstName => "Brian";
        public string LastName => "Bunke";
        public string Pronouns => "";
        public string ShortBioOrTagLine => "A self-deprecating Systems Automator interested in learning, testing, documenting, and open source.";
        public string StateOrRegion => "WA, USA";
        public string EmailAddress => "me@brianbunke.com";
        public string TwitterHandle => "brianbunke";
        public string MastodonHandle => "";
        public string GitHubHandle => "brianbunke";
        public string GravatarHash => "5eb2b9485a755280dc633d2a9ab2160b";

        public GeoPosition Position => new GeoPosition(48.751911, -122.478685);

        public Uri WebSite => new Uri("https://www.brianbunke.com/");
        public IEnumerable<Uri> FeedUris
        {
            get { yield return new Uri("https://www.brianbunke.com/feed.xml"); }
        }
        public bool Filter(SyndicationItem item)
        {
            return item.Categories?.Any(c => c.Name.ToLowerInvariant().Contains("powershell")) ?? false;
        }
        public string FeedLanguageCode => "en";
    }
}
