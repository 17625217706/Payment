using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiItemExtitemInfoDeleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiItemExtitemInfoDeleteModel : AlipayObject
    {
        /// <summary>
        /// 商品编码
        /// </summary>
        [JsonProperty("goods_id")]
        [XmlElement("goods_id")]
        public string GoodsId { get; set; }
    }
}
