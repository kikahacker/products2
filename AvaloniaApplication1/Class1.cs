using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplication1
{
    public class Tovars
    {
        public string name { get; set; }
        public double price { get; set; }
        public int kolichestvo { get; set; }
        public string discr { get; set; }


        public override string ToString()
        {
            return $"{name} ({kolichestvo}шт) - {price}:rub за шт Описание: {discr}";
        }
    }
    public class listTovars
    {
        public static listTovars? asd;
        public List<Tovars> listik = new List<Tovars>();
        public listTovars()
        {
        }
        public void add(Tovars a)
        {
            listik.Add(a);
        }
        public static listTovars asdasd
        {
            get
            {
                if (asd == null)
                {
                    asd = new listTovars();
                }
                return asd;
            }
        }
    }
}
