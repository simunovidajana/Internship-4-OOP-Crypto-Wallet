using CryptoWallet.Assets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Interfaces
{
    internal interface INonFungible
    {
        Decimal IzracunajUkupnuVrijednostAsseta(List<FungibleAsset> fungibleAsseti,List<NonFungibleAsset> nonFungibleAsseti);
    }
}
