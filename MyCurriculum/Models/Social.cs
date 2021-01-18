using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCurriculum.Models {
    public class Social {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string LinkImage { get; set; }

        [DisplayName("Nome da Rede Social")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Name { get; set; }

        [DisplayName("Link da Rede Social")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Link { get; set; }

        public Social() {
        }

        public Social(int id, string linkImage, string name, string link) {
            Id = id;
            LinkImage = linkImage;
            Name = name;
            Link = link;
        }
    }
}
