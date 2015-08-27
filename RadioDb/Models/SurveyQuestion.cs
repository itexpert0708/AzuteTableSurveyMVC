using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Table;

namespace RadioDb.Models
{
    public class SurveyQuestion : TableEntity
    {
        public static string TableName
        {
            get { return "SurveyQuetion"; }
        }

        public enum QuestionTypes
        {
            Main,
            Object,
            Subject,
            CheckBox,
        }

        public int Index { get; set; }

        public string Header { get; set; }
        public string Description { get; set; }

        public string QuestionTypeStr { get; set; }
        public QuestionTypes QuestionType
        {
            get
            {
                var typeData = (QuestionTypes)Enum.Parse(typeof(QuestionTypes), QuestionTypeStr);
                return typeData;
            }
            set { QuestionTypeStr = value.ToString(); }
        }

        public IEnumerable<string> ObjectAnswers()
        {
            if (ObjectAnswer1 == null) yield break; yield return ObjectAnswer1;
            if (ObjectAnswer2 == null) yield break; yield return ObjectAnswer2;
            if (ObjectAnswer3 == null) yield break; yield return ObjectAnswer3;
            if (ObjectAnswer4 == null) yield break; yield return ObjectAnswer4;
            if (ObjectAnswer5 == null) yield break; yield return ObjectAnswer5;
            if (ObjectAnswer6 == null) yield break; yield return ObjectAnswer6;
            if (ObjectAnswer7 == null) yield break; yield return ObjectAnswer7;
            if (ObjectAnswer8 == null) yield break; yield return ObjectAnswer8;
            if (ObjectAnswer9 == null) yield break; yield return ObjectAnswer9;
            if (ObjectAnswer10 == null) yield break; yield return ObjectAnswer10;
            if (ObjectAnswer11 == null) yield break; yield return ObjectAnswer11;
            if (ObjectAnswer12 == null) yield break; yield return ObjectAnswer12;
            if (ObjectAnswer13 == null) yield break; yield return ObjectAnswer13;
            if (ObjectAnswer14 == null) yield break; yield return ObjectAnswer14;
            if (ObjectAnswer15 == null) yield break; yield return ObjectAnswer15;
            if (ObjectAnswer16 == null) yield break; yield return ObjectAnswer16;
            if (ObjectAnswer17 == null) yield break; yield return ObjectAnswer17;
            if (ObjectAnswer18 == null) yield break; yield return ObjectAnswer18;
            if (ObjectAnswer19 == null) yield break; yield return ObjectAnswer19;
            if (ObjectAnswer20 == null) yield break; yield return ObjectAnswer20;
        }

        public string ObjectAnswer1 { get; set; }
        public string ObjectAnswer2 { get; set; }
        public string ObjectAnswer3 { get; set; }
        public string ObjectAnswer4 { get; set; }
        public string ObjectAnswer5 { get; set; }
        public string ObjectAnswer6 { get; set; }
        public string ObjectAnswer7 { get; set; }
        public string ObjectAnswer8 { get; set; }
        public string ObjectAnswer9 { get; set; }
        public string ObjectAnswer10 { get; set; }
        public string ObjectAnswer11 { get; set; }
        public string ObjectAnswer12 { get; set; }
        public string ObjectAnswer13 { get; set; }
        public string ObjectAnswer14 { get; set; }
        public string ObjectAnswer15 { get; set; }
        public string ObjectAnswer16 { get; set; }
        public string ObjectAnswer17 { get; set; }
        public string ObjectAnswer18 { get; set; }
        public string ObjectAnswer19 { get; set; }
        public string ObjectAnswer20 { get; set; }

        public IEnumerable<string> CheckBoxAnswers()
        {
            if (CheckBoxAnswer1 == null)
                yield break;
            yield return CheckBoxAnswer1;
            if (CheckBoxAnswer2 == null)
                yield break;
            yield return CheckBoxAnswer2;
            if (CheckBoxAnswer3 == null)
                yield break;
            yield return CheckBoxAnswer3;
            if (CheckBoxAnswer4 == null)
                yield break;
            yield return CheckBoxAnswer4;
            if (CheckBoxAnswer5 == null)
                yield break;
            yield return CheckBoxAnswer5;
            if (CheckBoxAnswer6 == null)
                yield break;
            yield return CheckBoxAnswer6;
            if (CheckBoxAnswer7 == null)
                yield break;
            yield return CheckBoxAnswer7;
            if (CheckBoxAnswer8 == null)
                yield break;
            yield return CheckBoxAnswer8;
            if (CheckBoxAnswer9 == null)
                yield break;
            yield return CheckBoxAnswer9;
            if (CheckBoxAnswer10 == null)
                yield break;
            yield return CheckBoxAnswer10;
            if (CheckBoxAnswer11 == null)
                yield break;
            yield return CheckBoxAnswer11;
            if (CheckBoxAnswer12 == null)
                yield break;
            yield return CheckBoxAnswer12;
            if (CheckBoxAnswer3 == null)
                yield break;
            yield return CheckBoxAnswer13;
            if (CheckBoxAnswer14 == null)
                yield break;
            yield return CheckBoxAnswer14;
            if (CheckBoxAnswer15 == null)
                yield break;
            yield return CheckBoxAnswer15;
            if (CheckBoxAnswer16 == null)
                yield break;
            yield return CheckBoxAnswer16;
            if (CheckBoxAnswer17 == null)
                yield break;
            yield return CheckBoxAnswer17;
            if (CheckBoxAnswer18 == null)
                yield break;
            yield return CheckBoxAnswer18;
            if (CheckBoxAnswer19 == null)
                yield break;
            yield return CheckBoxAnswer19;
            if (CheckBoxAnswer20 == null)
                yield break;
            yield return CheckBoxAnswer20;
        }

        public string CheckBoxAnswer1 { get; set; }
        public string CheckBoxAnswer2 { get; set; }
        public string CheckBoxAnswer3 { get; set; }
        public string CheckBoxAnswer4 { get; set; }
        public string CheckBoxAnswer5 { get; set; }
        public string CheckBoxAnswer6 { get; set; }
        public string CheckBoxAnswer7 { get; set; }
        public string CheckBoxAnswer8 { get; set; }
        public string CheckBoxAnswer9 { get; set; }
        public string CheckBoxAnswer10 { get; set; }
        public string CheckBoxAnswer11 { get; set; }
        public string CheckBoxAnswer12 { get; set; }
        public string CheckBoxAnswer13 { get; set; }
        public string CheckBoxAnswer14 { get; set; }
        public string CheckBoxAnswer15 { get; set; }
        public string CheckBoxAnswer16 { get; set; }
        public string CheckBoxAnswer17 { get; set; }
        public string CheckBoxAnswer18 { get; set; }
        public string CheckBoxAnswer19 { get; set; }
        public string CheckBoxAnswer20 { get; set; }

        public SurveyQuestion()
        {

        }


    }
}
