using CryptoWallet.Assets;
using CryptoWallet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Classes
{
    public class EthereumWallet : Wallet, INonFungible
    {
        public List<Guid> AdreseNonFungibleAssetaKojePosjeduje { get; set; } = new List<Guid>();

        public List<Guid> AdresePodrzanihFungibleINonFungibleAsseta { get; set; } = new List<Guid>();

        public Decimal IzracunajUkupnuVrijednostAsseta(List<FungibleAsset> fungibleAsseti, List<NonFungibleAsset> nonFungibleAsseti)
        {
            var vrijednost = 0M;

            foreach (var asset in BalansiFungibleAsseta)
            {
                var fungibleAsset = nonFungibleAsseti.FirstOrDefault(x => x.Adresa == asset.Item1);
                if (fungibleAsset != null)
                {
                    vrijednost = vrijednost + fungibleAsset.Vrijednost * asset.Item2;
                }
            }

            return vrijednost;
        }
    }
}
