using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Transactions
{
    public class FungibleAssetTransakcija
    {
        public Guid Id { get; } = Guid.NewGuid();

        public Guid FungibleAssetId { get; }

        public DateTime Datum { get; }

        public Guid AdresaWalletaPošiljateljFungibleAsseta { get; }
        
        public Guid AdresaWalletaPrimateljFungibleAsseta { get; }

        public Decimal PočetniBalansWalletaPošiljatelja { get; set; }

        public Decimal KrajnjiBalansWalletaPošiljatelja { get; set; }

        public Decimal PočetniBalansWalletaPrimatelja { get; set; }

        public Decimal KrajnjiBalansWalletaPrimatelja { get; set; }

        public bool TransakcijaJeOpozvana { get; set; }


        public FungibleAssetTransakcija(Guid adresaFungibleAsseta, Guid adresaWalletaPosiljatelj, Guid adresaWalletaPrimatelj)
        {
            FungibleAssetId = adresaFungibleAsseta;

            Datum = DateTime.Now;

            AdresaWalletaPošiljateljFungibleAsseta = adresaWalletaPosiljatelj;

            AdresaWalletaPrimateljFungibleAsseta = adresaWalletaPrimatelj;
        }
    }
}
