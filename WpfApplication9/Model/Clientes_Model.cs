using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication9.Model
{
    public class Clientes_Model
    {
        public string tipo { get; set; }
        public string cod { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public string cep { get; set; }
        public string tel { get; set; }
        public string cel { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string repit_senha { get; set; }
        public string tipo_check() {
            if (cod == "Fisica") return tipo = "2";
            else { return tipo = "1"; }
        }
    }
}
