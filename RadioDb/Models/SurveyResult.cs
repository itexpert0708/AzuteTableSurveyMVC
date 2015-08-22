using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Table;

namespace RadioDb.Models
{
    public class SurveyResult : TableEntity
    {
        public string Header { get; set; }

        public string ImageUrl { get; set; }

        public SurveyResult()
        {

        }
    }
}
