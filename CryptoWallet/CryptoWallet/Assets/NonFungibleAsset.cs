using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Assets
{
    public class NonFungibleAsset
    {
        public Guid Adresa { get; } = Guid.NewGuid();

        public string Ime { get; set; }

        public Decimal Vrijednost { get; set; }

        public Guid FungibleAssetId { get; }

        public NonFungibleAsset(Guid idFungibleAsseta)
        {
            FungibleAssetId = idFungibleAsseta;
        }
    }
}
