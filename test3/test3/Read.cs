using DocumentFormat.OpenXml.Packaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3
{
    class Read
    {
        //国考_原题
        public string[] readList()
        {
            string fileName = @"F:\Workplace\CSharp\test3\国考_原题.docx";
            using (WordprocessingDocument wordprocessingDocument =
                WordprocessingDocument.Open(fileName, false))
            {
                // Create a Body object.
                DocumentFormat.OpenXml.Wordprocessing.Body body =
                    wordprocessingDocument.MainDocumentPart.Document.Body;

                List<string> list = new List<string>();
                foreach (var g in body.Elements())
                {
                    list.Add(g.InnerText);
                }
                //初始化一个字符数组
                char[] reArray = new char[list.Count];
                //将list转化为字符串数组
                string[] str = list.ToArray();
                //调用函数转化为字符数组
                Replacement RE = new Replacement();
                reArray = RE.replacementRE(str, list.Count);
                //再转换为string类型
                string[] s = new string[reArray.Length];
                //调用函数replacementStr
                s = RE.replacementStr(reArray);
                return s;

            }
        }
        //国考_标准答案1
        public string[] readList1()
        {
            string fileName = @"F:\test3\国考_标准答案1.docx";

            using (WordprocessingDocument wordprocessingDocument =
                WordprocessingDocument.Open(fileName, false))
            {
                // Create a Body object.
                DocumentFormat.OpenXml.Wordprocessing.Body body =
                    wordprocessingDocument.MainDocumentPart.Document.Body;

                List<string> list1 = new List<string>();
                foreach (var g in body.Elements())
                {
                    list1.Add(g.InnerText);
                }
                //初始化一个字符数组
                char[] reArray = new char[list1.Count];
                //将list转化为字符串数组
                string[] str = list1.ToArray();
                //调用函数转化为字符数组
                Replacement RE = new Replacement();
                reArray = RE.replacementRE(str, list1.Count);
                //再转换为string类型
                string[] s = new string[reArray.Length];
                //调用函数replacementStr
                s = RE.replacementStr(reArray);
                return s;
            }
        }
        //国考_标准答案2
        public string[] readList2()
        {
            string fileName = @"F:\test3\国考_标准答案2.docx";
            using (WordprocessingDocument wordprocessingDocument =
                WordprocessingDocument.Open(fileName, false))
            {
                // Create a Body object.
                DocumentFormat.OpenXml.Wordprocessing.Body body =
                    wordprocessingDocument.MainDocumentPart.Document.Body;

                List<string> list2 = new List<string>();
                foreach (var g in body.Elements())
                {
                    list2.Add(g.InnerText);
                }
                //初始化一个字符数组
                char[] reArray = new char[list2.Count];
                //将list转化为字符串数组
                string[] str = list2.ToArray();
                //调用函数转化为字符数组
                Replacement RE = new Replacement();
                reArray = RE.replacementRE(str, list2.Count);
                //再转换为string类型
                string[] s = new string[reArray.Length];
                //调用函数replacementStr
                s = RE.replacementStr(reArray);
                return s;
            }
        }

        //国考_标准答案3
        public string[] readList3()
        {
            string fileName = @"F:\test3\国考_标准答案3.docx";
            using (WordprocessingDocument wordprocessingDocument =
                WordprocessingDocument.Open(fileName, false))
            {
                // Create a Body object.
                DocumentFormat.OpenXml.Wordprocessing.Body body =
                    wordprocessingDocument.MainDocumentPart.Document.Body;

                List<string> list3 = new List<string>();
                foreach (var g in body.Elements())
                {
                    list3.Add(g.InnerText);
                }
                //初始化一个字符数组
                char[] reArray = new char[list3.Count];
                //将list转化为字符串数组
                string[] str = list3.ToArray();
                //调用函数转化为字符数组
                Replacement RE = new Replacement();
                reArray = RE.replacementRE(str, list3.Count);
                //再转换为string类型
                string[] s = new string[reArray.Length];
                //调用函数replacementStr
                s = RE.replacementStr(reArray);
                return s;
            }
        }

        //国考_原题
        public string[] readList4()
        {
            string fileName = @"F:\test3\国考_原题.docx";
            using (WordprocessingDocument wordprocessingDocument =
                WordprocessingDocument.Open(fileName, false))
            {
                // Create a Body object.
                DocumentFormat.OpenXml.Wordprocessing.Body body =
                    wordprocessingDocument.MainDocumentPart.Document.Body;

                List<string> list4 = new List<string>();
                foreach (var g in body.Elements())
                {
                    list4.Add(g.InnerText);
                }
                //初始化一个字符数组
                char[] reArray = new char[list4.Count];
                //将list转化为字符串数组
                string[] str = list4.ToArray();
                //调用函数转化为字符数组
                Replacement RE = new Replacement();
                reArray = RE.replacementRE(str, list4.Count);
                //再转换为string类型
                string[] s = new string[reArray.Length];
                //调用函数replacementStr
                s = RE.replacementStr(reArray);
                return s;

            }
        }
    }
}
