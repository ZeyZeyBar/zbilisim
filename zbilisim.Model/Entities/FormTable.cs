using System.ComponentModel.DataAnnotations;
using zbilisim.Core.Entitiy;

namespace zbilisim.Model.Entities
{
    public class FormTable:CoreEntity
    {
        public string NameSurname { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email{ get; set; }
        public string Message { get; set; }
    }
}
