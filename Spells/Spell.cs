using System;
using System.Collections.Generic;
using System.Text;

namespace Spells
{
    public class Spell
    {

        public string Source { get; set; } = "";
        public string Name { get; set; } = "";
        public string SpellLv { get; set; } = "";
        public string School { get; set; } = "";
        public bool Ritual { get; set; } = false;
        public string CastingTime { get; set; } = "";
        public string Range { get; set; } = "";
        public bool Verbal { get; set; } = false;
        public bool Somatic { get; set; } = false;
        public string Materials { get; set; } = "";
        public int SpellCost { get; set; } = 0;
        public string Duration { get; set; } = "";
        public bool Concentration { get; set; } = false;
        public string Description { get; set; } = "";
        public string[] Classes { get; set; } = new string[0];
        public bool SingleTarget { get; set; } = false;
        public string[] SavingThrows { get; set; } = new string [0];
        public string[] DamageTypes { get; set; } = new string[0];
        public string[] Conditions { get; set; } = new string[0];

        public Spell(string source,
            string name,
            string spellLv,
            string school,
            bool ritual,
            string castingTime,
            string range,
            bool verbal,
            bool somatic,
            string materials,
            int spellCost,
            string duration,
            bool concentration,
            string description,
            string[] classes,
            bool singleTarget,
            string[] savingThrows,
            string[] damageTypes,
            string[] conditions)
        {
            this.Source = source;
            this.Name = name;
            this.SpellLv = spellLv;
            this.School = school;
            this.Ritual = ritual;
            this.CastingTime = castingTime;
            this.Range = range;
            this.Verbal = verbal;
            this.Somatic = somatic;
            this.Materials = materials;
            this.SpellCost = spellCost;
            this.Duration = duration;
            this.Concentration = concentration;
            this.Description = description;
            this.Classes = classes;
            this.SingleTarget = singleTarget;
            this.SavingThrows = savingThrows;
            this.DamageTypes = damageTypes;
            this.Conditions = conditions;
        }

        public Spell()
        {
        }
    }
}