using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_3
{
    public partial class Class
    {
        struct Article
        {
            public int id;
            public string title;
            public int price;

            public ArticleType Type;
            public Article(int id, string title, int price, ArticleType type)
            {
                this.id = id;   
                this.title = title;                
                this.price = price;
                this.Type = type;

            }
        }
        public enum ArticleType
        {
            Type1,
            Type2,
            Type3
        }

        struct Client
        {
            public ClientType Type2;
            
            public int id;             // код клиента
            public string fio;         // ФИО клиента
            public string adress;      // адрес
            public int number;         // телефон 
            public int counter_price;  // кол-во заказов
            public double total_price; // общая сумма

            public Client(int id, string fio, ClientType type)
            {
                this.id = id;
                this.fio = fio;
                this.Type2 = type;
            }
        }
        public enum ClientType
        {
            VIP,
            Medium,
            Low
        }


        private int _num;
        public int Num { get { return _num; } set { _num = value; } }

        public string Asd2 { get;set; }

        public void Der(int num = 12, params int[] cow) 
        {
            Article article1 = new Article(1, "Товар 1",100, ArticleType.Type1);
        }

        public void Der2(int num = 12, params int[] cow)
        {
            Client client1 = new Client(1, "Товар 1", ClientType.VIP);
        }
    }
}
