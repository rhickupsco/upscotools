using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

/// <summary>
/// Summary description for MasterList
/// </summary>
namespace EquipmentInventoryModel
{
    [ScaffoldTable(true)]
    [MetadataType(typeof(SoftwareListMetaData))]

    /// <summary>
    /// Summary description for Software
    /// </summary>
    public partial class Software
    {
        public Software()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }

    public partial class SoftwareListMetaData
    {
        [ScaffoldColumn(false)]
        public object Id { get; set; }

        [UIHint("DateCalendar")]
        [DisplayName("License Expiration")]
        public object LicenseExpiration { get; set; }



    }
}