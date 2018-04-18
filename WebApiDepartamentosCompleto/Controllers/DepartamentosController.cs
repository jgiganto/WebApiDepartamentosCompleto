using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiDepartamentosCompleto.Models;

namespace WebApiDepartamentosCompleto.Controllers
{
    public class DepartamentosController : ApiController
    {
        ModeloDepartamentos modelo;
        public DepartamentosController()
        {
            modelo = new ModeloDepartamentos();
        }
        // GET: api/Departamentos
        public List<DEPT> Get()
        {
            return modelo.GetDepartamentos();
        }

        // GET: api/Departamentos/5
        public DEPT Get(int id)
        {
            return modelo.BuscarDepartamento(id);
        }

        // POST: api/Departamentos
        // POST: api/Departamentos/11/NOMBRE/LOCALIDAD
        //void Post(int num, String nom, String loc)
        //INSERTAR DEPARTAMENTO
        public void Post(DEPT dept)
        {
            modelo.InsertarDepartamento(dept.DEPT_NO, dept.DNOMBRE
                , dept.LOC);        }


        // PUT: api/Departamentos/5
        //MODIFICAR DEPARTAMENTO
        public void Put(int id, DEPT dept)
        {
            modelo.ModificarDepartamento(id, dept.DNOMBRE
                , dept.LOC);
        }

        // DELETE: api/Departamentos/5
        public void Delete(int id)
        {
            modelo.BorrarDepartamento(id);
        }

    }
}
