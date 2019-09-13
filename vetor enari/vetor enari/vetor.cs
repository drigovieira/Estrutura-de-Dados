using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetor_enari
{

    class vetor
    {

        private usuarios[] pessoas = new usuarios[3];

        public bool addUser(int index, usuarios us)
        {
            
            pessoas[index] = us;

            return true;
        }

        public string verUser(int index)
        {
            string txt = String.Format("\nNome: {0} , Email: {1} , Senha: {2} , CPF: {3}", pessoas[index].getNome(), pessoas[index].getEmail(), pessoas[index].getSenha(), pessoas[index].getCpf());
            return txt;
        }

        public void delUser(int index)
        {
            pessoas[index].setAtivo(false);

        }

        public void editUser(int index)
        {
            int e;
            string nnome, nemail, nsenha;
            long ncpf;

            Console.WriteLine("qual atributo quer editar? [1]nome , [2]email, [3]senha, [4]cpf ");
            e = int.Parse(Console.ReadLine());
            if (e == 1)
            {
                Console.Write("");
                nnome = Console.ReadLine();
                pessoas[index].setNome(nnome);
            }
            else if (e == 2)
            {
                Console.Write("");
                nemail = Console.ReadLine();
                pessoas[index].setEmail(nemail);
            }
            else if (e == 3)
            {
                Console.Write("");
                nsenha = Console.ReadLine();
                pessoas[index].setSenha(nsenha);
            }
            else if (e == 4)
            {
                Console.Write("");
                ncpf = (long.Parse(Console.ReadLine()));
                pessoas[index].setCpf(ncpf);
            }

            Console.WriteLine("---------------");
            Console.WriteLine("Editado");
            Console.WriteLine(this.verUser(index));
            Console.WriteLine("---------------");


        }




        public void listar()
        {
            foreach (var pessoa in pessoas)
            {
                if (pessoa.getAtivo())
                {
                    string txt = String.Format("\nNome: {0} , Email: {1} , Senha: {2} , CPF: {3}", pessoa.getNome(), pessoa.getEmail(), pessoa.getSenha(), pessoa.getCpf());
                    Console.WriteLine(txt);
                }
            }
        }
    }
}
