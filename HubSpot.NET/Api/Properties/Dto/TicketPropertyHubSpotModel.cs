using System;
using System.Collections.Generic;
using System.Text;
using HubSpot.NET.Core.Interfaces;
using System.Runtime.Serialization;

namespace HubSpot.NET.Api.Properties.Dto
{
    public class TicketPropertyHubSpotModel : IHubSpotModel
    {
        [DataMember(Name = "hs_lastmodifieddate")]
        public DateTime hs_lastmodifieddate { get; set; }

        [DataMember(Name = "hs_pipeline")]
        public string hs_pipeline { get; set; }

        [DataMember(Name = "hs_pipeline_stage")]
        public string hs_pipeline_stage { get; set; }

        [DataMember(Name = "hs_ticket_priority")]
        public string hs_ticket_priority { get; set; }

        [DataMember(Name = "hubspot_owner_id")]
        public string hubspot_owner_id { get; set; }

        [DataMember(Name = "subject")]
        public string subject { get; set; }

        public bool IsNameValue => false;

    }
}
