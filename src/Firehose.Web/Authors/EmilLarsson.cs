using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;
namespace Firehose.Web.Authors
{
    public class EmilLarsson : IAmACommunityMember
    {
        public string FirstName => "Emil";
        public string LastName => "Larsson";
        public string Pronouns => "";
        public string ShortBioOrTagLine => "PowerShell loving hybrid identity architect, blog about PowerShell solutions in Windows Server Core, Active Directory, Azure AD";
        public string StateOrRegion => "Sweden";
        public string EmailAddress => "string.Empty";
        public string TwitterHandle => "ehmiiz";
        public string MastodonHandle => "@ehmiiz@infosec.exchange";
        public string GravatarHash => "0a22f6278e9e9ffdb9f6192ae012ba50";
        public string GitHubHandle => "ehmiiz";
        public GeoPosition Position => new GeoPosition(58.114988, 15.031354);
        public Uri WebSite => new Uri("https://ehmiiz.tech/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://ehmiiz.tech/index.xml"); } }
     	public string FeedLanguageCode => "en";
    }
	
}
