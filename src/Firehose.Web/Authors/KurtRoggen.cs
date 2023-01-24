using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;
namespace Firehose.Web.Authors
{
    public class KurtRoggen : IAmAMicrosoftMVP
    {
        public string FirstName => "Kurt";
        public string LastName => "Roggen [BE]";
        public string Pronouns => "";
        public string ShortBioOrTagLine => "Cloud & Datacenter Management MVP and Principal Technical Consultant";
        public string StateOrRegion => "Belgium";
        public string EmailAddress => "";
        public string TwitterHandle => "roggenk";
        public string MastodonHandle => "";
        public string GitHubHandle => "roggenk";
        public string GravatarHash => "00000000000000000000000000000000";
        public GeoPosition Position => new GeoPosition(50.8503, 4.3517);
        public Uri WebSite => new Uri("https://kurtroggen.be");
        public IEnumerable<Uri> FeedUris 
        { 
          get { yield return new Uri("https://kurtroggen.wordpress.com/feed/"); } 
        }
        public string FeedLanguageCode => "en";
    }
}
