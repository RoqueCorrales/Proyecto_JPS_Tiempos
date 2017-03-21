using DBAccess;
using ProyectoTiempos.Controladores;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTiempos.Utils
{
    public class Logica : ErrorHandler
    {
        private Sorteo sorteo;
        private SorteoPremiado sorPre;
       private  List<Modelo.Sorteo> lista;
        public Logica()
        {
            sorteo = new Sorteo();
            sorPre = new SorteoPremiado();
            lista = new List<Modelo.Sorteo>();
        }


        public List<string> cargarCombo()
        {
            DataTable result = new DataTable();
            
            result = this.sorteo.SelectCodigo();
            List<string> lista = new List<string>();
            if (this.sorteo.isError)
            {
                this.isError = true;
                this.errorDescription = this.sorteo.errorDescription;
            }
            for (int i = 0; i < result.Rows.Count; i++)
            {
              lista.Add(result.Rows[i]["codigo"].ToString());
            }


            return lista;
            }


        public int buscarID(string codigo)
        {
            int id_sorteo;
            DataTable result = new DataTable();
            result = this.sorteo.SelectCodigo(codigo);
            DataRow row = result.Rows[0];
            string id = row["id"].ToString();
            id_sorteo = Convert.ToInt32(id);
            return id_sorteo;
        }


        public Boolean existeSorteo(string codigo)
        {
            DataTable sor = new DataTable();

            sor = sorteo.SelectCodigo(codigo);

            if(sor.Rows.Count > 0)
            {
                return true;
            }


            return false;
        }


        public List<String> cargarComboxSorteosNoPremiados()
        {

            DataTable todos = new DataTable();
            DataTable resultPremiados = new DataTable();

            todos = sorteo.SelectSorteosEstadoTrue();
            resultPremiados = sorPre.Select();
            List<string> lista = new List<string>();
            

            for (int i = 0; i < todos.Rows.Count; i++)
            {
                string a = (todos.Rows[i]["codigo"]).ToString();
                lista.Add(a);
            }

            for (int j = 0; j < resultPremiados.Rows.Count; j++)
            {
                string a = resultPremiados.Rows[j]["codigo_sorteo"].ToString();
                if (lista.Contains(a))
                {
                    lista.Remove(a);
                }
            }
            return lista;


        }
        public List<string>  cargarComboEstadoTrue()
        {
            DataTable result = new DataTable();
            result = this.sorteo.SelectSorteosEstadoTrue();
            List<string> lista = new List<string>();
            if (this.sorteo.isError)
            {
                this.isError = true;
                this.errorDescription = this.sorteo.errorDescription;
            }
            for (int i = 0; i < result.Rows.Count; i++)
            {
                
              lista.Add(result.Rows[i]["codigo"].ToString());


            }
            return lista;
        }


        public List<Modelo.Sorteo> listaSorteos()
        {
            
             lista = new List<Modelo.Sorteo>();
            DataTable result = new DataTable();
            result = this.sorteo.SelectCodigo();

            for (int i = 0; i < result.Rows.Count; i++)
            {
                Modelo.Sorteo s = new Modelo.Sorteo();
                s.fecha = Convert.ToDateTime(result.Rows[i]["fecha"]);
                s.estado = Convert.ToBoolean(result.Rows[i]["estado"]);
                s.descripcion = result.Rows[i]["descripcion"].ToString();
                s.id= Convert.ToInt32(result.Rows[i]["id"]);
                s.codigo = (result.Rows[i]["codigo"].ToString());

                lista.Add(s);
            }

            return lista; 
          
        }

        public Modelo.Sorteo buscarInfoSorteo(string codigo)
        {
            Modelo.Sorteo s = new Modelo.Sorteo();
           

            return s;
        }
    }
    }

