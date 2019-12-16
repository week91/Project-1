using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoreApp
{
    public interface ILemmatization
    {
        List<string> Lemma(string lem);
    }

}