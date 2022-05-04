using System;
using System.Collections.Generic;
using System.Text;

namespace Spells
{
    public class PHB
    {
        public string name = "Player's Handbook";
        public Dictionary<string, Spell> Spells { get; private set; }

        public void Init()
        {
            Spell acidSplash = new Spell
            {
                Source = this.name,
                Name = "Acid Slash",
                SpellLv = SpellLv.cantrip,
                School = SchoolOfMagic.conjuration,
                CastingTime = DndTime.action,
                Range = "60 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = string.Empty,
                SpellCost = 0,
                Duration = DndTime.instantaneous,
                Ritual = false,
                Description = "You hurl a bubble of acid. Choose one creature within range, or choose two creatures within range that are within 5 feet of each other. A target must succeed on a Dexterity saving throw or take 1d6 acid damage. This spell’s damage increases by 1d6 when you reach 5th level(2d6), 11th level(3d6), and 17th level(4d6).",
                Classes = new string[] { DnDClass.sorcerer, DnDClass.wizard },
                SavingThrows = new string[] { SavingThrows.dexterity },
                DamageTypes = new string[] { DamageType.acid }
            };
            Spells.Add(acidSplash.Name, acidSplash);

            Spell aid = new Spell 
            {
                Source = this.name,
                Name = "Aid",
                SpellLv = SpellLv.second,
                School = SchoolOfMagic.abjuration,
                CastingTime = DndTime.action,
                Range = "30 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a tiny strip of white cloth",
                SpellCost = 0,
                Duration = "8 "+StringTime.hours,
                Ritual = false,
                Description = "Your spell bolsters your allies with toughness and resolve. Choose up to three creatures within range. Each target’s hit point maximum and current hit points increase by 5 for the duration. At Higher Levels. When you cast this spell using a spell slot of 3rd level or higher, a target’s hit points increase by an additional 5 for each slot level above 2nd.",
                Classes = new string[] { DnDClass.cleric, DnDClass.paladin },
                SavingThrows = new string[] { },
                DamageTypes = new string[] { }
            };
            Spells.Add(aid.Name, aid);

            Spell alarm = new Spell 
            {
                Source = this.name,
                Name = "Alarm",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.abjuration,
                CastingTime = StringTime.minute,
                Range = "30 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a tiny bell and a piece of fine silver wire",
                SpellCost = 0,
                Duration = "8 " + StringTime.hours,
                Ritual = true,
                Description = "You set an alarm against unwanted intrusion. Choose a door, a window, or an area within range that is no larger than a 20-foot cube. Until the spell ends, an alarm alerts you whenever a Tiny or larger creature touches or enters the w arded area. W hen you cast the spell, you can designate creatures that w on’t set off the alarm. You also choose whether the alarm is mental or audible. A mental alarm alerts you with a ping in your mind if you are within 1 mile of the warded area. This ping awakens you if you are sleeping. An audible alarm produces the sound of a hand bell for 10 seconds within 60 feet.",
                Classes = new string[] { DnDClass.wizard },
                SavingThrows = new string[] { },
                DamageTypes = new string[] { }
            };
            Spells.Add(alarm.Name, alarm);

            Spell alterSelf = new Spell
            {
                Source = this.name,
                Name = "Alter Self",
                SpellLv = SpellLv.second,
                School = SchoolOfMagic.transmutation,
                CastingTime = DndTime.action,
                Range = Range.self,
                Verbal = true,
                Somatic = true,
                Materials = string.Empty,
                SpellCost = 0,
                Duration = DndTime.concentration + StringTime.hour,
                Ritual = false,
                Description = "You assume a different form. When you cast the spell, choose one of the following options, the effects of which last for the duration of the spell. While the spell lasts, you can end one option as an action to gain the benefits of a different one.\n Aquatic Adaptation. You adapt your body to an aquatic environment, sprouting gills and growing w ebbing between your fingers. You can breathe underwater and gain a swimming speed equal to your walking speed. \n Change Appearance. You transform your appearance. You decide what you look like, including your height, weight, facial features, sound of your voice, hair length, coloration, and distinguishing characteristics, if any. You can make yourself appear as a m em ber of another race, though none of your statistics change. You also can’t appear as a creature of a different size than you, and your basic shape stays the same; if you're bipedal, you can’t use this spell to becom e quadrupedal, for instance. At any time for the duration of the spell, you can use your action to change your appearance in this way again. \n Natural Weapons. You grow claws, fangs, spines, horns, or a different natural w eapon of your choice. Your unarm ed strikes deal 1d6 bludgeoning, piercing, or slashing damage, as appropriate to the natural weapon you chose, and you are proficient with your unarmed strikes. Finally, the natural weapon is magic and you have a +1 bonus to the attack and damage rolls you make using it.",
                Classes = new string[] { DnDClass.sorcerer, DnDClass.wizard },
                SavingThrows = new string[] { },
                DamageTypes = new string[] { }
            };
            Spells.Add(alterSelf.Name, alterSelf);

            Spell animalFriendship = new Spell
            {
                Source = this.name,
                Name = "Animal Friendship",
                SpellLv = SpellLv.first,
                School = ,
                CastingTime = ,
                Range = ,
                Verbal = ,
                Somatic = ,
                Materials = ,
                SpellCost = ,
                Duration = ,
                Ritual = ,
                Description = ,
                Classes = new string[] { },
                SavingThrows = new string[] { },
                DamageTypes = new string[] { }
            };
        }
    }
    
}
