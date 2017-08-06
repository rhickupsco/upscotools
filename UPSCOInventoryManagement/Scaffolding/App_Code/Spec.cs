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
    [MetadataType(typeof(SpecsMetaData))]
    public partial class Spec
    {
        public Spec()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
    public partial class SpecsMetaData
    {
        [ScaffoldColumn(false)]
        public object Id { get; set; }

        //[DisplayName("Specs For Tag")]
        //public object MasterListId { get; set; }

        [DisplayName("Type of RAM")]
        public object RAMType { get; set; }

        [DisplayName("GIGS of RAM")]
        public object RAMAmount { get; set; }

        [DisplayName("Operating System")]
        [DefaultValue("Windows 10 Pro 64")]
        public object OperatingSystem { get; set; }

        [DisplayName("Hard Drive Type")]
        public object HardDriveType { get; set; }

        [DisplayName("Case Type")]
        public object FormFactor { get; set; }

        [DisplayName("Hard Drive Capacity")]
        public object HardDriveSize { get; set; }

        [DisplayName("RAID")]
        [DefaultValue("none")]
        public object RaidConfiguration { get; set; }
    }
}