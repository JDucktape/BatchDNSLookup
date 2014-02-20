using System;
using System.Net;
using System.Text;
using JHSoftware;

namespace ClandestineDevelopment.Tools.BatchDnsLookup
{
    public class DnsLookup
    {
        public IPAddress PrimaryDnsServer { get; set; }
        public IPAddress SecondaryDnsServer { get; set; }

        private bool EnableCustomDnsServers;
        private bool EnableDebugLogging;
        private int Timeout;
        private int RetryCount;

        public DnsLookup(bool enableCustomDnsServers, bool enableDebugLogging, int queryTimeout, int queryRetries)
        {
            this.EnableCustomDnsServers = enableCustomDnsServers;
            this.EnableDebugLogging = enableDebugLogging;
            this.Timeout = queryTimeout;
            this.RetryCount = queryRetries;
        }

        public string Lookup(string domain, DnsClient.RecordType recordtype, bool onlyGetOneRecord) 
        {
            StringBuilder output = new StringBuilder();
            if (domain.Trim().Length == 0)
            {
                output.Append("");
            }
            else
            {
                try
                {
                    DnsClient.RequestOptions options = new DnsClient.RequestOptions();

                    if (EnableCustomDnsServers)
                    {
                        options.DnsServers = new IPAddress[] { PrimaryDnsServer, SecondaryDnsServer };
                    }
                    options.TimeOut = new TimeSpan(0, 0, Timeout);
                    options.RetryCount = RetryCount;

                    if (recordtype == DnsClient.RecordType.PTR)
                    {
                        string[] hostnames; 
                        IPAddress ip;
                        if (IPAddress.TryParse(domain, out ip))
                        {
                            hostnames = DnsClient.LookupReverse(ip, options);
                            if (onlyGetOneRecord)
                            {
                                if (EnableDebugLogging)
                                {
                                    output.Append(String.Format("IP: {0} Type: {1} Result: {2}", ip.ToString(), recordtype, hostnames[hostnames.Length - 1]));
                                }
                                else
                                {
                                    output.Append(hostnames[hostnames.Length - 1]);
                                }
                            }
                            else
                            {
                                for (int i = 0; i < hostnames.Length; i++)
                                {
                                    if (i == hostnames.Length - 1)
                                    {
                                        // It's the last record, end the output without a linebreak.
                                        if (EnableDebugLogging)
                                        {
                                            output.Append(String.Format("IP: {0} Type: {1} Result: {2}", ip.ToString(), recordtype, hostnames[i]));
                                        }
                                        else
                                        {
                                            output.Append(hostnames[i]);
                                        }
                                    }
                                    else
                                    {
                                        if (EnableDebugLogging)
                                        {
                                            output.AppendLine(String.Format("IP: {0} Type: {1} Result: {2}", ip.ToString(), recordtype, hostnames[i]));
                                        }
                                        else
                                        {
                                            output.AppendLine(hostnames[i]);
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            output.Append(String.Format("Error: {0} is not a valid IP address", domain));
                        }
                    }
                    //else if (recordtype == DnsClient.RecordType.MX)
                    //{
                    //    // TODO: Implement this - add support for MX Priority stuff in output?
                    //    DnsClient.MXHost[] mailhosts = DnsClient.LookupMX(domain, options);
                    //    if (onlyGetOneRecord)
                    //    {

                    //    }
                    //    else
                    //    {
                    //        foreach(var m in mailhosts)
                    //            output.AppendLine(String.Format("Preference: {2} Hostname: {0} IP: ", m.HostName, m.IPAddresses, m.Preference));

                    //    }
                    //}
                    else
                    {
                        DnsClient.Response response = DnsClient.Lookup(domain, recordtype, options);
                        if (onlyGetOneRecord)
                        {
                            // We should only get one record, so we'll pick the last record looked up in the chain. 
                            // It's most likely the one needed in typical recursive A-record lookups.
                            DnsClient.Response.Record record = response.AnswerRecords[response.AnswerRecords.Count - 1];
                            if (EnableDebugLogging)
                            {
                                output.Append(String.Format("Domain: {0} Type: {1} TTL: {2} Result: {3}", record.Name, record.Type, record.TTL, record.Data));
                            }
                            else
                            {
                                output.Append(record.Data);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < response.AnswerRecords.Count; i++)
                            {
                                if (i == response.AnswerRecords.Count - 1)
                                {
                                    // It's the last record, end the output without a linebreak.
                                    if (EnableDebugLogging)
                                    {
                                        output.Append(String.Format("Domain: {0} Type: {1} TTL: {2} Result: {3}", response.AnswerRecords[i].Name, response.AnswerRecords[i].Type, response.AnswerRecords[i].TTL, response.AnswerRecords[i].Data));
                                    }
                                    else
                                    {
                                        output.Append(response.AnswerRecords[i].Data);
                                    }
                                }
                                else
                                {
                                    if (EnableDebugLogging)
                                    {
                                        output.AppendLine(String.Format("Domain: {0} Type: {1} TTL: {2} Result: {3}", response.AnswerRecords[i].Name, response.AnswerRecords[i].Type, response.AnswerRecords[i].TTL, response.AnswerRecords[i].Data));
                                    }
                                    else
                                    {
                                        output.AppendLine(response.AnswerRecords[i].Data);
                                    }
                                }
                            }
                        }
                    }
                }
                catch (DnsClient.NXDomainException nxd)
                {
                    if (EnableDebugLogging)
                    {
                        output.Append(nxd.Message);

                    }
                    else
                    {
                        output.Append("The domain name does not exist.");
                    }
                }
                catch (DnsClient.NoDefinitiveAnswerException nda)
                {
                    if (EnableDebugLogging)
                    {
                        for (int i = 0; i < nda.ServerProblems.Count; i++)
                        {
                            if (i == nda.ServerProblems.Count - 1)
                            {
                                // It's the last record, end the output without a linebreak
                                output.Append(String.Format("DNS Server: {0} Problem: {1} ({2})", nda.ServerProblems[i].Server, nda.ServerProblems[i].ProblemDescription, nda.ServerProblems[i].Problem));
                            }
                            else
                            {
                                output.AppendLine(String.Format("DNS Server: {0} Problem: {1} ({2})", nda.ServerProblems[i].Server, nda.ServerProblems[i].ProblemDescription, nda.ServerProblems[i].Problem));
                            }
                        }
                    }
                    else
                    {
                        output.Append("No definitive answer from server.");
                    }
                }
                catch (Exception ex)
                {
                    output.Append("Error: " + ex.Message);
                }
            }
            return output.ToString();
        }
    }
}
