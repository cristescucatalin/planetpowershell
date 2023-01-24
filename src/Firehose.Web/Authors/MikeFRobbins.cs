﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using Firehose.Web.Infrastructure;
namespace Firehose.Web.Authors
{
    public class MikeFRobbins : IAmAMicrosoftMVP
    {
        public string FirstName => "Mike";
        public string LastName => "Robbins";
        public string Pronouns => "";
        public string ShortBioOrTagLine => "is the leader and co-founder of the Mississippi PowerShell User Group.";
        public string StateOrRegion => "Mississippi, USA";
        public string EmailAddress => "";
        public string TwitterHandle => "mikefrobbins";
        public string MastodonHandle => "";
        public string GitHubHandle => "mikefrobbins";
        public string GravatarHash => "e809f9f3d1f46f219c3a28b2fd7dbf83";
        public GeoPosition Position => new GeoPosition(32.3643100, -88.7036560);

        public Uri WebSite => new Uri("https://mikefrobbins.com/");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://mikefrobbins.com/index.xml"); } }
		
        public string FeedLanguageCode => "en";
    }
}
