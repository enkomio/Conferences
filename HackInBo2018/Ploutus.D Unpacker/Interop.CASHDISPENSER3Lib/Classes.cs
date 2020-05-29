using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CASHDISPENSER3Lib
{
    public interface ICDMCashUnitStatus
    {

    }

    public enum CDMCashUnitStatus
    {
        Ready,
        Full

    }

    public interface ICDMCashUnit
    {
        Int16 Number { get; set; }
        Int32 Count { get; set; }
        Int32 Value { get; set; }
        CDMCashUnitStatus status { get; set; }
        String Currency { get; set; }
    }

    public class CDMCashUnit : ICDMCashUnit
    {
        public Int16 Number { get; set; }
        public Int32 Count { get; set; }
        public Int32 Value { get; set; }
        public CDMCashUnitStatus status { get; set; }
        public String Currency { get; set; }
    }

    public interface ICDMDenomination
    {
        Int16 NoOfValues { get; set; }
        Int32 Amount { get; set; }
        String Values { get; set; }
        String CurrencyID { get; set; }        
    }

    public class CDMDenomination : ICDMDenomination
    {
        public Int16 NoOfValues { get; set; }
        public Int32 Amount { get; set; }
        public String Values { get; set; }
        public String CurrencyID { get; set; }
    }

    public class CDMDenominationClass : CDMDenomination
    {
        public CDMDenominationClass() : base()
        {
            this.CurrencyID = "MLW";
        }
    }

    public interface ICDMCashUnitList : IEnumerable
    {
        Int16 Count { get; set; }
        ICDMCashUnit GetCashUnit(Int16 n);
    }

    public enum CDMPosition : Int16
    {
        A = 0,
        B = 1,
        C = 2,
        D = 3,
        E = 4,
        F = 5,
        G = 6,
        H = 7
    }

    public class CDMCashUnitList : ICDMCashUnitList 
    {
        public Int16 Count { get; set; }

        public CDMCashUnitList()
        {
            this.Count = 10;
        }

        public CDMCashUnit GetCashUnit(Int16 n)
        {
            return new CDMCashUnit();
        }

        ICDMCashUnit ICDMCashUnitList.GetCashUnit(short n)
        {
            var cu = new CDMCashUnit {
                Number = n,
                Count = 55,
                Value = 12,
                Currency = "Euro"
            };
            return cu;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
