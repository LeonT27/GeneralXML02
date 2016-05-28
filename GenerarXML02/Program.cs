using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GenerarXML02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WriteXML();
        }

        public class Activos
        {
            public int no_de_asiento;
            public string descripcion_del_asiento;
            public DateTime fecha_asiento;
            public string cuenta_contable;
            public string tipo_de_movimiento;
            public Double monto_de_movimiento;
        }

        public static void WriteXML()
        {

                Activos Activo = new Activos();
                Activo.no_de_asiento = 1;
                Activo.descripcion_del_asiento = "La sopa de capitan america";
                Activo.fecha_asiento = DateTime.Now;
                Activo.cuenta_contable = "Comida";
                Activo.tipo_de_movimiento = "Debito";
                Activo.monto_de_movimiento = 250.00;
                System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(Activos));
                var path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//Activos1.xml";
                System.IO.FileStream file = System.IO.File.Create(path);
                writer.Serialize(file, Activo);
                file.Close();
                Console.WriteLine("Exito");
                Console.Read();
            
        }
    }
}
