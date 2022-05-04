using System;
using System.Collections.Generic;
using System.Text;

namespace Spells
{
    public class Spell
    {

        public string Source { get; set; }
        public string Name { get; set; }
        public string SpellLv { get; set; }
        public string School { get; set; }
        public string CastingTime { get; set; }
        public string Range { get; set; }
        public bool Verbal { get; set; }
        public bool Somatic { get; set; }
        public string Materials { get; set; }
        public int SpellCost { get; set; }
        public string Duration { get; set; }
        public bool Ritual { get; set; }
        public string Description { get; set; }
        public string[] Classes { get; set; }
        public string[] SavingThrows { get; set; }
        public string[] DamageTypes { get; set; }

        public Spell(string source,
            string name,
            string spellLv,
            string school,
            string castingTime,
            string range,
            bool verbal,
            bool somatic,
            string materials,
            int spellCost,
            string duration,
            bool ritual,
            string description,
            string[] classes,
            string[] savingThrows,
            string[] damageTypes)
        {
            this.Source = source;
            this.Name = name;
            this.SpellLv = spellLv;
            this.School = school;
            this.CastingTime = castingTime;
            this.Range = range;
            this.Verbal = verbal;
            this.Somatic = somatic;
            this.Materials = materials;
            this.SpellCost = spellCost;
            this.Duration = duration;
            this.Ritual = ritual;
            this.Description = description;
            this.Classes = classes;
            this.SavingThrows = savingThrows;
            this.DamageTypes = damageTypes;
        }

        public Spell()
        {
        }
    }
}