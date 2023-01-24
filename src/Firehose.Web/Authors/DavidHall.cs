using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;
namespace Firehose.Web.Authors
{
    public class DavidHall : IAmACommunityMember
    {
        public string FirstName => "David";
        public string LastName => "Hall";
        public string Pronouns => "";
        public string ShortBioOrTagLine => "Microsoft PowerShell Enthusiast. Founder of SignalWarrant.com";
        public string StateOrRegion => "Georgia, USA";
        public string EmailAddress => "";
        public string TwitterHandle => "signalwarrant";
        public string MastodonHandle => "";
        public string GitHubHandle => "signalwarrant";
        public string GravatarHash => "afd7acd25c1511435fd85cdeda29aa43";
        public GeoPosition Position => new GeoPosition(33.281, -82.0743);
        public Uri WebSite => new Uri("https://signalwarrant.com");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://www.cyberautomate.io/index.xml"); } }
        public string FeedLanguageCode => "en";
    }
}
