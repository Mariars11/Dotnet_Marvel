using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using src.Dto;

namespace src.Models
{
    public class Hero
    {
        public Hero(){}

        public Hero(CreateHero hero){
            this.Name = hero.Name;
            this.RealName = hero.RealName;
            this.GroupId = hero.GroupId;
            this.CreateAt = DateTime.Now;
        }
        
        [Key] //data annotation para indicar que é uma chave
        public int Id { get; set; }

        [MaxLength(80)] // referente ao nome
        [MinLength(3)]
        public string Name { get; set; }
        
        [MaxLength(80)] // referente ao nome real
        [Required]
        public string RealName { get; set; }
        public DateTime CreateAt { get; set; }
        public int? GroupId { get; set; } // ? - permissão de null
        [ForeignKey("GroupId")]
        public Group group { get; set; }
    }
}