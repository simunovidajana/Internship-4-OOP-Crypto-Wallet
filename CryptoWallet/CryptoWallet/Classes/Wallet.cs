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

        //TODO: F.a.t || N.f.a.t.
        public virtual List<Guid> AdreseTransakcija { get; private set; } 
    }
}
