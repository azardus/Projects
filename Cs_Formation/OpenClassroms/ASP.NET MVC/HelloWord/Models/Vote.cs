using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWord.Models
{
    public class Vote
    {
        // Mot clé virtual , cela permet d’activer le chargement paresseux de la propriété par Entity Framework afin de permettre le chargement de ces objets à partir de leurs identifiants.

        public int Id { get; set; } 

        public virtual Utilisateur Utilisateur { get; set; }
        public virtual Resto Resto { get; set; }
    }
}