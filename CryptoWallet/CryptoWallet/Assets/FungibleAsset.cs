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
        
        public string Ime { get; set; }

        public string Oznaka { get; set; }

        public Decimal Vrijednost { get; set; }

        public void AddNewFungibleAsset(List<FungibleAsset> listaFungibleAsseta, FungibleAsset noviFungibleAsset)
        {
            var imeJeUnique = listaFungibleAsseta.FirstOrDefault(x => x.Ime == noviFungibleAsset.Ime);
            var oznakaJeUnique = listaFungibleAsseta.FirstOrDefault(x => x.Oznaka == noviFungibleAsset.Oznaka);

            if(imeJeUnique != null && oznakaJeUnique != null)
            {
                listaFungibleAsseta.Add(noviFungibleAsset);
            }
            else
            {
                Console.WriteLine($"Već postoji Fungible Asset sa imenom : {noviFungibleAsset.Ime} ili oznakom : {noviFungibleAsset.Oznaka}");
            }            
        }

    }
}
