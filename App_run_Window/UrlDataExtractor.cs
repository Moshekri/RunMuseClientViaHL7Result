using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_run_Window
{
    public static class UrlDataExtractor
    {
        public static URLData GetData(string rawData, CultureInfo cInfo)
        {
            string PID = GetDataElement(rawData, "PatientID=");
            string testType = GetDataElement(rawData, "TestType=");
            string date = GetDataElement(rawData, "Date=");
            string time = GetDataElement(rawData, "Time=").Replace("%3a", ":");
            string site = GetDataElement(rawData, "Site=");
            if (PID==""||testType==""||date==""||time==""||site=="")
            {
                return null;
            }
            //format the time string to the correct one
            int index = time.LastIndexOf(':');
            string tempTime = time.Remove(index, 1);
            tempTime = tempTime.Insert(index, ".");

            DateTime parsedTime = DateTime.Parse(date + " " + tempTime, cInfo);
            string datetime = $"{parsedTime.Year.ToString("d2")}{parsedTime.Month.ToString("d2")}{parsedTime.Day.ToString("d2")}T{parsedTime.Hour.ToString("d2")}{parsedTime.Minute.ToString("d2")}{parsedTime.Second.ToString("d2")}{parsedTime.Millisecond.ToString("d2")}";


            return new URLData() { PID = PID, TestType = testType, Site = site, TestDateTime = datetime,ParesedDateTime= parsedTime};
        }
        private static string GetDataElement(string text, string whatToFind)
        {
            string data;
            if (text == null || text == "")
            {
                return "";
            }
            int start = text.IndexOf(whatToFind);
            if (start == -1)
            {
                return "";
            }
            start += whatToFind.Length;
            int finish = text.IndexOf(@"\T\", start);
            if (finish ==-1 && whatToFind == "Site=")
            {
                data = text.Substring(start); 
            }
            else
            {
                data = text.Substring(start, finish - start);
            }
             
            return data;
        }
    }

}


public class URLData
{
    public string PID { get; set; }
    public string Site { get; set; }
    public string TestType { get; set; }
    public string TestDateTime { get; set; }
    public DateTime ParesedDateTime { get; set; }
}