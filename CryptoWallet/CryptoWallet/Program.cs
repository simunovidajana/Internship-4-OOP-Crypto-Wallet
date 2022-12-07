using CryptoWallet.Assets;
using CryptoWallet.Classes;
using CryptoWallet.Enums;
using CryptoWallet.Transactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoWallet
{
    internal class Program
    {
        #region Fungible Asseti
        public static FungibleAsset fungibleAsset1 = new FungibleAsset
        {
            Ime = "Australian dollar",
            Oznaka = "AUD",
            Vrijednost = 0.67M
        };
        public static FungibleAsset fungibleAsset2 = new FungibleAsset
        {
            Ime = "Canadian Dollar",
            Oznaka = "CAD",
            Vrijednost = 1.36M
        };
        public static FungibleAsset fungibleAsset3 = new FungibleAsset
        {
            Ime = "Czech koruna",
            Oznaka = "CZK",
            Vrijednost = 23.09M
        };
        public static FungibleAsset fungibleAsset4 = new FungibleAsset
        {
            Ime = "Danish Krone",
            Oznaka = "DKK",
            Vrijednost = 7.07M
        };
        public static FungibleAsset fungibleAsset5 = new FungibleAsset
        {
            Ime = "Hungarian forint",
            Oznaka = "HUF",
            Vrijednost = 390.44M
        };
        public static FungibleAsset fungibleAsset6 = new FungibleAsset
        {
            Ime = "Japanese yen",
            Oznaka = "JPY",
            Vrijednost = 136.30M
        };
        public static FungibleAsset fungibleAsset7 = new FungibleAsset
        {
            Ime = "Norwegian krone",
            Oznaka = "NOK",
            Vrijednost = 10.0M
        };
        public static FungibleAsset fungibleAsset8 = new FungibleAsset
        {
            Ime = "Swedish krona",
            Oznaka = "SEK",
            Vrijednost = 10.35M
        };
        public static FungibleAsset fungibleAsset9 = new FungibleAsset
        {
            Ime = "Swiss franc",
            Oznaka = "CHF",
            Vrijednost = 0.94M
        };
        public static FungibleAsset fungibleAsset10 = new FungibleAsset
        {
            Ime = "Dutch Guilder",
            Oznaka = "NLG",
            Vrijednost = 2.09M
        };

        public static List<FungibleAsset> fungibleAsseti = new List<FungibleAsset>()
        {
            fungibleAsset1,
            fungibleAsset2,
            fungibleAsset3,
            fungibleAsset4,
            fungibleAsset5,
            fungibleAsset6,
            fungibleAsset7,
            fungibleAsset8,
            fungibleAsset9,
            fungibleAsset10
        };
        #endregion

        #region Non Fungible Asseti

        public static NonFungibleAsset nonfungibleAsset1 = new NonFungibleAsset(fungibleAsset1.Adresa)
        {
            Ime = "Slika1",
            Vrijednost = 10
        };
        public static NonFungibleAsset nonfungibleAsset2 = new NonFungibleAsset(fungibleAsset1.Adresa)
        {
            Ime = "Slika2",
            Vrijednost = 20
        };
        public static NonFungibleAsset nonfungibleAsset3 = new NonFungibleAsset(fungibleAsset1.Adresa)
        {
            Ime = "Slika3",
            Vrijednost = 30
        };
        public static NonFungibleAsset nonfungibleAsset4 = new NonFungibleAsset(fungibleAsset1.Adresa)
        {
            Ime = "Slika4",
            Vrijednost = 40
        };
        public static NonFungibleAsset nonfungibleAsset5 = new NonFungibleAsset(fungibleAsset1.Adresa)
        {
            Ime = "Slika5",
            Vrijednost = 50
        };
        public static NonFungibleAsset nonfungibleAsset6 = new NonFungibleAsset(fungibleAsset1.Adresa)
        {
            Ime = "Slika6",
            Vrijednost = 60
        };
        public static NonFungibleAsset nonfungibleAsset7 = new NonFungibleAsset(fungibleAsset1.Adresa)
        {
            Ime = "Slika7",
            Vrijednost = 70
        };
        public static NonFungibleAsset nonfungibleAsset8 = new NonFungibleAsset(fungibleAsset2.Adresa)
        {
            Ime = "Slika8",
            Vrijednost = 80
        };
        public static NonFungibleAsset nonfungibleAsset9 = new NonFungibleAsset(fungibleAsset2.Adresa)
        {
            Ime = "Slika9",
            Vrijednost = 90
        };
        public static NonFungibleAsset nonfungibleAsset10 = new NonFungibleAsset(fungibleAsset2.Adresa)
        {
            Ime = "Slika10",
            Vrijednost = 100
        };
        public static NonFungibleAsset nonfungibleAsset11 = new NonFungibleAsset(fungibleAsset1.Adresa)
        {
            Ime = "Slika11",
            Vrijednost = 110
        };
        public static NonFungibleAsset nonfungibleAsset12 = new NonFungibleAsset(fungibleAsset1.Adresa)
        {
            Ime = "Slika12",
            Vrijednost = 120
        };
        public static NonFungibleAsset nonfungibleAsset13 = new NonFungibleAsset(fungibleAsset1.Adresa)
        {
            Ime = "Slika13",
            Vrijednost = 130
        };
        public static NonFungibleAsset nonfungibleAsset14 = new NonFungibleAsset(fungibleAsset1.Adresa)
        {
            Ime = "Slika14",
            Vrijednost = 140
        };
        public static NonFungibleAsset nonfungibleAsset15 = new NonFungibleAsset(fungibleAsset1.Adresa)
        {
            Ime = "Slika15",
            Vrijednost = 150
        };
        public static NonFungibleAsset nonfungibleAsset16 = new NonFungibleAsset(fungibleAsset1.Adresa)
        {
            Ime = "Slika16",
            Vrijednost = 160
        };
        public static NonFungibleAsset nonfungibleAsset17 = new NonFungibleAsset(fungibleAsset1.Adresa)
        {
            Ime = "Slika17",
            Vrijednost = 170
        };
        public static NonFungibleAsset nonfungibleAsset18 = new NonFungibleAsset(fungibleAsset2.Adresa)
        {
            Ime = "Slika18",
            Vrijednost = 180
        };
        public static NonFungibleAsset nonfungibleAsset19 = new NonFungibleAsset(fungibleAsset2.Adresa)
        {
            Ime = "Slika19",
            Vrijednost = 190
        };
        public static NonFungibleAsset nonfungibleAsset20 = new NonFungibleAsset(fungibleAsset2.Adresa)
        {
            Ime = "Slika20",
            Vrijednost = 200
        };

        public static List<NonFungibleAsset> nonFungibleAsseti = new List<NonFungibleAsset>()
        {
            nonfungibleAsset1,
            nonfungibleAsset2,
            nonfungibleAsset3,
            nonfungibleAsset4,
            nonfungibleAsset5,
            nonfungibleAsset6,
            nonfungibleAsset7,
            nonfungibleAsset8,
            nonfungibleAsset9,
            nonfungibleAsset10,
            nonfungibleAsset11,
            nonfungibleAsset12,
            nonfungibleAsset13,
            nonfungibleAsset14,
            nonfungibleAsset15,
            nonfungibleAsset16,
            nonfungibleAsset17,
            nonfungibleAsset18,
            nonfungibleAsset19,
            nonfungibleAsset20
        };
        #endregion

        #region Walleti
        public static BitcoinWallet bitcoinWallet1 = new BitcoinWallet
        {
            AdresePodrzanihFungibleAsseta = new List<Guid>
            {
                fungibleAsset1.Adresa,
                fungibleAsset2.Adresa,
                fungibleAsset3.Adresa
            }
        };
        public static BitcoinWallet bitcoinWallet2 = new BitcoinWallet
        {
            AdresePodrzanihFungibleAsseta =
            {
                fungibleAsset1.Adresa,
                fungibleAsset2.Adresa,
                fungibleAsset3.Adresa
            }
        };
        public static BitcoinWallet bitcoinWallet3 = new BitcoinWallet
        {
            AdresePodrzanihFungibleAsseta =
            {
                fungibleAsset1.Adresa,
                fungibleAsset2.Adresa,
                fungibleAsset3.Adresa
            }
        };
        public static EthereumWallet ethereumWallet1 = new EthereumWallet
        {
            AdresePodrzanihFungibleINonFungibleAsseta =
            {
                fungibleAsset1.Adresa,
                fungibleAsset2.Adresa,
                fungibleAsset3.Adresa,
                nonfungibleAsset1.Adresa,
                nonfungibleAsset2.Adresa,
                nonfungibleAsset3.Adresa,
            }
        };
        public static EthereumWallet ethereumWallet2 = new EthereumWallet
        {
            AdresePodrzanihFungibleINonFungibleAsseta =
            {
                fungibleAsset1.Adresa,
                fungibleAsset2.Adresa,
                fungibleAsset3.Adresa,
                nonfungibleAsset1.Adresa,
                nonfungibleAsset2.Adresa,
                nonfungibleAsset3.Adresa,
            }
        };
        public static EthereumWallet ethereumWallet3 = new EthereumWallet
        {
            AdresePodrzanihFungibleINonFungibleAsseta =
            {
                fungibleAsset1.Adresa,
                fungibleAsset2.Adresa,
                fungibleAsset3.Adresa,
                nonfungibleAsset1.Adresa,
                nonfungibleAsset2.Adresa,
                nonfungibleAsset3.Adresa,
            }
        };
        public static SolanaWallet solanaWallet1 = new SolanaWallet
        {
            AdresePodrzanihFungibleINonFungibleAsseta =
            {
                fungibleAsset1.Adresa,
                fungibleAsset2.Adresa,
                fungibleAsset3.Adresa,
                nonfungibleAsset1.Adresa,
                nonfungibleAsset2.Adresa,
                nonfungibleAsset3.Adresa,
            }
        };
        public static SolanaWallet solanaWallet2 = new SolanaWallet
        {
            AdresePodrzanihFungibleINonFungibleAsseta =
            {
                fungibleAsset1.Adresa,
                fungibleAsset2.Adresa,
                fungibleAsset3.Adresa,
                nonfungibleAsset1.Adresa,
                nonfungibleAsset2.Adresa,
                nonfungibleAsset3.Adresa,
            }
        };
        public static SolanaWallet solanaWallet3 = new SolanaWallet
        {
            AdresePodrzanihFungibleINonFungibleAsseta =
            {
                fungibleAsset1.Adresa,
                fungibleAsset2.Adresa,
                fungibleAsset3.Adresa,
                nonfungibleAsset1.Adresa,
                nonfungibleAsset2.Adresa,
                nonfungibleAsset3.Adresa,
            }
        };

        public static List<BitcoinWallet> bitcoinWalleti = new List<BitcoinWallet>()
        {
            bitcoinWallet1,
            bitcoinWallet2,
            bitcoinWallet3
        };
        public static List<EthereumWallet> ethereumWalleti = new List<EthereumWallet>
        {
            ethereumWallet1,
            ethereumWallet2,
            ethereumWallet3
        };
        public static List<SolanaWallet> solanaWalleti = new List<SolanaWallet>
        {
            solanaWallet1,
            solanaWallet2,
            solanaWallet3
        };
        #endregion

        public static void Main(string[] args)
        {

            MainMenu();
        }

        private static void Selection(int choice)
        {
            switch (choice)
            {
                case 0:
                    Exit();
                    break;
                case 1:
                    KreirajWallet();
                    break;
                case 2:
                    PristupiWalletu();
                    break;
            }
        }

        private static void MainMenu()
        {
            var options = "\n1 - Kreiraj wallet\n2 - Pristupi walletu\n0 - Izađi iz programa";
            Selection(Menu(options, "", 0, 2));

            Console.ReadKey();
        }
        private static int Menu(string options, string optionally, int lowerLimit, int upperLimit)
        {
            Console.Clear();
            Console.WriteLine(optionally);

            Console.WriteLine("\nIzaberite jednu od ponuđenih mogućnosti upisom broja: ");
            bool correctInput;
            int userChoice;
            do
            {
                Console.WriteLine(options);
                correctInput = int.TryParse(Console.ReadLine(), out userChoice);

            } while (correctInput == false || userChoice < lowerLimit || userChoice > upperLimit);

            return userChoice;
        }
        private static void Exit()
        {
            Console.Clear();
            Console.WriteLine("\nOdabrali ste opciju : 0 - Izlaz iz aplikacije.\n");
            var closeApp = "";
            do
            {
                Console.WriteLine("Jeste li sigurni da želite izaći iz aplikacije? (DA/NE)");
                closeApp = Console.ReadLine().Trim();

            } while (closeApp != "DA" && closeApp != "NE");
            if (closeApp == "DA")
                Environment.Exit(0);
            else
                MainMenu();
        }
        private static void PristupiWalletu()
        {
            Console.Clear();
            IspisiAdreseSvihWalleta();

            Console.WriteLine("Unesite adresu walleta koji želite koristiti : ");

            Guid adresaWalleta = Guid.Parse(Console.ReadLine());

            var wallet1 = bitcoinWalleti.FirstOrDefault(x => x.Adresa == adresaWalleta);
            var wallet2 = ethereumWalleti.FirstOrDefault(x => x.Adresa == adresaWalleta);
            var wallet3 = solanaWalleti.FirstOrDefault(x => x.Adresa == adresaWalleta);

            if (wallet1 != null)
                Podmenu(wallet1);
            else if (wallet2 != null)
                Podmenu(wallet2);
            else if (wallet3 != null)
                Podmenu(wallet3);
            else
                Console.WriteLine("Trazeni wallet ne postoji");
            //opcije
            //portfolio
            //transfer
            //povijest transakcija
        }

        private static void Podmenu(BitcoinWallet wallet)
        {
            Console.Clear();
            var options = "\n1 - Portfolio\n2 - Transfer\n3 - Povijest transakcija \n0 - Povratak na inicijalni menu";
            SelectionPodMenu(Menu(options, "", 0, 3), wallet);

            Console.ReadKey();
        }
        private static void Podmenu(EthereumWallet wallet)
        {
            Console.Clear();
            var options = "\n1 - Portfolio\n2 - Transfer\n3 - Povijest transakcija \n0 - Povratak na inicijalni menu";
            SelectionPodMenu(Menu(options, "", 0, 3), wallet);

            Console.ReadKey();
        }
        private static void Podmenu(SolanaWallet wallet)
        {
            Console.Clear();
            var options = "\n1 - Portfolio\n2 - Transfer\n3 - Povijest transakcija \n0 - Povratak na inicijalni menu";
            SelectionPodMenu(Menu(options, "", 0, 3), wallet);

            Console.ReadKey();
        }
        private static void SelectionPodMenu(int choice, EthereumWallet wallet)
        {
            switch (choice)
            {
                case 0:
                    MainMenu();
                    break;
                case 1:
                    Portfolio(wallet);
                    break;
                case 2:
                    Console.WriteLine("Unesite adresu walleta kojem šaljete asset : ");
                    Guid adresaWalletaPrimatelj = Guid.Parse(Console.ReadLine());
                    Console.WriteLine("Unesite adresu walleta koji šalje asset : ");
                    Guid adresaWalletaPosiljatelj = Guid.Parse(Console.ReadLine());

                    //TODO Fungible ili non fungible
                    //Spremi transakciju
                    Console.WriteLine("Unesite količimu asseta koji šaljete  : ");
                    Decimal kolicinaAsseta = Decimal.Parse(Console.ReadLine());

                    var trazeniWallet = ethereumWalleti.FirstOrDefault(x => x.Adresa == adresaWalletaPrimatelj);
                    //trazeniWallet.BalansiFungibleAsseta += kolicinaAsseta;

                    break;
                case 3:
                    break;
            }
        }
        private static void SelectionPodMenu(int choice, BitcoinWallet wallet)
        {
            switch (choice)
            {
                case 0:
                    MainMenu();
                    break;
                case 1:
                    Portfolio(wallet);
                    break;
                case 2:
                    Console.WriteLine("Unesite adresu walleta kojem šaljete asset : ");
                    Guid adresaWalletaPrimatelj = Guid.Parse(Console.ReadLine());
                    Console.WriteLine("Unesite adresu walleta koji šalje asset : ");
                    Guid adresaWalletaPosiljatelj = Guid.Parse(Console.ReadLine());

                    //TODO Fungible ili non fungible
                    //Spremi transakciju
                    Console.WriteLine("Unesite količimu asseta koji šaljete  : ");
                    Decimal kolicinaAsseta = Decimal.Parse(Console.ReadLine());

                    var trazeniWallet = ethereumWalleti.FirstOrDefault(x => x.Adresa == adresaWalletaPrimatelj);
                    //trazeniWallet.BalansiFungibleAsseta += kolicinaAsseta;
                    break;
                case 3:
                    break;
            }
        }
        private static void SelectionPodMenu(int choice, SolanaWallet wallet)
        {
            switch (choice)
            {
                case 0:
                    MainMenu();
                    break;
                case 1:
                    Portfolio(wallet);
                    MainMenu();
                    break;
                case 2:
                    Console.WriteLine("Unesite adresu walleta kojem šaljete asset : ");
                    Guid adresaWalletaPrimatelj = Guid.Parse(Console.ReadLine());
                    Console.WriteLine("Unesite adresu walleta koji šalje asset : ");
                    Guid adresaWalletaPosiljatelj = Guid.Parse(Console.ReadLine());

                    //TODO Fungible ili non fungible
                    //Spremi transakciju
                    Console.WriteLine("Unesite količimu asseta koji šaljete  : ");
                    Decimal kolicinaAsseta = Decimal.Parse(Console.ReadLine());

                    var trazeniWallet = ethereumWalleti.FirstOrDefault(x => x.Adresa == adresaWalletaPrimatelj);
                    //trazeniWallet.BalansiFungibleAsseta += kolicinaAsseta;
                    break;
                case 3:
                    break;
            }
        }
        private static void Portfolio(BitcoinWallet wallet)
        {
            Console.Clear();
            var vrijednost = wallet.IzracunajUkupnuVrijednostAsseta(fungibleAsseti);
            Console.WriteLine($"ukupna vrijednost svih asseta u USD : {vrijednost}");
            foreach (var asset in wallet.BalansiFungibleAsseta)
            {
                var trazeniAsset = fungibleAsseti.FirstOrDefault(x => x.Adresa == asset.Item1);

                Console.WriteLine($"Adresa fungible asseta : {asset.Item1}");
                Console.WriteLine($"Ime fungible asseta : {trazeniAsset.Ime}");
                Console.WriteLine($"Oznaka fungible asseta : {trazeniAsset.Oznaka}");
                Console.WriteLine($"Vrijednost fungible asseta : {asset.Item2}");
                Console.WriteLine($"Vrijednost fungible asseta : {asset.Item2 * trazeniAsset.Vrijednost} USD");
                ////TODO:
                //Console.WriteLine("Postotak pada/povečanja ukupne USD vrijednosti ovog asseta u odnosu na prošli put kada se ta informacija prikazala");
            }
            Console.ReadKey();

        }
        private static void Portfolio(EthereumWallet wallet)
        {
            Console.Clear();
            var vrijednost = wallet.IzracunajUkupnuVrijednostAsseta(fungibleAsseti, nonFungibleAsseti);
            Console.WriteLine($"ukupna vrijednost svih asseta u USD : {vrijednost}");
            foreach (var asset in wallet.BalansiFungibleAsseta)
            {
                var trazeniAsset = fungibleAsseti.FirstOrDefault(x => x.Adresa == asset.Item1);

                Console.WriteLine($"Adresa fungible asseta : {asset.Item1}");
                Console.WriteLine($"Ime fungible asseta : {trazeniAsset.Ime}");
                Console.WriteLine($"Oznaka fungible asseta : {trazeniAsset.Oznaka}");
                Console.WriteLine($"Vrijednost fungible asseta : {asset.Item2}");
                Console.WriteLine($"Vrijednost fungible asseta : {asset.Item2 * trazeniAsset.Vrijednost} USD");
                ////TODO:
                //Console.WriteLine("Postotak pada/povečanja ukupne USD vrijednosti ovog asseta u odnosu na prošli put kada se ta informacija prikazala");
            }
            foreach (var asset in wallet.AdreseNonFungibleAssetaKojePosjeduje)
            {
                var trazeniAsset = nonFungibleAsseti.FirstOrDefault(x => x.Adresa == asset);
                var fungiblevrijednost = fungibleAsseti.FirstOrDefault(x => x.Adresa == trazeniAsset.FungibleAssetId).Vrijednost;
                Console.WriteLine($"Adresa fungible asseta : {asset}");
                Console.WriteLine($"Ime fungible asseta : {trazeniAsset.Ime}");
                Console.WriteLine($"Vrijednost fungible asseta : {trazeniAsset.Vrijednost}");
                Console.WriteLine($"Vrijednost fungible asseta : {fungiblevrijednost * trazeniAsset.Vrijednost} USD");
                ////TODO:
                //Console.WriteLine("Postotak pada/povečanja ukupne USD vrijednosti ovog asseta u odnosu na prošli put kada se ta informacija prikazala");
            }
            Console.ReadKey();
        }
        private static void Portfolio(SolanaWallet wallet)
        {
            Console.Clear();
            var vrijednost = wallet.IzracunajUkupnuVrijednostAsseta(fungibleAsseti, nonFungibleAsseti);
            Console.WriteLine($"ukupna vrijednost svih asseta u USD : {vrijednost}");
            foreach (var asset in wallet.BalansiFungibleAsseta)
            {
                var trazeniAsset = fungibleAsseti.FirstOrDefault(x => x.Adresa == asset.Item1);

                Console.WriteLine($"Adresa fungible asseta : {asset.Item1}");
                Console.WriteLine($"Ime fungible asseta : {trazeniAsset.Ime}");
                Console.WriteLine($"Oznaka fungible asseta : {trazeniAsset.Oznaka}");
                Console.WriteLine($"Vrijednost fungible asseta : {asset.Item2}");
                Console.WriteLine($"Vrijednost fungible asseta : {asset.Item2 * trazeniAsset.Vrijednost} USD");
                ////TODO:
                //Console.WriteLine("Postotak pada/povečanja ukupne USD vrijednosti ovog asseta u odnosu na prošli put kada se ta informacija prikazala");
            }
            foreach (var asset in wallet.AdreseNonFungibleAssetaKojePosjeduje)
            {
                var trazeniAsset = nonFungibleAsseti.FirstOrDefault(x => x.Adresa == asset);
                var fungiblevrijednost = fungibleAsseti.FirstOrDefault(x => x.Adresa == trazeniAsset.FungibleAssetId).Vrijednost;
                Console.WriteLine($"Adresa fungible asseta : {asset}");
                Console.WriteLine($"Ime fungible asseta : {trazeniAsset.Ime}");
                Console.WriteLine($"Vrijednost fungible asseta : {trazeniAsset.Vrijednost}");
                Console.WriteLine($"Vrijednost fungible asseta : {fungiblevrijednost * trazeniAsset.Vrijednost} USD");
                ////TODO:
                //Console.WriteLine("Postotak pada/povečanja ukupne USD vrijednosti ovog asseta u odnosu na prošli put kada se ta informacija prikazala");
            }
            Console.ReadKey();
        }

        private static void IspisiAdreseSvihWalleta()
        {
            Console.Clear();
            foreach (var wallet in bitcoinWalleti)
            {
                Console.WriteLine("Tip walleta : Bitcoin wallet");
                Console.WriteLine($"Adresa walleta : {wallet.Adresa}");
                var ukupnaVrijednost = wallet.IzracunajUkupnuVrijednostAsseta(fungibleAsseti);
                Console.WriteLine($"Ukupna vrijednost svih asseta koje posjeduje : {ukupnaVrijednost} USD");
                //TODO:
                Console.WriteLine("Postotak pada/povećanja ukupne USD vrijednosti svih asseta koje posjeduje u odnosu na prošli put kada se ta informacija prikazala");
            }
            foreach (var wallet in ethereumWalleti)
            {
                Console.WriteLine("Tip walleta : Ethereum wallet");
                Console.WriteLine($"Adresa walleta : {wallet.Adresa}");
                var ukupnaVrijednost = wallet.IzracunajUkupnuVrijednostAsseta(fungibleAsseti, nonFungibleAsseti);
                Console.WriteLine($"Ukupna vrijednost svih asseta koje posjeduje : {ukupnaVrijednost} USD");
                //TODO:
                Console.WriteLine("Postotak pada/povećanja ukupne USD vrijednosti svih asseta koje posjeduje u odnosu na prošli put kada se ta informacija prikazala");
            }
            foreach (var wallet in solanaWalleti)
            {
                Console.WriteLine("Tip walleta : Solana wallet");
                Console.WriteLine($"Adresa walleta : {wallet.Adresa}");
                var ukupnaVrijednost = wallet.IzracunajUkupnuVrijednostAsseta(fungibleAsseti, nonFungibleAsseti);
                Console.WriteLine($"Ukupna vrijednost svih asseta koje posjeduje : {ukupnaVrijednost} USD");
                //TODO:
                Console.WriteLine("Postotak pada/povećanja ukupne USD vrijednosti svih asseta koje posjeduje u odnosu na prošli put kada se ta informacija prikazala");
            }
        }

        private static void KreirajWallet()
        {
            Console.Clear();
            var options = "\n1 - Bitcoin wallet\n2 - Etheruem wallet\n3 - Solana wallet";
            KreirajOdabraniWallet(Menu(options, "", 1, 3));

            Console.ReadKey();
        }

        private static void SelectionKreirajWallet(int choice)
        {
            switch (choice)
            {
                case 1:
                    Exit();
                    break;
                case 2:
                    KreirajWallet();
                    break;
                case 3:
                    PristupiWalletu();
                    break;
            }
        }

        private static void KreirajOdabraniWallet(int vrstaWalleta)
        {
            switch (vrstaWalleta)
            {
                case 1:
                    KreirajBitcoinWallet();
                    MainMenu();
                    break;
                case 2:
                    KreirajEthereumWallet();
                    MainMenu();
                    break;
                case 3:
                    KreirajSolanaWallet();
                    MainMenu();
                    break;
            }
        }

        private static void KreirajBitcoinWallet()
        {
            var noviBitcoinWallet = new BitcoinWallet();

            noviBitcoinWallet.AdresePodrzanihFungibleAsseta.Add(fungibleAsset1.Adresa);
            noviBitcoinWallet.AdresePodrzanihFungibleAsseta.Add(fungibleAsset2.Adresa);
            noviBitcoinWallet.AdresePodrzanihFungibleAsseta.Add(fungibleAsset3.Adresa);
            bitcoinWalleti.Add(noviBitcoinWallet);

            Console.WriteLine("Bitcoin wallet je kreiran");
            Console.ReadKey();
        }
        private static void KreirajEthereumWallet()
        {
            var noviEthereumWallet = new EthereumWallet();

            noviEthereumWallet.AdresePodrzanihFungibleINonFungibleAsseta.Add(fungibleAsset1.Adresa);
            noviEthereumWallet.AdresePodrzanihFungibleINonFungibleAsseta.Add(fungibleAsset2.Adresa);
            noviEthereumWallet.AdresePodrzanihFungibleINonFungibleAsseta.Add(fungibleAsset3.Adresa);
            noviEthereumWallet.AdresePodrzanihFungibleINonFungibleAsseta.Add(nonfungibleAsset1.Adresa);
            noviEthereumWallet.AdresePodrzanihFungibleINonFungibleAsseta.Add(nonfungibleAsset2.Adresa);
            noviEthereumWallet.AdresePodrzanihFungibleINonFungibleAsseta.Add(nonfungibleAsset3.Adresa);
            ethereumWalleti.Add(noviEthereumWallet);

            Console.WriteLine("Ethereum wallet je kreiran");
            Console.ReadKey();
        }
        private static void KreirajSolanaWallet()
        {
            var noviSolanaWallet = new SolanaWallet();

            noviSolanaWallet.AdresePodrzanihFungibleINonFungibleAsseta.Add(fungibleAsset1.Adresa);
            noviSolanaWallet.AdresePodrzanihFungibleINonFungibleAsseta.Add(fungibleAsset2.Adresa);
            noviSolanaWallet.AdresePodrzanihFungibleINonFungibleAsseta.Add(fungibleAsset3.Adresa);

            solanaWalleti.Add(noviSolanaWallet);

            Console.WriteLine("Solana wallet je kreiran");
            Console.ReadKey();
        }
    }
}
