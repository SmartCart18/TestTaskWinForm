using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TestTaskWinForm
{
    internal class Document
    {
        public string UserName { get; set; }
        public string TypeDocument { get; set; }
        public int Quantity { get; set; }
        public string ReasonRequest { get; set; }
        public string StatusDocument { get; set; } = "Новый документ";

        public Document() { }
        public Document(string userName, string typeDocument, int quantity, string reasonRequest, string statusDocument)
        {
            UserName = userName;
            TypeDocument = typeDocument;
            Quantity = quantity;
            ReasonRequest = reasonRequest;
            StatusDocument = statusDocument;
        }
        public string GetDocument()
        {
            string textToAppend = UserName + ";" + TypeDocument + ";" + Quantity + ";" + ReasonRequest + ";" + StatusDocument + Environment.NewLine;
            return textToAppend;
        }
        public void SetDocument(string userName, string typeDocument, int quantity, string reasonRequest, string statusDocument)
        {
            UserName = userName;
            TypeDocument = typeDocument;
            Quantity= quantity;
            ReasonRequest = reasonRequest;
            StatusDocument = statusDocument;
        }

        public string ForСompareDocument() {
            string textToСompare = UserName + ";" + TypeDocument;
            return textToСompare;
        }

       
    }
}
