using System.Collections.Generic;

namespace Toci.Hammer.HashMap
{
    public interface IGenealogyTreeMd : IMegaDictionary<string, string, List<string>>
    {
        bool AddGrandFatherChildren(string grandfather, string father, List<string> children);
    }
}