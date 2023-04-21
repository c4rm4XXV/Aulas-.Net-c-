using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/*Por convenção nomes de Class sempre começão com letra Maiuscula caso de nome composto segue o mesmo sentido */

namespace Projeto_.Net_C_.Models
{
    /*para identificar uma classe usamos a palafra dedicada class*/
    public class PessoaFisica
    {
        /*para facilitar representamos no codigo apenas o necessario para definir uma pessoa*/
        //public string Nome { get; set; }
        /*as funções get e set servem para retornar e atribuir respstivamento ao/o atributo */
        public int Idade { get; set; }
        /*() serve para indicar uma ação caracteritico de uma função/metodo*/
        public void Apresentar()
        /*por conveção de index as chaves de uma função ou classe fica na linha seguinte*/
        {
            /*na estrutura do Writeline quando colocamos uma {} com o nome de um atributo da classe automaticamento o valor deste adriburto é chamado*/
           // Console.WriteLine($"Olá, meu Nome e{Nome}, e tenho {Idade} anos");
        }

    }
}