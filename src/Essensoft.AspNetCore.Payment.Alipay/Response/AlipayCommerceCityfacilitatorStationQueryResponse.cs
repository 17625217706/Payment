using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceCityfacilitatorStationQueryResponse.
    /// </summary>
    public class AlipayCommerceCityfacilitatorStationQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支持设为起点的站点列表
        /// </summary>
        [JsonProperty("support_starts")]
        [XmlArray("support_starts")]
        [XmlArrayItem("station_detail_info")]
        public List<StationDetailInfo> SupportStarts { get; set; }
    }
}
