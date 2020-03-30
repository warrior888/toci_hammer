using System.Collections.Generic;

namespace Toci.Hammer.HashMap
{
    public class GrMegaDictionary : GrMegaDictionaryBase<string, string, List<string>>, IGenealogyTreeMd
    {
        public bool AddGrandFatherChildren(string grandfather, string father, List<string> children)
        {
            Add(grandfather, father, children);

            return true;
        }
    }
}