using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiDepartamentosCompleto.Models
{
    public class ModeloDepartamentos
    {
        ContextoDepartamentos contexto;

        public ModeloDepartamentos()
        {
            this.contexto = new ContextoDepartamentos();
        }
        //GET()
        public List<DEPT> GetDepartamentos()
        {
            var consulta = from datos in contexto.DEPT
                           select datos;
            return consulta.ToList();
        }

        //GET(id)
        public DEPT BuscarDepartamento(int depno)
        {
            return contexto.DEPT.Find(depno);
        }
        //POST
        public void InsertarDepartamento(int num, String nom,String loc)
        {
            DEPT dep = new DEPT();
            dep.DEPT_NO = num;
            dep.DNOMBRE = nom;
            dep.LOC = loc;
            contexto.DEPT.Add(dep);
            contexto.SaveChanges();
        }
        //PUT()
        public void ModificarDepartamento(int num,String nom, String loc)
        {
            DEPT dep = this.BuscarDepartamento(num);
            dep.DNOMBRE = nom;
            dep.LOC = loc;
            contexto.SaveChanges();            
        }
        //DELETE()
        public void BorrarDepartamento(int num)
        {
            DEPT dep = this.BuscarDepartamento(num);
            contexto.DEPT.Remove(dep);
            contexto.SaveChanges();
        }

    }
}