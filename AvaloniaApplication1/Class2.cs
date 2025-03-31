using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplication1
{
    public class busket
    {
        public List<tovarsInBusket> list;
        public busket()
        {
            list = new List<tovarsInBusket>();
        }
        public void add(tovarsInBusket tovar) 
        {
            list.Add(tovar);

        }
        public void remove(tovarsInBusket tovar) 
        {
            list.Remove(tovar);
        }
    }
    public class tovarsInBusket
    {
        public string name { get; set; }
        public int kolvo {  get; set; }
        public double price { get; set; }
        public override string ToString()
        {
            return $"{name} ({kolvo}шт) - {price}:rub за шт";
        }
        public tovarsInBusket tovarInTovarInBusket(Tovars tovar, tovarsInBusket a)
        {
            a.name = tovar.name ;
            a.price = tovar.price ;
            return a;
        }
    }
    
}
