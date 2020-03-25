using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWord.Models
{
    public class Clients
    {
        public List<Client> ObtenirListeClients()
        {
            return new List<Client>
            {
                new Client { Nom = "Jérémie", Age = 38 },
                new Client { Nom = "Antoine", Age = 41 },
                new Client { Nom = "Patricia", Age = 38 },
                new Client { Nom = "Filipe" , Age = 27 },
                new Client { Nom = "Laurence", Age = 48 },
            };
        }
    }
}