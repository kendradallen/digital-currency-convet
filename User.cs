using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalCurrencyConverted
{
    public class User
    {
        #region Fields

        #endregion

        #region Prop
        public decimal Cash { get; set; }
        public decimal Bitcoin { get; set; }
        public decimal Etherium { get; set; }
        public decimal Litecoin { get; set; }
        #endregion

        #region CTOR
        public User( )
        {
            Cash = 5000;
            Bitcoin = 0;
            Etherium = 0;
            Litecoin = 0;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Account:\nCash: {Cash:c}\nBitcoin: {Bitcoin:c}\nEtherium: {Etherium:c}\nLitecoin: {Litecoin:c}";
        }

        public decimal AccountTotal()
        {
            return Cash + Bitcoin + Etherium + Litecoin;
        }
        #endregion
    }
}
