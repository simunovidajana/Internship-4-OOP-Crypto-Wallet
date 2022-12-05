using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Transactions
{
    public class NonFungibleAssetTransakcija
    {
        public Guid Id { get; } = Guid.NewGuid();

        public Guid NonFungibleAssetId { get; }

        public DateTime Datum { get; }

        public Guid AdresaWalletaPošiljateljNonFungibleAsseta { get; }

        public Guid AdresaWalletaPrimateljNonFungibleAsseta { get; }

        public bool TransakcijaJeOpozvana { get; set; }


        public NonFungibleAssetTransakcija(Guid adresaNonFungibleAsseta, Guid adresaWalletaPosiljatelj, Guid adresaWalletaPrimatelj)
        {
            NonFungibleAssetId = adresaNonFungibleAsseta;

            Datum = DateTime.Now;

            AdresaWalletaPošiljateljNonFungibleAsseta = adresaWalletaPosiljatelj;

            AdresaWalletaPrimateljNonFungibleAsseta = adresaWalletaPrimatelj;
        }
    }
}
