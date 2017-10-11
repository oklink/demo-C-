using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.oklink.client;
using Newtonsoft.Json;
namespace com.oklink.rest
{
    class Client
    {
        static void Main(String[] args)
        {
            String api_key = "";  //provied by oklink
            String secret_key = ""; //provied by oklink
            String url_prex = "https://www.oklink.com";
            IOKLinkClient client = new OKLinkClientImpl(url_prex,api_key,secret_key);

            Dictionary<string, Object> param = new Dictionary<string, Object>();
            param.Add("symbol", "BTC");
            String result = client.ticker(param);
             
            //get remittance support country list
            //String result = client.getCountryList();

            //get detail kyc info for every country
            //Dictionary<string, Object> param = new Dictionary<string, Object>();
            //param.Add("country_id", "40");
            //param.Add("pay_mode", "2");
            //String result = client.getDetailInfo(param);

            //create remittance
            //Dictionary<string, Object> param = new Dictionary<string, Object>();
            //Dictionary<string, Object> detail_info = new Dictionary<string, Object>();
            //Dictionary<string, Object> beneficiary = new Dictionary<string, Object>();
            //Dictionary<string, Object> remitter = new Dictionary<string, Object>();
            //beneficiary.Add("full_name","jimmy.yu");
            //beneficiary.Add("mobile_number","86,186000001");
            //beneficiary.Add("email","b@test.com");
            //remitter.Add("full_name", "rldrich");
            //remitter.Add("mobile_number", "86,186000002");
            //remitter.Add("email", "a@test.com");
            //detail_info.Add("bank_id", "69");
            //detail_info.Add("bank_acc_number", "1232132212321");
            //detail_info.Add("beneficiary", beneficiary);
            //detail_info.Add("remitter",remitter);
            //param.Add("country_id", 143);
            //param.Add("remit_fee",0);
            //param.Add("pay_mode", 2);
            //param.Add("transfer_network",1);
            //param.Add("receive_amount", 100);
            //param.Add("detail_info", JsonConvert.SerializeObject(detail_info).ToString()); //note : detail_info is a String 
            //param.Add("is_create", 1);
            //String result = client.createRemittance(param);

            //get remittance info
            //Dictionary<string, Object> param = new Dictionary<string, Object>();
            //param.Add("id", "fdasfa");
            //param.Add("type", 1);
            //String result = client.getRemitInfo(param);

            //get payment info
            //Dictionary<string, Object> param = new Dictionary<string, Object>();
            //param.Add("id", "fdasfa");
            //String result = client.getPayInfo(param);

            // to pay note:pay_hex is a string signed by signtoos and the source string is the result of pay_info
            // for .net we just provide a signtools which is JavaScript version.
            // this workflow is the some with API refund、reject、receive
            //Dictionary<string, Object> param = new Dictionary<string, Object>();
            //param.Add("id", "fdasfa");
            //param.Add("pay_hex","a string signed by signtoos");
            //String result = client.toPay(param);


            //for delivery partner accept a remittance
            //Dictionary<string, Object> param = new Dictionary<string, Object>();
            //param.Add("id", "fdasfa");
            //String result = client.accept(param);

            //get receive info
            //Dictionary<string, Object> param = new Dictionary<string, Object>();
            //param.Add("id", "fdasfa");
            //String result = client.getReciveInfo(param);

            //receive the money 
            //Dictionary<string, Object> param = new Dictionary<string, Object>();
            //param.Add("id", "fdasfa");
            //param.Add("receive_hex","a string signed by signtoos");
            //String result = client.toPay(param);


            Console.WriteLine(result);
            Console.ReadLine();
           
            
        }
    }
}
