using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSocialNetWorkManager.Models
{
    internal class AppManager
    {
        public string AppTitle { get; set; }

        public AppManager() 
        {
            AppTitle = "Administrador de redes sociales";
            SocialNetworks = new List<SocialNetwork>();
            SocialNetworksWithGroups = new List<SocialNetworkWithGroups>();
            InitializeSocialNetworks();
        }

        public void InitializeSocialNetworks()
        {
            SocialNetworks.Add(new SocialNetwork()
            {
                Name = "Twitter",
                Description = "Red social para intercambio de mensajes cortos",
                Users = new List<User>(),
                DateCreated = new DateTime(2008,1,20)
            });

            SocialNetworks.Add(new SocialNetwork()
            {
                Name = "Instagram",
                Description = "Red social para intercambio de fotos y videos cortos",
                Users = new List<User>(),
                DateCreated = new DateTime(2010, 5, 01)
            });

            SocialNetworksWithGroups.Add(new SocialNetworkWithGroups()
            {
                Name = "Facebook",
                Description = "Red social para intercambio de fotos, videos, pensamientos y debate",
                Users = new List<User>(),
                Groups = new List<string>(),
                DateCreated = new DateTime(2010, 5, 01)
            });
        }

        public List<SocialNetwork> SocialNetworks { get; set; }

        public List<SocialNetworkWithGroups> SocialNetworksWithGroups { get; set; }


    }
}
