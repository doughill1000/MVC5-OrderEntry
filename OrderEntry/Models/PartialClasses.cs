using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OrderEntry.Models
{
    [MetadataType(typeof(OrderMetadata))]
    public partial class Order { }

    [MetadataType(typeof(SeparationMetaData))]
    public partial class Separation { }
}