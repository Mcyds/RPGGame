using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Boss : Enemy
    {     
        public Boss() : base("Big Bos")
        {
            Health = 150;
        }
    }
    
}