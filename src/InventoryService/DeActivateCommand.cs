using System;
using System.Runtime.Serialization;

namespace InventroyService
{
    [DataContract]
    public class DeActivateCommand
    {
        [DataMember]
        public Guid ProductId { get; set; }
    }
}