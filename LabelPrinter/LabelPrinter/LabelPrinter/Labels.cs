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

        public int variableCount { get; set; }

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
        }

        public void LoadTemplateInfo(string LabelName) {
            DataTable dt;

            SQLDataAccess da = new SQLDataAccess();
            dt = da.GetAllDataFromQuery("Select * from Templates where TemplateName = @parameter", LabelName);

            if (dt.Rows.Count == 1) {
                labelType = dt.Rows[0]["TemplateType"].ToString();
                labelQuery = dt.Rows[0]["TemplateQuery"].ToString();
                labelName = dt.Rows[0]["TemplateName"].ToString();
                string longstring = dt.Rows[0]["TemplateVariablesCSV"].ToString();
                variables = longstring.Split(',');
                variableCount = variables.Count();
            }
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


    }




}
