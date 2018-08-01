using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace walle.component.json
{
    public class JsonUtilsEx
    {
        #region toStr

        public static String toStr(Object oObj)
        {
            String strRes = JsonConvert.SerializeObject(oObj);
            return strRes;
        }

        #endregion

        #region toObj

        #endregion
    }
}
