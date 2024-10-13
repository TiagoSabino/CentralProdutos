using CentralProdutos.BaseDados.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CentralProdutos.BaseDados.Negocio
{
    public class UsuarioNegocio
    {
        private CentralProdutosDataContext context = new CentralProdutosDataContext();

        public USUARIO salvarUsuario(USUARIO obj)
        {
            try
            {
                if (obj.ID <= 0)
                {
                    context.Usuario.Add(obj);
                }
                else
                {
                    USUARIO objAux = (from c in context.Usuario
                                      where c.ID == obj.ID
                                      select c).FirstOrDefault();

                    objAux = obj;
                }

                context.SaveChanges();

                return obj;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public USUARIO listarUsuario(string login, string senha)
        {
            try
            {
                USUARIO objAux = (from c in context.Usuario
                                  where c.LOGIN == login
                                  select c).FirstOrDefault();

                return objAux;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}