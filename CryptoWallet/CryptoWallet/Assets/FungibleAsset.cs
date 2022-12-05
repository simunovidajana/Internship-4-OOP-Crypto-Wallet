
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Assets
{
    public class FungibleAsset
    {
        public Guid Adresa { get; } = Guid.NewGuid();
        
        //TODO:unique
        public string Ime { get; set; }

        //TODO:unique
        public string Oznaka { get; set; }

        public Decimal Vrijednost { get; set; }

    }
}
