using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Net;
using System.Xml;

namespace CBHProject
{
    class FREDCB
    {
        private string accessDate = "2000-01-01";
        private string apikey = "15c11acdced34a0fb6f2aa4e31e328e1";

        public string getDate()
        { // get most current date
            DateTime date = DateTime.Now;
            date = new DateTime(date.Year, date.Month, 1, 0, 0, 0, date.Kind);
            date = date.AddMonths(-4);
            accessDate = date.ToString("yyyy-MM-dd");
            return accessDate;
        }

        public string phxrnsa() // get the Home Price Index for Phoenix, AZ
        {
            string r;
            String url = String.Format("http://api.stlouisfed.org/fred/series/observations?series_id=PHXRNSA&api_key={0}", apikey);

            try
            {
                // Make the HTTP request / get the response
                HttpWebRequest Request = (System.Net.HttpWebRequest)HttpWebRequest.Create(url);
                HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();

                // Parse the HTTP response into an XML document
                XmlDocument xml = new XmlDocument();
                xml.Load(Response.GetResponseStream());
                XmlElement root = xml.DocumentElement;

                // Get today's data via XPath

                string date = getDate();
                string insert = String.Format("/observations/observation[@date='{0}']/@value", date);
                string xmlNode = root.SelectSingleNode(insert).Value;

                Response.Close();

                r = xmlNode;
            }
            catch (Exception ex)
            {
                r = "DNF";  // this current month not found in xml file (Date Not Found)
            }

            return r;
        }

        public string phoeURN() // get the unemployment rate in phoenix-mesa-scottsdale, AZ
        {
            string u;
            String url = String.Format("http://api.stlouisfed.org/fred/series/observations?series_id=PHOE004URN&api_key={0}", apikey);

            try
            {
                // Make the HTTP request / get the response
                HttpWebRequest Request = (System.Net.HttpWebRequest)HttpWebRequest.Create(url);
                HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();

                // Parse the HTTP response into an XML document
                XmlDocument xml = new XmlDocument();
                xml.Load(Response.GetResponseStream());
                XmlElement root = xml.DocumentElement;

                // Get today's data via XPath

                string date = getDate();
                string insert = String.Format("/observations/observation[@date='{0}']/@value", date);
                string xmlNode = root.SelectSingleNode(insert).Value;

                Response.Close();

                u = xmlNode;
            }
            catch (Exception ex)
            {
                u = "DNF";
            }

            return u;
        }

        public string AZMARIURN() // get the unemployment rate in Maricopa County, AZ
        {
            string u1;
            String url = String.Format("http://api.stlouisfed.org/fred/series/observations?series_id=AZMARI3URN&api_key={0}", apikey);

            try
            {
                // Make the HTTP request / get the response
                HttpWebRequest Request = (System.Net.HttpWebRequest)HttpWebRequest.Create(url);
                HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();

                // Parse the HTTP response into an XML document
                XmlDocument xml = new XmlDocument();
                xml.Load(Response.GetResponseStream());
                XmlElement root = xml.DocumentElement;

                // Get today's data via XPath

                string date = getDate();
                string insert = String.Format("/observations/observation[@date='{0}']/@value", date);
                string xmlNode = root.SelectSingleNode(insert).Value;

                Response.Close();

                u1 = xmlNode;
            }
            catch (Exception ex)
            {
                u1 = "DNF";
            }

            return u1;
        }

        public string AZMARIPOP() // get the Resident Population in Maricopa County, AZ
        {
            string p;
            String url = String.Format("http://api.stlouisfed.org/fred/series/observations?series_id=AZMARI3POP&api_key={0}", apikey);

            try
            {
                // Make the HTTP request / get the response
                HttpWebRequest Request = (System.Net.HttpWebRequest)HttpWebRequest.Create(url);
                HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();

                // Parse the HTTP response into an XML document
                XmlDocument xml = new XmlDocument();
                xml.Load(Response.GetResponseStream());
                XmlElement root = xml.DocumentElement;

                // Get today's data via XPath

                string date = getDate();
                string insert = String.Format("/observations/observation[@date='{0}']/@value", date);
                string xmlNode = root.SelectSingleNode(insert).Value;

                Response.Close();

                p = xmlNode;
            }
            catch (Exception ex)
            {
                p = "DNF";
            }

            return p;
        }

        public string AZMARILFN() // get the Civilian Labor Force in Maricopa County, AZ
        {
            string lfn;
            String url = String.Format("http://api.stlouisfed.org/fred/series/observations?series_id=AZMARI3LFN&api_key={0}", apikey);

            try
            {
                // Make the HTTP request / get the response
                HttpWebRequest Request = (System.Net.HttpWebRequest)HttpWebRequest.Create(url);
                HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();

                // Parse the HTTP response into an XML document
                XmlDocument xml = new XmlDocument();
                xml.Load(Response.GetResponseStream());
                XmlElement root = xml.DocumentElement;

                // Get today's data via XPath

                string date = getDate();
                string insert = String.Format("/observations/observation[@date='{0}']/@value", date);
                string xmlNode = root.SelectSingleNode(insert).Value;

                Response.Close();

                lfn = xmlNode;
            }
            catch (Exception ex)
            {
                lfn = "DNF";
            }

            return lfn;
        }

        public string AZSTHPI() // get All-Transactions House Price Index for Arizona
        {
            string lfn;
            String url = String.Format("http://api.stlouisfed.org/fred/series/observations?series_id=AZSTHPI&api_key={0}", apikey);

            try
            {
                // Make the HTTP request / get the response
                HttpWebRequest Request = (System.Net.HttpWebRequest)HttpWebRequest.Create(url);
                HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();

                // Parse the HTTP response into an XML document
                XmlDocument xml = new XmlDocument();
                xml.Load(Response.GetResponseStream());
                XmlElement root = xml.DocumentElement;

                // Get today's data via XPath

                string date = getDate();
                string insert = String.Format("/observations/observation[@date='{0}']/@value", date);
                string xmlNode = root.SelectSingleNode(insert).Value;

                Response.Close();

                lfn = xmlNode;
            }
            catch (Exception ex)
            {
                lfn = "DNF";
            }

            return lfn;
        }

        public string SPCS20RSA() // Case-Shiller Composite-20 
        {
            string lfn;
            String url = String.Format("http://api.stlouisfed.org/fred/series/observations?series_id=SPCS20RSA&api_key={0}", apikey);

            try
            {
                // Make the HTTP request / get the response
                HttpWebRequest Request = (System.Net.HttpWebRequest)HttpWebRequest.Create(url);
                HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();

                // Parse the HTTP response into an XML document
                XmlDocument xml = new XmlDocument();
                xml.Load(Response.GetResponseStream());
                XmlElement root = xml.DocumentElement;

                // Get today's data via XPath

                string date = getDate();
                string insert = String.Format("/observations/observation[@date='{0}']/@value", date);
                string xmlNode = root.SelectSingleNode(insert).Value;

                Response.Close();

                lfn = xmlNode;
            }
            catch (Exception ex)
            {
                lfn = "DNF";
            }

            return lfn;
        }

        public string SPCS20RNSA() // get the Case-Shiller Composite-20 Not Seasonally Adjusted
        {
            string lfn;
            String url = String.Format("http://api.stlouisfed.org/fred/series/observations?series_id=SPCS20RNSA&api_key={0}", apikey);

            try
            {
                // Make the HTTP request / get the response
                HttpWebRequest Request = (System.Net.HttpWebRequest)HttpWebRequest.Create(url);
                HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();

                // Parse the HTTP response into an XML document
                XmlDocument xml = new XmlDocument();
                xml.Load(Response.GetResponseStream());
                XmlElement root = xml.DocumentElement;

                // Get today's data via XPath

                string date = getDate();
                string insert = String.Format("/observations/observation[@date='{0}']/@value", date);
                string xmlNode = root.SelectSingleNode(insert).Value;

                Response.Close();

                lfn = xmlNode;
            }
            catch (Exception ex)
            {
                lfn = "DNF";
            }

            return lfn;
        }

        public string SPCS20RPSNSA() // get the S&P Case-Shiller 20-City Home Price Sales Pair Counts
        {
            string lfn;
            String url = String.Format("http://api.stlouisfed.org/fred/series/observations?series_id=SPCS20RPSNSA&api_key={0}", apikey);

            try
            {
                // Make the HTTP request / get the response
                HttpWebRequest Request = (System.Net.HttpWebRequest)HttpWebRequest.Create(url);
                HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();

                // Parse the HTTP response into an XML document
                XmlDocument xml = new XmlDocument();
                xml.Load(Response.GetResponseStream());
                XmlElement root = xml.DocumentElement;

                // Get today's data via XPath

                string date = getDate();
                string insert = String.Format("/observations/observation[@date='{0}']/@value", date);
                string xmlNode = root.SelectSingleNode(insert).Value;

                Response.Close();

                lfn = xmlNode;
            }
            catch (Exception ex)
            {
                lfn = "DNF";
            }

            return lfn;
        }

        public string SPCS10RSA() // get the  Case-Shiller Composite-10
        {
            string lfn;
            String url = String.Format("http://api.stlouisfed.org/fred/series/observations?series_id=SPCS10RSA&api_key={0}", apikey);

            try
            {
                // Make the HTTP request / get the response
                HttpWebRequest Request = (System.Net.HttpWebRequest)HttpWebRequest.Create(url);
                HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();

                // Parse the HTTP response into an XML document
                XmlDocument xml = new XmlDocument();
                xml.Load(Response.GetResponseStream());
                XmlElement root = xml.DocumentElement;

                // Get today's data via XPath

                string date = getDate();
                string insert = String.Format("/observations/observation[@date='{0}']/@value", date);
                string xmlNode = root.SelectSingleNode(insert).Value;

                Response.Close();

                lfn = xmlNode;
            }
            catch (Exception ex)
            {
                lfn = "DNF";
            }

            return lfn;
        }

        public string SPCS10RNSA() // get the Case-Shiller Composite-10 Not Seasonally Adjusted
        {
            string lfn;
            String url = String.Format("http://api.stlouisfed.org/fred/series/observations?series_id=SPCS10RNSA&api_key={0}", apikey);

            try
            {
                // Make the HTTP request / get the response
                HttpWebRequest Request = (System.Net.HttpWebRequest)HttpWebRequest.Create(url);
                HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();

                // Parse the HTTP response into an XML document
                XmlDocument xml = new XmlDocument();
                xml.Load(Response.GetResponseStream());
                XmlElement root = xml.DocumentElement;

                // Get today's data via XPath

                string date = getDate();
                string insert = String.Format("/observations/observation[@date='{0}']/@value", date);
                string xmlNode = root.SelectSingleNode(insert).Value;

                Response.Close();

                lfn = xmlNode;
            }
            catch (Exception ex)
            {
                lfn = "DNF";
            }

            return lfn;
        }

        public string SPCS10RPSNSA() // get the CS&P Case-Shiller 10-City Home Price Sales Pair Counts
        {
            string lfn;
            String url = String.Format("http://api.stlouisfed.org/fred/series/observations?series_id=SPCS10RPSNSA&api_key={0}", apikey);

            try
            {
                // Make the HTTP request / get the response
                HttpWebRequest Request = (System.Net.HttpWebRequest)HttpWebRequest.Create(url);
                HttpWebResponse Response = (HttpWebResponse)Request.GetResponse();

                // Parse the HTTP response into an XML document
                XmlDocument xml = new XmlDocument();
                xml.Load(Response.GetResponseStream());
                XmlElement root = xml.DocumentElement;

                // Get today's data via XPath

                string date = getDate();
                string insert = String.Format("/observations/observation[@date='{0}']/@value", date);
                string xmlNode = root.SelectSingleNode(insert).Value;

                Response.Close();

                lfn = xmlNode;
            }
            catch (Exception ex)
            {
                lfn = "DNF";
            }

            return lfn;
        }

    }
}
