using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeService.Helpers
{
    public class MethodsHttpIntrodoction
    {
        /*
         * ---------------------------------------------------------------------------------
         *  INTRODUÇÃO AOS VERBOS HTTP E AS BOAS PRÁTICAS DE UMA API RESTFULL
         * ----------------------------------------------------------------------------------
         * 
            Pontos a serem lembrados ao trabalhar com o método de postagem da API da Web:
            1- Se um tipo de retorno de método for nulo na Web API, por padrão, 
            a API Service retornará o código de status 204 No Content.

            2- Quando um novo item é criado, devemos retornar o código de status 201 Item Created.
            Com o código de status 201, também devemos incluir o local, ou seja, URI do item recém-criado.
        
            3- Quando um item não for encontrado, em vez de retornar NULL e o código de status 200 OK, 
            retorne o código de status 404 Not Found juntamente com uma mensagem significativa como “ 
            Funcionário com ID = 15 não encontrado ”
         
         
         */
    }
}