using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.LSP
{
    public class RightShoe : Shoe
    {
        public RightShoe() 
        {
            
        }  
        public override string Side
        {
            get { return "Right"; }
        }
    }
}
