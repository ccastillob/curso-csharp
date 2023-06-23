using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSocialNetWorkManager.Models
{
    internal class SocialNetwork
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public List<User> Users { get; set; }

        public DateTime DateCreated { get; set; }

    }
}
