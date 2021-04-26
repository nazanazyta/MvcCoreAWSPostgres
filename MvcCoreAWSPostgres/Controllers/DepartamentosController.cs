using Microsoft.AspNetCore.Mvc;
using MvcCoreAWSPostgres.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreAWSPostgres.Controllers
{
    public class DepartamentosController: Controller
    {
        RepositoryDepartamentos Repo;

        public DepartamentosController(RepositoryDepartamentos repo)
        {
            this.Repo = repo;
        }

        public IActionResult Index()
        {
            return View(this.Repo.GetDepartamentos());
        }

        public IActionResult Details(int id)
        {
            return View(this.Repo.FindDepartamento(id));
        }
    }
}
