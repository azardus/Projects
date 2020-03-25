using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord.Models
{
    public interface IDal : IDisposable
    {
        void CreeUnResto(string Nom, string Telephone);
        List<Resto> OptenirListeDeTousLesRestos();
    }
}
