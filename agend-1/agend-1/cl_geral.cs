using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace agend_1
{
    public static class cl_geral
    {
        public static string versao = "v 1.0.0";

        //estrutura dos contatos
        public static List<contacts>LISTA_CONTACTS;

        public static void CriaLista()
        {
            string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string pasta_contatos = pasta_documentos + @"\pasta_contatos.txt";
            //criar lista
            LISTA_CONTACTS = new List<contacts>();

            if (File.Exists(pasta_contatos))
             {
                StreamReader pasta = new StreamReader(pasta_contatos, Encoding.Default);
                while (!pasta.EndOfStream)
                {
                    string name = pasta.ReadLine();

                    string number = pasta.ReadLine();

                    string ende = pasta.ReadLine();

                    contacts new_contact = new contacts();
                    new_contact.name = name;
                    new_contact.number = number;
                    new_contact.ende = ende;
                    LISTA_CONTACTS.Add(new_contact);
                }

                pasta.Dispose();
            }

        }

        public static void SalvarNovo(string _name, string _number, string _ender) 
        {
            /*salvar novo dado
            contacts novo = new contacts();
            novo.name = _name;
            novo.name = _number;
            LISTA_CONTACTS.Add(novo); */

            LISTA_CONTACTS.Add(new contacts() { name = _name, number = _number, ende= _ender });

            //atualizar lista
            SalvarPasta();

        }

        public static void SalvarPasta()
        {
            string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string pasta_contatos = pasta_documentos + @"\pasta_contatos.txt";

            StreamWriter lista = new StreamWriter(pasta_contatos, false, Encoding.Default);
            foreach(contacts contacts in LISTA_CONTACTS)
            {
                lista.WriteLine(contacts.name);
                lista.WriteLine(contacts.number);
                lista.WriteLine(contacts.ende);

            }
            lista.Dispose();
        }
    }

   
}
