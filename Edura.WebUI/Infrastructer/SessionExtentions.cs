using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edura.WebUI.Infrastructer
{
    public static class SessionExtentions
    {
        //session daki verilerin json formatında gönderilebilmesi için tanımlandı
        public static void SetJson(this ISession session,string key,object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetJson<T>(this ISession session,string key)
        {
            var data = session.GetString(key);

            return data == null ?
                default(T) : JsonConvert.DeserializeObject<T>(data);
        }
    }
}
