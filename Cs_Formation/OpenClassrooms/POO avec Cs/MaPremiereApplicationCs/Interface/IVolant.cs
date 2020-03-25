using System;
using System.Collections.Generic;
using System.Text;

namespace MaPremiereApplicationCs.Interface
{
    interface IVolant
    { /**
     *   l'interface ne contient que le contrat et aucune implémentation.
     *   Il n'est pas possible de créer des instances ds une interface.
     *   jamais de corps de méthode dans une interface ni de variables membres
     *   uniquement des méthodes et des propriétés.
     *   
     *   Notez quand même qu’il ne faut pas définir de visibilité sur les membres d’une interface. 
     *   Nous serons obligés de définir les visibilités en public sur les objets implémentant l’interface.
     * */

        int NombrePropulseur { get; set; }
        void Voler();

    }
}
