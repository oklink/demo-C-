using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.oklink.httpbase;
using Newtonsoft.Json;
namespace com.oklink.client
{
    class OKLinkClientImpl : IOKLinkClient
    {
       
        private String secret_key;
        
        private String api_key;
      
        private String url_prex;
        public String getSecret_key()
        {
            return secret_key;
        }

        public void setSecret_key(String secret_key)
        {
            this.secret_key = secret_key;
        }

        public String getApi_key()
        {
            return api_key;
        }

        public void setApi_key(String api_key)
        {
            this.api_key = api_key;
        }

        public String getUrl_prex()
        {
            return url_prex;
        }

        public void setUrl_prex(String url_prex)
        {
            this.url_prex = url_prex;
        }
        public OKLinkClientImpl(String url_prex, String api_key, String secret_key)
        {
            this.api_key = api_key;
            this.secret_key = secret_key;
            this.url_prex = url_prex;
        }

        public OKLinkClientImpl(String url_prex)
        {
            this.url_prex = url_prex;
        }

      
        private const String ticker_url = "/api/v2/ticker.do";
        private const String country_url = "/api/v2/country.do";
        private const String detail_url = "/api/v2/detail_info.do";
        private const String create_remittance = "/api/v2/create_remittance.do";
        private const String remit_info = "/api/v2/remittance_info.do";
        private const String remit_list = "/api/v2/remittance_list.do";
        private const String pay_info = "/api/v2/pay_info.do";
        private const String pay = "/api/v2/pay.do";
        private const String accept = "/api/v2/accept.do";
        private const String reject_info = "/api/v2/reject_info.do";
        private const String reject = "/api/v2/reject.do";
        private const String refund = "/api/v2/refund.do";
        private const String refund_info = "/api/v2/refund_info.do";
        private const String receive_info = "/api/v2/receive_info.do";
        private const String receive = "/api/v2/receive.do";
        private const String user_info = "/api/v2/user_info.do";




        public String ticker(Dictionary<string, Object> param)
        {
            String result = "";
            try
            {
                HttpUtilManager httpUtil = HttpUtilManager.getInstance(api_key,secret_key);
                result = httpUtil.requestHttpPost(url_prex, ticker_url, param);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return result;
        }


        public string getCountryList()
        {
            String result = "";
            try
            {
                HttpUtilManager httpUtil = HttpUtilManager.getInstance(api_key, secret_key);
                result = httpUtil.requestHttpPost(url_prex, country_url, null);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return result;
        }

        public string getDetailInfo(Dictionary<string, Object> param)
        {
            String result = "";
            try
            {
                HttpUtilManager httpUtil = HttpUtilManager.getInstance(api_key, secret_key);
                result = httpUtil.requestHttpPost(url_prex,detail_url, param);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return result;
        }

        public string createRemittance(Dictionary<string, Object> param)
        {
            String result = "";
            try
            {
                HttpUtilManager httpUtil = HttpUtilManager.getInstance(api_key, secret_key);
                result = httpUtil.requestHttpPost(url_prex, create_remittance, param);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return result;
        }

        public string getRemitInfo(Dictionary<string, Object> param)
        {
            String result = "";
            try
            {
                HttpUtilManager httpUtil = HttpUtilManager.getInstance(api_key, secret_key);
                result = httpUtil.requestHttpPost(url_prex, remit_info, param);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return result;
        }

        public string getPayInfo(Dictionary<string, Object> param)
        {
            String result = "";
            try
            {
                HttpUtilManager httpUtil = HttpUtilManager.getInstance(api_key, secret_key);
                result = httpUtil.requestHttpPost(url_prex, pay_info, param);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return result;
        }

        public string toPay(Dictionary<string, Object> param)
        {
            String result = "";
            try
            {
                HttpUtilManager httpUtil = HttpUtilManager.getInstance(api_key, secret_key);
                result = httpUtil.requestHttpPost(url_prex, pay, param);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return result;
        }

        public string getRemitList(Dictionary<string, Object> param)
        {
            String result = "";
            try
            {
                HttpUtilManager httpUtil = HttpUtilManager.getInstance(api_key, secret_key);
                result = httpUtil.requestHttpPost(url_prex, remit_list, param);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return result;
        }

        string IOKLinkClient.accept(Dictionary<string, Object> param)
        {
            String result = "";
            try
            {
                HttpUtilManager httpUtil = HttpUtilManager.getInstance(api_key, secret_key);
                result = httpUtil.requestHttpPost(url_prex, accept, param);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return result;
        }

        public string getRejectInfo(Dictionary<string, Object> param)
        {
            String result = "";
            try
            {
                HttpUtilManager httpUtil = HttpUtilManager.getInstance(api_key, secret_key);
                result = httpUtil.requestHttpPost(url_prex, reject_info, param);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return result;
        }

        string IOKLinkClient.reject(Dictionary<string, Object> param)
        {
            String result = "";
            try
            {
                HttpUtilManager httpUtil = HttpUtilManager.getInstance(api_key, secret_key);
                result = httpUtil.requestHttpPost(url_prex, reject, param);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return result;
        }

        public string getReFundInfo(Dictionary<string, Object> param)
        {
            String result = "";
            try
            {
                HttpUtilManager httpUtil = HttpUtilManager.getInstance(api_key, secret_key);
                result = httpUtil.requestHttpPost(url_prex, refund_info, param);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return result;
        }

        string IOKLinkClient.refund(Dictionary<string, Object> param)
        {
            String result = "";
            try
            {
                HttpUtilManager httpUtil = HttpUtilManager.getInstance(api_key, secret_key);
                result = httpUtil.requestHttpPost(url_prex, refund, param);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return result;
        }

        public string getReciveInfo(Dictionary<string, Object> param)
        {
            String result = "";
            try
            {
                HttpUtilManager httpUtil = HttpUtilManager.getInstance(api_key, secret_key);
                result = httpUtil.requestHttpPost(url_prex, receive_info, param);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return result;
        }

        public string appealReceive(Dictionary<string, Object> param)
        {
            String result = "";
            try
            {
                HttpUtilManager httpUtil = HttpUtilManager.getInstance(api_key, secret_key);
                result = httpUtil.requestHttpPost(url_prex, receive, param);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return result;
        }

        public string getUserInfo()
        {
            String result = "";
            try
            {
                HttpUtilManager httpUtil = HttpUtilManager.getInstance(api_key, secret_key);
                result = httpUtil.requestHttpPost(url_prex, user_info, null);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return result;
        }
    }
}
