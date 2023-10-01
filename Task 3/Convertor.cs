using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Convertor
    {
        private decimal _eurExchanchangeRate;
        private decimal _usdExchanchangeRate;

        public Convertor(decimal eurRate, decimal usdRate)
        {
            _eurExchanchangeRate = eurRate;
            _usdExchanchangeRate= usdRate;
        }

        public decimal UsdToUah(decimal number)
        {
            return _usdExchanchangeRate * number;
        }

        public decimal EurToUah(decimal number)
        {
            return _eurExchanchangeRate * number;
        }

        public decimal UahToUsd(decimal number)
        {
            return number / _usdExchanchangeRate;
        }

        public decimal UahToEur(decimal number)
        {
            return number / _eurExchanchangeRate;
        }

        public decimal UsdToEur(decimal number)
        {
            return _usdExchanchangeRate * number / _eurExchanchangeRate;
        }

        public decimal EurToUsd(decimal number)
        {
            return _eurExchanchangeRate*number / _usdExchanchangeRate;
        }
    }

}
