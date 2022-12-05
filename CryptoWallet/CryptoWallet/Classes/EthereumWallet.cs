using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes
{
    public class EthereumWallet : Wallet
    {
        public List<Guid> AdreseNonFungibleAssetaKojePosjeduje { get; set; } = new List<Guid>();

        public List<Guid> AdresePodrzanihFungibleINonFungibleAsseta { get; set; } = new List<Guid>();

    }
}
