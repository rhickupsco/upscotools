using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LabelPrinter.Data_Access;

namespace LabelPrinter
{
    public class Labels
    {

        private string labelType { get; set; }
        private string labelName { get; set; }
        private string labelQuery { get; set; }
        private string[] variables { get; set; }
        private string templateLocation { get; set; }
        private string[] additionalUserInput { get; set; }
        public int variableCount { get; set; }
        public int userFormVarsCount { get; set; }

        public static readonly Labels SelectedLabel = new Labels();

        public Labels() {
            labelType = string.Empty;
            labelQuery = string.Empty;
            labelName = string.Empty;
            variables = new string[] {
            string.Empty,
            string.Empty,
            string.Empty,
            string.Empty,
            string.Empty,
            string.Empty,
            string.Empty,
            string.Empty,
            string.Empty,
            string.Empty,
            string.Empty,
            string.Empty
            };
            templateLocation = string.Empty;
            additionalUserInput = new string[] {
            "none",
            "none",
            "none",
            "none",
            "none"
            };
        }

        public void LoadTemplateInfo(string LabelName) {
            DataTable dt;

            SQLDataAccess da = new SQLDataAccess();
            dt = da.GetAllDataFromQuery("Select * from Templates where TemplateName = @parameter", LabelName);

            if (dt.Rows.Count == 1) {
                labelType = dt.Rows[0]["TemplateType"].ToString();
                labelQuery = dt.Rows[0]["TemplateQuery"].ToString();
                labelName = dt.Rows[0]["TemplateName"].ToString();

                //this looks for additional userform variables
                string userFormInput = dt.Rows[0]["AdditionalUserFormInfo"].ToString();
                additionalUserInput = userFormInput.Split(',');
                userFormVarsCount = CountNotNone();

                //this looks at the variables needed for database query
                string longstring = dt.Rows[0]["TemplateVariablesCSV"].ToString();
                variables = longstring.Split(',');
                variableCount = variables.Count();
            }
        }

        private int CountNotNone()
        {
           int validCount = 0;

           //this only counts the userForm Variables that are not "none", which is the default value in the table for that field
           foreach(string var in additionalUserInput) {
           if (var != "none")
                validCount += 1;
           }
            return validCount;
        }

        public string GetLabelName() {
            return labelName;
        }

        public string GetTemplateLocation() {
            return templateLocation;
        }

 
        public void SetTemplateLocation(string location) {
            templateLocation = location;
        }

        public string GetQuery() {
            return labelQuery;
        }
        
        public string GetVariableValue(int variableIndex) {

            return variables[variableIndex];
        }

        public string GetLabelType() {
        return labelType;
        }

        public string GetUserVariableValue(int variableIndex) {
            return additionalUserInput[variableIndex];
        }

        public bool IsUsed(string v)
        {
            bool isUsed = false;
            if(additionalUserInput.Contains(v)) {isUsed = true; }
            return isUsed;
        }
    }




}
