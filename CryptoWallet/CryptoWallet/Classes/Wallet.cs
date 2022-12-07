using CryptoWallet.Assets;
using CryptoWallet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes
{
    public class Wallet 
    {
        public virtual Guid Adresa { get; } = Guid.NewGuid(); 

        public virtual List<(Guid, Decimal)> BalansiFungibleAsseta { get; private set; } = new List<(Guid, Decimal)>();

        public virtual List<Guid> AdreseTransakcija { get; private set; } = new List<Guid>(); 
        
        

    }
}
