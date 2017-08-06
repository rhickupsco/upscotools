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
    [MetadataType(typeof(MasterListMetaData))]
    public partial class MasterList
    {
        public MasterList()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }

   
    public partial class MasterListMetaData
    {
        [UIHint("DateCalendar")]
        public object DatePurchased { get; set; }

        [UIHint("DateCalendar")]
        public object WarrantyExpiration { get; set; }

        [ScaffoldColumn(false)]
        public object Id { get; set; }
    }
}