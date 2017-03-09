using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Security.Cryptography;
using System.Runtime.Serialization;
using Newtonsoft.Json;
namespace com.oklink.httpbase
{

    class HttpUtilManager
    {
        private string apikey;
        private string secret;
        private HttpUtilManager(string apikey, string secret) {
            this.apikey = apikey;
            this.secret = secret;
        }
        private static HttpUtilManager instance = null;
        public static HttpUtilManager getInstance(string apikey,string secret)
        {
            if (instance == null) {
                instance = new HttpUtilManager(apikey, secret);
            }
            return instance;
        }
        private string CreateToken(string message, string secret)
        {
            var encoding = new System.Text.ASCIIEncoding();
            byte[] keyByte = encoding.GetBytes(secret);
            byte[] messageBytes = encoding.GetBytes(message);
            using (var hmacsha256 = new HMACSHA256(keyByte))
            {
                byte[] hashmessage = hmacsha256.ComputeHash(messageBytes);
                return toHexString(hashmessage);
            }
        }
        private  string toHexString(byte[] bytes) // 0xae00cf => "AE00CF "
        {
            string hexString = string.Empty;
            if (bytes != null)
            {
                StringBuilder strB = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    strB.Append(bytes[i].ToString("x2"));
                }
                hexString = strB.ToString();
            }
            return hexString;
        }
        private string GetTimeStamp()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        } 
        public String requestHttpPost(String url_prex, String url, Dictionary<String, Object> paras)
        {
            String responseContent = "";
            HttpWebResponse httpWebResponse = null;
            StreamReader streamReader = null;
            try
            {  //组装访问路径
                String base_url = url_prex + url;
                //根据url创建HttpWebRequest对象
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(base_url);
                //设置请求方式和头信息
                httpWebRequest.Method = "POST";
                httpWebRequest.ContentType = "application/json";
                String data = "";
                if(paras!=null){
                   data =  JsonConvert.SerializeObject(paras).ToString();
                }
                String nonce = GetTimeStamp();
                String needSign = nonce+url+data;
                httpWebRequest.Headers.Add("KEY", apikey);
                httpWebRequest.Headers.Add("NONCE", nonce);
                httpWebRequest.Headers.Add("SIGNATURE", CreateToken(needSign, secret));
                byte[] btBodys = Encoding.UTF8.GetBytes(data);
                httpWebRequest.ContentLength = btBodys.Length;
                    //将请求内容封装在请求体中
                httpWebRequest.GetRequestStream().Write(btBodys, 0, btBodys.Length);
                
                //获取响应
                httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                //得到响应流
                streamReader = new StreamReader(httpWebResponse.GetResponseStream());
                //读取响应内容
                responseContent = streamReader.ReadToEnd();
                //关闭资源
                httpWebResponse.Close();
                streamReader.Close();
                //返回结果
                if (responseContent == null || "".Equals(responseContent))
                {
                    return "";
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (httpWebResponse != null)
                {
                    httpWebResponse.Close();

                }
                if (streamReader != null)
                {
                    streamReader.Close();
                }
            }
            return responseContent;
        }

    }
}
