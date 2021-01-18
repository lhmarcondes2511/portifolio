using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCurriculum.Models {
    public class Topic {
        [Key]
        public int Id { get; set; }

        [DisplayName("Nome do Tópico")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Name { get; set; }

        public Topic() {
        }

        public Topic(int id, string name) {
            Id = id;
            Name = name;
        }
    }
}
