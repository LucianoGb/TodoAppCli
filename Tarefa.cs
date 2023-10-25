using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoAppCli
{
    internal class Tarefa
    {
        public List<string> Descricao { get; set; } = new List<string>() ;

       
        public void AdicionarTarefa( string descricao)
        {
            Descricao.Add(descricao);
        }

        



    }
}
