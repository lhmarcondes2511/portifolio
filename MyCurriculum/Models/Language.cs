using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCurriculum.Models {
    public class Language {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string LinkImage { get; set; }
        
        [DisplayName("Nome da Linguagem")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [MinLength(0)]
        public int Percent { get; set; }
        
        [Required(ErrorMessage = "Campo Obrigatório")]
        [MinLength(0)]
        public string Text { get; set; }
        public ICollection<Topic> Topics { get; set; } = new List<Topic>();

        public Language() {
        }

        public Language(int id, string linkImage, string name, int percent, string text) {
            Id = id;
            LinkImage = linkImage;
            Name = name;
            Percent = percent;
            Text = text;
        }
    }
}
