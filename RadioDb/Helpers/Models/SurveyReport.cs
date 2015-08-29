using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Table;

namespace RadioDb.Models
{
    /// <summary>
    /// 사용자가 입력한 설문 결과를 저장하는 클래스입니다.
    /// </summary>
    public class SurveyReport : TableEntity
    {
        public string Report1 { get; set; }
        public string Report2 { get; set; }
        public string Report3 { get; set; }
        public string Report4 { get; set; }
        public string Report5 { get; set; }
        public string Report6 { get; set; }
        public string Report7 { get; set; }
        public string Report8 { get; set; }
        public string Report9 { get; set; }
        public string Report10 { get; set; }

        public SurveyReport()
        {
            
        }
    }
}
