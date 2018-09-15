using System;
using System.Collections.Generic;

namespace api
{
    public partial class Games
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Plataforma { get; set; }
        public string Imagem { get; set; }
    }
}
