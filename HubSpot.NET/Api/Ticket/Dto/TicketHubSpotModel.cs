using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using HubSpot.NET.Core.Interfaces;

namespace HubSpot.NET.Api.Ticket.Dto
{

    /// <summary>
    /// Models the associations of a deal to companies & contacts
    /// </summary>
    [DataContract]
    public class TicketHubSpotAssociations
    {
        [DataMember(Name = "associatedCompanyIds")]
        public long[] AssociatedCompany { get; set; }

        [DataMember(Name = "associatedVids")]
        public long[] AssociatedContacts { get; set; }
    }

    /// <summary>
    /// Models a Ticket entity within HubSpot. Default properties are included here
    /// with the intention that you'd extend this class with properties specific to 
    /// your HubSpot account.
    /// </summary>
    [DataContract]
    public class TicketHubSpotModel : IHubSpotSerializable<TicketHubSpotModel>
    {
        public TicketHubSpotModel()
        {

        }

        [DataMember(Name = "archived")]
        public bool archived { get; set; }
        public string id { get; set; }
        public bool IsNameValue => true;

        [IgnoreDataMember]
        public TicketHubSpotAssociations Associations { get; set; }

        public virtual void ToHubSpotDataEntity(ref TicketHubSpotModel converted)
        {
            converted.Associations = Associations;
        }

        public virtual void FromHubSpotDataEntity(TicketHubSpotModel hubspotData)
        {
            if (hubspotData.Associations != null)
            {
                Associations.AssociatedContacts = hubspotData.Associations.AssociatedContacts;
                Associations.AssociatedCompany = hubspotData.Associations.AssociatedCompany;
            }
        }
    }
}
