using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace EquipmentInventoryModel
{
    [ScaffoldTable(true)]
    [MetadataType(typeof(TypesMetaData))]

    /// <summary>
    /// Summary description for EquipmentType
    /// </summary>
    public partial class EquipmentType
    {
        public EquipmentType()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }

    public partial class TypesMetaData
    {
        [ScaffoldColumn(false)]
        public object Id { get; set; }

        [DisplayName("Type Of Equipment")]
        public object TypeName { get; set; }

        [DisplayName("Default Manufacturer")]
        public object DefaultManufacturer { get; set; }

        [DisplayName("Default Base Model")]
        public object DefaultBaseModel { get; set; }

        [DisplayName("Default Power Model")]
        public object DefaultPowerModel { get; set; }


        [DisplayName("Derfault Service Provider")]
        public object DefaultServiceProvider { get; set; }


    }
}