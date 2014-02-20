using System;
using System.Collections.Generic;
using System.Text;

namespace ClandestineDevelopment.Tools.BatchDnsLookup
{
    public class DnsDataItem: IComparable
    {
        public int ID { get; set; }
        public string Domain { get; set; }
        public string Result { get; set; }

        public DnsDataItem(int id, string domain)
        {
            this.ID = id;
            this.Domain = domain;
        }

        public string GetResultsAsCSV(bool embedInDoubleQuotes)
        {
            if (embedInDoubleQuotes)
            {
                return String.Format("\"{0}\"", Result.Replace(Environment.NewLine, ","));
            }
            else
            {
                return Result.Replace(Environment.NewLine, ",");
            }
        }

        public string GetDomainAndResultAsCSV(bool embedInDoubleQuotes, char separator)
        {
            if (embedInDoubleQuotes)
            {
                return String.Format("\"{0}\"{1}\"{2}\"", Domain, separator, Result.Replace(Environment.NewLine, ","));
            }
            else
            {
                return String.Format("{0}{1}{2}", Domain, separator, Result.Replace(Environment.NewLine, ","));
            }
        }

        public int CompareTo(object obj)
        {
            DnsDataItem target = (DnsDataItem)obj;
            if (this.ID < target.ID)
                return -1;
            if (this.ID == target.ID)
                return 0;
            if (this.ID > target.ID)
                return 1;
            return 0;
        }
    }
}
