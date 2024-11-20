using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WinFormsApp5.Form1;

namespace WinFormsApp5
{
    internal class Grafs
    {
        List<NodeG> nodes = new List<NodeG>();

        public void dodajSomsiada(NodeG somsiad)
        {
            if (!this.nodes.Contains(somsiad))
            {
                this.nodes.Add(somsiad);
            }
        }
        public void przechodzenie(NodeG somsiad)
        {
            for (int i = 0; i < this.nodes.Count; i++)
            {
                NodeG node = this.nodes[i];

            }
        }

    }
}

