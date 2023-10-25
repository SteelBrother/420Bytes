using _420BytesProyect.BM.General.Interfaces;
using _420BytesProyect.DM;
using _420BytesProyect.DT.Planta;
using Microsoft.Extensions.Logging;
using _420BytesProyect.DT.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace _420BytesProyect.BM.General
{
    public class BMPlanta : IBMPlantas
    {
        private readonly IConexionBD conexionBD;
        private readonly ILogger<IBMPlantas> logger;

        public BMPlanta(IConexionBD conexionBD, ILogger<IBMPlantas> logger)
        {
            this.conexionBD = conexionBD;
            this.logger = logger;

        }


        public async Task<List<Planta>> ConsultarListaDePlantas()
        {
            try
            {
                var plantas = await conexionBD.QueryAsync<Planta>("Planta.SP_ConsultarListaDePlantas");
                return plantas.ToList();
            }
            catch (Exception ex)
            {
                logger.LogError($"Clase: {GetType().Name}, Metodo: {MethodBase.GetCurrentMethod()?.DeclaringType?.Name}, Tipo: {ex.GetType()}, Error: {ex.Message}");
                return new List<Planta>();
            }
        }
        public async Task<List<PlantaxUsuario>>ConsultarPlantasPorUsuario(int Cedula)
        {
            try
            {
                var plantas = await conexionBD.QueryAsync<PlantaxUsuario>("Planta.SP_ConsultarPlantasPorUsuario", new { Cedula });
                return plantas.ToList();
            }
            catch (Exception ex)
            {
                logger.LogError($"Clase: {GetType().Name}, Metodo: {MethodBase.GetCurrentMethod()?.DeclaringType?.Name}, Tipo: {ex.GetType()}, Error: {ex.Message}");
                return new List<PlantaxUsuario>();
            }
        }
    }
}
