using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMaterial.Domain
{
    public class Material
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;  
        public decimal Cost { get; set; }
    }
}
