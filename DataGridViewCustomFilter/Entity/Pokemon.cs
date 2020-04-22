using CsvHelper.Configuration.Attributes;

namespace DataGridViewCustomFilter.Entity
{
    public class Pokemon
    {
        [Name("name01")]
        public string NameEn { get; set; }

        [Name("name02")]
        public string NameJa { get; set; }

        [Name("HP")]
        public int HitPoint { get; set; }

        [Name("Attack")]
        public int Attack { get; set; }

        [Name("Defense")]
        public int Defense { get; set; }

        [Name("Sp_Atk")]
        public int SpecialAttack { get; set; }

        [Name("Sp_Def")]
        public int SpecialDefense { get; set; }

        [Name("Speed")]
        public int Speed { get; set; }

        [Name("sum")]
        public int Sum { get; set; }

        [Name("type1")]
        public string TypeA { get; set; }

        [Name("type2")]
        public string TypeB { get; set; }
    }
}
