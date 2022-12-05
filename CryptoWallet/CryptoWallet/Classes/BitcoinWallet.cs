using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes
{
    public class BitcoinWallet : Wallet
    {
        public List<Guid> AdresePodrzanihFungibleAsseta { get; set; } = new List<Guid>();
    }
}
