using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.oklink.client
{
    /// </summary>
    interface IOKLinkClient
    {
        String ticker(Dictionary<string, Object> param);

	    String getCountryList();

        String getDetailInfo(Dictionary<string, Object> param);


        String createRemittance(Dictionary<string, Object> param);
        String getRemitInfo(Dictionary<string, Object> param);

        String getPayInfo(Dictionary<string, Object> param);
        String toPay(Dictionary<string, Object> param);

        String getRemitList(Dictionary<string, Object> param);
        String accept(Dictionary<string, Object> param);
        String getRejectInfo(Dictionary<string, Object> param);
        String reject(Dictionary<string, Object> param);

        String getReFundInfo(Dictionary<string, Object> param);
        String refund(Dictionary<string, Object> param);

        String getReciveInfo(Dictionary<string, Object> param);
        String appealReceive(Dictionary<string, Object > param);
	    String getUserInfo();
	
  
    }
}
