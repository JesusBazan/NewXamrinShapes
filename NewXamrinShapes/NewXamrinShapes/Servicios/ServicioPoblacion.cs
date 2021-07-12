using System;
using System.Collections.Generic;
using System.Text;

using NewXamrinShapes.Clases;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace NewXamrinShapes.Servicios
{
    static class ServicioPoblacion
    {
        public static async Task<ObjetoPoblacion[]> ConsultarClima()
        {
            ObjetoPoblacion[] arrPoblacion = new ObjetoPoblacion[6];
            var conexion = $"https://datausa.io/api/data?drilldowns=Nation&measures=Population";
            using (var cliente = new HttpClient())
            {
                var peticion = await cliente.GetAsync(conexion);//peticion URL
                
                if (peticion != null)
                {
                    var json = peticion.Content.ReadAsStringAsync().Result;
                    //   var json = await peticion.Content.ReadAsStringAsync();

                    var datos = (JContainer)JsonConvert.DeserializeObject(json);

                    if (datos != null)
                    {
                        //protected List<string> list = new List<string>();
                        
                        for (int i = 0; i < 6; i++)
                        {
                            arrPoblacion[i] = new ObjetoPoblacion();
                            arrPoblacion[i].Year = (string)datos["data"][i]["Year"];
                            string str = (string)datos["data"][i]["Population"];
                            arrPoblacion[i].Population = str.Substring(0, 3) + " Millones";
                            int num = (int)datos["data"][i]["Population"];
                            arrPoblacion[i].PopulationNum = (num / 30000000)+(i*2);
                        }
                        return arrPoblacion;
                    }

                }
            }
            return default(ObjetoPoblacion[]);
        }
    }
}
