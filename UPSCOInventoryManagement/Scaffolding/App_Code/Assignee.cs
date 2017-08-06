using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace EquipmentInventoryModel
{ 
    [ScaffoldTable(true)]
    [MetadataType(typeof(AssigneeMetaData))]
    [MultiColumnSearch("FirstName", "LastName")]
    public partial class Assignee
        {
            public Assignee()
            { 
           
            }
        internal sealed class AssigneeMetadata { }
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class MultiColumnSearchAttribute : Attribute
    {
        public String[] Columns { get; private set; }

        public MultiColumnSearchAttribute(params String[] columns)
        {
            Columns = columns;
        }
    }

    [MetadataType(typeof(AssigneeMetaData))]
    public partial class AssigneeMetaData
    {
       
        [ScaffoldColumn(false)]
        public object Id { get; set; }

        [DisplayName("Date of Hire")]
        [UIHint("DateCalendar")]
        public object StartDate { get; set; }

        [ScaffoldColumn(false)]
        [DisplayName("Last Date Worked")]
        [UIHint("DateCalendar")]
        public object EndDate { get; set; }

        [DisplayName("Phone Extension")]
        [UIHint("PhoneNumber")]
        public object PhoneExtension { get; set; }

        [DisplayName("Windows User Name")]
        [UIHint("PeoplePicker")]
        public object UserName { get; set; }
        
        [DisplayName("Email Address")]      
        public object EmailAddress { get; set; }

        [DisplayName("First Name")]
        public object FirstName { get; set; }

        [DisplayName("Last Name")]   
        public object LastName { get; set; }

        [DisplayName("Job Title")]
        public object JobTitle { get; set; }

        [DisplayName("Active")]
        [DefaultValue(true)]
        public object IsActive { get; set; }

        [DisplayName("Inside Or Out")]
        [DefaultValue("I")]
        public object InsideOrOutside { get; set; }

        [DisplayName("Office Location")]
        public object OfficeLocation { get; set; }

        [DisplayName("Cell Phone")]
        public object CellPhone { get; set; }
    }

  



}
