using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSocialNetWorkManager.Models
{
    internal class SocialNetworkWithGroups: SocialNetwork
    {
        public List<string> Groups { get; set; }

    }
}
