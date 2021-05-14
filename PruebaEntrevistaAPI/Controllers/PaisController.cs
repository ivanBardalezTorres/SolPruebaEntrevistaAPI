using System.Collections.Generic;
using System.Web.Http;
using PruebaEntrevistaAPI.Models;

namespace ServicioAPI.Pais.Controllers
{
    public class PaisController : ApiController
    {

        public IEnumerable<cPais> Get()
        {
            //Se llena la lista para el DEMO
            List<cPais> listPaises = new List<cPais>();
            listPaises.Add(new cPais { uctry_code = "CA", uctry_title = "Canada", uctry_cinfo_ctrl = "2", uctry_info_lvls = "0" });
            listPaises.Add(new cPais { uctry_code = "EC", uctry_title = "Ecuador", uctry_cinfo_ctrl = "2", uctry_info_lvls = "0" });
            listPaises.Add(new cPais { uctry_code = "GT", uctry_title = "Guatemala", uctry_cinfo_ctrl = "2", uctry_info_lvls = "0" });
            listPaises.Add(new cPais { uctry_code = "VE", uctry_title = "Venezuela", uctry_cinfo_ctrl = "2", uctry_info_lvls = "0" });
            listPaises.Add(new cPais { uctry_code = "IT", uctry_title = "Italy", uctry_cinfo_ctrl = "2", uctry_info_lvls = "0" });
           
            return listPaises;
        }

    }
}
