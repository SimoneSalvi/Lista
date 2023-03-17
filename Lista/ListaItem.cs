using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    internal class ListaItem
    {
        public Item Inicio { get; set; }
        public Item Fim { get; set; }


        public ListaItem()
        {
            Inicio = null;
            Fim = null;
            Console.WriteLine("Lista criada com sucesso!!");
        }


        public void Insert(Item i)
        {
            if (IsEmpty())
            {
                Inicio = i;
                Fim = i;
            }
            else
            {
                if(i.Value <= Inicio.Value)
                {
                    InsertFirst(i);
                }
                else
                {
                    if(i.Value >= Fim.Value)
                    {
                        InsertLast(i);
                    }
                    else
                    {
                        InsertMiddle(i);
                    }
                }
            }
        }

        public void InsertLast(Item i)
        {
            Fim.Next = i;
            Fim = i;

        }

        public void InsertFirst(Item i)
        {
            i.Next = Inicio;
            Inicio = i;
        }

        public void InsertMiddle(Item i)
        {
            Item aux1;
            Item aux2;

            aux1 = Inicio;
            aux2 = Inicio.Next;



            while (i.Value > aux2.Value)
            {
                aux1 = aux2;
                aux2 = aux2.Next;
            }

            i.Next = aux1.Next;
            aux1.Next = i;
            aux2 = aux1.Next;

        }

        public void Pop(Item i)
        {
            if (IsEmpty())
            {
                Console.WriteLine("Impossivel remover, lista vazia!");
            }
            else
            {
                Item aux = Inicio;
                do
                {
                    if (i.Value == aux.Value)
                    {
                        Inicio.Next = aux.Next;
                    }
                    else
                    {
                        aux = aux.Next;
                    }
                } while (Inicio != aux.Next);
            }
        }

/*        public bool Find(Item f)
        {
            Item aux = Inicio;
            while (aux.Next != null)
            {
                if (aux.Value == f.Value)
                {
                    return true;
                }
                else
                {
                    aux = aux.Next;
                }
                return false;
            }
        }
*/

        public bool IsEmpty()
        {
            if(Inicio == null && Fim == null) return true; else return false;
        }


        public void Print()
        {
            Item aux;

            if (IsEmpty())
            {
                Console.WriteLine("Lista vazia!");
                return;
            }
            else
            {
                aux = Inicio;
                Console.WriteLine("\n Os elementos da lista são: \n");

                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Next;
                } while (aux != null);
                Console.WriteLine("Final da Lista...");
            }
        }


    }
}
