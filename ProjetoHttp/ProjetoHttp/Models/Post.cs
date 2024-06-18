using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploHTTP.models
{
    public class Post
    {
        //Botão direito, Quick Action...
        public int userId { get; set; }
        private int id;
        public int Id { get => id; set => id = value; }

        //Escrever 

        public int title { get; set; }
        public string body { get; set; }
        //userId
        //id
        //title
    }
}