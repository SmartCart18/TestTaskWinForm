using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskWinForm
{
    internal class Document
    {
        public string UserName { get; set; }
        public string TypeDocument { get; set; }
        public int Quantity { get; set; }
        public string ReasonRequest { get; set; }
        public string StatusDocument { get; set; } = "Новый документ";

        public Document(string userName, string typeDocument, int quantity, string reasonRequest, string statusDocument)
        {
            UserName = userName;
            TypeDocument = typeDocument;
            Quantity = quantity;
            ReasonRequest = reasonRequest;
            StatusDocument = statusDocument;
        }
    }
}
