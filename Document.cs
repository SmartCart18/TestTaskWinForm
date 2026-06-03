using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskWinForm
{
    internal class Document
    {
        public string UserName
        {
            get => UserName; set { if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("ФИО не может быть пустым."); UserName = value; }
        }

        public string TypeDocument
        {
            get => TypeDocument; set { if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Выберите вид справки."); TypeDocument = value; }
        }

        public int Quantity { get; set; }

        public string ReasonRequest
        {
            get => ReasonRequest; set { if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Выберите вид справки."); ReasonRequest = value; }
        }

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
