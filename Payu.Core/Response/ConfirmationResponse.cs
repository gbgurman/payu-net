﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Payu.Core.Response
{
    [XmlRoot("EPAYMENT")]
    public class ConfirmationResponse
    {
        public string ORDER_REF { get; set; }
        public string RESPONSE_CODE { get; set; }
        public string RESPONSE_MSG { get; set; }
        public string IDN_DATE { get; set; }
        public string ORDER_HASH { get; set; }
    }
}
