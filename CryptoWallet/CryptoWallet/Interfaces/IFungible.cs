﻿using CryptoWallet.Assets;
using CryptoWallet.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet.Interfaces
{
    internal interface IFungible
    {
        Decimal IzracunajUkupnuVrijednostAsseta(List<FungibleAsset> fungibleAsseti);
    }
}
