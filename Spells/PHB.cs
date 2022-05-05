using System;
using System.Collections.Generic;
using System.Text;

namespace Spells
{
    public static class PHB
    {
        public const string name = "Player's Handbook";

        public static Dictionary<string, Spell> Spells { get; private set; }

        public static void Init()
        {
            Spells = new Dictionary<string, Spell>();

            #region A
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
                Duration = DndTime.instantaneous,
                Description = "You hurl a bubble of acid. Choose one creature within range, or choose two creatures within range that are within 5 feet of each other. A target must succeed on a Dexterity saving throw or take 1d6 acid damage. This spell’s damage increases by 1d6 when you reach 5th level(2d6), 11th level(3d6), and 17th level(4d6).",
                Classes = new string[] { DnDClass.sorcerer, DnDClass.wizard },
                SingleTarget = true,
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
                Duration = "8 "+StringTime.hours,
                Description = "Your spell bolsters your allies with toughness and resolve. Choose up to three creatures within range. Each target’s hit point maximum and current hit points increase by 5 for the duration. At Higher Levels. When you cast this spell using a spell slot of 3rd level or higher, a target’s hit points increase by an additional 5 for each slot level above 2nd.",
                Classes = new string[] { DnDClass.cleric, DnDClass.paladin }
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
                Duration = "8 " + StringTime.hours,
                Ritual = true,
                Description = "You set an alarm against unwanted intrusion. Choose a door, a window, or an area within range that is no larger than a 20-foot cube. Until the spell ends, an alarm alerts you whenever a Tiny or larger creature touches or enters the w arded area. W hen you cast the spell, you can designate creatures that w on’t set off the alarm. You also choose whether the alarm is mental or audible. A mental alarm alerts you with a ping in your mind if you are within 1 mile of the warded area. This ping awakens you if you are sleeping. An audible alarm produces the sound of a hand bell for 10 seconds within 60 feet.",
                Classes = new string[] { DnDClass.wizard }
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
                Concentration = true,
                Ritual = false,
                Description = "You assume a different form. When you cast the spell, choose one of the following options, the effects of which last for the duration of the spell. While the spell lasts, you can end one option as an action to gain the benefits of a different one.\n Aquatic Adaptation. You adapt your body to an aquatic environment, sprouting gills and growing w ebbing between your fingers. You can breathe underwater and gain a swimming speed equal to your walking speed. \n Change Appearance. You transform your appearance. You decide what you look like, including your height, weight, facial features, sound of your voice, hair length, coloration, and distinguishing characteristics, if any. You can make yourself appear as a m em ber of another race, though none of your statistics change. You also can’t appear as a creature of a different size than you, and your basic shape stays the same; if you're bipedal, you can’t use this spell to becom e quadrupedal, for instance. At any time for the duration of the spell, you can use your action to change your appearance in this way again. \n Natural Weapons. You grow claws, fangs, spines, horns, or a different natural w eapon of your choice. Your unarm ed strikes deal 1d6 bludgeoning, piercing, or slashing damage, as appropriate to the natural weapon you chose, and you are proficient with your unarmed strikes. Finally, the natural weapon is magic and you have a +1 bonus to the attack and damage rolls you make using it.",
                Classes = new string[] { DnDClass.sorcerer, DnDClass.wizard }
            };
            Spells.Add(alterSelf.Name, alterSelf);

            Spell animalFriendship = new Spell
            {
                Source = this.name,
                Name = "Animal Friendship",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.enchantment,
                CastingTime = DndTime.action,
                Range = "30 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a morsel of food",
                Duration = "24 " + StringTime.hours,
                Description = "This spell lets you convince a beast that you mean it no harm. Choose a beast that you can see within range. It must see and hear you. If the beast’s Intelligence is 4 or higher, the spell fails. Otherwise, the beast must succeed on a Wisdom saving throw or be charmed by you for the spell’s duration. If you or one of your companions harms the target, the spells ends. At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, you can affect one additional beast for each slot level above 1st",
                Classes = new string[] { DnDClass.bard, DnDClass.druid, DnDClass.ranger },
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.wisdom },
                Conditions = new string[] { Conditions.charmed }
            };
            Spells.Add(animalFriendship.Name, animalFriendship);

            Spell animalMessenger = new Spell
            {
                Source = this.name,
                Name = "Animal Messenger",
                SpellLv = SpellLv.second,
                School = SchoolOfMagic.enchantment,
                CastingTime = DndTime.action,
                Range = "30 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a morsel of food",
                Duration = "24 " + StringTime.hours,
                Ritual = true,
                Description = "By means of this spell, you use an animal to deliver a message. Choose a Tiny beast you can see within range, such as a squirrel, a blue jay, or a bat. You specify a location, which you must have visited, and a recipient who matches a general description, such as “a man or woman dressed in the uniform of the town guard” or “a red-haired dwarf wearing a pointed hat.” You also speak a message of up to twenty-five words. The target beast travels for the duration of the spell toward the specified location, covering about 50 miles per 24 hours for a flying messenger, or 25 miles for other animals. When the messenger arrives, it delivers your message to the creature that you described, replicating the sound of your voice. The messenger speaks only to a creature matching the description you gave. If the messenger doesn’t reach its destination before the spell ends, the message is lost, and the beast makes its way back to where you cast this spell. At Higher Levels. If you cast this spell using a spell slot of 3nd level or higher, the duration of the spell increases by 48 hours for each slot level above 2nd",
                Classes = new string[] { DnDClass.bard, DnDClass.druid, DnDClass.ranger },
                SingleTarget = true
            };
            Spells.Add(animalMessenger.Name, animalMessenger);

            Spell animalShapes = new Spell
            {
                Source = this.name,
                Name = "Animal Shapes",
                SpellLv = SpellLv.eighth,
                School = SchoolOfMagic.transmutation,
                CastingTime = DndTime.action,
                Range = "30 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.concentration + "24 " + StringTime.hours,
                Description = "Your magic turns others into beasts. Choose any number of willing creatures that you can see within range. You transform each target into the form of a Large or smaller beast with a challenge rating of 4 or lower. On subsequent turns, you can use your action to transform affected creatures into new forms. The transformation lasts for the duration for each target, or until the target drops to 0 hit points or dies. You can choose a different form for each target. A target’s game statistics are replaced by the statistics of the chosen beast, though the target retains its alignment and Intelligence, Wisdom , and Charisma scores. The target assumes the hit points of its new form, and when it reverts to its normal form, it returns to the number of hit points it had before it transformed. If it reverts as a result of dropping to 0 hit points, any excess damage carries over to its normal form. As long as the excess damage doesn’t reduce the creature’s normal form to 0 hit points, it isn’t knocked unconscious. The creature is limited in the actions it can perform by the nature of its new form, and it can’t speak or cast spells. The target’s gear melds into the new form. The target can’t activate, wield, or otherwise benefit from any of its equipment.",
                Classes = new string[] { DnDClass.druid }
            };
            Spells.Add(animalShapes.Name, animalShapes);

            Spell animateDead = new Spell
            {
                Source = this.name,
                Name = "Animate Dead",
                SpellLv = SpellLv.third,
                School = SchoolOfMagic.necromancy,
                CastingTime = StringTime.minute,
                Range = "10 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a drop of blood, a piece of flesh, and a pinch of bone dust",
                Duration = DndTime.instantaneous,
                Description = "This spell creates an undead servant. Choose a pile of bones or a corpse of a Medium or Small humanoid within range. Your spell imbues the target with a foul mimicry of life, raising it as an undead creature. The target becomes a skeleton if you chose bones or a zombie if you chose a corpse (the DM has the creature’s game statistics). On each of your turns, you can use a bonus action to mentally command any creature you made with this spell if the creature is within 60 feet of you (if you control multiple creatures, you can command any or all of them at the same time, issuing the same command to each one). You decide what action the creature will take and where it will move during its next turn, or you can issue a general command, such as to guard a particular chamber or corridor. If you issue no commands, the creature only defends itself against hostile creatures. Once given an order, the creature continues to follow it until its task is complete. The creature is under your control for 24 hours, after which it stops obeying any command you’ve given it. To maintain control of the creature for another 24 hours, you must cast this spell on the creature again before the current 24-hour period ends. This use of the spell reasserts your control over up to four creatures you have animated with this spell, rather than animating a new one. At Higher Levels. When you cast this spell using a spell slot of 4th level or higher, you animate or reassert control over two additional undead creatures for each slot level above 3rd. Each of the creatures must come from a different corpse or pile of bones.",
                Classes = new string[] { DnDClass.cleric, DnDClass.wizard }
            };
            Spells.Add(animateDead.Name, animateDead);

            Spell animateObjects = new Spell
            {
                Source = this.name,
                Name = "Animate Objects",
                SpellLv = SpellLv.fifth,
                School = SchoolOfMagic.transmutation,
                CastingTime = DndTime.action,
                Range = "120 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "Objects come to life at your command. Choose up to ten nonmagical objects within range that are not being worn or carried. Medium targets count as two objects, Large targets count as four objects, Huge targets count as eight objects. You can’t animate any object larger than Huge. Each target animates and becomes a creature under your control until the spell ends or until reduced to 0 hit points. As a bonus action, you can mentally command any creature you made with this spell if the creature is within 500 feet of you (if you control multiple creatures, you can command any or all of them at the same time, issuing the same command to each one). You decide what action the creature will take and where it will move during its next turn, or you can issue a general command, such as to guard a particular chamber or corridor. If you issue no commands, the creature only defends itself against hostile creatures. Once given an order, the creature continues to follow it until its task is complete. ~Animated Object Statistics~  - Tiny Size HP 20 AC 18 Attack +8 to hit, 1d4 + 4 damage Str 4 Dex 18 - - Small Size HP 25 AC 16 Attack +6 to hit, 1d8 + 2 damage Str 6 Dex 14 - - Medium Size HP 40 AC 13 Attack +5 to hit, 2d6 + 1 damage Str 10 Dex 12 - - Large Size HP 50 AC 10 Attack +6 to hit, 2d10 + 2 damage Str 14 Dex 10 - - Huge Size HP 80 AC 10 Attack +8 to hit, 2d12 + 4 damage Str 18 Dex 6 - An animated object is a construct with AC, hit points, attacks, Strength, and Dexterity determined by its size. Its Constitution is 10 and its Intelligence and Wisdom are 3, and its Charisma is 1. Its speed is 30 feet; if the object lacks legs or other appendages it can use for locomotion, it instead has a flying speed of 30 feet and can hover. If the object is securely attached to a surface or a larger object, such as a chain bolted to a wall, its speed is 0. It has blindsight with a radius of 30 feet and is blind beyond that distance. When the animated object drops to 0 hit points, it reverts to its original object form, and any remaining damage carries over to its original object form. If you command an object to attack, it can make a single melee attack against a creature within 5 feet of it. It makes a slam attack with an attack bonus and bludgeoning damage determined by its size. The DM might rule that a specific object inflicts slashing or piercing damage based on its form. At Higher Levels. If you cast this spell using a spell slot of 6th level or higher, you can animate two additional objects for each slot level above 5th.",
                Classes = new string[] { DnDClass.bard, DnDClass.sorcerer, DnDClass.wizard }
            };
            Spells.Add(animateObjects.Name, animateObjects);

            Spell anitlifeShell = new Spell
            {
                Source = this.name,
                Name = "Antilife Shell",
                SpellLv = SpellLv.fifth,
                School = SchoolOfMagic.abjuration,
                CastingTime = DndTime.action,
                Range = Range.self + ", 10" + Range.footRadius + " " + Range.sphere,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.concentration + StringTime.hour,
                Concentration = true,
                Description = "A shimmering barrier extends out from you in a 10-foot radius and moves with you, remaining centered on you and hedging out creatures other than undead and constructs. The barrier lasts for the duration. The barrier prevents an affected creature from passing or reaching through. An affected creature can cast spells or make attacks with ranged or reach weapons through the barrier. If you move so that an affected creature is forced to pass through the barrier, the spell ends.",
                Classes = new string[] { DnDClass.druid }
            };
            Spells.Add(anitlifeShell.Name, anitlifeShell);

            Spell antimagicField = new Spell
            {
                Source = this.name,
                Name = "Antimagic Field",
                SpellLv = SpellLv.eighth,
                School = SchoolOfMagic.abjuration,
                CastingTime = DndTime.action,
                Range = Range.self + ", 10" + Range.footRadius + " " + Range.sphere,
                Verbal = true,
                Somatic = true,
                Materials = "a pinch of powdered iron or iron filings",
                Duration = DndTime.concentration + StringTime.hour,
                Concentration = true,
                Description = "A 10-foot-radius invisible sphere of antimagic surrounds you. This area is divorced from the magical energy that suffuses the multiverse. Within the sphere, spells can’t be cast, summoned creatures disappear, and even magic items become mundane. Until the spell ends, the sphere moves with you, centered on you. Spells and other magical effects, except those created by an artifact or a deity, are suppressed in the sphere and can’t protrude into it. A slot expended to cast a suppressed spell is consumed. While an effect is suppressed, it doesn’t function, but the time it spends suppressed counts against its duration. Targeted Effects. Spells and other magical effects, such as magic missile and charm person, that target a creature or an object in the sphere have no effect on that target. Areas of Magic. The area of another spell or magical effect, such as fireball, can’t extend into the sphere. If the sphere overlaps an area of magic, the part of the area that is covered by the sphere is suppressed. For example, the flames created by a wall of fire are suppressed within the sphere, creating a gap in the wall if the overlap is large enough. Spells. Any active spell or other magical effect on a creature or an object in the sphere is suppressed while the creature or object is in it. Magic Items. The properties and powers of magic items are suppressed in the sphere. For example, a + 1 longsword in the sphere functions as a nonmagical longsword. A magic weapon’s properties and powers are suppressed if it is used against a target in the sphere or wielded by an attacker in the sphere. If a magic weapon or a piece of magic ammunition fully leaves the sphere (for example, if you fire a magic arrow or throw a magic spear at a target outside the sphere), the magic of the item ceases to be suppressed as soon as it exits. Magical Travel. Teleportation and planar travel fail to work in the sphere, whether the sphere is the destination or the departure point for such magical travel. A portal to another location, world, or plane of existence, as well as an opening to an extradimensional space such as that created by the rope trick spell, temporarily closes while in the sphere. Creatures and Objects. A creature or object summoned or created by magic temporarily w inks out of existence in the sphere. Such a creature instantly reappears once the space the creature occupied is no longer within the sphere. Dispel Magic. Spells and magical effects such as dispel magic have no effect on the sphere. Likewise, the spheres created by different antimagic field spells don’t nullify each other. ",
                Classes = new string[] { DnDClass.cleric, DnDClass.wizard},
            };
            Spells.Add(antimagicField.Name, antimagicField);

            Spell antipathySympathy = new Spell
            {
                Source = this.name,
                Name = "Antipathy/Sympathy",
                SpellLv = SpellLv.eighth,
                School = SchoolOfMagic.enchantment,
                CastingTime =  StringTime.hour,
                Range = "60 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "either a lump of alum soaked in vinegar for the antipathy effect or a drop of honey for the sympathy effect",
                Duration = "10 " + StringTime.days,
                Description = "This spell attracts or repels creatures of your choice. You target something within range, either a Huge or smaller object or creature or an area that is no larger than a 200-foot cube. Then specify a kind of intelligent creature, such as red dragons, goblins, or vampires. You invest the target with an aura that either attracts or repels the specified creatures for the duration. Choose antipathy or sympathy as the aura’s effect. -Antipathy-. The enchantment causes creatures of the kind you designated to feel an intense urge to leave the area and avoid the target. When such a creature can see the target or comes within 60 feet of it, the creature must succeed on a Wisdom saving throw or become frightened. The creature remains frightened while it can see the target or is within 60 feet of it. While frightened by the target, the creature must use its movement to move to the nearest safe spot from which it can’t see the target. If the creature moves more than 60 feet from the target and can’t see it, the creature is no longer frightened, but the creature becomes frightened again if it regains sight of the target or moves within 60 feet of it. -Sympathy-. The enchantment causes the specified creatures to feel an intense urge to approach the target while within 60 feet of it or able to see it. When such a creature can see the target or com es within 60 feet of it, the creature must succeed on a Wisdom saving throw or use its movement on each of its turns to enter the area or move within reach of the target. When the creature has done so, it can’t willingly move away from the target. If the target damages or otherwise harms an affected creature, the affected creature can make a Wisdom saving throw to end the effect, as described below. -Ending the Effect-. If an affected creature ends its turn while not within 60 feet of the target or able to see it, the creature makes a Wisdom saving throw. On a successful save, the creature is no longer affected by the target and recognizes the feeling o f repugnance or attraction as magical. In addition, a creature affected by the spell is allowed another Wisdom saving throw every 24 hours while the spell persists. A creature that successfully saves against this effect is immune to it for 1 minute, after which time it can be affected again.",
                Classes = new string[] { DnDClass.druid, DnDClass.wizard},
                SavingThrows = new string[] { SavingThrows.wisdom },
                Conditions = new string[] { Conditions.frightened}
            };
            Spells.Add(antipathySympathy.Name, antipathySympathy);

            Spell arcaneEye = new Spell
            {
                Source = this.name,
                Name = "Arcane Eye",
                SpellLv = SpellLv.fourth,
                School = SchoolOfMagic.divination,
                CastingTime = DndTime.action,
                Range = "30 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a bit of bat fur",
                Duration = DndTime.concentration + StringTime.hour,
                Concentration = true,
                Description = "You create an invisible, magical eye within range that hovers in the air for the duration. You mentally receive visual information from the eye, which has normal vision and darkvision out to 30 feet. The eye can look in every direction. As an action, you can move the eye up to 30 feet in any direction. There is no limit to how far away from you the eye can move, but it can’t enter another plane of existence. A solid barrier blocks the eye’s movement, but the eye can pass through an opening as small as 1 inch in diameter.",
                Classes = new string[] { DnDClass.wizard}
            };
            Spells.Add(arcaneEye.Name, arcaneEye);

            Spell arcaneGate = new Spell
            {
                Source = this.name,
                Name = "Arcane Gate",
                SpellLv = SpellLv.sixth,
                School = SchoolOfMagic.conjuration,
                CastingTime = DndTime.action,
                Range = "500 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.concentration + "10 " + StringTime.minutes,
                Concentration = true,
                Description = "You create linked teleportation portals that remain open for the duration. Choose two points on the ground that you can see, one point within 10 feet of you and one point within 500 feet of you. A circular portal, 10 feet in diameter, opens over each point. If the portal would open in the space occupied by a creature, the spell fails, and the casting is lost. The portals are two-dimensional glowing rings filled with mist, hovering inches from the ground and perpendicular to it at the points you choose. A ring is visible only from one side (your choice), which is the side that functions as a portal. Any creature or object entering the portal exits from the other portal as if the two were adjacent to each other; passing through a portal from the nonportal side has no effect. The mist that fills each portal is opaque and blocks vision through it. On your turn, you can rotate the rings as a bonus action so that the active side faces in a different direction.",
                Classes = new string[] { DnDClass.sorcerer, DnDClass.warlock, DnDClass.wizard }
            };
            Spells.Add(arcaneGate.Name, arcaneGate);

            Spell arcaneLock = new Spell
            {
                Source = this.name,
                Name = "Arcane Lock",
                SpellLv = SpellLv.second,
                School = SchoolOfMagic.abjuration,
                CastingTime = DndTime.action,
                Range = Range.touch,
                Verbal = true,
                Somatic = true,
                Materials = "gold dust worth at least 25 gp, which the spell consumes",
                SpellCost = 25,
                Duration = DndTime.untilDispelled,
                Description = "You touch a closed door, window, gate, chest, or other entryway, and it becomes locked for the duration. You and the creatures you designate when you cast this spell can open the object normally. You can also set a password that, when spoken within 5 feet of the object, suppresses this spell for 1 minute. Otherwise, it is impassable until it is broken or the spell is dispelled or suppressed. Casting knock on the object suppresses arcane lock for 10 minutes. While affected by this spell, the object is more difficult to break or force open; the DC to break it or pick any locks on it increases by 10.",
                Classes = new string[] { DnDClass.wizard },
                SingleTarget = true
            };
            Spells.Add(arcaneLock.Name, arcaneLock);

            Spell armorOfAgathys = new Spell
            {
                Source = this.name,
                Name = "Armor of Agathys",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.abjuration,
                CastingTime = DndTime.action,
                Range = Range.self,
                Verbal = true,
                Somatic = true,
                Materials = "a cup of water",
                Duration = StringTime.hour,
                Description = "A protective magical force surrounds you, manifesting as a spectral frost that covers you and your gear. You gain 5 temporary hit points for the duration. If a creature hits you with a melee attack while you have these hit points, the creature takes 5 cold damage. At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, both the temporary hit points and the cold damage increase by 5 for each slot level above 1st.",
                Classes = new string[] { DnDClass.warlock },
                DamageTypes = new string[] { DamageType.cold}
            };
            Spells.Add(armorOfAgathys.Name, armorOfAgathys);

            Spell armsOfHadar = new Spell
            {
                Source = this.name,
                Name = "Arms of Hadar",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.conjuration,
                CastingTime = DndTime.action,
                Range = Range.self + ", 10" + Range.footRadius,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.instantaneous,
                Description = "You invoke the power of Hadar, the Dark Hunger. Tendrils of dark energy erupt from you and batter all creatures within 10 feet of you. Each creature in that area must make a Strength saving throw. On a failed save, a target takes 2d6 necrotic damage and can’t take reactions until its next turn. On a successful save, the creature takes half damage, but suffers no other effect. At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, the damage increases by 1d6 for each slot level above 1st.",
                Classes = new string[] { DnDClass.warlock },
                SavingThrows = new string[] { SavingThrows.strength },
                DamageTypes = new string[] { DamageType.necrotic }
            };
            Spells.Add(armsOfHadar.Name, armsOfHadar);

            Spell astralProjection = new Spell
            {
                Source = this.name,
                Name = "Astral Projection",
                SpellLv = SpellLv.nineth,
                School = SchoolOfMagic.necromancy,
                CastingTime = StringTime.hour,
                Range = "10 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "for each creature you affect with this spell, you must provide one jacinth worth at least 1,000 gp and one ornately carved bar of silver worth at least 100 gp, all of which the spell consumes.",
                SpellCost = 1100,
                Duration = DndTime.special,
                Description = "You and up to eight willing creatures within range project your astral bodies into the Astral Plane (the spell fails and the casting is wasted if you are already on that plane). The material body you leave behind is unconscious and in a state of suspended animation; it doesn’t need food or air and doesn’t age. Your astral body resembles your mortal form in almost every way, replicating your game statistics and possessions. The principal difference is the addition of a silvery cord that extends from between your shoulder blades and trails behind you, fading to invisibility after 1 foot. This cord is your tether to your material body. As long as the tether remains intact, you can find your way home. If the cord is cut—something that can happen only when an effect specifically states that it does—your soul and body are separated, killing you instantly. Your astral form can freely travel through the Astral Plane and can pass through portals there leading to any other plane. If you enter a new plane or return to the plane you were on when casting this spell, your body and possessions are transported along the silver cord, allowing you to re-enter your body as you enter the new plane. Your astral form is a separate incarnation. Any damage or other effects that apply to it have no effect on your physical body, nor do they persist when you return to it. The spell ends for you and your companions when you use your action to dismiss it. When the spell ends, the affected creature returns to its physical body, and it awakens. The spell might also end early for you or one of your companions. A successful dispel magic spell used against an astral or physical body ends the spell for that creature. If a creature’s original body or its astral form drops to 0 hit points, the spell ends for that creature. If the spell ends and the silver cord is intact, the cord pulls the creature’s astral form back to its body, ending its state of suspended animation. If you are returned to your body prematurely, your companions remain in their astral forms and must find their own way back to their bodies, usually by dropping to 0 hit points.",
                Classes = new string[] { DnDClass.cleric, DnDClass.warlock, DnDClass.wizard }
            };
            Spells.Add(astralProjection.Name, astralProjection);

            Spell augury = new Spell
            {
                Source = this.name,
                Name = "Augury",
                SpellLv = SpellLv.second,
                School = SchoolOfMagic.divination,
                CastingTime = StringTime.minute,
                Range = Range.self,
                Verbal = true,
                Somatic = true,
                Materials = "specially marked sticks, bones, or similar tokens worth at least 25 gp",
                SpellCost = 25,
                Duration = DndTime.instantaneous,
                Ritual = true,
                Description = "By casting gem-inlaid sticks, rolling dragon bones, laying out ornate cards, or employing some other divining tool, you receive an omen from an otherworldly entity about the results of a specific course of action that you plan to take within the next 30 minutes. The DM chooses from the following possible omens: - Weal, for good results - Woe, for bad results - Weal and woe, for both good and bad results - Nothing, for results that aren’t especially good or bad The spell doesn’t take into account any possible circumstances that might change the outcome, such as the casting of additional spells or the loss or gain of a companion. If you cast the spell two or more times before completing your next long rest, there is a cumulative 25 percent chance for each casting after the first that you get a random reading. The DM makes this roll in secret.",
                Classes = new string[] { DnDClass.cleric }
            };
            Spells.Add(augury.Name, augury);

            Spell auraOfLive = new Spell
            {
                Source = this.name,
                Name = "Aura of Life",
                SpellLv = SpellLv.fourth,
                School = SchoolOfMagic.abjuration,
                CastingTime = DndTime.action,
                Range = Range.self + ", 30" + Range.footRadius,
                Verbal = true,
                Duration = DndTime.concentration + "10 " + StringTime.minutes,
                Concentration = true,
                Description = "Life-preserving energy radiates from you in an aura with a 30-foot radius. Until the spell ends, the aura moves with you, centered on you. Each nonhostile creature in the aura (including you) has resistance to necrotic damage, and its hit point maximum can't be reduced. In addition, a nonhostile, living creature regains 1 hit point when it starts its turn in the aura with 0 hit points. ",
                Classes = new string[] { DnDClass.paladin }
            };
            Spells.Add(auraOfLive.Name, auraOfLive);

            Spell auraOfPurity = new Spell
            {
                Source = this.name,
                Name = "Aura of Purity",
                SpellLv = SpellLv.fourth,
                School = SchoolOfMagic.abjuration,
                CastingTime = DndTime.action,
                Range = Range.self + ", 30" + Range.footRadius,
                Verbal = true,
                Duration = DndTime.concentration + "10 " + StringTime.minutes,
                Concentration = true,
                Description = "Purifying energy radiates from you in an aura with a 30-foot radius. Until the spell ends, the aura moves with you, centered on you. Each nonhostile creature in the aura (including you) can’t become diseased, has resistance to poison damage, and has advantage on saving throws against effects that cause any of the following conditions: blinded, charm ed, deafened, frightened, paralyzed, poisoned, and stunned. ",
                Classes = new string[] { DnDClass.paladin }
            };
            Spells.Add(auraOfPurity.Name, auraOfPurity);

            Spell auraOfVitality = new Spell
            {
                Source = this.name,
                Name = "Aura of Vitality",
                SpellLv = SpellLv.third,
                School = SchoolOfMagic.evocation,
                CastingTime = DndTime.action,
                Range = Range.self + ", 30" + Range.footRadius,
                Verbal = true,
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "Healing energy radiates from you in an aura with a 30-foot radius. Until the spell ends, the aura moves with you, centered on you. You can use a bonus action to cause one creature in the aura (including you) to regain 2d6 hit points.",
                Classes = new string[] { DnDClass.paladin }
            };
            Spells.Add(auraOfVitality.Name, auraOfVitality);

            Spell awaken = new Spell
            {
                Source = this.name,
                Name = "Awaken",
                SpellLv = SpellLv.fifth,
                School = SchoolOfMagic.transmutation,
                CastingTime = "8 " + StringTime.hours,
                Range = Range.touch,
                Verbal = true,
                Somatic = true,
                Materials = "an agate worth at least 1,000 gp, which the spell consumes",
                SpellCost = 1000,
                Duration = DndTime.instantaneous,
                Description = "After spending the casting time tracing magical pathways within a precious gemstone, you touch a Huge or sm aller beast or plant. The target must have either no Intelligence score or an Intelligence of 3 or less. The target gains an Intelligence of 10. The target also gains the ability to speak one language you know. If the target is a plant, it gains the ability to move its limbs, roots, vines, creepers, and so forth, and it gains senses similar to a human’s. Your DM chooses statistics appropriate for the awakened plant, such as the statistics for the awakened shrub or the awakened tree. The awakened beast or plant is charm ed by you for 30 days or until you or your com panions do anything harmful to it. W hen the charm ed condition ends, the awakened creature chooses whether to remain friendly to you, based on how you treated it while it w as charmed. ",
                Classes = new string[] { DnDClass.bard, DnDClass.druid,  },
                Conditions = new string[] { Conditions.charmed }
            };
            Spells.Add(awaken.Name, awaken);

            #endregion

            #region B

            Spell bane = new Spell
            {
                Source = this.name,
                Name = "Bane",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.enchantment,
                CastingTime = DndTime.action,
                Range = "30 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a drop of blood",
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "Up to three creatures of your choice that you can see within range must make Charisma saving throws. Whenever a target that fails this saving throw makes an attack roll or a saving throw before the spell ends, the target must roll a d4 and subtract the number rolled from the attack roll or saving throw. At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, you can target one additional creature for each slot level above 1st.",
                Classes = new string[] { DnDClass.bard, DnDClass.cleric, },
                SavingThrows = new string[] { SavingThrows.charisma}
            };
            Spells.Add(bane.Name, bane);

            Spell banishingSmite = new Spell
            {
                Source = this.name,
                Name = "Banishing Smite",
                SpellLv = SpellLv.fifth,
                School = SchoolOfMagic.abjuration,
                CastingTime = DndTime.bounusAction,
                Range = Range.self,
                Verbal = true,
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "The next time you hit a creature with a weapon attack before this spell ends, your weapon crackles with force, and the attack deals an extra 5d10 force damage to the target. Additionally, if this attack reduces the target to 50 hit points or fewer, you banish it. If the target is native to a different plane of existence than the one you’re on, the target disappears, returning to its home plane. If the target is native to the plane you’re on, the creature vanishes into a harmless demiplane. While there, the target is incapacitated. It remains there until the spell ends, at which point the target reappears in the space it left or in the nearest unoccupied space if that space is occupied.",
                Classes = new string[] { DnDClass.paladin },
                DamageTypes = new string[] { DamageType.force },
                Conditions = new string[] { Conditions.incapacitated }
            };
            Spells.Add(banishingSmite.Name, banishingSmite);

            Spell banishment = new Spell
            {
                Source = this.name,
                Name = "Banishment",
                SpellLv = SpellLv.fourth,
                School = SchoolOfMagic.abjuration,
                CastingTime = DndTime.action,
                Range = "60 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "an item distasteful to the target",
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "You attempt to send one creature that you can see within range to another plane of existence. The target must succeed on a Charisma saving throw or be banished. If the target is native to the plane of existence you’re on, you banish the target to a harmless demiplane. While there, the target is incapacitated. The target remains there until the spell ends, at which point the target reappears in the space it left or in the nearest unoccupied space if that space is occupied. If the target is native to a different plane of existence than the one you’re on, the target is banished with a faint popping noise, returning to its home plane. If the spell ends before 1 minute has passed, the target reappears in the space it left or in the nearest unoccupied space if that space is occupied. Otherwise, the target doesn't return. At Higher Levels. When you cast this spell using a spell slot of 5th level or higher, you can target one additional creature for each slot level above 4th.",
                Classes = new string[] { DnDClass.cleric, DnDClass.paladin, DnDClass.sorcerer, DnDClass.warlock, DnDClass.wizard },
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.charisma },
                Conditions = new string[] { Conditions.incapacitated }
            };
            Spells.Add(banishment.Name, banishment);

            Spell barkskin = new Spell
            {
                Source = this.name,
                Name = "Barkskin",
                SpellLv = SpellLv.second,
                School = SchoolOfMagic.transmutation,
                CastingTime = DndTime.action,
                Range = Range.touch,
                Verbal = true,
                Somatic = true,
                Materials = "a handful of oak bark",
                Duration = DndTime.concentration + StringTime.hour,
                Concentration = true,
                Description = "You touch a willing creature. Until the spell ends, the target’s skin has a rough, bark-like appearance, and the target’s AC can’t be less than 16, regardless of what kind of arm or it is wearing.",
                Classes = new string[] { DnDClass.druid, DnDClass.ranger},
                SingleTarget = true
            };
            Spells.Add(barkskin.Name, barkskin);

            Spell beaconOfHope = new Spell
            {
                Source = this.name,
                Name = "Beacon of Hope",
                SpellLv = SpellLv.third,
                School = SchoolOfMagic.abjuration,
                CastingTime = DndTime.action,
                Range = "30 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "This spell bestows hope and vitality. Choose any number of creatures within range. For the duration, each target has advantage on Wisdom saving throws and death saving throws, and regains the maximum number of hit points possible from any healing.",
                Classes = new string[] { DnDClass.cleric }
            };
            Spells.Add(beaconOfHope.Name, beaconOfHope);

            Spell beastSense = new Spell
            {
                Source = this.name,
                Name = "Beast Sense",
                SpellLv = SpellLv.second,
                School = SchoolOfMagic.divination,
                CastingTime = DndTime.action,
                Range = Range.touch,
                Somatic = true,
                Duration = DndTime.concentration + StringTime.hour,
                Concentration = true,
                Ritual = true,
                Description = "You touch a willing beast. For the duration of the spell, you can use your action to see through the beast’s eyes and hear what it hears, and continue to do so until you use your action to return to your normal senses.",
                Classes = new string[] { DnDClass.druid, DnDClass.ranger },
                SingleTarget = true
            };
            Spells.Add(beastSense.Name, beastSense);

            Spell bestowCurse = new Spell
            {
                Source = this.name,
                Name = "Bestow Curse",
                SpellLv = SpellLv.third,
                School = SchoolOfMagic.necromancy,
                CastingTime = DndTime.action,
                Range = Range.touch,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "You touch a creature, and that creature must succeed on a Wisdom saving throw or become cursed for the duration of the spell. When you cast this spell, choose the nature of the curse from the following options: - Choose one ability score. While cursed, the target has disadvantage on ability checks and saving throws made with that ability score. -- While cursed, the target has disadvantage on attack rolls against you. -- While cursed, the target must make a Wisdom saving throw at the start of each of its turns. If it fails, it wastes its action that turn doing nothing. -- While the target is cursed, your attacks and spells deal an extra 1d8 necrotic damage to the target. - A remove curse spell ends this effect. At the DM’s option, you may choose an alternative curse effect, but it should be no more powerful than those described above. The DM has final say on such a curse’s effect. At Higher Levels. If you cast this spell using a spell slot of 4th level or higher, the duration is concentration, up to 10 minutes. If you use a spell slot of 5th level or higher, the duration is 8 hours. If you use a spell slot of 7th level or higher, the duration is 24 hours. If you use a 9th level spell slot, the spell lasts until it is dispelled. Using a spell slot of 5th level or higher grants a duration that doesn’t require concentration.",
                Classes = new string[] { DnDClass.bard, DnDClass.cleric, DnDClass.wizard},
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.wisdom },
                DamageTypes = new string[] { DamageType.necrotic }
            };
            Spells.Add(bestowCurse.Name, bestowCurse);

            Spell bigbysHand = new Spell
            {
                Source = this.name,
                Name = "Bigby's Hand",
                SpellLv = SpellLv.fifth,
                School = SchoolOfMagic.evocation,
                CastingTime = DndTime.action,
                Range = "120 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "an eggshell and a snakeskin glove",
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "You create a Large hand of shimmering, translucent force in an unoccupied space that you can see within range. The hand lasts for the spell’s duration, and it moves at your command, mimicking the movements of your own hand. The hand is an object that has AC 20 and hit points equal to your hit point maximum. If it drops to 0 hit points, the spell ends. It has a Strength of 26 (+8) and a Dexterity of 10 (+0). The hand doesn’t fill its space. When you cast the spell and as a bonus action on your subsequent turns, you can move the hand up to 60 feet and then cause one of the following effects with it. -Clenched Fist. The hand strikes one creature or object within 5 feet of it. Make a melee spell attack for the hand using your game statistics. On a hit, the target takes 4d8 force damage. --Forceful Hand. The hand attempts to push a creature within 5 feet of it in a direction you choose. Make a check with the hand’s Strength contested by the Strength (Athletics) check of the target. If the target is Medium or smaller, you have advantage on the check. If you succeed, the hand pushes the target up to 5 feet plus a number of feet equal to five times your spellcasting ability modifier. The hand moves with the target to remain within 5 feet of it. --Grasping Hand. The hand attempts to grapple a Huge or smaller creature within 5 feet of it. You use the hand’s Strength score to resolve the grapple. If the target is Medium or smaller, you have advantage on the check. While the hand is grappling the target, you can use a bonus action to have the hand crush it. When you do so, the target takes bludgeoning damage equal to 2d6 + your spellcasting ability modifier. --Interposing Hand. The hand interposes itself between you and a creature you choose until you give the hand a different command. The hand moves to stay between you and the target, providing you with half cover against the target. The target can't move through the hand’s space if its Strength score is less than or equal to the hand’s Strength score. If its Strength score is higher than the hand’s Strength score, the target can move toward you through the hand’s space, but that space is difficult terrain for the target. -At Higher Levels. W hen you cast this spell using a spell slot of 6th level or higher, the damage from the clenched fist option increases by 2d8 and the damage from the grasping hand increases by 2d6 for each slot level above 5th.",
                Classes = new string[] { DnDClass.wizard },
                SavingThrows = new string[] { },
                DamageTypes = new string[] { DamageType.force, DamageType.bludgeoning },
                Conditions = new string[] { Conditions.grappled }
            };
            Spells.Add(bigbysHand.Name, bigbysHand);

            Spell bladeBarrier = new Spell
            {
                Source = this.name,
                Name = "Blade Barrier",
                SpellLv = SpellLv.sixth,
                School = SchoolOfMagic.evocation,
                CastingTime = DndTime.action,
                Range = "90 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.concentration + "10 " + StringTime.minutes,
                Concentration = true,
                Description = "You create a vertical wall of whirling, razor-sharp blades made of magical energy. The wall appears within range and lasts for the duration. You can make a straight wall up to 100 feet long, 20 feet high, and 5 feet thick, or a ringed wall up to 60 feet in diameter, 20 feet high, and 5 feet thick. The wall provides three-quarters cover to creatures behind it, and its space is difficult terrain. When a creature enters the wall’s area for the first time on a turn or starts its turn there, the creature must make a Dexterity saving throw. On a failed save, the creature takes 6d10 slashing damage. On a successful save, the creature takes half as much damage.",
                Classes = new string[] { DnDClass.cleric },
                SavingThrows = new string[] { SavingThrows.dexterity },
                DamageTypes = new string[] { DamageType.slashing }
            };
            Spells.Add(bladeBarrier.Name, bladeBarrier);

            Spell bladeWard = new Spell
            {
                Source = this.name,
                Name = "Blade Ward",
                SpellLv = SpellLv.cantrip,
                School = SchoolOfMagic.abjuration,
                CastingTime = DndTime.action,
                Range = Range.self,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.round,
                Description = "You extend your hand and trace a sigil of warding in the air. Until the end of your next turn, you have resistance against bludgeoning, piercing, and slashing damage dealt by weapon attacks.",
                Classes = new string[] { DnDClass.bard, DnDClass.sorcerer, DnDClass.warlock, DnDClass.wizard }
            };
            Spells.Add(bladeWard.Name, bladeWard);

            Spell bless = new Spell
            {
                Source = this.name,
                Name = "Bless",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.enchantment,
                CastingTime = DndTime.action,
                Range = "30 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a sprinkling of holy water",
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "You bless up to three creatures of your choice within range. Whenever a target m akes an attack roll or a saving throw before the spell ends, the target can roll a d4 and add the number rolled to the attack roll or saving throw. At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, you can target one additional creature for each slot level above 1st.",
                Classes = new string[] { DnDClass.cleric, DnDClass.paladin },
            };
            Spells.Add(bless.Name, bless);

            Spell blight = new Spell
            {
                Source = this.name,
                Name = "Blight",
                SpellLv = SpellLv.fourth,
                School = SchoolOfMagic.necromancy,
                CastingTime = DndTime.action,
                Range = "30 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.instantaneous,
                Description = "Necromantic energy washes over a creature of your choice that you can see within range, draining moisture and vitality from it. The target must make a Constitution saving throw. The target takes 8d8 necrotic damage on a failed save, or half as much damage on a successful one. This spell has no effect on undead or constructs. If you target a plant creature or a magical plant, it makes the saving throw with disadvantage, and the spell deals maximum damage to it. If you target a nonmagical plant that isn’t a creature, such as a tree or shrub, it doesn’t make a saving throw; it simply withers and dies. At Higher Levels. When you cast this spell using a spell slot of 5th level or higher, the damage increases by 1d8 for each slot level above 4th.",
                Classes = new string[] { DnDClass.druid, DnDClass.sorcerer, DnDClass.warlock, DnDClass.wizard },
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.constitution },
                DamageTypes = new string[] { DamageType.necrotic },
            };
            Spells.Add(blight.Name, blight);

            Spell blindingSmite = new Spell
            {
                Source = this.name,
                Name = "Blinding Smite",
                SpellLv = SpellLv.third,
                School = SchoolOfMagic.evocation,
                CastingTime = DndTime.action,
                Range = Range.self,
                Verbal = true,
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "The next time you hit a creature with a melee weapon attack during this spell’s duration, your weapon flares with bright light, and the attack deals an extra 3d8 radiant damage to the target. Additionally, the target must succeed on a Constitution saving throw or be blinded until the spell ends. A creature blinded by this spell makes another Constitution saving throw at the end of each of its turns. On a successful save, it is no longer blinded.",
                Classes = new string[] { DnDClass.paladin },
                SavingThrows = new string[] { SavingThrows.constitution },
                DamageTypes = new string[] { DamageType.radiant },
                Conditions = new string[] { Conditions.blinded },
            };
            Spells.Add(blindingSmite.Name, blindingSmite);

            Spell blindnessDeafness = new Spell
            {
                Source = this.name,
                Name = "Blindness/Deafness",
                SpellLv = SpellLv.second,
                School = SchoolOfMagic.necromancy,
                CastingTime = DndTime.action,
                Range = "30 " + Range.feet,
                Verbal = true,
                Duration = StringTime.minute,
                Concentration = true,
                Description = "You can blind or deafen a foe. Choose one creature that you can see within range to make a Constitution saving throw. If it fails, the target is either blinded or deafened (your choice) for the duration. At the end of each of its turns, the target can make a Constitution saving throw. On a success, the spell ends. At Higher Levels. When you cast this spell using a spell slot of 3rd level or higher, you can target one additional creature for each slot level above 2nd",
                Classes = new string[] { DnDClass.bard, DnDClass.cleric, DnDClass.sorcerer, DnDClass.wizard },
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.constitution },
                Conditions = new string[] { Conditions.blinded, Conditions.deafened },
            };
            Spells.Add(blindnessDeafness.Name, blindnessDeafness);

            Spell blink = new Spell
            {
                Source = this.name,
                Name = "Blink",
                SpellLv = SpellLv.third,
                School = SchoolOfMagic.transmutation,
                CastingTime = DndTime.action,
                Range = Range.self,
                Verbal = true,
                Somatic = true,
                Duration = StringTime.minute,
                Description = "Roll a d20 at the end of each of your turns for the duration of the spell. On a roll of 11 or higher, you vanish from your current plane of existence and appear in the Ethereal Plane (the spell fails and the casting is wasted if you were already on that plane). At the start of your next turn, and when the spell ends if you are on the Ethereal Plane, you return to an unoccupied space of your choice that you can see within 10 feet of the space you vanished from. If no unoccupied space is available within that range, you appear in the nearest unoccupied space (chosen at random if more than one space is equally near). You can dismiss this spell as an action. While on the Ethereal Plane, you can see and hear the plane you originated from, which is cast in shades of gray, and you can’t see anything there more than 60 feet away. You can only affect and be affected by other creatures on the Ethereal Plane. Creatures that aren’t there can’t perceive you or interact with you, unless they have the ability to do so.",
                Classes = new string[] { DnDClass.sorcerer, DnDClass.wizard },
            };
            Spells.Add(blink.Name, blink);

            Spell blur = new Spell
            {
                Source = this.name,
                Name = "Blur",
                SpellLv = SpellLv.second,
                School = SchoolOfMagic.illusion,
                CastingTime = DndTime.action,
                Range = Range.self,
                Verbal = true,
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "Your body becomes blurred, shifting and wavering to all who can see you. For the duration, any creature has disadvantage on attack rolls against you. An attacker is immune to this effect if it doesn’t rely on sight, as with blindsight, or can see through illusions, as with truesight.",
                Classes = new string[] { DnDClass.sorcerer, DnDClass.wizard },
            };
            Spells.Add(blur.Name, blur);

            Spell brandingSmite = new Spell
            {
                Source = this.name,
                Name = "Branding Smite",
                SpellLv = SpellLv.second,
                School = SchoolOfMagic.evocation,
                CastingTime = DndTime.bounusAction,
                Range = Range.self,
                Verbal = true,
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "The next time you hit a creature with a weapon attack before this spell ends, the weapon gleams with astral radiance as you strike. The attack deals an extra 2d6 radiant damage to the target, which becomes visible if it’s invisible, and the target sheds dim light in a 5-foot radius and can’t become invisible until the spell ends. At Higher Levels. When you cast this spell using a spell slot of 3rd level or higher, the extra damage increases by 1d6 for each slot level above 2nd.",
                Classes = new string[] { DnDClass.paladin },
                DamageTypes = new string[] { DamageType.radiant },
            };
            Spells.Add(brandingSmite.Name, brandingSmite);

            Spell burningHands = new Spell
            {
                Source = this.name,
                Name = "Burning Hands",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.evocation,
                CastingTime = DndTime.action,
                Range = Range.self + ", 15" + Range.footCone,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.instantaneous,
                Description = "As you hold your hands with thumbs touching and fingers spread, a thin sheet of flames shoots forth from your outstretched fingertips. Each creature in a 15-foot cone must make a Dexterity saving throw. A creature takes 3d6 fire damage on a failed save, or half as much damage on a successful one. The fire ignites any flammable objects in the area that aren’t being worn or carried. At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, the damage increases by 1d6 for each slot level above 1st.",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.dexterity },
                DamageTypes = new string[] { DamageType.fire },
            };
            Spells.Add(burningHands.Name, burningHands);

            #endregion
        }
    }
    
}
