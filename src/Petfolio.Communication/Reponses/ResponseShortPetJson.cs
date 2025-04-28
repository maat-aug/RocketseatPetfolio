using Petfolio.Communication.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petfolio.Communication.Reponses
{
    public class ResponseShortPetJson
    {
        public int Id {  get; set; }
        public string Name { get; set; } = string.Empty;
        public PetType Type { get; set; }
    }
}
