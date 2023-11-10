using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.Classes
{
    public class PessoaJuridica : Pessoa
    {
       public string? CNPJ {get;set;}

       public void Inserir(PessoaJuridica pj){

        using(StreamWriter batata = new StreamWriter(pj.Nome+".txt")){
            batata.WriteLine($"{pj.Nome};{pj.Rendimento};{pj.CNPJ}");

        }

       }


    }
}