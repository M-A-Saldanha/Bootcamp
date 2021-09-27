using System;

namespace AgenciaBancariaDominio
{
    public static class Validacoes
    {
         public static string ValidarStringVazia (this string texto) 
        {
           return string.IsNullOrWhiteSpace(texto) ?
                        throw new Exception("Propriedade deve estar preenchida")
                        : texto;
        }
    }
}