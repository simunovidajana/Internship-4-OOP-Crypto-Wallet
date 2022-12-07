using CryptoWallet.Assets;
using CryptoWallet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes
{
    public class BitcoinWallet : Wallet, IFungible
    {
        public List<Guid> AdresePodrzanihFungibleAsseta { get; set; } = new List<Guid>();

        public Decimal IzracunajUkupnuVrijednostAsseta(List<FungibleAsset> fungibleAsseti)
        {
            var vrijednost = 0M;

            foreach (var asset in BalansiFungibleAsseta)
            {
                var fungibleAsset = fungibleAsseti.FirstOrDefault(x => x.Adresa == asset.Item1);
                if (fungibleAsset != null)
                {
                    vrijednost += fungibleAsset.Vrijednost * asset.Item2;
                }
            }

            return vrijednost;
        }

        
    }
}
