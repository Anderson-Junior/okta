using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FamilyTreeBuilder.ModelsGenerated
{
    public partial class Person
    {
        public Person()
        {
            InverseFatherNavigation = new HashSet<Person>();
            InverseMotherNavigation = new HashSet<Person>();
        }

        public int Id { get; set; }
        [Display(Name = "Primeiro Nome")]
        public string FirstName { get; set; }

        [Display(Name = "Último Nome")]
        public string LastName { get; set; }

        [Display(Name = "Sexo")]
        public string Sex { get; set; }

        [Display(Name = "Data de Nascimento")]
        public DateTime? BirthDate { get; set; }

        [Display(Name = "Data de falecimento")]
        public DateTime? DeathDate { get; set; }

        [Display(Name = "Pai")]
        public int? Father { get; set; }

        [Display(Name = "Mãe")]
        public int? Mother { get; set; }
        
        public virtual Person FatherNavigation { get; set; }
        public virtual Person MotherNavigation { get; set; }
        public virtual ICollection<Person> InverseFatherNavigation { get; set; }
        public virtual ICollection<Person> InverseMotherNavigation { get; set; }
    }
}
