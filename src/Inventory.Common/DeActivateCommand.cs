using System;
using System.Runtime.Serialization;

namespace Inventory.Common
{
    [DataContract]
    public class DeActivateCommand
    {
        [DataMember]
        public Guid ProductId { get; set; }
    }
}