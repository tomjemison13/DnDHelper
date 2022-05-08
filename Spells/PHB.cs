﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Spells
{
    public static class PHB
    {
        public const string sourceTitle = "Player's Handbook";

        public static Dictionary<string, Spell> Spells { get; private set; }

        public static void Init()
        {
            Spells = new Dictionary<string, Spell>();

            #region A

            Spell acidSplash = new Spell
            {
                Source = sourceTitle,
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
                Source = sourceTitle,
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
                Classes = new string[] { DnDClass.cleric, DnDClass.paladin },
                SingleTarget = true
            };
            Spells.Add(aid.Name, aid);

            Spell alarm = new Spell 
            {
                Source = sourceTitle,
                Name = "Alarm",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.abjuration,
                CastingTime = StringTime.minute,
                Range = "30 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a tiny bell and a piece of fine silver wire",
                Duration = "8 " + StringTime.hours,
                Description = "You set an alarm against unwanted intrusion. Choose a door, a window, or an area within range that is no larger than a 20-foot cube. Until the spell ends, an alarm alerts you whenever a Tiny or larger creature touches or enters the w arded area. W hen you cast the spell, you can designate creatures that w on’t set off the alarm. You also choose whether the alarm is mental or audible. A mental alarm alerts you with a ping in your mind if you are within 1 mile of the warded area. This ping awakens you if you are sleeping. An audible alarm produces the sound of a hand bell for 10 seconds within 60 feet.",
                Classes = new string[] { DnDClass.ranger, DnDClass.wizard }
            };
            Spells.Add(alarm.Name, alarm);

            Spell alterSelf = new Spell
            {
                Source = sourceTitle,
                Name = "Alter Self",
                SpellLv = SpellLv.second,
                School = SchoolOfMagic.transmutation,
                Ritual = true,
                CastingTime = DndTime.action,
                Range = Range.self,
                Verbal = true,
                Somatic = true,
                Materials = string.Empty,
                SpellCost = 0,
                Duration = DndTime.concentration + StringTime.hour,
                Concentration = true,
                Description = "You assume a different form. When you cast the spell, choose one of the following options, the effects of which last for the duration of the spell. While the spell lasts, you can end one option as an action to gain the benefits of a different one.\n Aquatic Adaptation. You adapt your body to an aquatic environment, sprouting gills and growing w ebbing between your fingers. You can breathe underwater and gain a swimming speed equal to your walking speed. \n Change Appearance. You transform your appearance. You decide what you look like, including your height, weight, facial features, sound of your voice, hair length, coloration, and distinguishing characteristics, if any. You can make yourself appear as a m em ber of another race, though none of your statistics change. You also can’t appear as a creature of a different size than you, and your basic shape stays the same; if you're bipedal, you can’t use this spell to becom e quadrupedal, for instance. At any time for the duration of the spell, you can use your action to change your appearance in this way again. \n Natural Weapons. You grow claws, fangs, spines, horns, or a different natural w eapon of your choice. Your unarm ed strikes deal 1d6 bludgeoning, piercing, or slashing damage, as appropriate to the natural weapon you chose, and you are proficient with your unarmed strikes. Finally, the natural weapon is magic and you have a +1 bonus to the attack and damage rolls you make using it.",
                Classes = new string[] { DnDClass.sorcerer, DnDClass.wizard }
            };
            Spells.Add(alterSelf.Name, alterSelf);

            Spell animalFriendship = new Spell
            {
                Source = sourceTitle,
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
                Source = sourceTitle,
                Name = "Animal Messenger",
                SpellLv = SpellLv.second,
                School = SchoolOfMagic.enchantment,
                Ritual = true,
                CastingTime = DndTime.action,
                Range = "30 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a morsel of food",
                Duration = "24 " + StringTime.hours,
                Description = "By means of this spell, you use an animal to deliver a message. Choose a Tiny beast you can see within range, such as a squirrel, a blue jay, or a bat. You specify a location, which you must have visited, and a recipient who matches a general description, such as “a man or woman dressed in the uniform of the town guard” or “a red-haired dwarf wearing a pointed hat.” You also speak a message of up to twenty-five words. The target beast travels for the duration of the spell toward the specified location, covering about 50 miles per 24 hours for a flying messenger, or 25 miles for other animals. When the messenger arrives, it delivers your message to the creature that you described, replicating the sound of your voice. The messenger speaks only to a creature matching the description you gave. If the messenger doesn’t reach its destination before the spell ends, the message is lost, and the beast makes its way back to where you cast this spell. At Higher Levels. If you cast this spell using a spell slot of 3nd level or higher, the duration of the spell increases by 48 hours for each slot level above 2nd",
                Classes = new string[] { DnDClass.bard, DnDClass.druid, DnDClass.ranger },
                SingleTarget = true
            };
            Spells.Add(animalMessenger.Name, animalMessenger);

            Spell animalShapes = new Spell
            {
                Source = sourceTitle,
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
                Source = sourceTitle,
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
                Source = sourceTitle,
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
                Source = sourceTitle,
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
                Source = sourceTitle,
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
                Source = sourceTitle,
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
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.wisdom },
                Conditions = new string[] { Conditions.frightened}
            };
            Spells.Add(antipathySympathy.Name, antipathySympathy);

            Spell arcaneEye = new Spell
            {
                Source = sourceTitle,
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
                Source = sourceTitle,
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
                Source = sourceTitle,
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
                Source = sourceTitle,
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
                Source = sourceTitle,
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
                Source = sourceTitle,
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
                Source = sourceTitle,
                Name = "Augury",
                SpellLv = SpellLv.second,
                School = SchoolOfMagic.divination,
                Ritual = true,
                CastingTime = StringTime.minute,
                Range = Range.self,
                Verbal = true,
                Somatic = true,
                Materials = "specially marked sticks, bones, or similar tokens worth at least 25 gp",
                SpellCost = 25,
                Duration = DndTime.instantaneous,
                Description = "By casting gem-inlaid sticks, rolling dragon bones, laying out ornate cards, or employing some other divining tool, you receive an omen from an otherworldly entity about the results of a specific course of action that you plan to take within the next 30 minutes. The DM chooses from the following possible omens: - Weal, for good results - Woe, for bad results - Weal and woe, for both good and bad results - Nothing, for results that aren’t especially good or bad The spell doesn’t take into account any possible circumstances that might change the outcome, such as the casting of additional spells or the loss or gain of a companion. If you cast the spell two or more times before completing your next long rest, there is a cumulative 25 percent chance for each casting after the first that you get a random reading. The DM makes this roll in secret.",
                Classes = new string[] { DnDClass.cleric }
            };
            Spells.Add(augury.Name, augury);

            Spell auraOfLive = new Spell
            {
                Source = sourceTitle,
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
                Source = sourceTitle,
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
                Source = sourceTitle,
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
                Source = sourceTitle,
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
                SingleTarget = true,
                Conditions = new string[] { Conditions.charmed }
            };
            Spells.Add(awaken.Name, awaken);

            #endregion

            #region B

            Spell bane = new Spell
            {
                Source = sourceTitle,
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
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.charisma}
            };
            Spells.Add(bane.Name, bane);

            Spell banishingSmite = new Spell
            {
                Source = sourceTitle,
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
                Source = sourceTitle,
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
                Source = sourceTitle,
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
                Source = sourceTitle,
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
                Source = sourceTitle,
                Name = "Beast Sense",
                SpellLv = SpellLv.second,
                School = SchoolOfMagic.divination,
                Ritual = true,
                CastingTime = DndTime.action,
                Range = Range.touch,
                Somatic = true,
                Duration = DndTime.concentration + StringTime.hour,
                Concentration = true,
                Description = "You touch a willing beast. For the duration of the spell, you can use your action to see through the beast’s eyes and hear what it hears, and continue to do so until you use your action to return to your normal senses.",
                Classes = new string[] { DnDClass.druid, DnDClass.ranger },
                SingleTarget = true
            };
            Spells.Add(beastSense.Name, beastSense);

            Spell bestowCurse = new Spell
            {
                Source = sourceTitle,
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
                Source = sourceTitle,
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
                Source = sourceTitle,
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
                Source = sourceTitle,
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
                Source = sourceTitle,
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
                SingleTarget = true
            };
            Spells.Add(bless.Name, bless);

            Spell blight = new Spell
            {
                Source = sourceTitle,
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
                Source = sourceTitle,
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
                Source = sourceTitle,
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
                Source = sourceTitle,
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
                Source = sourceTitle,
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
                Source = sourceTitle,
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
                Source = sourceTitle,
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

            #region C

            Spell callLightning = new Spell
            {
                Source = sourceTitle,
                Name = "Call Lightning",
                SpellLv = SpellLv.third,
                School = SchoolOfMagic.conjuration,
                CastingTime = DndTime.action,
                Range = "120 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.concentration + "10 " + StringTime.minutes,
                Concentration = true,
                Description = "A storm cloud appears in the shape of a cylinder that is 10 feet tall with a 60-foot radius, centered on a point you can see 100 feet directly above you. The spell fails if you can’t see a point in the air where the storm cloud could appear (for example, if you are in a room that can’t accommodate the cloud). When you cast the spell, choose a point you can see within range. A bolt of lightning flashes down from the cloud to that point. Each creature within 5 feet of that point must make a Dexterity saving throw. A creature takes 3d10 lightning damage on a failed save, or half as much damage on a successful one. On each of your turns until the spell ends, you can use your action to call down lightning in this way again, targeting the same point or a different one. If you are outdoors in stormy conditions when you cast this spell, the spell gives you control over the existing storm instead of creating a new one. Under such conditions, the spell’s damage increases by 1d10. At Higher Levels. When you cast this spell using a spell slot of 4th or higher level, the damage increases by 1d10 for each slot level above 3rd",
                Classes = new string[] { DnDClass.druid },
                SavingThrows = new string[] { SavingThrows.dexterity },
                DamageTypes = new string[] { DamageType.lightning }
            };
            Spells.Add(callLightning.Name, callLightning);

            Spell calmEmotions = new Spell
            {
                Source = sourceTitle,
                Name = "Calm Emotions",
                SpellLv = SpellLv.second,
                School = SchoolOfMagic.enchantment,
                CastingTime = DndTime.action,
                Range = "60 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "You attempt to suppress strong emotions in a group of people. Each humanoid in a 20-foot-radius sphere centered on a point you choose within range must make a Charisma saving throw; a creature can choose to fail this saving throw if it wishes. If a creature fails its saving throw, choose one of the following two effects. You can suppress any effect causing a target to be charmed or frightened. When this spell ends, any suppressed effect resumes, provided that its duration has not expired in the meantime. Alternatively, you can make a target indifferent about creatures of your choice that it is hostile toward. This indifference ends if the target is attacked or harmed by a spell or if it witnesses any of its friends being harmed. When the spell ends, the creature becomes hostile again, unless the DM rules otherwise. ",
                Classes = new string[] { DnDClass.bard, DnDClass.cleric },
                SavingThrows = new string[] { SavingThrows.charisma },
                Conditions = new string[] { Conditions.charmed, Conditions.frightened }
            };
            Spells.Add(calmEmotions.Name, calmEmotions);

            Spell chainLightning = new Spell
            {
                Source = sourceTitle,
                Name = "Chain Lightning",
                SpellLv = SpellLv.sixth,
                School = SchoolOfMagic.evocation,
                CastingTime = DndTime.action,
                Range = "150 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a bit of fur; a piece of amber, glass, or a crystal rod; and three silver pins",
                Duration = DndTime.instantaneous,
                Description = "You create a bolt of lightning that arcs toward a target of your choice that you can see within range. Three bolts then leap from that target to as many as three other targets, each of which must be within 30 feet of the first target. A target can be a creature or an object and can be targeted by only one of the bolts. A target must make a Dexterity saving throw. The target takes 10d8 lightning damage on a failed save, or half as much damage on a successful one. At Higher Levels. When you cast this spell using a spell slot of 7th level or higher, one additional bolt leaps from the first target to another target for each slot level above 6th",
                Classes = new string[] { DnDClass.sorcerer, DnDClass.wizard },
                SavingThrows = new string[] { SavingThrows.dexterity },
                DamageTypes = new string[] { DamageType.lightning }
            };
            Spells.Add(chainLightning.Name, chainLightning);

            Spell charmPerson = new Spell
            {
                Source = sourceTitle,
                Name = "Charm Person",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.enchantment,
                CastingTime = DndTime.action,
                Range = "30 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = StringTime.hour,
                Description = "You attempt to charm a humanoid you can see within range. It must make a Wisdom saving throw, and does so with advantage if you or your companions are fighting it. If it fails the saving throw, it is charmed by you until the spell ends or until you or your companions do anything harmful to it. The charmed creature regards you as a friendly acquaintance. When the spell ends, the creature knows it was charmed by you. At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, you can target one additional creature for each slot level above 1st. The creatures must be within 30 feet of each other when you target them.",
                Classes = new string[] { DnDClass.bard, DnDClass.druid, DnDClass.sorcerer, DnDClass.warlock, DnDClass.wizard},
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.wisdom },
                Conditions = new string[] { Conditions.charmed }
            };
            Spells.Add(charmPerson.Name, charmPerson);

            Spell chillTouch = new Spell
            {
                Source = sourceTitle,
                Name = "Chill Touch",
                SpellLv = SpellLv.cantrip,
                School = SchoolOfMagic.necromancy,
                CastingTime = DndTime.action,
                Range = "120 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.round,
                Description = "You create a ghostly, skeletal hand in the space of a creature within range. Make a ranged spell attack against the creature to assail it with the chill of the grave. On a hit, the target takes 1d8 necrotic damage, and it can’t regain hit points until the start of your next turn. Until then, the hand clings to the target. If you hit an undead target, it also has disadvantage on attack rolls against you until the end of your next turn. This spell’s damage increases by 1d8 when you reach 5th level (2d8), 11th level (3d8), and 17th level (4d8).",
                Classes = new string[] { DnDClass.sorcerer, DnDClass.warlock, DnDClass.wizard },
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.ranged },
                DamageTypes = new string[] { DamageType.necrotic }
            };
            Spells.Add(chillTouch.Name, chillTouch);

            Spell chromaticOrb = new Spell
            {
                Source = sourceTitle,
                Name = "Chromatic Orb",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.evocation,
                CastingTime = DndTime.action,
                Range = "90 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a diamond worth at least 50gp",
                SpellCost = 50,
                Duration = DndTime.instantaneous,
                Description = "You hurl a 4-inch-diameter sphere of energy at a creature that you can see within range. You choose acid, cold, fire, lightning, poison, or thunder for the type of orb you create, and then make a ranged spell attack against the target. If the attack hits, the creature takes 3d8 damage of the type you chose. At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, the damage increases by 1d8 for each slot level above 1st.",
                Classes = new string[] { DnDClass.sorcerer, DnDClass.wizard },
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.ranged },
                DamageTypes = new string[] { DamageType.acid, DamageType.cold, DamageType.fire, DamageType.lightning, DamageType.poison, DamageType.thunder }
            };
            Spells.Add(chromaticOrb.Name, chromaticOrb);

            Spell circleOfDeath = new Spell
            {
                Source = sourceTitle,
                Name = "Circle of Death",
                SpellLv = SpellLv.sixth,
                School = SchoolOfMagic.necromancy,
                CastingTime = DndTime.action,
                Range = "150 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "the powder of a crushed black pearl worth at least 500 gp",
                SpellCost = 500,
                Duration = DndTime.instantaneous,
                Description = "A sphere of negative energy ripples out in a 60-footradius sphere from a point within range. Each creature in that area must make a Constitution saving throw. A target takes 8d6 necrotic damage on a failed save, or half as much damage on a successful one. At Higher Levels. When you cast this spell using a spell slot of 7th level or higher, the damage increases by 2d6 for each slot level above 6th.",
                Classes = new string[] { DnDClass.sorcerer, DnDClass.warlock, DnDClass.wizard },
                SavingThrows = new string[] { SavingThrows.constitution },
                DamageTypes = new string[] { DamageType.necrotic }
            };
            Spells.Add(circleOfDeath.Name, circleOfDeath);

            Spell circleOfPower = new Spell
            {
                Source = sourceTitle,
                Name = "Cicle of Power",
                SpellLv = SpellLv.fifth,
                School = SchoolOfMagic.abjuration,
                CastingTime = DndTime.action,
                Range = Range.self + ", 30" + Range.footRadius,
                Verbal = true,
                Duration = DndTime.concentration + "10 " + StringTime.minutes,
                Concentration = true,
                Description = "Divine energy radiates from you, distorting and diffusing magical energy within 30 feet of you. Until the spell ends, the sphere moves with you, centered on you. For the duration, each friendly creature in the area (including you) has advantage on saving throws against spells and other magical effects. Additionally, when an affected creature succeeds on a saving throw made against a spell or magical effect that allows it to make a saving throw to take only half damage, it instead takes no damage if it succeeds on the saving throw",
                Classes = new string[] { DnDClass.paladin }
            };
            Spells.Add(circleOfPower.Name, circleOfPower);

            Spell clairvoyance = new Spell
            {
                Source = sourceTitle,
                Name = "Clairvoyance",
                SpellLv = SpellLv.third,
                School = SchoolOfMagic.divination,
                CastingTime = "10 " + StringTime.minutes,
                Range = Range.mile,
                Verbal = true,
                Somatic = true,
                Materials = "a focus worth at least 100 gp, either a jeweled horn for hearing or a glass eye for seeing",
                SpellCost =100 ,
                Duration = DndTime.concentration + "10 " + StringTime.minutes,
                Concentration = true,
                Description = "You create an invisible sensor within range in a location familiar to you (a place you have visited or seen before) or in an obvious location that is unfamiliar to you (such as behind a door, around a corner, or in a grove of trees). The sensor remains in place for the duration, and it can’t be attacked or otherwise interacted with. When you cast the spell, you choose seeing or hearing. You can use the chosen sense through the sensor as if you were in its space. As your action, you can switch between seeing and hearing. A creature that can see the sensor (such as a creature benefiting from see invisibility or truesight) sees a luminous, intangible orb about the size of your fist.",
                Classes = new string[] { DnDClass.bard, DnDClass.cleric, DnDClass.sorcerer, DnDClass.wizard }
            };
            Spells.Add(clairvoyance.Name, clairvoyance);

            Spell clone = new Spell
            {
                Source = sourceTitle,
                Name = "Clone",
                SpellLv = SpellLv.eighth,
                School = SchoolOfMagic.necromancy,
                CastingTime = StringTime.hour,
                Range = Range.touch,
                Verbal = true,
                Somatic = true,
                Materials = "a diamond worth at least 1,000 gp and at least 1 cubic inch of flesh of the creature that is to be cloned, which the spell consumes, and a vessel worth at least 2,000 gp that has a sealable lid and is large enough to hold a Medium creature, such as a huge urn, coffin, mud-filled cyst in the ground, or crystal container filled with salt water",
                SpellCost = 3000,
                Duration = DndTime.instantaneous,
                Description = "This spell grows an inert duplicate of a living creature as a safeguard against death. This clone forms inside a sealed vessel and grows to full size and maturity after 120 days; you can also choose to have the clone be a younger version of the same creature. It remains inert and endures indefinitely, as long as its vessel remains undisturbed. At any time after the clone matures, if the original creature dies, its soul transfers to the clone, provided that the soul is free and willing to return. The clone is physically identical to the original and has the same personality, memories, and abilities, but none of the original’s equipment. The original creature’s physical remains, if they still exist, become inert and can’t thereafter be restored to life, since the creature’s soul is elsewhere.",
                Classes = new string[] { DnDClass.wizard }
            };
            Spells.Add(clone.Name, clone);

            Spell cloudOfDaggers = new Spell
            {
                Source = sourceTitle,
                Name = "Cloud of Daggers",
                SpellLv = SpellLv.second,
                School = SchoolOfMagic.conjuration,
                CastingTime = DndTime.action,
                Range = "60 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a silver of glass",
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "You fill the air with spinning daggers in a cube 5 feet on each side, centered on a point you choose within range. A creature takes 4d4 slashing damage when it enters the spell’s area for the first time on a turn or starts its turn there. At Higher Levels. When you cast this spell using a spell slot of 3rd level or higher, the damage increases by 2d4 for each slot level above 2nd.",
                Classes = new string[] { DnDClass.bard, DnDClass.sorcerer, DnDClass.warlock, DnDClass.wizard  },
                DamageTypes = new string[] { DamageType.slashing }
            };
            Spells.Add(cloudOfDaggers.Name, cloudOfDaggers);

            Spell cloudkill = new Spell
            {
                Source = sourceTitle,
                Name = "Cloudkill",
                SpellLv = SpellLv.fifth,
                School = SchoolOfMagic.conjuration,
                CastingTime = DndTime.action,
                Range = "120 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.concentration + "10 " + StringTime.minutes,
                Concentration = true,
                Description = "You create a 20-foot-radius sphere of poisonous, yellowgreen fog centered on a point you choose within range. The fog spreads around corners. It lasts for the duration or until strong wind disperses the fog, ending the spell. Its area is heavily obscured. When a creature enters the spell’s area for the first time on a turn or starts its turn there, that creature must make a Constitution saving throw. The creature takes 5d8 poison damage on a failed save, or half as much damage on a successful one. Creatures are affected even if they hold their breath or don’t need to breathe. The fog moves 10 feet away from you at the start of each of your turns, rolling along the surface of the ground. The vapors, being heavier than air, sink to the lowest level of the land, even pouring down openings. At Higher Levels. When you cast this spell using a spell slot of 6th level or higher, the damage increases by 1d8 for each slot level above 5th.",
                Classes = new string[] { DnDClass.sorcerer, DnDClass.wizard },
                SavingThrows = new string[] { SavingThrows.constitution },
                DamageTypes = new string[] { DamageType.poison }
            };
            Spells.Add(cloudkill.Name, cloudkill);

            Spell colorSpray = new Spell
            {
                Source = sourceTitle,
                Name = "Color Spray",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.illusion,
                CastingTime = DndTime.action,
                Range = Range.self + ", 15" + Range.footCone,
                Verbal = true,
                Somatic = true,
                Materials = "a pinch of powder or sand that is colored red, yellow, and blue",
                Duration = DndTime.round,
                Description = "A dazzling array of flashing, colored light springs from your hand. Roll 6d10; the total is how many hit points of creatures this spell can effect. Creatures in a 15-foot cone originating from you are affected in ascending order of their current hit points (ignoring unconscious creatures and creatures that can’t see). Starting with the creature that has the lowest current hit points, each creature affected by this spell is blinded until the spell ends. Subtract each creature’s hit points from the total before moving on to the creature with the next lowest hit points. A creature’s hit points must be equal to or less than the remaining total for that creature to be affected.",
                Classes = new string[] { },
                Conditions = new string[] { Conditions.blinded }
            };
            Spells.Add(colorSpray.Name, colorSpray);

            Spell command = new Spell
            {
                Source = sourceTitle,
                Name = "Command",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.enchantment,
                CastingTime = DndTime.round,
                Range = "60 " + Range.footCone,
                Verbal = true,
                Duration = DndTime.round,
                Description = "You speak a one-word command to a creature you can see within range. The target must succeed on a Wisdom saving throw or follow the command on its next turn. The spell has no effect if the target is undead, if it doesn’t understand your language, or if your command is directly harmful to it. Some typical commands and their effects follow. You might issue a command other than one described here. If you do so, the DM determines how the target behaves. If the target can’t follow your command, the spell ends. Approach. The target moves toward you by the shortest and most direct route, ending its turn if it moves within 5 feet of you. Drop. The target drops whatever it is holding and then ends its turn. Flee. The target spends its turn moving away from you by the fastest available means. Grovel. The target falls prone and then ends its turn. Halt. The target doesn’t move and takes no actions. A flying creature stays aloft, provided that it is able to do so. If it must move to stay aloft, it flies the minimum distance needed to remain in the air. At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, you can affect one additional creature for each slot level above 1st. The creatures must be within 30 feet of each other when you target them.",
                Classes = new string[] { },
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.wisdom },
                Conditions = new string[] { Conditions.prone }
            };
            Spells.Add(command.Name, command);

            Spell commune = new Spell
            {
                Source = sourceTitle,
                Name = "Commune",
                SpellLv = SpellLv.fifth,
                School = SchoolOfMagic.divination,
                CastingTime = StringTime.minute,
                Range = Range.self,
                Verbal = true,
                Somatic = true,
                Materials = "incense and a vial of holy or unholy water",
                Duration = StringTime.minute,
                Description = "You contact your deity or a divine proxy and ask up to three questions that can be answered with a yes or no. You must ask your questions before the spell ends. You receive a correct answer for each question. Divine beings aren’t necessarily omniscient, so you might receive “unclear” as an answer if a question pertains to information that lies beyond the deity’s knowledge. In a case where a one-word answer could be misleading or contrary to the deity’s interests, the DM might offer a short phrase as an answer instead. If you cast the spell two or more times before finishing your next long rest, there is a cumulative 25 percent chance for each casting after the first that you get no answer. The DM m akes this roll in secret.",
                Classes = new string[] { }
            };
            Spells.Add(commune.Name, commune);

            Spell communeWithNature = new Spell
            {
                Source = sourceTitle,
                Name = "Commune with Nature",
                SpellLv = SpellLv.fifth,
                School = SchoolOfMagic.divination,
                CastingTime = StringTime.minute,
                Range = Range.self,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.instantaneous,
                Description = "You briefly become one with nature and gain knowledge of the surrounding territory. In the outdoors, the spell gives you knowledge of the land within 3 miles of you. In caves and other natural underground settings, the radius is limited to 300 feet. The spell doesn’t function where nature has been replaced by construction, such as in dungeons and towns. You instantly gain knowledge of up to three facts of your choice about any of the following subjects as they relate to the area: - terrain and bodies of water - - prevalent plants, minerals, animals, or peoples - - pow erful celestials, fey, fiends, elementals, or undead - - influence from other planes of existence - - buildings - For example, you could determine the location of powerful undead in the area, the location of major sources of safe drinking water, and the location of any nearby towns.",
                Classes = new string[] { },
                SingleTarget = true,
            };
            Spells.Add(communeWithNature.Name, communeWithNature);

            Spell compelledDuel = new Spell
            {
                Source = sourceTitle,
                Name = "Compelled Duel",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.enchantment,
                CastingTime = DndTime.bounusAction,
                Range = "30 " + Range.feet,
                Verbal = true,
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "You attempt to compel a creature into a duel. One creature that you can see within range must make a Wisdom saving throw. On a failed save, the creature is drawn to you, com pelled by your divine demand. For the duration, it has disadvantage on attack rolls against creatures other than you, and must make a Wisdom saving throw each time it attempts to move to a space that is more than 30 feet away from you; if it succeeds on this saving throw, this spell doesn’t restrict the target’s movement for that turn. The spell ends if you attack any other creature, if you cast a spell that targets a hostile creature other than the target, if a creature friendly to you damages the target or casts a harmful spell on it, or if you end your turn more than 30 feet away from the target.",
                Classes = new string[] { },
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.wisdom }
            };
            Spells.Add(compelledDuel.Name, compelledDuel);

            Spell comprehendLanguages = new Spell
            {
                Source = sourceTitle,
                Name = "Comprehend Languages",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.divination,
                Ritual = true,
                CastingTime = DndTime.action,
                Range = Range.self,
                Verbal = true,
                Somatic = true,
                Materials = "a pinch of soot and salt",
                Duration = StringTime.hour,
                Description = "For the duration, you understand the literal meaning of any spoken language that you hear. You also understand any written language that you see, but you must be touching the surface on which the words are written. It takes about 1 minute to read one page of text. This spell doesn’t decode secret messages in a text or a glyph, such as an arcane sigil, that isn’t part of a written language.",
                Classes = new string[] { }
            };
            Spells.Add(comprehendLanguages.Name, comprehendLanguages);

            Spell compulsion = new Spell
            {
                Source = sourceTitle,
                Name = "Compulsion",
                SpellLv = SpellLv.fourth,
                School = SchoolOfMagic.enchantment,
                CastingTime = DndTime.action,
                Range = "30 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "Creatures of your choice that you can see within range and that can hear you must make a Wisdom saving throw. A target automatically succeeds on this saving throw if it can’t be charmed. On a failed save, a target is affected by this spell. Until the spell ends, you can use a bonus action on each of your turns to designate a direction that is horizontal to you. Each affected target must use as much of its movement as possible to move in that direction on its next turn. It can take its action before it moves. After moving in this way, it can make another Wisdom saving to try to end the effect. A target isn’t compelled to move into an obviously deadly hazard, such as a fire or pit, but it will provoke opportunity attacks to move in the designated direction.",
                Classes = new string[] { },
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.wisdom }
            };
            Spells.Add(compulsion.Name, compulsion);

            Spell coneOfCold = new Spell
            {
                Source = sourceTitle,
                Name = "Cone of Cold",
                SpellLv = SpellLv.fifth,
                School = SchoolOfMagic.evocation,
                CastingTime = DndTime.action,
                Range = Range.self + ", 60" + Range.footCone,
                Verbal = true,
                Somatic = true,
                Materials = "a small crystal or glass cone",
                Duration = DndTime.instantaneous,
                Description = "A blast of cold air erupts from your hands. Each creature in a 60-foot cone must make a Constitution saving throw. A creature takes 8d8 cold damage on a failed save, or half as much damage on a successful one. A creature killed by this spell becomes a frozen statue until it thaws. At Higher Levels. When you cast this spell using a spell slot of 6th level or higher, the damage increases by 1d8 for each slot level above 5th.",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.constitution },
                DamageTypes = new string[] { DamageType.cold }
            };
            Spells.Add(coneOfCold.Name, coneOfCold);

            Spell confusion = new Spell
            {
                Source = sourceTitle,
                Name = "Confusion",
                SpellLv = SpellLv.fourth,
                School = SchoolOfMagic.enchantment,
                CastingTime = DndTime.action,
                Range = "90 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "three nut shells",
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "This spell assaults and twists creatures' minds, spawning delusions and provoking uncontrolled action. Each creature in a 10-foot-radius sphere centered on a point you choose within range must succeed on a Wisdom saving throw when you cast this spell or be affected by it. An affected target can’t take reactions and must roll a d10 at the start of each of its turns to determine its behavior for that turn. ~d10 Behavior~ ~1 The creature uses all its movement to move in a random direction. To determine the direction, roll a d8 and assign a direction to each die face. The creature doesn’t take an action this turn. ~2-6 The creature doesn’t move or take actions this turn. ~7-8 The creature uses its action to make a melee attack against a randomly determined creature within its reach. If there is no creature within its reach, the creature does nothing this turn. ~9-10 The creature can act and move normally~ At the end of each of its turns, an affected target can make a Wisdom saving throw. If it succeeds, this effect ends for that target. At Higher Levels. When you cast this spell using a spell slot of 5th level or higher, the radius of the sphere increases by 5 feet for each slot level above 4th.",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.wisdom }
            };
            Spells.Add(confusion.Name, confusion);

            Spell conjureAnimals = new Spell
            {
                Source = sourceTitle,
                Name = "Conjure Animals",
                SpellLv = SpellLv.third,
                School = SchoolOfMagic.conjuration,
                CastingTime = DndTime.action,
                Range = "60 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.concentration + StringTime.hour,
                Concentration = true,
                Description = "You summon fey spirits that take the form of beasts and appear in unoccupied spaces that you can see within range. Choose one of the following options for what appears: - One beast of challenge rating 2 or lower - - Two beasts of challenge rating 1 or lower - - Four beasts of challenge rating 1/2 or lower - - Eight beasts of challenge rating 1/4 or lower - Each beast is also considered fey, and it disappears when it drops to 0 hit points or when the spell ends. The summoned creatures are friendly to you and your companions. Roll initiative for the summoned creatures as a group, which has its own turns. They obey any verbal commands that you issue to them (no action required by you). If you don’t issue any commands to them, they defend themselves from hostile creatures, but otherwise take no actions. The DM has the creatures’ statistics. At Higher Levels. When you cast this spell using certain higher-level spell slots, you choose one of the summoning options above, and more creatures appear: twice as many with a 5th-level slot, three times as many with a 7th-level slot, and four times as many with a 9th-level slot.",
                Classes = new string[] { }
            };
            Spells.Add(conjureAnimals.Name, conjureAnimals);

            Spell conjureBarrage = new Spell
            {
                Source = sourceTitle,
                Name = "Conjure Barrage",
                SpellLv = SpellLv.third,
                School = SchoolOfMagic.conjuration,
                CastingTime = DndTime.action,
                Range = Range.self + ", 60" + Range.footCone,
                Verbal = true,
                Somatic = true,
                Materials = "one piece of ammunition or a thrown weapon",
                Duration = DndTime.instantaneous,
                Description = "You throw a nonmagical weapon or fire a piece of nonmagical ammunition into the air to create a cone of identical weapons that shoot forward and then disappear. Each creature in a 60-foot cone must succeed on a Dexterity saving throw. A creature takes 3d8 damage on a failed save, or half as much damage on a successful one. The damage type is the same as that of the weapon or ammunition used as a component.",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.dexterity },
                DamageTypes = new string[] { DamageType.bludgeoning, DamageType.slashing, DamageType.piercing }
            };
            Spells.Add(conjureBarrage.Name, conjureBarrage);

            Spell conjureCelestial = new Spell
            {
                Source = sourceTitle,
                Name = "Conjure Celestial",
                SpellLv = SpellLv.seventh,
                School = SchoolOfMagic.conjuration,
                CastingTime = StringTime.minute,
                Range = "90 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.concentration + StringTime.hour,
                Concentration = true,
                Description = "You summon a celestial of challenge rating 4 or lower, which appears in an unoccupied space that you can see within range. The celestial disappears when it drops to 0 hit points or when the spell ends. The celestial is friendly to you and your companions for the duration. Roll initiative for the celestial, which has its own turns. It obeys any verbal commands that you issue to it (no action required by you), as long as they don’t violate its alignment. If you don’t issue any commands to the celestial, it defends itself from hostile creatures but otherwise takes no actions. The DM has the celestial’s statistics. At Higher Levels. When you cast this spell using a 9th-level spell slot, you summon a celestial of challenge rating 5 or lower.",
                Classes = new string[] { }
            };
            Spells.Add(conjureCelestial.Name, conjureCelestial);

            Spell conjureElemental = new Spell
            {
                Source = sourceTitle,
                Name = "Conjure Elemental",
                SpellLv = SpellLv.fifth,
                School = SchoolOfMagic.conjuration,
                CastingTime = StringTime.minute,
                Range = "90 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "burning incense for air, soft clay for earth, sulfur and phosphorus for fire, or water and sand for water",
                Duration = DndTime.concentration + StringTime.hour,
                Concentration = true,
                Description = "You call forth an elemental servant. Choose an area of air, earth, fire, or water that fills a 10-foot cube within range. An elemental of challenge rating 5 or lower appropriate to the area you chose appears in an unoccupied space within 10 feet of it. For example, a fire elemental emerges from a bonfire, and an earth elemental rises up from the ground. The elemental disappears when it drops to 0 hit points or when the spell ends. The elemental is friendly to you and your companions for the duration. Roll initiative for the elemental, which has its own turns. It obeys any verbal comm ands that you issue to it (no action required by you). If you don’t issue any commands to the elemental, it defends itself from hostile creatures but otherwise takes no actions. If your concentration is broken, the elemental doesn’t disappear. Instead, you lose control of the elemental, it becomes hostile toward you and your companions, and it might attack. An uncontrolled elemental can’t be dismissed by you, and it disappears 1 hour after you summoned it. The DM has the elemental’s statistics. At Higher Levels. When you cast this spell using a spell slot of 6th level or higher, the challenge rating increases by 1 for each slot level above 5th.",
                Classes = new string[] { },
            };
            Spells.Add(conjureElemental.Name, conjureElemental);

            Spell conjureFey = new Spell
            {
                Source = sourceTitle,
                Name = "Conjure Fey",
                SpellLv = SpellLv.sixth,
                School = SchoolOfMagic.conjuration,
                CastingTime = StringTime.minute,
                Range = "90 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.concentration + StringTime.hour,
                Concentration = true,
                Description = "You summon a fey creature of challenge rating 6 or lower, or a fey spirit that takes the form of a beast of challenge rating 6 or lower. It appears in an unoccupied space that you can see within range. The fey creature disappears when it drops to 0 hit points or when the spell ends. The fey creature is friendly to you and your companions for the duration. Roll initiative for the creature, which has its own turns. It obeys any verbal commands that you issue to it (no action required by you), as long as they don't violate its alignment. If you don’t issue any commands to the fey creature, it defends itself from hostile creatures but otherwise takes no actions. If your concentration is broken, the fey creature doesn’t disappear. Instead, you lose control of the fey creature, it becomes hostile toward you and your companions, and it might attack. An uncontrolled fey creature can't be dismissed by you, and it disappears 1 hour after you summoned it. The DM has the fey creature’s statistics. At Higher Levels. When you cast this spell using a spell slot of 7th level or higher, the challenge rating increases by 1 for each slot level above 6th.",
                Classes = new string[] { },
            };
            Spells.Add(conjureFey.Name, conjureFey);

            Spell conjureMinorElementala = new Spell
            {
                Source = sourceTitle,
                Name = "Conjure Minor Elementals",
                SpellLv = SpellLv.fourth,
                School = SchoolOfMagic.conjuration,
                CastingTime = StringTime.minute,
                Range = "90 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.concentration + StringTime.hour,
                Concentration = true,
                Description = "You summon elementals that appear in unoccupied spaces that you can see within range. You choose one the following options for what appears: - One elemental of challenge rating 2 or lower - - Two elementals o f challenge rating 1 or lower - - Four elementals of challenge rating 1/2 or lower - - Eight elementals of challenge rating 1/4 or lower. - An elemental summoned by this spell disappears when it drops to 0 hit points or when the spell ends. The summoned creatures are friendly to you and your companions. Roll initiative for the summoned creatures as a group, which has its ow n turns. They obey any verbal commands that you issue to them (no action required by you). If you don’t issue any commands to them, they defend themselves from hostile creatures, but otherwise take no actions. The DM has the creatures' statistics. At Higher Levels. When you cast this spell using certain higher-level spell slots, you choose one of the summoning options above, and m ore creatures appear: twice as many with a 6th-level slot and three times as many with an 8th-level slot.",
                Classes = new string[] { },
            };
            Spells.Add(conjureMinorElementala.Name, conjureMinorElementala);

            Spell conjureVolley = new Spell
            {
                Source = sourceTitle,
                Name = "Conjure Volley",
                SpellLv = SpellLv.fifth,
                School = SchoolOfMagic.conjuration,
                CastingTime = DndTime.action,
                Range = "150 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "one piece of ammunition or one throwing weapon",
                Duration = DndTime.instantaneous,
                Description = "You fire a piece of nonmagical ammunition from a ranged weapon or throw a nonmagical weapon into the air and choose a point within range. Hundreds of duplicates of the ammunition or weapon fall in a volley from above and then disappear. Each creature in a 40-foot-radius. 20-foot-high cylinder centered on that point must make a Dexterity saving throw. A creature takes 8d8 damage on a failed save, or half as much damage on a successful one. The damage type is the same as that of the ammunition or weapon.",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.dexterity },
                DamageTypes = new string[] { DamageType.bludgeoning, DamageType.slashing, DamageType.piercing }
            };
            Spells.Add(conjureVolley.Name, conjureVolley);

            Spell conjureWoodlandBeings = new Spell
            {
                Source = sourceTitle,
                Name = "Conjure Woodland Beings",
                SpellLv = SpellLv.fourth,
                School = SchoolOfMagic.conjuration,
                CastingTime = DndTime.action,
                Range = "60 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "one holly berry per creature summoned",
                Duration = DndTime.concentration + StringTime.hour,
                Concentration = true,
                Description = "You summon fey creatures that appear in unoccupied spaces that you can see within range. Choose one of the following options for what appears: - One fey creature of challenge rating 2 or lower - - Two fey creatures of challenge rating 1 or lower - - Four fey creatures of challenge rating 1/2 or lower - - Eight fey creatures of challenge rating 1/4 or lower - A summoned creature disappears when it drops to 0 hit points or when the spell ends. The summoned creatures are friendly to you and your companions. Roll initiative for the summoned creatures as a group, which have their own turns. They obey any verbal commands that you issue to them (no action required by you). If you don't issue any commands to them, they defend themselves from hostile creatures, but otherwise take no actions. The DM has the creatures’ statistics. At Higher Levels. When you cast this spell using certain higher-level spell slots, you choose one of the summoning options above, and more creatures appear: twice as many with a 6th-level slot and three times as many with an 8th-level slot.",
                Classes = new string[] { },
            };
            Spells.Add(conjureWoodlandBeings.Name, conjureWoodlandBeings);

            Spell contactOtherPlane = new Spell
            {
                Source = sourceTitle,
                Name = "Contact Other Plane",
                SpellLv = SpellLv.fifth,
                School = SchoolOfMagic.divination,
                Ritual = true,
                CastingTime = StringTime.minute,
                Range = Range.self,
                Verbal = true,
                Duration = StringTime.minute,
                Description = "You mentally contact a demigod, the spirit of a long-dead sage, or some other mysterious entity from another plane. Contacting this extraplanar intelligence can strain or even break your mind. When you cast this spell, make a DC 15 Intelligence saving throw. On a failure, you take 6d6 psychic damage and are insane until you finish a long rest. While insane, you can’t take actions, can’t understand what other creatures say, can’t read, and speak only in gibberish. A greater restoration spell cast on you ends this effect. On a successful save, you can ask the entity up to five questions. You must ask your questions before the spell ends. The DM answers each question with one word, such as “yes,” “no,” “maybe,” “never,” “irrelevant,” or “unclear” (if the entity doesn’t know the answer to the question). If a one-word answer would be misleading, the DM might instead offer a short phrase as an answer.",
                Classes = new string[] { }
            };
            Spells.Add(contactOtherPlane.Name, contactOtherPlane);

            Spell contagion = new Spell
            {
                Source = sourceTitle,
                Name = "Contagion",
                SpellLv = SpellLv.fifth,
                School = SchoolOfMagic.necromancy,
                CastingTime = DndTime.action,
                Range = Range.touch,
                Verbal = true,
                Somatic = true,
                Duration = "7 " + StringTime.days,
                Description = "Your touch inflicts disease. Make a melee spell attack against a creature within your reach. On a hit, you afflict the creature with a disease of your choice from any of the ones described below. At the end of each of the target’s turns, it must make a Constitution saving throw. After failing three of these saving throws, the disease’s effects last for the duration, and the creature stops making these saves. After succeeding on three of these saving throws, the creature recovers from the disease, and the spell ends. Since this spell induces a natural disease in its target, any effect that removes a disease or otherwise ameliorates a disease’s effects apply to it. - Blinding Sickness. Pain grips the creature’s mind, and its eyes turn milky white. The creature has disadvantage on Wisdom checks and Wisdom saving throws and is blinded. - - Filth Fever. A raging fever sw eeps through the creature’s body. The creature has disadvantage on Strength checks, Strength saving throws, and attack rolls that use Strength. - - Flesh Rot. The creature’s flesh decays. The creature has disadvantage on Charisma checks and vulnerability to all damage. - - Mindfire. The creature’s mind becom es feverish. The creature has disadvantage on Intelligence checks and Intelligence saving throws, and the creature behaves as if under the effects of the confusion spell during combat. - Seizure. The creature is overcom e with shaking. The creature has disadvantage on Dexterity checks, Dexterity saving throws, and attack rolls that use Dexterity. - - Slimy Doom . The creature begins to bleed uncontrollably. The creature has disadvantage on Constitution checks and Constitution saving throws. In addition, whenever the creature takes damage, it is stunned until the end of its next turn. -",
                Classes = new string[] { },
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.melee, SavingThrows.constitution },
                Conditions = new string[] { Conditions.blinded, Conditions.stunned }
            };
            Spells.Add(contagion.Name, contagion);

            Spell contingency = new Spell
            {
                Source = sourceTitle,
                Name = "Contingency",  
                SpellLv = SpellLv.sixth,
                School = SchoolOfMagic.evocation,
                CastingTime = "10 " + StringTime.minutes,
                Range = Range.self,
                Verbal = true,
                Somatic = true,
                Materials = "a statuette of yourself carved from ivory and decorated with gems worth at least 1,500gp",
                SpellCost = 1500,
                Duration = "10 " + StringTime.days,
                Description = "Choose a spell of 5th level or lower that you can cast, that has a casting time of 1 action, and that can target you. You cast that spell—called the contingent spell—as part of casting contingency, expending spell slots for both, but the contingent spell doesn't come into effect. Instead, it takes effect when a certain circumstance occurs. You describe that circumstance when you cast the two spells. For example, a contingency cast with water breathing might stipulate that water breathing comes into effect when you are engulfed in water or a similar liquid. The contingent spell takes effect immediately after the circumstance is met for the first time, whether or not you want it to. and then contingency ends. The contingent spell takes effect only on you, even if it can normally target others. You can use only one contingency spell at a time. If you cast this spell again, the effect of another contingency spell on you ends. Also, contingency ends on you if its material component is ever not on your person.",
                Classes = new string[] { },
            };
            Spells.Add(contingency.Name, contingency);

            Spell continualFlame = new Spell
            {
                Source = sourceTitle,
                Name = "Continual Flame",
                SpellLv = SpellLv.second,
                School = SchoolOfMagic.evocation,
                Ritual = true,
                CastingTime = DndTime.action,
                Range = Range.touch,
                Verbal = true,
                Somatic = true,
                Materials = "ruby dust worth 50gp, which the spells comsumes",
                SpellCost = 50,
                Duration = DndTime.untilDispelled,
                Description = "A flame, equivalent in brightness to a torch, springs forth from an object that you touch. The effect looks like a regular flame, but it creates no heat and doesn’t use oxygen. A continual flame can be covered or hidden but not smothered or quenched.",
                Classes = new string[] { },
                SingleTarget = true
            };
            Spells.Add(continualFlame.Name, continualFlame);

            Spell controlWater = new Spell
            {
                Source = sourceTitle,
                Name = "Control Water",
                SpellLv = SpellLv.fourth,
                School = SchoolOfMagic.transmutation,
                CastingTime = DndTime.action,
                Range = "300 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a drop of water and a pinch of dust",
                Duration = DndTime.concentration + "10 " + StringTime.minutes,
                Concentration = true,
                Description = "Until the spell ends, you control any freestanding water inside an area you choose that is a cube up to 100 feet on a side. You can choose from any of the following effects when you cast this spell. As an action on your turn, you can repeat the same effect or choose a different one. - Flood. You cause the water level of all standing water in the area to rise by as much as 20 feet. If the area includes a shore, the flooding water spills over onto dry land. If you choose an area in a large body of water, you instead create a 20-foot tall wave that travels from one side of the area to the other and then crashes down. Any Huge or smaller vehicles in the wave’s path are carried with it to the other side. Any Huge or smaller vehicles struck by the wave have a 25 percent chance of capsizing. The water level remains elevated until the spell ends or you choose a different effect. If this effect produced a wave, the wave repeats on the start of your next turn while the flood effect lasts. - - Part Water. You cause water in the area to move apart and create a trench. The trench extends across the spell’s area, and the separated water forms a wall to either side. The trench remains until the spell ends or you choose a different effect. The water then slowly fills in the trench over the course of the next round until the normal water level is restored. - - Redirect Flow. You cause flowing water in the area to move in a direction you choose, even if the water has to flow over obstacles, up walls, or in other unlikely directions. The water in the area moves as you direct it, but once it moves beyond the spell’s area, it resumes its flow based on the terrain conditions. The water continues to move in the direction you chose until the spell ends or you choose a different effect. - - Whirlpool. This effect requires a body of water at least 50 feet square and 25 feet deep. You cause a whirlpool to form in the center of the area. The whirlpool forms a vortex that is 5 feet wide at the base, up to 50 feet wide at the top, and 25 feet tall. Any creature or object in the water and within 25 feet of the vortex is pulled 10 feet toward it. A creature can swim away from the vortex by making a Strength (Athletics) check against your spell save DC. When a creature enters the vortex for the first time on a turn or starts its turn there, it must make a Strength saving throw. On a failed save, the creature takes 2d8 bludgeoning damage and is caught in the vortex until the spell ends. On a successful save, the creature takes half damage, and isn’t caught in the vortex. A creature caught in the vortex can use its action to try to swim away from the vortex as described above, but has disadvantage on the Strength (Athletics) check to do so. The first time each turn that an object enters the vortex, the object takes 2d8 bludgeoning damage; this damage occurs each round it remains in the vortex.",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.strength },
                DamageTypes = new string[] { DamageType.bludgeoning }
            };
            Spells.Add(controlWater.Name, controlWater);

            Spell controlWeather = new Spell
            {
                Source = sourceTitle,
                Name = "Control Weater",
                SpellLv = SpellLv.eighth,
                School = SchoolOfMagic.transmutation,
                CastingTime = "10 " + StringTime.minutes,
                Range = Range.self + ", 5" + Range.mileRadius,
                Verbal = true,
                Somatic = true,
                Materials = "burning incense and bits of earth and wood mixed in water",
                Duration = DndTime.concentration + "8 " + StringTime.hours,
                Concentration = true,
                Description = "You take control of the weather within 5 miles of you for the duration. You must be outdoors to cast this spell. Moving to a place where you don’t have a clear path to the sky ends the spell early. When you cast the spell, you change the current weather conditions, which are determined by the DM based on the climate and season. You can change precipitation, temperature, and wind. It takes 1d4 x 10 minutes for the new conditions to take effect. Once they do so, you can change the conditions again. W en the spell ends, the weather gradually returns to normal. When you change the weather conditions, find a current condition on the following tables and change its stage by one, up or down. When changing the wind, you can change its direction. ~Precipitation~ - 1 Clear - - 2 Light clouds - - 3 Overcast or ground fog - - 4 Rain, hail, or snow - - 5 Torrential rain, driving hail, or blizzard - ~Temperature~ - 1 Unbearable heat - - 2 Hot - - 3 Warm - - 4 Cool - - 5 Cold - - 6 Arctic cold - ~Wind~ - 1 Calm - - 2 Moderate wind - - 3 Strong wind - - 4 Gale - - 5 Storm -",
                Classes = new string[] { }
            };
            Spells.Add(controlWeather.Name, controlWeather);

            Spell cordonOfArrows = new Spell
            {
                Source = sourceTitle,
                Name = "Cordon of Arrows",
                SpellLv = SpellLv.second,
                School = SchoolOfMagic.transmutation,
                CastingTime = DndTime.action,
                Range = "5 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "four or more arrows or bolts",
                Duration = "8 " + StringTime.hours,
                Description = "You plant four pieces of nonmagical ammunition— arrows or crossbow bolts—in the ground within range and lay magic upon them to protect an area. Until the spell ends, whenever a creature other than you comes within 30 feet of the ammunition for the first time on a turn or ends its turn there, one piece of ammunition flies up to strike it. The creature must succeed on a Dexterity saving throw or take 1d6 piercing damage. The piece of ammunition is then destroyed. The spell ends when no ammunition remains. When you cast this spell, you can designate any creatures you choose, and the spell ignores them. At Higher Levels. When you cast this spell using a spell slot of 3rd level or higher, the amount of ammunition that can be affected increases by two for each slot level above 2nd.",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.dexterity },
                DamageTypes = new string[] { DamageType.piercing }
            };
            Spells.Add(cordonOfArrows.Name, cordonOfArrows);

            Spell counterSpell = new Spell
            {
                Source = sourceTitle,
                Name = "Counter Spell",
                SpellLv = SpellLv.third,
                School = SchoolOfMagic.abjuration,
                CastingTime = DndTime.reaction + ", which you take when you see a creature within 60 feet of you casting a spell",
                Range = "60 " + Range.feet,
                Somatic = true,
                Duration = DndTime.instantaneous,
                Description = "You attempt to interrupt a creature in the process of casting a spell. If the creature is casting a spell of 3rd level or lower, its spell fails and has no effect. If it is casting a spell of 4th level or higher, make an ability check using your spellcasting ability. The DC equals 10 + the spell’s level. On a success, the creature’s spell fails and has no effect. At Higher Levels. When you cast this spell using a spell slot of 4th level or higher, the interrupted spell has no effect if its level is less than or equal to the level of the spell slot you used.",
                Classes = new string[] { },
                SingleTarget = true
            };
            Spells.Add(counterSpell.Name, counterSpell);

            Spell createFoodAndWater = new Spell
            {
                Source = sourceTitle,
                Name = "Create Food and Water",
                SpellLv = SpellLv.third,
                School = SchoolOfMagic.conjuration,
                CastingTime = DndTime.action,
                Range = "30 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.instantaneous,
                Description = "You create 45 pounds of food and 30 gallons of water on the ground or in containers within range, enough to sustain up to fifteen humanoids or five steeds for 24 hours. The food is bland but nourishing, and spoils if uneaten after 24 hours. The water is clean and doesn’t go bad.",
                Classes = new string[] { }
            };
            Spells.Add(createFoodAndWater.Name, createFoodAndWater);

            Spell createOrDestroyWater = new Spell
            {
                Source = sourceTitle,
                Name = "Create or Destroy Water",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.transmutation,
                CastingTime = DndTime.action,
                Range = "30 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a drop of water if creating water or a few grains of sand if destroying it",
                Duration = DndTime.instantaneous,
                Description = "You either create or destroy water ~ Create Water. You create up to 10 gallons of clean water within range in an open container. Alternatively, the water falls as rain in a 30-foot cube within range, extinguishing exposed flames in the area. ~ ~ Destroy Water. You destroy up to 10 gallons of water in an open container within range. Alternatively, you destroy fog in a 30-foot cube within range. ~ At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, you create or destroy 10 additional gallons of water, or the size of the cube increases by 5 feet, for each slot level above 1st.",
                Classes = new string[] { }
            };
            Spells.Add(createOrDestroyWater.Name, createOrDestroyWater);

            Spell createUndead = new Spell
            {
                Source = sourceTitle,
                Name = "Create Undead",
                SpellLv = SpellLv.sixth,
                School = SchoolOfMagic.necromancy,
                CastingTime = StringTime.minute,
                Range = "10 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "one clay pot filled with grave dirt. one clay pot filled with brackish water, and one 150gp black onyx stone for each corpse",
                SpellCost = 150,
                Duration = DndTime.instantaneous,
                Concentration = true,
                Description = "You can cast this spell only at night. Choose up to three corpses of Medium or Small humanoids within range. Each corpse becomes a ghoul under your control. (The DM has game statistics for these creatures.) As a bonus action on each of your turns, you can mentally command any creature you animated with this spell if the creature is within 120 feet of you (if you control multiple creatures, you can command any or all of them at the same time, issuing the same command to each one). You decide what action the creature will take and where it will move during its next turn, or you can issue a general command, such as to guard a particular chamber or corridor. If you issue no commands, the creature only defends itself against hostile creatures. Once given an order, the creature continues to follow it until its task is complete. The creature is under your control for 24 hours, after which it stops obeying any command you have given it. To maintain control of the creature for another 24 hours, you must cast this spell on the creature before the current 24-hour period ends. This use of the spell reasserts your control over up to three creatures you have animated with this spell, rather than animating new ones. At Higher Levels. W en you cast this spell using a 7th-level spell slot, you can animate or reassert control over four ghouls. When you cast this spell using an 8th-level spell slot, you can animate or reassert control over five ghouls or two ghasts or wights. When you cast this spell using a 9th-level spell slot, you can animate or reassert control over six ghouls, three ghasts or wights, or two mummies.",
                Classes = new string[] { }
            };
            Spells.Add(createUndead.Name, createUndead);

            Spell creation = new Spell
            {
                Source = sourceTitle,
                Name = "Creation",
                SpellLv = SpellLv.fifth,
                School = SchoolOfMagic.illusion,
                CastingTime = StringTime.minute,
                Range = "30 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a tiny pieve of matter of the same type of the item you plan to create",
                Duration = DndTime.special,
                Description = "You pull wisps of shadow material from the Shadowfell to create a nonliving object of vegetable matter within range: soft goods, rope, wood, or something similar. You can also use this spell to create mineral objects such as stone, crystal, or metal. The object created must be no larger than a 5-foot cube, and the object must be of a form and material that you have seen before. The duration depends on the object’s material. If the object is composed of multiple materials, use the shortest duration. - Vegetable matter 1 day - - Stone or crystal 12 hours - - Precious metals 1 hour - - Gems 10 minutes - - Adamantine or mithral 1 minute - Using any material created by this spell as another spell’s material component causes that spell to fail. At Higher Levels. When you cast this spell using a spell slot of 6th level or higher, the cube increases by 5 feet for each slot level above 5th.",
                Classes = new string[] { }
            };
            Spells.Add(creation.Name, creation);

            Spell crownOfMadness = new Spell
            {
                Source = sourceTitle,
                Name = "Crown of Madness",
                SpellLv = SpellLv.second,
                School = SchoolOfMagic.enchantment,
                CastingTime = DndTime.action,
                Range = "120 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "One humanoid of your choice that you can see within range must succeed on a Wisdom saving throw or become charmed by you for the duration. While the target is charmed in this way, a twisted crown of jagged iron appears on its head, and a madness glows in its eyes. The charmed target must use its action before moving on each of its turns to make a melee attack against a creature other than itself that you mentally choose. The target can act normally on its turn if you choose no creature or if none are within its reach. On your subsequent turns, you must use your action to maintain control over the target, or the spell ends. Also, the target can make a Wisdom saving throw at the end of each of its turns. On a success, the spell ends.",
                Classes = new string[] { },
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.wisdom },
                Conditions = new string[] { Conditions.charmed }
            };
            Spells.Add(crownOfMadness.Name, crownOfMadness);

            Spell crusadersMantle = new Spell
            {
                Source = sourceTitle,
                Name = "Crusader's Mantle",
                SpellLv = SpellLv.third,
                School = SchoolOfMagic.evocation,
                CastingTime = DndTime.action,
                Range = Range.self,
                Verbal = true,
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "Holy power radiates from you in an aura with a 30-foot radius, awakening boldness in friendly creatures. Until the spell ends, the aura moves with you, centered on you. While in the aura, each nonhostile creature in the aura (including you) deals an extra 1d4 radiant damage when it hits with a weapon attack.",
                Classes = new string[] { },
                DamageTypes = new string[] { DamageType.radiant }
            };
            Spells.Add(crusadersMantle.Name, crusadersMantle);

            Spell cureWounds = new Spell
            {
                Source = sourceTitle,
                Name = "Cure Wounds",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.evocation,
                CastingTime = DndTime.action    ,
                Range = Range.touch,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.instantaneous,
                Description = "A creature you touch regains a number of hit points equal to 1d8 + your spellcasting ability modifier. This spell has no effect on undead or constructs. At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, the healing increases by 1d8 for each slot level above 1st.",
                Classes = new string[] { },
                SingleTarget = true
            };
            Spells.Add(cureWounds.Name, cureWounds);

            #endregion

            #region D

            Spell dancingLights = new Spell
            {
                Source = sourceTitle,
                Name = "Dancing Lights",
                SpellLv = SpellLv.cantrip,
                School = SchoolOfMagic.evocation,
                CastingTime = DndTime.action,
                Range = "120 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a bit of phosphorus or wychwood, or a glowworm",
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "You create up to four torch-sized lights within range, making them appear as torches, lanterns, or glowing orbs that hover in the air for the duration. You can also combine the four lights into one glowing vaguely humanoid form of Medium size. Whichever form you choose, each light sheds dim light in a 10-foot radius. As a bonus action on your turn, you can move the lights up to 60 feet to a new spot within range. A light must be within 20 feet of another light created by this spell, and a light winks out if it exceeds the spell’s range.",
                Classes = new string[] { }
            };
            Spells.Add(dancingLights.Name, dancingLights);

            Spell darkness = new Spell
            {
                Source = sourceTitle,
                Name = "Darkness",
                SpellLv = SpellLv.second,
                School = SchoolOfMagic.evocation,
                CastingTime = DndTime.action,
                Range = "60 " + Range.feet,
                Verbal = true,
                Materials = "bat fur and a drop of pitch or piece of coal",
                Duration = DndTime.concentration + "10 " + StringTime.minutes,
                Concentration = true,
                Description = "Magical darkness spreads from a point you choose within range to fill a 15-foot-radius sphere for the duration. The darkness spreads around corners. A creature with darkvision can’t see through this darkness, and nonmagical light can’t illuminate it. If the point you choose is on an object you are holding or one that isn’t being worn or carried, the darkness emanates from the object and moves with it. Completely covering the source of the darkness with an opaque object, such as a bowl or a helm, blocks the darkness. If any of this spell’s area overlaps with an area of light created by a spell of 2nd level or lower, the spell that created the light is dispelled.",
                Classes = new string[] { }
            };
            Spells.Add(darkness.Name, darkness);

            Spell daylight = new Spell
            {
                Source = sourceTitle,
                Name = "Daylight",
                SpellLv = SpellLv.third,
                School = SchoolOfMagic.evocation,
                CastingTime = DndTime.action,
                Range = "60 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = StringTime.hour,
                Concentration = true,
                Description = "A 60-foot-radius sphere of light spreads out from a point you choose within range. The sphere is bright light and sheds dim light for an additional 60 feet. If you chose a point on an object you are holding or one that isn’t being worn or carried, the light shines from the object and moves with it. Completely covering the affected object with an opaque object, such as a bowl or a helm, blocks the light. If any of this spell’s area overlaps with an area of darkness created by a spell of 3rd level or lower, the spell that created the darkness is dispelled.",
                Classes = new string[] { }
            };
            Spells.Add(daylight.Name, daylight);

            Spell deathWard = new Spell
            {
                Source = sourceTitle,
                Name = "Death Ward",
                SpellLv = SpellLv.fourth,
                School = SchoolOfMagic.abjuration,
                CastingTime = DndTime.action,
                Range = Range.touch,
                Verbal = true,
                Somatic = true,
                Duration = "8 " + StringTime.hours,
                Description = "You touch a creature and grant it a measure of protection from death. The first time the target would drop to 0 hit points as a result of taking damage, the target instead drops to 1 hit point, and the spell ends. If the spell is still in effect when the target is subjected to an effect that would kill it instantaneously without dealing damage, that effect is instead negated against the target, and the spell ends.",
                Classes = new string[] { },
                SingleTarget = true
            };
            Spells.Add(deathWard.Name, deathWard);

            Spell delayedBlastFireball = new Spell
            {
                Source = sourceTitle,
                Name = "Delayed Blast Fireball",
                SpellLv = SpellLv.seventh,
                School = SchoolOfMagic.evocation, 
                CastingTime = DndTime.action,
                Range = "150 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a tiny ball of bat guano and sulfur",
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "A beam of yellow light flashes from your pointing finger, then condenses to linger at a chosen point within range as a glowing bead for the duration. When the spell ends, either because your concentration is broken or because you decide to end it, the bead blossoms with a low roar into an explosion of flame that spreads around corners. Each creature in a 20-foot-radius sphere centered on that point must make a Dexterity saving throw. A creature takes fire damage equal to the total accumulated damage on a failed save, or half as much damage on a successful one. The spell’s base damage is 12d6. If at the end of your turn the bead has not yet detonated, the damage increases by 1d6. If the glowing bead is touched before the interval has expired, the creature touching it must make a Dexterity saving throw. On a failed save, the spell ends immediately, causing the bead to erupt in flame. On a successful save, the creature can throw the bead up to 40 feet. When it strikes a creature or a solid object, the spell ends, and the bead explodes. The fire dam ages objects in the area and ignites flammable objects that aren’t being worn or carried. At Higher Levels. When you cast this spell using a spell slot of 8th level or higher, the base damage increases by 1d6 for each slot level above 7th.",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.dexterity },
                DamageTypes = new string[] { DamageType.fire }
            };
            Spells.Add(delayedBlastFireball.Name, delayedBlastFireball);

            Spell demiplane = new Spell
            {
                Source = sourceTitle,
                Name = "Demiplane",
                SpellLv = SpellLv.eighth,
                School = SchoolOfMagic.conjuration,
                CastingTime = DndTime.action,
                Range = "60 " + Range.feet,
                Somatic = true,
                Duration = StringTime.hour,
                Description = "You create a shadowy door on a flat solid surface that you can see within range. The door is large enough to allow Medium creatures to pass through unhindered. When opened, the door leads to a demiplane that appears to be an empty room 30 feet in each dimension, made of wood or stone. When the spell ends, the door disappears, and any creatures or objects inside the demiplane remain trapped there, as the door also disappears from the other side. Each time you cast this spell, you can create a new demiplane, or have the shadowy door connect to a demiplane you created with a previous casting of this spell. Additionally, if you know the nature and contents of a demiplane created by a casting of this spell by another creature, you can have the shadowy door connect to its demiplane instead.",
                Classes = new string[] { },
            };
            Spells.Add(demiplane.Name, demiplane);

            Spell destructiveWave = new Spell
            {
                Source = sourceTitle,
                Name = "Destructive Wave",
                SpellLv = SpellLv.fifth,
                School = SchoolOfMagic.evocation,
                CastingTime = DndTime.action,
                Range = Range.self + ", 30" + Range.footRadius,
                Verbal = true,
                Duration = DndTime.instantaneous,
                Description = "You strike the ground, creating a burst of divine energy that ripples outward from you. Each creature you choose within 30 feet of you must succeed on a Constitution saving throw or take 5d6 thunder damage, as well as 5d6 radiant or necrotic damage (your choice), and be knocked prone. A creature that succeeds on its saving throw takes half as much damage and isn’t knocked prone.",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.constitution },
                DamageTypes = new string[] { DamageType.thunder, DamageType.radiant, DamageType.necrotic },
                Conditions = new string[] { Conditions.prone }
            };
            Spells.Add(destructiveWave.Name, destructiveWave);

            Spell detectEvilAndGood = new Spell
            {
                Source = sourceTitle,
                Name = "Detect Evil and Good",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.divination,
                CastingTime = DndTime.action,
                Range = Range.self,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.concentration + "10 " + StringTime.minutes,
                Concentration = true,
                Description = "For the duration, you know if there is an aberration, celestial, elemental, fey, fiend, or undead within 30 feet of you, as well as where the creature is located. Similarly, you know if there is a place or object within 30 feet of you that has been magically consecrated or desecrated. The spell can penetrate most barriers, but it is blocked by 1 foot of stone, 1 inch o f common metal, a thin sheet of lead, or 3 feet of wood or dirt.",
                Classes = new string[] { },
            };
            Spells.Add(detectEvilAndGood.Name, detectEvilAndGood);

            Spell detectMagic = new Spell
            {
                Source = sourceTitle,
                Name = "Detect Magic",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.divination,
                Ritual = true,
                CastingTime = DndTime.action,
                Range = Range.self,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.concentration + "10 " + StringTime.minutes,
                Concentration = true,
                Description = "For the duration, you sense the presence of magic within 30 feet of you. If you sense magic in this way, you can use your action to see a faint aura around any visible creature or object in the area that bears magic, and you learn its school of magic, if any. The spell can penetrate most barriers, but it is blocked by 1 foot of stone, 1 inch of common metal, a thin sheet of lead, or 3 feet of wood or dirt.",
                Classes = new string[] { },
            };
            Spells.Add(detectMagic.Name, detectMagic);

            Spell detectPoisonAndDisease = new Spell
            {
                Source = sourceTitle,
                Name = "Detect Poison and Disease",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.divination,
                Ritual = true,
                CastingTime = DndTime.action,
                Range = Range.self,
                Verbal = true,
                Somatic = true,
                Materials = "a yew leaf",
                Duration = DndTime.concentration + "10 " + StringTime.minutes,
                Concentration = true,
                Description = "For the duration, you can sense the presence and location of poisons, poisonous creatures, and diseases within 30 feet of you. You also identify the kind of poison, poisonous creature, or disease in each case. The spell can penetrate most barriers, but it is blocked by 1 foot of stone, 1 inch of common metal, a thin sheet of lead, or 3 feet of wood or dirt.",
                Classes = new string[] { },
            };
            Spells.Add(detectPoisonAndDisease.Name, detectPoisonAndDisease);

            Spell detectThoughts = new Spell
            {
                Source = sourceTitle,
                Name = "Detect Thoughts",
                SpellLv = SpellLv.second,
                School = SchoolOfMagic.divination,
                CastingTime = DndTime.action,
                Range = Range.self,
                Verbal = true,
                Somatic = true,
                Materials = "a copper piece",
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "For the duration, you can read the thoughts of certain creatures. When you cast the spell and as your action on each turn until the spell ends, you can focus your mind on any one creature that you can see within 30 feet of you. If the creature you choose has an Intelligence of 3 or lower or doesn’t speak any language, the creature is unaffected. You initially learn the surface thoughts of the creature—what is most on its mind in that moment. As an action, you can either shift your attention to another creature’s thoughts or attempt to probe deeper into the same creature’s mind. If you probe deeper, the target must make a Wisdom saving throw. If it fails, you gain insight into its reasoning (if any), its emotional state, and something that loom s large in its mind (such as something it worries over, loves, or hates). If it succeeds, the spell ends. Either way, the target knows that you are probing into its mind, and unless you shift your attention to another creature’s thoughts, the creature can use its action on its turn to make an Intelligence check contested by your Intelligence check; if it succeeds, the spell ends. Questions verbally directed at the target creature naturally shape the course of its thoughts, so this spell is particularly effective as part of an interrogation. You can also use this spell to detect the presence of thinking creatures you can’t see. When you cast the spell or as your action during the duration, you can search for thoughts within 30 feet of you. The spell can penetrate barriers, but 2 feet of rock, 2 inches of any metal other than lead, or a thin sheet of lead blocks you. You can’t detect a creature with an Intelligence of 3 or lower or one that doesn’t speak any language. Once you detect the presence of a creature in this way, you can read its thoughts for the rest of the duration as described above, even if you can’t see it, but it must still be within range.",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.wisdom },
            };
            Spells.Add(detectThoughts.Name, detectThoughts);

            Spell dimensionDoor = new Spell
            {
                Source = sourceTitle,
                Name = "Dimension Door",
                SpellLv = SpellLv.fourth,
                School = SchoolOfMagic.conjuration,
                CastingTime = DndTime.action,
                Range = "500 " + Range.feet,
                Verbal = true,
                Duration = DndTime.instantaneous,
                Description = "You teleport yourself from your current location to any other spot within range. You arrive at exactly the spot desired. It can be a place you can see, one you can visualize, or one you can describe by stating distance and direction, such as “200 feet straight downward” or “upward to the northwest at a 45-degree angle, 300 feet.” You can bring along objects as long as their weight doesn’t exceed what you can carry. You can also bring one willing creature of your size or smaller who is carrying gear up to its carrying capacity. The creature must be within 5 feet of you when you cast this spell. If you would arrive in a place already occupied by an object or a creature, you and any creature traveling with you each take 4d6 force damage, and the spell fails to teleport you.",
                Classes = new string[] { },
            };
            Spells.Add(dimensionDoor.Name, dimensionDoor);

            Spell disguiseSelf = new Spell
            {
                Source = sourceTitle,
                Name = "Disguise Self",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.illusion,
                CastingTime = DndTime.action,
                Range = Range.self,
                Verbal = true,
                Somatic = true,
                Duration = StringTime.hour,
                Description = "You make yourself—including your clothing, armor, weapons, and other belongings on your person—look different until the spell ends or until you use your action to dismiss it. You can seem 1 foot shorter or taller and can appear thin, fat, or in between. You can’t change your body type, so you must adopt a form that has the same basic arrangement of limbs. Otherwise, the extent of the illusion is up to you. The changes wrought by this spell fail to hold up to physical inspection. For example, if you use this spell to add a hat to your outfit, objects pass through the hat, and anyone who touches it would feel nothing or would feel your head and hair. If you use this spell to appear thinner than you are, the hand of someone who reaches out to touch you would bump into you while it was seemingly still in midair. To discern that you are disguised, a creature can use its action to inspect your appearance and must succeed on an Intelligence (Investigation) check against your spell save DC.",
                Classes = new string[] { }
            };
            Spells.Add(disguiseSelf.Name, disguiseSelf);

            Spell disintegrate = new Spell
            {
                Source = sourceTitle,
                Name = "Disintegrate",
                SpellLv = SpellLv.sixth,
                School = SchoolOfMagic.transmutation,
                CastingTime = DndTime.action,
                Range = "60 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a lodestone and a pinch of dust",
                Duration = DndTime.instantaneous,
                Description = "A thin green ray springs from your pointing finger to a target that you can see within range. The target can be a creature, an object, or a creation of magical force, such as the wall created by wall of force. A creature targeted by this spell must make a Dexterity saving throw. On a failed save, the target takes 10d6 + 40 force damage. If this damage reduces the target to 0 hit points, it is disintegrated. A disintegrated creature and everything it is wearing and carrying, except magic items, are reduced to a pile of fine gray dust. The creature can be restored to life only by means of a true resurrection or a wish spell. This spell automatically disintegrates a Large or smaller nonmagical object or a creation of magical force. If the target is a Huge or larger object or creation of force, this spell disintegrates a 10-foot-cube portion of it. A magic item is unaffected by this spell. At Higher Levels. When you cast this spell using a spell slot of 7th level or higher, the damage increases by 3d6 for each slot level above 6th.",
                Classes = new string[] { },
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.dexterity },
                DamageTypes = new string[] { DamageType.force },
            };
            Spells.Add(disintegrate.Name, disintegrate);

            Spell dispelEvilAndGood = new Spell
            {
                Source = sourceTitle,
                Name = "Dispel Evil and Good",
                SpellLv = SpellLv.fifth,
                School = SchoolOfMagic.abjuration,
                CastingTime = DndTime.action,
                Range = Range.self,
                Verbal = true,
                Somatic = true,
                Materials = "holy water or powdered silver and iron",
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "Shimmering energy surrounds and protects you from fey, undead, and creatures originating from beyond the Material Plane. For the duration, celestials, elementals, fey, fiends, and undead have disadvantage on attack rolls against you. You can end the spell early by using either of the following special functions. --Break Enchantment. As your action, you touch a creature you can reach that is charm ed, frightened, or possessed by a celestial, an elemental, a fey, a fiend, or an undead. The creature you touch is no longer charmed, frightened, or possessed by such creatures. --Dismissal. As your action, make a melee spell attack against a celestial, an elemental, a fey, a fiend, or an undead you can reach. On a hit, you attempt to drive the creature back to its home plane. The creature must succeed on a Charisma saving throw or be sent back to its home plane (if it isn't there already). If they aren’t on their home plane, undead are sent to the Shadowfell, and fey are sent to the Feywild.",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.charisma }
            };
            Spells.Add(dispelEvilAndGood.Name, dispelEvilAndGood);

            Spell dispelMagic = new Spell
            {
                Source = sourceTitle,
                Name = "Disple Magic",
                SpellLv = SpellLv.third,
                School = SchoolOfMagic.abjuration,
                CastingTime = DndTime.action,
                Range = "120 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.instantaneous,
                Description = "Choose one creature, object, or magical effect within range. Any spell of 3rd level or lower on the target ends. For each spell of 4th level or higher on the target, make an ability check using your spellcasting ability. The DC equals 10 + the spell’s level. On a successful check, the spell ends. At Higher Levels. When you cast this spell using a spell slot of 4th level or higher, you automatically end the effects of a spell on the target if the spell’s level is equal to or less than the level of the spell slot you used.",
                Classes = new string[] { },
                SingleTarget = true
            };
            Spells.Add(dispelMagic.Name, dispelMagic);

            Spell dissonantWhispers = new Spell
            {
                Source = sourceTitle,
                Name = "Dissonant Whispers",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.enchantment,
                CastingTime = DndTime.action,
                Range = "60 " + Range.feet,
                Verbal = true,
                Duration = DndTime.instantaneous,
                Description = "You whisper a discordant melody that only one creature of your choice within range can hear, wracking it with terrible pain. The target must make a Wisdom saving throw. On a failed save, it takes 3d6 psychic damage and must immediately use its reaction, if available, to move as far as its speed allows away from you. The creature doesn’t move into obviously dangerous ground, such as a fire or a pit. On a successful save, the target takes half as much damage and doesn’t have to move away. A deafened creature automatically succeeds on the save. At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, the damage increases by 1d6 for each slot level above 1st.",
                Classes = new string[] { },
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.wisdom },
                DamageTypes = new string[] { DamageType.psychic }
            };
            Spells.Add(dissonantWhispers.Name, dissonantWhispers);

            Spell divination = new Spell
            {
                Source = sourceTitle,
                Name = "Divination",
                SpellLv = SpellLv.fourth,
                School = SchoolOfMagic.divination,
                Ritual = true,
                CastingTime = DndTime.action,
                Range = Range.self,
                Verbal = true,
                Somatic = true,
                Materials = "incense and a sacrificial offering appropriate to your religion, together worth at least 25gp, which the spell consumes",
                SpellCost = 25,
                Duration = DndTime.instantaneous,
                Description = "Your magic and an offering put you in contact with a god or a god’s servants. You ask a single question concerning a specific goal, event, or activity to occur within 7 days. The DM offers a truthful reply. The reply might be a short phrase, a cryptic rhyme, or an omen. The spell doesn’t take into account any possible circumstances that might change the outcome, such as the casting of additional spells or the loss or gain of a companion. If you cast the spell two or more times before finishing your next long rest, there is a cumulative 25 percent chance for each casting after the first that you get a random reading. The DM makes this roll in secret.",
                Classes = new string[] { }
            };
            Spells.Add(divination.Name, divination);

            Spell divineFavor = new Spell
            {
                Source = sourceTitle,
                Name = "Divine Favor",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.evocation,
                CastingTime = DndTime.bounusAction,
                Range = Range.self,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "Your prayer empowers you with divine radiance. Until the spell ends, your weapon attacks deal an extra 1d4 radiant damage on a hit.",
                Classes = new string[] { },
                DamageTypes = new string[] { DamageType.radiant }
            };
            Spells.Add(divineFavor.Name, divineFavor);

            Spell divineWord = new Spell
            {
                Source = sourceTitle,
                Name = "Divine Word",
                SpellLv = SpellLv.seventh,
                School = SchoolOfMagic.evocation,
                CastingTime = DndTime.bounusAction,
                Range = "30 " + Range.feet,
                Verbal = true,
                Duration = DndTime.instantaneous,
                Description = "You utter a divine word, imbued with the power that shaped the world at the dawn of creation. Choose any number of creatures you can see within range. Each creature that can hear you must make a Charisma saving throw. On a failed save, a creature suffers an effect based on its current hit points: - 50 hit points or fewer: deafened for 1 minute - - 40 hit points or fewer: deafened and blinded for 10 minutes - - 30 hit points or fewer: blinded, deafened, and stunned for 1 hour - - 20 hit points or fewer: killed instantly - Regardless of its current hit points, a celestial, an elemental, a fey, or a fiend that fails its save is forced back to its plane of origin (if it isn’t there already) and can’t return to your current plane for 24 hours by any means short of a wish spell.",
                Classes = new string[] { },
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.charisma },
                Conditions = new string[] { Conditions.deafened, Conditions.blinded, Conditions.stunned }
            };
            Spells.Add(divineWord.Name, divineWord);

            Spell dominateBeast = new Spell
            {
                Source = sourceTitle,
                Name = "Dominate Beast",
                SpellLv = SpellLv.fourth,
                School = SchoolOfMagic.enchantment,
                CastingTime = DndTime.action,
                Range = "60 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "You attempt to beguile a beast that you can see within range. It must succeed on a Wisdom saving throw or be charmed by you for the duration. If you or creatures that are friendly to you are fighting it, it has advantage on the saving throw. While the beast is charmed, you have a telepathic link with it as long as the two of you are on the same plane of existence. You can use this telepathic link to issue commands to the creature while you are conscious (no action required), which it does its best to obey. You can specify a simple and general course of action, such as “Attack that creature,” “Run over there,” or “Fetch that object.” If the creature completes the order and doesn’t receive further direction from you, it defends and preserves itself to the best of its ability. You can use your action to take total and precise control of the target. Until the end of your next turn, the creature takes only the actions you choose, and doesn’t do anything that you don’t allow it to do. During this time, you can also cause the creature to use a reaction, but this requires you to use your own reaction as well. Each time the target takes damage, it makes a new Wisdom saving throw against the spell. If the saving throw succeeds, the spell ends. At Higher Levels. When you cast this spell with a 5th-level spell slot, the duration is concentration, up to 10 minutes. When you use a 6th-level spell slot, the duration is concentration, up to 1 hour. When you use a spell slot of 7th level or higher, the duration is concentration, up to 8 hours.",
                Classes = new string[] { },
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.wisdom },
                Conditions = new string[] { Conditions.charmed }
            };
            Spells.Add(dominateBeast.Name, dominateBeast);

            Spell dominateMonster = new Spell
            {
                Source = sourceTitle,
                Name = "Dominate Monster",
                SpellLv = SpellLv.eighth,
                School = SchoolOfMagic.enchantment,
                CastingTime = DndTime.action,
                Range = "60 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.concentration + StringTime.hour,
                Concentration = true,
                Description = "You attempt to beguile a creature that you can see within range. It must succeed on a Wisdom saving throw or be charmed by you for the duration. If you or creatures that are friendly to you are fighting it, it has advantage on the saving throw. While the creature is charmed, you have a telepathic link with it as long as the two of you are on the same plane of existence. You can use this telepathic link to issue com m ands to the creature while you are conscious (no action required), which it does its best to obey. You can specify a simple and general course of action, such as “Attack that creature,” “Run over there,” or “Fetch that object.” If the creature completes the order and doesn’t receive further direction from you, it defends and preserves itself to the best of its ability. You can use your action to take total and precise control of the target. Until the end of your next turn, the creature takes only the actions you choose, and doesn’t do anything that you don’t allow it to do. During this time, you can also cause the creature to use a reaction, but this requires you to use your own reaction as well. Each time the target takes damage, it makes a new Wisdom saving throw against the spell. If the saving throw succeeds, the spell ends. At Higher Levels. When you cast this spell with a 9th-level spell slot, the duration is concentration, up to 8 hours.",
                Classes = new string[] { },
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.wisdom },
                Conditions = new string[] { Conditions.charmed }
            };
            Spells.Add(dominateMonster.Name, dominateMonster);

            Spell dominatePerson = new Spell
            {
                Source = sourceTitle,
                Name = "Dominate Person",
                SpellLv = SpellLv.fifth,
                School = SchoolOfMagic.enchantment,
                CastingTime = DndTime.action,
                Range = "60 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "You attempt to beguile a humanoid that you can see within range. It must succeed on a Wisdom saving throw or be charmed by you for the duration. If you or creatures that are friendly to you are fighting it, it has advantage on the saving throw. While the target is charmed, you have a telepathic link with it as long as the two of you are on the same plane of existence. You can use this telepathic link to issue commands to the creature while you are conscious (no action required), which it does its best to obey. You can specify a simple and general course of action, such as “Attack that creature,” “Run over there,” or “Fetch that object.” If the creature completes the order and doesn’t receive further direction from you, it defends and preserves itself to the best of its ability. You can use your action to take total and precise control of the target. Until the end of your next turn, the creature takes only the actions you choose, and doesn’t do anything that you don’t allow it to do. During this time you can also cause the creature to use a reaction, but this requires you to use your own reaction as well. Each time the target takes damage, it makes a new Wisdom saving throw against the spell. If the saving throw succeeds, the spell ends. At Higher Levels. When you cast this spell using a 6th-level spell slot, the duration is concentration, up to 10 minutes. When you use a 7th-level spell slot, the duration is concentration, up to 1 hour. When you use a spell slot of 8th level or higher, the duration is concentration, up to 8 hours.",
                Classes = new string[] { },
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.wisdom },
                Conditions = new string[] { Conditions.charmed }
            };
            Spells.Add(dominatePerson.Name, dominatePerson);

            Spell drawmijsInstantSummons = new Spell
            {
                Source = sourceTitle,
                Name = "Drawmij's Instant Summons",
                SpellLv = SpellLv.sixth,
                School = SchoolOfMagic.conjuration,
                Ritual = true,
                CastingTime = StringTime.minute,
                Range = Range.touch,
                Verbal = true,
                Somatic = true,
                Materials = "a sapphire worth 1,000gp",
                SpellCost = 1000,
                Duration = DndTime.untilDispelled,
                Description = "You touch an object weighing 10 pounds or less whose longest dimension is 6 feet or less. The spell leaves an invisible mark on its surface and invisibly inscribes the name of the item on the sapphire you use as the material component. Each time you cast this spell, you must use a different sapphire. At any time thereafter, you can use your action to speak the item’s name and crush the sapphire. The item instantly appears in your hand regardless of physical or planar distances, and the spell ends.",
                Classes = new string[] { },
            };
            Spells.Add(drawmijsInstantSummons.Name, drawmijsInstantSummons);

            Spell dream = new Spell
            {
                Source = sourceTitle,
                Name = "Dream",
                SpellLv = SpellLv.fifth,
                School = SchoolOfMagic.illusion,
                CastingTime = StringTime.minute,
                Range = Range.special,
                Verbal = true,
                Somatic = true,
                Materials = "a handful of sand, a dab of ink, and a writing quill plucked from a sleeping bird",
                Duration = "8 " + StringTime.hours,
                Description = "This spell shapes a creature’s dreams. Choose a creature known to you as the target of this spell. The target must be on the same plane of existence as you. Creatures that don’t sleep, such as elves, can’t be contacted by this spell. You, or a willing creature you touch, enters a trance state, acting as a messenger. While in the trance, the messenger is aware of his or her surroundings, but can’t take actions or move. If the target is asleep, the messenger appears in the target’s dream s and can converse with the target as long as it remains asleep, through the duration of the spell. The messenger can also shape the environment o f the dream, creating landscapes, objects, and other images. The messenger can emerge from the trance at any time, ending the effect of the spell early. The target recalls the dream perfectly upon waking. If the target is awake when you cast the spell, the messenger knows it, and can either end the trance (and the spell) or wait for the target to fall asleep, at which point the messenger appears in the target’s dreams. You can make the messenger appear monstrous and terrifying to the target. If you do, the messenger can deliver a message of no more than ten words and then the target must make a Wisdom saving throw. On a failed save, echoes of the phantasmal monstrosity spawn a nightmare that lasts the duration of the target’s sleep and prevents the target from gaining any benefit from that rest. In addition, when the target wakes up, it takes 3d6 psychic damage. If you have a body part, lock of hair, clipping from a nail, or similar portion of the target’s body, the target makes its saving throw with disadvantage.",
                Classes = new string[] { },
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.wisdom },
                DamageTypes = new string[] { DamageType.psychic }
            };
            Spells.Add(dream.Name, dream);

            Spell druidcraft = new Spell
            {
                Source = sourceTitle,
                Name = "Druidcraft",
                SpellLv = SpellLv.cantrip,
                School = SchoolOfMagic.transmutation,
                CastingTime = DndTime.action,
                Range = "30 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.instantaneous,
                Description = "Whispering to the spirits of nature, you create one of the following effects within range: - You create a tiny, harm less sensory effect that predicts what the weather will be at your location for the next 24 hours. The effect might manifest as a golden orb for clear skies, a cloud for rain, falling snowflakes for snow, and so on. This effect persists for 1 round. - - You instantly make a flower blossom , a seed pod open, or a leaf bud bloom. - - You create an instantaneous, harm less sensory effect, such as falling leaves, a puff of wind, the sound of a small animal, or the faint odor of skunk. The effect must fit in a 5-foot cube. - - You instantly light or snuff out a candle, a torch, or a small campfire. -",
                Classes = new string[] { },
            };
            Spells.Add(druidcraft.Name, druidcraft);

            #endregion

            #region E

            Spell earthquake = new Spell
            {
                Source = sourceTitle,
                Name = "Earthquake",
                SpellLv = SpellLv.eighth,
                School = SchoolOfMagic.evocation,
                CastingTime = DndTime.action,
                Range = "500 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a pinch of dirt, a piece of rock, and a lump of clay",
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "You create a seismic disturbance at a point on the ground that you can see within range. For the duration, an intense tremor rips through the ground in a 100-foot-radius circle centered on that point and shakes creatures and structures in contact with the ground in that area. The ground in the area becomes difficult terrain. Each creature on the ground that is concentrating must make a Constitution saving throw. On a failed save, the creature’s concentration is broken. When you cast this spell and at the end of each turn you spend concentrating on it, each creature on the ground in the area must make a Dexterity saving throw. On a failed save, the creature is knocked prone. This spell can have additional effects depending on the terrain in the area, as determined by the DM. - Fissures. Fissures open throughout the spell’s area at the start of your next turn after you cast the spell. A total of 1d6 such fissures open in locations chosen by the DM. Each is 1d10 x 10 feet deep, 10 feet wide, and extends from one edge of the spell’s area to the opposite side. A creature standing on a spot where a fissure opens must succeed on a Dexterity saving throw or fall in. A creature that successfully saves moves with the fissure’s edge as it opens. A fissure that opens beneath a structure causes it to automatically collapse (see below). - - Structures. The tremor deals 50 bludgeoning damage to any structure in contact with the ground in the area when you cast the spell and at the start of each of your turns until the spell ends. If a structure drops to 0 hit points, it collapses and potentially dam ages nearby creatures. A creature within half the distance of a structure’s height must make a Dexterity saving throw. On a failed save, the creature takes 5d6 bludgeoning damage, is knocked prone, and is buried in the rubble, requiring a DC 20 Strength (Athletics) check as an action to escape. The DM can adjust the DC higher or lower, depending on the nature of the rubble. On a successful save, the creature takes half as much damage and doesn’t fall prone or become buried. -",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.constitution, SavingThrows.dexterity },
                DamageTypes = new string[] { DamageType.bludgeoning },
                Conditions = new string[] { Conditions.prone }
            };
            Spells.Add(earthquake.Name, earthquake);

            Spell eldritchBlast = new Spell
            {
                Source = sourceTitle,
                Name = "Eldritch Blast",
                SpellLv = SpellLv.cantrip,
                School = SchoolOfMagic.evocation,
                CastingTime = DndTime.action,
                Range = "120 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.instantaneous,
                Concentration = true,
                Description = "A beam of crackling energy streaks toward a creature within range. Make a ranged spell attack against the target. On a hit, the target takes 1dlO force damage. The spell creates more than one beam when you reach higher levels: two beams at 5th level, three beams at 11th level, and four beams at 17th level. You can direct the beams at the same target or at different ones. Make a separate attack roll for each beam.",
                Classes = new string[] { },
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.ranged },
                DamageTypes = new string[] { DamageType.force }
            };
            Spells.Add(eldritchBlast.Name, eldritchBlast);

            Spell elementalWeapon = new Spell
            {
                Source = sourceTitle,
                Name = "Elemental Weapon",
                SpellLv = SpellLv.third,
                School = SchoolOfMagic.transmutation,
                CastingTime = DndTime.action,
                Range = Range.touch,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.concentration + StringTime.hour,
                Concentration = true,
                Description = "A nonmagical weapon you touch becomes a magic weapon. Choose one of the following damage types: acid, cold, fire, lightning, or thunder. For the duration, the weapon has a +1 bonus to attack rolls and deals an extra 1d4 damage of the chosen type when it hits. At Higher Levels. When you cast this spell using a spell slot of 5th or 6th level, the bonus to attack rolls increases to +2 and the extra damage increases to 2d4. When you use a spell slot of 7th level or higher, the bonus increases to +3 and the extra damage increases to 3d4.",
                Classes = new string[] { },
                DamageTypes = new string[] { DamageType.acid, DamageType.cold, DamageType.fire, DamageType.lightning, DamageType.thunder }
            };
            Spells.Add(elementalWeapon.Name, elementalWeapon);

            Spell enhanceAbility = new Spell
            {
                Source = sourceTitle,
                Name = "Enhance Ability",
                SpellLv = SpellLv.second,
                School = SchoolOfMagic.transmutation,
                CastingTime = DndTime.action,
                Range = Range.touch,
                Verbal = true,
                Somatic = true,
                Materials = "fur or a feather from a beast",
                Duration = DndTime.concentration + StringTime.hour,
                Concentration = true,
                Description = "You touch a creature and bestow upon it a magical enhancement. Choose one of the following effects; the target gains that effect until the spell ends. - Bear’s Endurance. The target has advantage on Constitution checks. It also gains 2d6 temporary hit points, which are lost when the spell ends. - - Bull’s Strength. The target has advantage on Strength checks, and his or her carrying capacity doubles. - - Cat’s Grace. The target has advantage on Dexterity checks. It also doesn’t take damage from falling 20 feet or less if it isn’t incapacitated. - - Eagle’s Splendor. The target has advantage on Charisma checks. - - Fox’s Cunning. The target has advantage on Intelligence checks. - - Owl’s Wisdom. The target has advantage on Wisdom checks. - At Higher Levels. W hen you cast this spell using a spell slot of 3rd level or higher, you can target one additional creature for each slot level above 2nd.",
                Classes = new string[] { }
            };
            Spells.Add(enhanceAbility.Name, enhanceAbility);

            Spell enlargeReduce = new Spell
            {
                Source = sourceTitle,
                Name = "Enlarge/Reduce",
                SpellLv = SpellLv.second,
                School = SchoolOfMagic.transmutation,
                CastingTime = DndTime.action,
                Range = "30 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a pinch or powdered iron",
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "You cause a creature or an object you can see within range to grow larger or smaller for the duration. Choose either a creature or an object that is neither worn nor carried. If the target is unwilling, it can make a Constitution saving throw. On a success, the spell has no effect. If the target is a creature, everything it is wearing and carrying changes size with it. Any item dropped by an affected creature returns to normal size at once. - Enlarge. The target’s size doubles in all dimensions, and its weight is multiplied by eight. This growth increases its size by one category—from Medium to Large, for example. If there isn’t enough room for the target to double its size, the creature or object attains the maximum possible size in the space available. Until the spell ends, the target also has advantage on Strength checks and Strength saving throws. The target’s weapons also grow to match its new size. While these weapons are enlarged, the target’s attacks with them deal 1d4 extra damage. - - Reduce. The target’s size is halved in all dimensions, and its weight is reduced to one-eighth of normal. This reduction decreases its size by one category—from Medium to Small, for example. Until the spell ends, the target also has disadvantage on Strength checks and Strength saving throws. The target’s weapons also shrink to match its new size. While these weapons are reduced, the target’s attacks with them deal 1d4 less damage (this can’t reduce the damage below 1). -",
                Classes = new string[] { },
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.constitution }
            };
            Spells.Add(enlargeReduce.Name, enlargeReduce);

            Spell ensnaringStrike = new Spell
            {
                Source = sourceTitle,
                Name = "Ensnaring Strike",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.conjuration,
                CastingTime = DndTime.concentration,
                Range = Range.self,
                Verbal = true,
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "The next time you hit a creature with a weapon attack before this spell ends, a writhing mass of thorny vines appears at the point of impact, and the target must succeed on a Strength saving throw or be restrained by the magical vines until the spell ends. A Large or larger creature has advantage on this saving throw. If the target succeeds on the save, the vines shrivel away. While restrained by this spell, the target takes 1d6 piercing damage at the start of each of its turns. A creature restrained by the vines or one that can touch the creature can use its action to make a Strength check against your spell save DC. On a success, the target is freed. At Higher Levels. If you cast this spell using a spell slot of 2nd level or higher, the damage increases by 1d6 for each slot level above 1st.",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.strength },
                DamageTypes = new string[] { DamageType.piercing }
            };
            Spells.Add(ensnaringStrike.Name, ensnaringStrike);

            Spell entagle = new Spell
            {
                Source = sourceTitle,
                Name = "Entangle",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.conjuration,
                CastingTime = DndTime.action,
                Range = "90 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "Grasping weeds and vines sprout from the ground in a 20-foot square starting from a point within range. For the duration, these plants turn the ground in the area into difficult terrain. A creature in the area when you cast the spell must succeed on a Strength saving throw or be restrained by the entangling plants until the spell ends. A creature restrained by the plants can use its action to make a Strength check against your spell save DC. On a success, it frees itself. When the spell ends, the conjured plants wilt away.",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.strength },
                Conditions = new string[] { Conditions.restrained }
            };
            Spells.Add(entagle.Name, entagle);

            Spell enthrall = new Spell
            {
                Source = sourceTitle,
                Name = "Entrhall",
                SpellLv = SpellLv.second,
                School = SchoolOfMagic.enchantment,
                CastingTime = DndTime.action,
                Range = "60 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = StringTime.minute,
                Description = "You weave a distracting string of words, causing creatures of your choice that you can see within range and that can hear you to make a Wisdom saving throw. Any creature that can’t be charmed succeeds on this saving throw automatically, and if you or your companions are fighting a creature, it has advantage on the save. On a failed save, the target has disadvantage on Wisdom (Perception) checks made to perceive any creature other than you until the spell ends or until the target can no longer hear you. The spell ends if you are incapacitated or can no longer speak.",
                Classes = new string[] { },
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.wisdom },
                Conditions = new string[] { Conditions.charmed }
            };
            Spells.Add(enthrall.Name, enthrall);
            
            Spell etherealness = new Spell
            {
                Source = sourceTitle,
                Name = "Etherealness",
                SpellLv = SpellLv.seventh,
                School = SchoolOfMagic.transmutation,
                CastingTime = DndTime.action,
                Range = Range.self,
                Verbal = true,
                Somatic = true,
                Duration = "Up to 8" + StringTime.hours,
                Description = "You step into the border regions of the Ethereal Plane, in the area where it overlaps with your current plane. You remain in the Border Ethereal for the duration or until you use your action to dis iss the spell. During this time, you can move in any direction. If you move up or down, every foot of movement costs an extra foot. You can see and hear the plane you originated from, but everything there looks gray, and you can’t see anything more than 60 feet away. While on the Ethereal Plane, you can only affect and be affected by other creatures on that plane. Creatures that aren't on the Ethereal Plane can’t perceive you and can’t interact with you, unless a special ability or magic has given them the ability to do so. You ignore all objects and effects that aren’t on the Ethereal Plane, allowing you to move through objects you perceive on the plane you originated from. When the spell ends, you immediately return to the plane you originated from in the spot you currently occupy. If you occupy the same spot as a solid object or creature when this happens, you are immediately shunted to the nearest unoccupied space that you can occupy and take force damage equal to twice the number of feet you are moved. This spell has no effect if you cast it while you are on the Ethereal Plane or a plane that doesn’t border it, such as one o f the Outer Planes. At Higher Levels. When you cast this spell using a spell slot of 8th level or higher, you can target up to three willing creatures (including you) for each slot level above 7th. The creatures must be within 10 feet of you when you cast the spell.",
                Classes = new string[] { }
            };
            Spells.Add(etherealness.Name, etherealness);

            Spell evardsBlackTentacles = new Spell
            {
                Source = sourceTitle,
                Name = "Evard's Black Tentacles",
                SpellLv = SpellLv.fourth,
                School = SchoolOfMagic.conjuration,
                CastingTime = DndTime.action,
                Range = "90 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a piece of tentacle from a giant octopus or a giant squid",
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "Squirming, ebony tentacles fill a 20-foot square on ground that you can see within range. For the duration, these tentacles turn the ground in the area into difficult terrain. When a creature enters the affected area for the first time on a turn or starts its turn there, the creature must succeed on a Dexterity saving throw or take 3d6 bludgeoning damage and be restrained by the tentacles until the spell ends. A creature that starts its turn in the area and is already restrained by the tentacles takes 3d6 bludgeoning damage. A creature restrained by the tentacles can use its action to make a Strength or Dexterity check (its choice) against your spell save DC. On a success, it frees itself.",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.dexterity },
                DamageTypes = new string[] { DamageType.bludgeoning },
                Conditions = new string[] { Conditions.restrained }
            };
            Spells.Add(evardsBlackTentacles.Name, evardsBlackTentacles);

            Spell expeditiousRetreat = new Spell
            {
                Source = sourceTitle,
                Name = "Expeditious Retreat",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.transmutation,
                CastingTime = DndTime.bounusAction,
                Range = Range.self,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.concentration + "10 " + StringTime.minutes,
                Concentration = true,
                Description = "This spell allows you to move at an incredible pace. When you cast this spell, and then as a bonus action on each of your turns until the spell ends, you can take the Dash action.",
                Classes = new string[] { }
            };
            Spells.Add(expeditiousRetreat.Name, expeditiousRetreat);

            Spell eyebite = new Spell
            {
                Source = sourceTitle,
                Name = "Eyebite",
                SpellLv = SpellLv.sixth,
                School = SchoolOfMagic.necromancy,
                CastingTime = DndTime.action,
                Range = Range.self,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "For the spell’s duration, your eyes become an inky void imbued with dread power. One creature of your choice within 60 feet of you that you can see must succeed on a Wisdom saving throw or be affected by one of the following effects of your choice for the duration. On each of your turns until the spell ends, you can use your action to target another creature but can’t target a creature again if it has succeeded on a saving throw against this casting of eyebite. - Asleep. The target falls unconscious. It wakes up if it takes any damage or if another creature uses its action to shake the sleeper awake. - - Panicked. The target is frightened of you. On each of its turns, the frightened creature must take the Dash action and move away from you by the safest and shortest available route, unless there is nowhere to move. If the target moves to a place at least 60 feet away from you where it can no longer see you, this effect ends. - - Sickened. The target has disadvantage on attack rolls and ability checks. At the end of each of its turns, it can make another Wisdom saving throw. If it succeeds, the effect ends. -",
                Classes = new string[] { },
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.wisdom },
                Conditions = new string[] { Conditions.frightened }
            };
            Spells.Add(eyebite.Name, eyebite);

            #endregion

            #region F

            Spell fabricate = new Spell
            {
                Source = sourceTitle,
                Name = "Fabricate",
                SpellLv = SpellLv.fourth,
                School = SchoolOfMagic.transmutation,
                CastingTime = "10 " + StringTime.minutes,
                Range = "120 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.instantaneous,
                Description = "You convert raw materials into products of the same material. For example, you can fabricate a wooden bridge from a clump of trees, a rope from a patch of hemp, and clothes from flax or wool. Choose raw materials that you can see within range. You can fabricate a Large or smaller object (contained within a 10-foot cube, or eight connected 5-foot cubes), given a sufficient quantity of raw material. If you are working with metal, stone, or another mineral substance, however, the fabricated object can be no larger than Medium (contained within a single 5-foot cube). The quality of objects made by the spell is commensurate with the quality of the raw materials. Creatures or magic items can’t be created or transmuted by this spell. You also can’t use it to create items that ordinarily require a high degree of craftsmanship, such as jewelry, weapons, glass, or armor, unless you have proficiency with the type of artisan’s tools used to craft such objects.",
                Classes = new string[] { }
            };
            Spells.Add(fabricate.Name, fabricate);

            Spell faerieFire = new Spell
            {
                Source = sourceTitle,
                Name = "Faerie Fire",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.evocation,
                CastingTime = DndTime.action,
                Range = "60 " + Range.feet,
                Verbal = true,
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "Each object in a 20-foot cube within range is outlined in blue, green, or violet light (your choice). Any creature in the area when the spell is cast is also outlined in light if it fails a Dexterity saving throw. For the duration, objects and affected creatures shed dim light in a 10-foot radius. Any attack roll against an affected creature or object has advantage if the attacker can see it, and the affected creature or object can’t benefit from being invisible.",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.dexterity }
            };
            Spells.Add(faerieFire.Name, faerieFire);

            Spell falseLife = new Spell
            {
                Source = sourceTitle,
                Name = "False Life",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.necromancy,
                CastingTime = DndTime.action,
                Range = Range.self,
                Verbal = true,
                Somatic = true,
                Materials = "a small amount of alcohol or distilled spirits",
                Duration = StringTime.hour,
                Description = "Bolstering yourself with a necromantic facsimile of life, you gain 1d4 + 4 temporary hit points for the duration. At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, you gain 5 additional temporary hit points for each slot level above 1st.",
                Classes = new string[] { }
            };
            Spells.Add(falseLife.Name, falseLife);

            Spell fear = new Spell
            {
                Source = sourceTitle,
                Name = "Fear",
                SpellLv = SpellLv.third,
                School = SchoolOfMagic.illusion,
                CastingTime = DndTime.action,
                Range = Range.self + ", 30" + Range.footCone,
                Verbal = true,
                Somatic = true,
                Materials = "a white feather or the heart of a hen",
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "You project a phantasmal image of a creature’s worst fears. Each creature in a 30-foot cone must succeed on a Wisdom saving throw or drop whatever it is holding and become frightened for the duration. While frightened by this spell, a creature must take the Dash action and move away from you by the safest available route on each of its turns, unless there is nowhere to move. If the creature ends its turn in a location where it doesn’t have line of sight to you, the creature can make a Wisdom saving throw. On a successful save, the spell ends for that creature.",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.wisdom },
                Conditions = new string[] { Conditions.frightened }
            };
            Spells.Add(fear.Name, fear);

            Spell featherFall = new Spell
            {
                Source = sourceTitle,
                Name = "Feather Fall",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.transmutation,
                CastingTime = DndTime.reaction + ", which you take when you or a creature within 60 feet of you falls",
                Range = "60 " + Range.feet,
                Verbal = true,
                Materials = "a small feather or piece of down",
                Duration = StringTime.minute,
                Description = "Choose up to five falling creatures within range. A falling creature's rate of descent slow s to 60 feet per round until the spell ends. If the creature lands before the spell ends, it takes no falling damage and can land on its feet, and the spell ends for that creature.",
                Classes = new string[] { },
            };
            Spells.Add(featherFall.Name, featherFall);

            Spell feeblemind = new Spell
            {
                Source = sourceTitle,
                Name = "Feeblemind",
                SpellLv = SpellLv.eighth,
                School = SchoolOfMagic.enchantment,
                CastingTime = DndTime.action,
                Range = "150 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a handful of clay, crystal, glass, or mineral spheres",
                Duration = DndTime.instantaneous,
                Description = "You blast the mind of a creature that you can see within range, attempting to shatter its intellect and personality. The target takes 4d6 psychic damage and must make an Intelligence saving throw. On a failed save, the creature’s Intelligence and Charisma scores become 1. The creature can’t cast spells, activate magic items, understand language, or communicate in any intelligible way. The creature can, however, identify its friends, follow them, and even protect them. At the end of every 30 days, the creature can repeat its saving throw against this spell. If it succeeds on its saving throw, the spell ends. The spell can also be ended by greater restoration, heal, or wish.",
                Classes = new string[] { },
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.intelligence },
                DamageTypes = new string[] { DamageType.psychic }
            };
            Spells.Add(feeblemind.Name, feeblemind);

            Spell feignDeath = new Spell
            {
                Source = sourceTitle,
                Name = "Feign Death",
                SpellLv = SpellLv.third,
                School = SchoolOfMagic.necromancy,
                Ritual = true,
                CastingTime = DndTime.action,
                Range = Range.touch,
                Verbal = true,
                Somatic = true,
                Materials = "a pinch of graveyard dirt",
                Duration = StringTime.hour,
                Description = "You touch a willing creature and put it into a cataleptic state that is indistinguishable from death. For the spell’s duration, or until you use an action to touch the target and dismiss the spell, the target appears dead to all outward inspection and to spells used to determine the target’s status. The target is blinded and incapacitated, and its speed drops to 0. The target has resistance to all damage except psychic damage. If the target is diseased or poisoned when you cast the spell, or becomes diseased or poisoned while under the spell’s effect, the disease and poison have no effect until the spell ends.",
                Classes = new string[] { },
                SingleTarget = true,
                Conditions = new string[] { Conditions.blinded, Conditions.incapacitated }
            };
            Spells.Add(feignDeath.Name, feignDeath);

            Spell findFamiliar = new Spell
            {
                Source = sourceTitle,
                Name = "Find Familiar",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.conjuration,
                Ritual = true,
                CastingTime = StringTime.hour,
                Range = "10 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "10gp worth of charcoal, incense, and herbs that must be consumed by fire in a brass brazier",
                SpellCost = 10,
                Duration = DndTime.instantaneous,
                Description = "You gain the service of a familiar, a spirit that takes an animal form you choose: bat, cat, crab, frog (toad), hawk, lizard, octopus, owl, poisonous snake, fish (quipper), rat, raven, sea horse, spider, or weasel. Appearing in an unoccupied space within range, the familiar has the statistics o f the chosen form, though it is a celestial, fey, or fiend (your choice) instead of a beast. Your familiar acts independently of you, but it always obeys your commands. In combat, it rolls its own initiative and acts on its own turn. A familiar can’t attack, but it can take other actions as normal. When the familiar drops to 0 hit points, it disappears, leaving behind no physical form. It reappears after you cast this spell again While your familiar is within 100 feet of you, you can communicate with it telepathically. Additionally, as an action, you can see through your familiar’s eyes and hear what it hears until the start of your next turn, gaining the benefits of any special senses that the familiar has. During this time, you are deaf and blind with regard to your own senses. As an action, you can temporarily dismiss your familiar. It disappears into a pocket dimension where it awaits your summons. Alternatively, you can dismiss it forever. As an action while it is temporarily dismissed, you can cause it to reappear in any unoccupied space within 30 feet of you. You can’t have m ore than one familiar at a time. If you cast this spell while you already have a familiar, you instead cause it to adopt a new form. Choose one of the forms from the above list. Your familiar transforms into the chosen creature. Finally, when you cast a spell with a range of touch, your familiar can deliver the spell as if it had cast the spell. Your familiar must be within 100 feet of you, and it must use its reaction to deliver the spell when you cast it. If the spell requires an attack roll, you use your attack modifier for the roll.",
                Classes = new string[] { }
            };
            Spells.Add(findFamiliar.Name, findFamiliar);

            Spell findSteed = new Spell
            {
                Source = sourceTitle,
                Name = "Find Steed",
                SpellLv = SpellLv.second,
                School = SchoolOfMagic.conjuration,
                CastingTime = "10 " + StringTime.minutes,
                Range = "30 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.instantaneous,
                Description = "You summon a spirit that assumes the form of an unusually intelligent, strong, and loyal steed, creating a long-lasting bond with it. Appearing in an unoccupied space within range, the steed takes on a form that you choose, such as a warhorse, a pony, a camel, an elk, or a mastiff. (Your DM might allow other animals to be summoned as steeds.) The steed has the statistics of the chosen form, though it is a celestial, fey, or fiend (your choice) instead of its normal type. Additionally, if your steed has an Intelligence of 5 or less, its Intelligence becomes 6, and it gains the ability to understand one language of your choice that you speak. Your steed serves you as a mount, both in combat and out, and you have an instinctive bond with it that allows you to fight as a seam less unit. While mounted on your steed, you can make any spell you cast that targets only you also target your steed. When the steed drops to 0 hit points, it disappears, leaving behind no physical form. You can also dismiss your steed at any time as an action, causing it to disappear. In either case, casting this spell again sum m ons the same steed, restored to its hit point maximum. While your steed is within 1 mile of you, you can communicate with it telepathically. You can’t have more than one steed bonded by this spell at a time. As an action, you can release the steed from its bond at any time, causing it to disappear.",
                Classes = new string[] { },
            };
            Spells.Add(findSteed.Name, findSteed);

            Spell findThePath = new Spell
            {
                Source = sourceTitle,
                Name = "Find the Path",
                SpellLv = SpellLv.sixth,
                School = SchoolOfMagic.divination,
                CastingTime = StringTime.minute,
                Range = Range.self,
                Verbal = true,
                Somatic = true,
                Materials = "a set of divinatory tools -- such as bones, ivory sticks, cards, teeth, or carvd runes-- worth 100gp and an object from the location you wish you find.",
                SpellCost = 100,
                Duration = DndTime.concentration + StringTime.day,
                Concentration = true,
                Description = "This spell allows you to find the shortest, most direct physical route to a specific fixed location that you are familiar with on the same plane of existence. If you name a destination on another plane of existence, a destination that moves (such as a mobile fortress), or a destination that isn’t specific (such as “a green dragon’s lair”), the spell fails. For the duration, as long as you are on the same plane of existence as the destination, you know how far it is and in what direction it lies. While you are traveling there, whenever you are presented with a choice of paths along the way, you automatically determine which path is the shortest and most direct route (but not necessarily the safest route) to the destination.",
                Classes = new string[] { }
            };
            Spells.Add(findThePath.Name, findThePath);

            Spell findTraps = new Spell
            {
                Source = sourceTitle,
                Name = "Find Traps",
                SpellLv = SpellLv.second,
                School = SchoolOfMagic.divination,
                CastingTime = DndTime.action,
                Range = "120 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.instantaneous,
                Description = "You sense the presence of any trap within range that is within line of sight. A trap, for the purpose of this spell, includes anything that would inflict a sudden or unexpected effect you consider harmful or undesirable, which was specifically intended as such by its creator. Thus, the spell would sense an area affected by the alarm spell, a glyph of warding, or a mechanical pit trap, but it would not reveal a natural weakness in the floor, an unstable ceiling, or a hidden sinkhole. This spell merely reveals that a trap is present. You don’t learn the location of each trap, but you do learn the general nature of the danger posed by a trap you sense.",
                Classes = new string[] { }
            };
            Spells.Add(findTraps.Name, findTraps);

            Spell fingerOfDeath = new Spell
            {
                Source = sourceTitle,
                Name = "Finger of Death",
                SpellLv = SpellLv.seventh,
                School = SchoolOfMagic.necromancy,
                CastingTime = DndTime.action,
                Range = "60 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.instantaneous,
                Description = "You send negative energy coursing through a creature that you can see within range, causing it searing pain. The target must make a Constitution saving throw. It takes 7d8 + 30 necrotic damage on a failed save, or half as much damage on a successful one. A humanoid killed by this spell rises at the start of your next turn as a zombie that is permanently under your command, following your verbal orders to the best of its ability",
                Classes = new string[] { },
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.constitution },
                DamageTypes = new string[] { DamageType.necrotic }
            };
            Spells.Add(fingerOfDeath.Name, fingerOfDeath);

            Spell fireball = new Spell
            {
                Source = sourceTitle,
                Name = "Fireball",
                SpellLv = SpellLv.third,
                School = SchoolOfMagic.evocation,
                CastingTime = DndTime.action,
                Range = "150 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a tiny ball or bat guano and sulfur",
                Duration = DndTime.instantaneous,
                Description = "A bright streak flashes from your pointing finger to a point you choose within range and then blossoms with a low roar into an explosion of flame. Each creature in a 20-foot-radius sphere centered on that point must make a Dexterity saving throw. A target takes 8d6 fire damage on a failed save, or half as much damage on a successful one. The fire spreads around corners. It ignites flammable objects in the area that aren't being worn or carried. At Higher Levels. When you cast this spell using a spell slot of 4th level or higher, the damage increases by 1d6 for each slot level above 3rd.",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.dexterity },
                DamageTypes = new string[] { DamageType.fire }

            };
            Spells.Add(fireball.Name, fireball);

            Spell fireBolt = new Spell
            {
                Source = sourceTitle,
                Name = "Fire Bolt",
                SpellLv = SpellLv.cantrip,
                School = SchoolOfMagic.evocation,
                CastingTime = DndTime.action,
                Range = "120 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.instantaneous,
                Description = "You hurl a mote of fire at a creature or object within range. Make a ranged spell attack against the target. On a hit, the target takes 1d10 fire damage. A flammable object hit by this spell ignites if it isn't being worn or carried. This spell’s damage increases by 1d10 when you reach 5th level (2d10), 11th level (3d10), and 17th level (4d10).",
                Classes = new string[] { },
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.ranged },
                DamageTypes = new string[] { DamageType.fire }
            };
            Spells.Add(fireBolt.Name, fireBolt);

            Spell fireShield = new Spell
            {
                Source = sourceTitle,
                Name = "Fire Shield",
                SpellLv = SpellLv.fourth,
                School = SchoolOfMagic.evocation,
                CastingTime = DndTime.action,
                Range = Range.self,
                Verbal = true,
                Somatic = true,
                Materials = "a bit of phosphorus or a firefly",
                Duration = "10 " + StringTime.minutes,
                Description = "Thin and wispy flames wreathe your body for the duration, shedding bright light in a 10-foot radius and dim light for an additional 10 feet. You can end the spell early by using an action to dismiss it. The flames provide you with a warm shield or a chill shield, as you choose. The warm shield grants you resistance to cold damage, and the chill shield grants you resistance to fire damage. In addition, whenever a creature within 5 feet of you hits you with a melee attack, the shield erupts with flame. The attacker takes 2d8 fire damage from a warm shield, or 2d8 cold damage from a cold shield.",
                Classes = new string[] { },
                DamageTypes = new string[] { DamageType.cold, DamageType.fire }
            };
            Spells.Add(fireShield.Name, fireShield);

            Spell fireStorm = new Spell
            {
                Source = sourceTitle,
                Name = "Fire Storm",
                SpellLv = SpellLv.seventh,
                School = SchoolOfMagic.evocation,
                CastingTime = DndTime.action,
                Range = "150 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.instantaneous,
                Description = "A storm made up of sheets of roaring flame appears in a location you choose within range. The area of the storm consists of up to ten 10-foot cubes, which you can arrange as you wish. Each cube must have at least one face adjacent to the face of another cube. Each creature in the area must make a Dexterity saving throw. It takes 7d10 fire damage on a failed save, or half as much damage on a successful one. The fire damages objects in the area and ignites flammable objects that aren't being worn or carried. If you choose, plant life in the area is unaffected by this spell.",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.dexterity },
                DamageTypes = new string[] { DamageType.fire }
            };
            Spells.Add(fireStorm.Name, fireStorm);

            Spell flameBlade = new Spell
            {
                Source = sourceTitle,
                Name = "Flame Blade",
                SpellLv = SpellLv.second,
                School = SchoolOfMagic.evocation,
                CastingTime = DndTime.bounusAction,
                Range = Range.self,
                Verbal = true,
                Somatic = true,
                Materials = "leaf of sumac",
                Duration = DndTime.concentration + "10 " + StringTime.minutes,
                Description = "You evoke a fiery blade in your free hand. The blade is similar in size and shape to a scimitar, and it lasts for the duration. If you let go of the blade, it disappears, but you can evoke the blade again as a bonus action. You can use your action to make a melee spell attack with the fiery blade. On a hit, the target takes 3d6 fire damage. The flaming blade sheds bright light in a 10-foot radius and dim light for an additional 10 feet. At Higher Levels. When you cast this spell using a spell slot of 4th level or higher, the damage increases by 1d6 for every two slot levels above 2nd.",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.melee },
                DamageTypes = new string[] { DamageType.fire }
            };
            Spells.Add(flameBlade.Name, flameBlade);

            Spell flameStrike = new Spell
            {
                Source = sourceTitle,
                Name = "Flame Strike",
                SpellLv = SpellLv.fifth,
                School = SchoolOfMagic.evocation,
                CastingTime = DndTime.action,
                Range = "60 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "pinch of sulfur",
                Duration = DndTime.instantaneous,
                Description = "A vertical column of divine fire roars down from the heavens in a location you specify. Each creature in a 10-foot-radius, 40-foot-high cylinder centered on a point within range must make a Dexterity saving throw. A creature takes 4d6 fire damage and 4d6 radiant damage on a failed save, or half as much damage on a successful one. At Higher Levels. When you cast this spell using a spell slot of 6th level or higher, the fire damage or the radiant damage (your choice) increases by 1d6 for each slot level above 5th.",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.dexterity },
                DamageTypes = new string[] { DamageType.fire, DamageType.radiant }
            };
            Spells.Add(flameStrike.Name, flameStrike);

            Spell flamingSphere = new Spell
            {
                Source = sourceTitle,
                Name = "Flaming Sphere",
                SpellLv = SpellLv.second,
                School = SchoolOfMagic.conjuration,
                CastingTime = DndTime.action,
                Range = "60 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a bit of tallow, a pinch of brimstone, and a dusting of powdered iron",
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "A 5-foot-diameter sphere of fire appears in an unoccupied space of your choice within range and lasts for the duration. Any creature that ends its turn within 5 feet of the sphere must make a Dexterity saving throw. The creature takes 2d6 fire damage on a failed save, or half as much damage on a successful one. As a bonus action, you can move the sphere up to 30 feet. If you ram the sphere into a creature, that creature must make the saving throw against the sphere’s damage, and the sphere stops moving this turn. When you move the sphere, you can direct it over barriers up to 5 feet tall and jump it across pits up to 10 feet wide. The sphere ignites flammable objects not being worn or carried, and it sheds bright light in a 20-foot radius and dim light for an additional 20 feet. At Higher Levels. When you cast this spell using a spell slot of 3rd level or higher, the damage increases by 1d6 for each slot level above 2nd.",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.dexterity },
                DamageTypes = new string[] { DamageType.fire }
            };
            Spells.Add(flamingSphere.Name, flamingSphere);

            Spell fleshToStone = new Spell
            {
                Source = sourceTitle,
                Name = "Flesh to Stone",
                SpellLv = SpellLv.sixth,
                School = SchoolOfMagic.transmutation,
                CastingTime = DndTime.action,
                Range = "60 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a pinch of lime, water, and earth",
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "You attempt to turn one creature that you can see within range into stone. If the target’s body is made of flesh, the creature must make a Constitution saving throw. On a failed save, it is restrained as its flesh begins to harden. On a successful save, the creature isn’t affected. A creature restrained by this spell must make another Constitution saving throw at the end of each of its turns. If it successfully saves against this spell three times, the spell ends. If it fails its saves three times, it is turned to stone and subjected to the petrified condition for the duration. The successes and failures don’t need to be consecutive; keep track of both until the target collects three of a kind. If the creature is physically broken while petrified, it suffers from similar deformities if it reverts to its original state. If you maintain your concentration on this spell for the entire possible duration, the creature is turned to stone until the effect is removed",
                Classes = new string[] { },
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.constitution,  },
                Conditions = new string[] { Conditions.restrained, Conditions.petrified }
            };
            Spells.Add(fleshToStone.Name, fleshToStone);

            Spell fly = new Spell
            {
                Source = sourceTitle,
                Name = "Fly",
                SpellLv = SpellLv.third,
                School = SchoolOfMagic.transmutation,
                CastingTime = DndTime.action,
                Range = Range.touch,
                Verbal = true,
                Somatic = true,
                Materials = "a wing feather from any bird",
                Duration = DndTime.concentration + "10 " + StringTime.minutes,
                Concentration = true,
                Description = "You touch a willing creature. The target gains a flying speed of 60 feet for the duration. When the spell ends, the target falls if it is still aloft, unless it can stop the fall. At Higher Levels. When you cast this spell using a spell slot of 4th level or higher, you can target one additional creature for each slot level above 3rd.",
                Classes = new string[] { },
            };
            Spells.Add(fly.Name, fly);

            Spell fogCloud = new Spell
            {
                Source = sourceTitle,
                Name = "Fog Cloud",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.conjuration,
                CastingTime = DndTime.action,
                Range = "120 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.concentration + StringTime.hour,
                Description = "You create a 20-foot-radius sphere of fog centered on a point within range. The sphere spreads around corners, and its area is heavily obscured. It lasts for the duration or until a wind of moderate or greater speed (at least 10 miles per hour) disperses it. At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, the radius of the fog increases by 20 feet for each slot level above 1st.",
                Classes = new string[] { },
            };
            Spells.Add(fogCloud.Name, fogCloud);

            Spell forbiddance = new Spell
            {
                Source = sourceTitle,
                Name = "Forbiddance",
                SpellLv = SpellLv.sixth,
                School = SchoolOfMagic.abjuration,
                Ritual = true,
                CastingTime = "10 " + StringTime.minutes,
                Range = Range.touch,
                Verbal = true,
                Somatic = true,
                Materials = "a sprinkling of holy water, rare incense, and powdered ruby worth at least 1,000gp",
                SpellCost = 1000,
                Duration = StringTime.day,
                Description = "You create a ward against magical travel that protects up to 40,000 square feet of floor space to a height of 30 feet above the floor. For the duration, creatures can’t teleport into the area or use portals, such as those created by the gate spell, to enter the area. The spell proofs the area against planar travel, and therefore prevents creatures from accessing the area by way of the Astral Plane, Ethereal Plane, Feywild, Shadowfell, or the plane shift spell. In addition, the spell damages types of creatures that you choose when you cast it. Choose one or more of the following: celestials, elementals, fey, fiends, and undead. When a chosen creature enters the spell’s area for the first time on a turn or starts its turn there, the creature takes 5d10 radiant or necrotic damage (your choice when you cast this spell). When you cast this spell, you can designate a password. A creature that speaks the password as it enters the area takes no damage from the spell. The spell’s area can't overlap with the area of another forbiddance spell. If you cast forbiddance every day for 30 days in the same location, the spell lasts until it is dispelled, and the material components are consumed on the last casting.",
                Classes = new string[] { },
                SingleTarget = true,
                DamageTypes = new string[] { DamageType.radiant, DamageType.necrotic }
            };
            Spells.Add(forbiddance.Name, forbiddance);

            Spell forcecage = new Spell
            {
                Source = sourceTitle,
                Name = "Forcecage",
                SpellLv = SpellLv.seventh,
                School = SchoolOfMagic.evocation,
                CastingTime = DndTime.action,
                Range = "100 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "ruby dust worth 1,500gp",
                SpellCost = 1500,
                Duration = StringTime.hour,
                Description = "An immobile, invisible, cube-shaped prison com posed of magical force springs into existence around an area you choose within range. The prison can be a cage or a solid box, as you choose. A prison in the shape of a cage can be up to 20 feet on a side and is made from 1/2-inch diameter bars spaced 1/2 inch apart. A prison in the shape of a box can be up to 10 feet on a side, creating a solid barrier that prevents any matter from passing through it and blocking any spells cast into or out from the area. When you cast the spell, any creature that is completely inside the cage's area is trapped. Creatures only partially within the area, or those too large to fit inside the area, are pushed away from the center of the area until they are completely outside the area. A creature inside the cage can’t leave it by nonmagical means. If the creature tries to use teleportation or interplanar travel to leave the cage, it must first make a Charisma saving throw. On a success, the creature can use that magic to exit the cage. On a failure, the creature can't exit the cage and wastes the use of the spell or effect. The cage also extends into the Ethereal Plane, blocking ethereal travel. This spell can’t be dispelled by dispel magic",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.charisma }
            };
            Spells.Add(forcecage.Name, forcecage);

            Spell foresight = new Spell
            {
                Source = sourceTitle,
                Name = "Foresight",
                SpellLv = SpellLv.nineth,
                School = SchoolOfMagic.divination,
                CastingTime = StringTime.minute,
                Range = Range.touch,
                Verbal = true,
                Somatic = true,
                Materials = "a hummingbird feather",
                Duration = "8 " + StringTime.hours,
                Description = "You touch a willing creature and bestow a limited ability to see into the immediate future. For the duration, the target can’t be surprised and has advantage on attack rolls, ability checks, and saving throws. Additionally, other creatures have disadvantage on attack rolls against the target for the duration. This spell immediately ends if you cast it again before its duration ends",
                Classes = new string[] { }
            };
            Spells.Add(foresight.Name, foresight);

            Spell freedomOfMovement = new Spell
            {
                Source = sourceTitle,
                Name = "Freedom of Movement",
                SpellLv = SpellLv.fourth,
                School = SchoolOfMagic.abjuration,
                CastingTime = DndTime.action,
                Range = Range.touch,
                Verbal = true,
                Somatic = true,
                Materials = "a leather strap, bound around the arm or a similar appendage",
                Duration = StringTime.hour,
                Description = "You touch a willing creature. For the duration, the target’s movement is unaffected by difficult terrain, and spells and other magical effects can neither reduce the target’s speed nor cause the target to be paralyzed or restrained. The target can also spend 5 feet of movement to automatically escape from nonmagical restraints, such as manacles or a creature that has it grappled. Finally, being underwater imposes no penalties on the target's movement or attacks.",
                Classes = new string[] { }
            };
            Spells.Add(freedomOfMovement.Name, freedomOfMovement);

            Spell friends = new Spell
            {
                Source = sourceTitle,
                Name = "Friends",
                SpellLv = SpellLv.cantrip,
                School = SchoolOfMagic.enchantment,
                CastingTime = DndTime.action,
                Range = Range.self,
                Somatic = true,
                Materials = "a small amount of makeup applied to the face as this spell is cast",
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "For the duration, you have advantage on all Charisma checks directed at one creature of your choice that isn’t hostile toward you. When the spell ends, the creature realizes that you used magic to influence its mood and becomes hostile toward you. A creature prone to violence might attack you. Another creature might seek retribution in other ways (at the DM’s discretion), depending on the nature of your interaction with it.",
                Classes = new string[] { }
            };
            Spells.Add(friends.Name, friends);

            #endregion

            #region G

            Spell gaseousForm = new Spell
            {
                Source = sourceTitle,
                Name = "Gaseous Form",
                SpellLv = SpellLv.third,
                School = SchoolOfMagic.transmutation,
                CastingTime = DndTime.action,
                Range = Range.touch,
                Verbal = true,
                Somatic = true,
                Materials = "a bit of gauze and a wisp of smoke",
                Duration = DndTime.concentration + StringTime.hour,
                Concentration = true,
                Description = "You transform a willing creature you touch, along with everything it’s wearing and carrying, into a misty cloud for the duration. The spell ends if the creature drops to 0 hit points. An incorporeal creature isn’t affected. While in this form, the target’s only method of movement is a flying speed of 10 feet. The target can enter and occupy the space of another creature. The target has resistance to nonmagical damage, and it has advantage on Strength, Dexterity, and Constitution saving throws. The target can pass through small holes, narrow openings, and even mere cracks, though it treats liquids as though they w ere solid surfaces. The target can't fall and remains hovering in the air even when stunned or otherwise incapacitated. While in the form of a misty cloud, the target can’t talk or manipulate objects, and any objects it w as carrying or holding can’t be dropped, used, or otherwise interacted with. The target can’t attack or cast spells.",
                Classes = new string[] { }
            };
            Spells.Add(gaseousForm.Name, gaseousForm);

            Spell gate = new Spell
            {
                Source = sourceTitle,
                Name = "Gate",
                SpellLv = SpellLv.nineth,
                School = SchoolOfMagic.conjuration,
                CastingTime = DndTime.action,
                Range = "60 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a diamond worth at least 5,000gp",
                SpellCost = 5000,
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "You conjure a portal linking an unoccupied space you can see within range to a precise location on a different plane of existence. The portal is a circular opening, which you can make 5 to 20 feet in diameter. You can orient the portal in any direction you choose. The portal lasts for the duration. The portal has a front and a back on each plane where it appears. Travel through the portal is possible only by moving through its front. Anything that does so is instantly transported to the other plane, appearing in the unoccupied space nearest to the portal. Deities and other planar rulers can prevent portals created by this spell from opening in their presence or anywhere within their domains. When you cast this spell, you can speak the name of a specific creature (a pseudonym, title, or nickname doesn’t work). If that creature is on a plane other than the one you are on, the portal opens in the named creature’s immediate vicinity and draws the creature through it to the nearest unoccupied space on your side of the portal. You gain no special power over the creature, and it is free to act as the DM deems appropriate. It might leave, attack you, or help you.",
                Classes = new string[] { }
            };
            Spells.Add(gate.Name, gate);

            Spell geas = new Spell
            {
                Source = sourceTitle,
                Name = "Geas",
                SpellLv = SpellLv.fifth,
                School = SchoolOfMagic.enchantment,
                CastingTime = StringTime.minute,
                Range = "60 " + Range.feet,
                Verbal = true,
                Duration = "30 " + StringTime.days,
                Concentration = true,
                Description = "You place a magical command on a creature that you can see within range, forcing it to carry out some service or refrain from some action or course of activity as you decide. If the creature can understand you, it must succeed on a Wisdom saving throw or become charmed by you for the duration. While the creature is charmed by you, it takes 5 d10 psychic damage each time it acts in a manner directly counter to your instructions, but no more than once each day. A creature that can't understand you is unaffected by the spell. You can issue any command you choose, short of an activity that would result in certain death. Should you issue a suicidal command, the spell ends. You can end the spell early by using an action to dismiss it. A remove curse, greater restoration, or wish spell also ends it. At Higher Levels. When you cast this spell using a spell slot of 7th or 8th level, the duration is 1 year. When you cast this spell using a spell slot of 9th level, the spell lasts until it is ended by one of the spells mentioned above.",
                Classes = new string[] { },
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.wisdom },
                DamageTypes = new string[] { DamageType.psychic },
                Conditions = new string[] { Conditions.charmed }
            };
            Spells.Add(geas.Name, geas);

            Spell gentleRepose = new Spell
            {
                Source = sourceTitle,
                Name = "Gentle Repose",
                SpellLv = SpellLv.second,
                School = SchoolOfMagic.necromancy,
                Ritual = true,
                CastingTime = DndTime.action,
                Range = Range.touch,
                Verbal = true,
                Somatic = true,
                Materials = "a pinch of salt and one copper piece placed on each of the corpse’s eyes, which must remain there for the duration",
                Duration = "10 " + StringTime.days,
                Description = "You touch a corpse or other remains. For the duration, the target is protected from decay and can’t become undead. The spell also effectively extends the time limit on raising the target from the dead, since days spent under the influence of this spell don’t count against the time limit of spells such as raise dead.",
                Classes = new string[] { }
            };
            Spells.Add(gentleRepose.Name, gentleRepose);

            Spell giantInsect = new Spell
            {
                Source = sourceTitle,
                Name = "Giant Insect",
                SpellLv = SpellLv.fourth,
                School = SchoolOfMagic.transmutation,
                CastingTime = DndTime.action,
                Range = "30 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.concentration + "10 " + StringTime.minutes,
                Concentration = true,
                Description = "You transform up to ten centipedes, three spiders, five wasps, or one scorpion within range into giant versions of their natural forms for the duration. A centipede becomes a giant centipede, a spider becomes a giant spider, a wasp becomes a giant wasp, and a scorpion becomes a giant scorpion. Each creature obeys your verbal commands, and in combat, they act on your turn each round. The DM has the statistics for these creatures and resolves their actions and movement. A creature remains in its giant size for the duration, until it drops to 0 hit points, or until you use an action to dismiss the effect on it. The DM might allow you to choose different targets. For example, if you transform a bee, its giant version might have the same statistics as a giant wasp.",
                Classes = new string[] { }
            };
            Spells.Add(giantInsect.Name, giantInsect);

            Spell glibness = new Spell
            {
                Source = sourceTitle,
                Name = "Glibness",
                SpellLv = SpellLv.eighth,
                School = SchoolOfMagic.transmutation,
                CastingTime = DndTime.action,
                Range = Range.self,
                Verbal = true,
                Duration = StringTime.hour,
                Concentration = true,
                Description = "Until the spell ends, when you make a Charisma check, you can replace the number you roll with a 15. Additionally, no matter what you say, magic that would determine if you are telling the truth indicates that you are being truthful.",
                Classes = new string[] { },
            };
            Spells.Add(glibness.Name, glibness);

            Spell globalOfInvulnerability = new Spell
            {
                Source = sourceTitle,
                Name = "Global of Invulnerability",
                SpellLv = SpellLv.sixth,
                School = SchoolOfMagic.abjuration,
                CastingTime = DndTime.action,
                Range = Range.self + ", 10" + Range.footRadius,
                Verbal = true,
                Somatic = true,
                Materials = "a glass or crystal bead that shatters when the spell ends",
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "An immobile, faintly shimmering barrier springs into existence in a 10-foot radius around you and remains for the duration. Any spell of 5th level or lower cast from outside the barrier can't affect creatures or objects within it, even if the spell is cast using a higher level spell slot. Such a spell can target creatures and objects within the barrier, but the spell has no effect on them. Similarly, the area within the barrier is excluded from the areas affected by such spells. At Higher Levels. When you cast this spell using a spell slot of 7th level or higher, the barrier blocks spells of one level higher for each slot level above 6th.",
                Classes = new string[] { }
            };
            Spells.Add(globalOfInvulnerability.Name, globalOfInvulnerability);

            Spell glyphOfWarding = new Spell
            {
                Source = sourceTitle,
                Name = "Glyph of Warding",
                SpellLv = SpellLv.third,
                School = SchoolOfMagic.abjuration,
                CastingTime = StringTime.hour,
                Range = Range.touch,
                Verbal = true,
                Somatic = true,
                Materials = "incense and powdered diamond worth at least 200gp which the spell consumes",
                SpellCost = 200,
                Duration = DndTime.untilDispelled,
                Description = "When you cast this spell, you inscribe a glyph that harms other creatures, either upon a surface (such as a table or a section of floor or wall) or within an object that can be closed (such as a book, a scroll, or a treasure chest) to conceal the glyph. If you choose a surface, the glyph can cover an area of the surface no larger than 10 feet in diameter. If you choose an object, that object must remain in its place; if the object is moved more than 10 feet from where you cast this spell, the glyph is broken, and the spell ends without being triggered. The glyph is nearly invisible and requires a successful Intelligence (Investigation) check against your spell save DC to be found. You decide what triggers the glyph when you cast the spell. For glyphs inscribed on a surface, the most typical triggers include touching or standing on the glyph, removing another object covering the glyph, approaching within a certain distance of the glyph, or manipulating the object on which the glyph is inscribed. For glyphs inscribed within an object, the most common triggers include opening that object, approaching within a certain distance of the object, or seeing or reading the glyph. Once a glyph is triggered, this spell ends. You can further refine the trigger so the spell activates only under certain circumstances or according to physical characteristics (such as height or weight), creature kind (for example, the ward could be set to affect aberrations or drow), or alignment. You can also set conditions for creatures that don’t trigger the glyph, such as those who say a certain password. When you inscribe the glyph, choose explosive runes or a spell glyph. - Explosive Runes. When triggered, the glyph erupts with magical energy in a 20-foot-radius sphere centered on the glyph. The sphere spreads around corners. Each creature in the area must make a Dexterity saving throw. A creature takes 5d8 acid, cold, fire, lightning, or thunder damage on a failed saving throw (your choice when you create the glyph), or half as much damage on a successful one. - - Spell Glyph. You can store a prepared spell of 3rd level or lower in the glyph by casting it as part of creating the glyph. The spell must target a single creature or an area. The spell being stored has no immediate effect when cast in this way. When the glyph is triggered, the stored spell is cast. If the spell has a target, it targets the creature that triggered the glyph. If the spell affects an area, the area is centered on that creature. If the spell summons hostile creatures or creates harmful objects or traps, they appear as close as possible to the intruder and attack it. If the spell requires concentration, it lasts until the end of its full duration. - At Higher Levels. When you cast this spell using a spell slot of 4th level or higher, the damage of an explosive runes glyph increases by 1d8 for each slot level above 3rd. If you create a spell glyph, you can store any spell of up to the same level as the slot you use for the glyph of warding.",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.dexterity },
                DamageTypes = new string[] { DamageType.acid, DamageType.cold, DamageType.fire, DamageType.lightning, DamageType.lightning }
            };
            Spells.Add(glyphOfWarding.Name, glyphOfWarding);

            Spell goodberry = new Spell
            {
                Source = sourceTitle,
                Name = "Goodberry",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.transmutation,
                CastingTime = DndTime.action,
                Range = Range.touch,
                Verbal = true,
                Somatic = true,
                Materials = "a sprig of mistletoe",
                Duration = DndTime.instantaneous,
                Description = "Up to ten berries appear in your hand and are infused with magic for the duration. A creature can use its action to eat one berry. Eating a berry restores 1 hit point, and the berry provides enough nourishment to sustain a creature for one day. The berries lose their potency if they have not been consumed within 24 hours of the casting of this spell.",
                Classes = new string[] { }
            };
            Spells.Add(goodberry.Name, goodberry);

            Spell graspingVine = new Spell
            {
                Source = sourceTitle,
                Name = "Grasping Vine",
                SpellLv = SpellLv.fourth,
                School = SchoolOfMagic.conjuration,
                CastingTime = DndTime.bounusAction,
                Range = "30 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "You conjure a vine that sprouts from the ground in an unoccupied space of your choice that you can see within range. When you cast this spell, you can direct the vine to lash out at a creature within 30 feet of it that you can see. That creature must succeed on a Dexterity saving throw or be pulled 20 feet directly toward the vine. Until the spell ends, you can direct the vine to lash out at the same creature or another one as a bonus action on each of your turns.",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.dexterity }
            };
            Spells.Add(graspingVine.Name, graspingVine);

            Spell grease = new Spell
            {
                Source = sourceTitle,
                Name = "Grease",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.conjuration,
                CastingTime = DndTime.action,
                Range = "60 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a bit of pork rind or buter",
                Duration = StringTime.minute,
                Description = "Slick grease covers the ground in a 10-foot square centered on a point within range and turns it into difficult terrain for the duration. When the grease appears, each creature standing in its area must succeed on a Dexterity saving throw or fall prone. A creature that enters the area or ends its turn there must also succeed on a Dexterity saving throw or fall prone.",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.dexterity },
                Conditions = new string[] { Conditions.prone }
            };
            Spells.Add(grease.Name, grease);

            Spell greaterInvisibility = new Spell
            {
                Source = sourceTitle,
                Name = "Greater Invisibility",
                SpellLv = SpellLv.fourth,
                School = SchoolOfMagic.illusion,
                CastingTime = DndTime.action,
                Range = Range.touch,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "You or a creature you touch becomes invisible until the spell ends. Anything the target is wearing or carrying is invisible as long as it is on the target’s person.",
                Classes = new string[] { },
                SingleTarget = true,
                Conditions = new string[] { Conditions.invisible }
            };
            Spells.Add(greaterInvisibility.Name, greaterInvisibility);

            Spell greaterRestoration = new Spell
            {
                Source = sourceTitle,
                Name = "Greater Restoration",
                SpellLv = SpellLv.fifth,
                School = SchoolOfMagic.abjuration,
                CastingTime = DndTime.action,
                Range = Range.touch,
                Verbal = true,
                Somatic = true,
                Materials = "diamond dust worth at least 100gp, which the spell consumes",
                SpellCost = 100,
                Duration = DndTime.instantaneous,
                Description = "You imbue a creature you touch with positive energy to undo a debilitating effect. You can reduce the target’s exhaustion level by one, or end one of the following effects on the target: - One effect that charmed or petrified the target - - One curse, including the target’s attunement to a cursed magic item - - Any reduction to one of the target’s ability scores - - One effect reducing the target’s hit point maximum -",
                Classes = new string[] { },
                SingleTarget = true
            };
            Spells.Add(greaterRestoration.Name, greaterRestoration);

            Spell guardianOfFaith = new Spell
            {
                Source = sourceTitle,
                Name = "Gaurdian of Faith",
                SpellLv = SpellLv.fourth,
                School = SchoolOfMagic.conjuration,
                CastingTime = DndTime.action,
                Range = "30 " + Range.feet,
                Verbal = true,
                Duration = "8 " + StringTime.hours,
                Concentration = true,
                Description = "A Large spectral guardian appears and hovers for the duration in an unoccupied space of your choice that you can see within range. The guardian occupies that space and is indistinct except for a gleaming sword and shield emblazoned with the symbol of your deity. Any creature hostile to you that moves to a space within 10 feet of the guardian for the first time on a turn must succeed on a Dexterity saving throw. The creature takes 20 radiant damage on a failed save, or half as much damage on a successful one. The guardian vanishes when it has dealt a total of 60 damage.",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.dexterity },
                DamageTypes = new string[] { DamageType.radiant }
            };
            Spells.Add(guardianOfFaith.Name, guardianOfFaith);

            Spell gaurdsAndWards = new Spell
            {
                Source = sourceTitle,
                Name = "Gaurds and Wards",
                SpellLv = SpellLv.sixth,
                School = SchoolOfMagic.abjuration,
                CastingTime = "10 " + StringTime.minutes,
                Range = Range.touch,
                Verbal = true,
                Somatic = true,
                Materials = "burning incense, a small measure of brim stone and oil, a knotted string, a small amount of umber hulk blood, and a small silver rod worth at least 10 gp)",
                SpellCost = 10,
                Duration = "24 " + StringTime.hours,
                Description = "You create a ward that protects up to 2,500 square feet of floor space (an area 50 feet square, or one hundred 5-foot squares or twenty-five 10-foot squares). The warded area can be up to 20 feet tall, and shaped as you desire. You can ward several stories of a stronghold by dividing the area among them, as long as you can walk into each contiguous area while you are casting the spell. When you cast this spell, you can specify individuals that are unaffected by any or all of the effects that you choose. You can also specify a password that, when spoken aloud, makes the speaker immune to these effects. Guards and wards creates the following effects within the warded area. - Corridors. Fog fills all the warded corridors, making them heavily obscured. In addition, at each intersection or branching passage offering a choice of direction, there is a 50 percent chance that a creature other than you will believe it is going in the opposite direction from the one it chooses. - - Doors. All doors in the warded area are magically locked, as if sealed by an arcane lock spell. In addition, you can cover up to ten doors with an illusion (equivalent to the illusory object function of the minor illusion spell) to make them appear as plain sections of wall. - - Stairs. Webs fill all stairs in the warded area from top to bottom, as the web spell. These strands regrow in 10 minutes if they are burned or torn away while guards and wards lasts. - - Other Spell Effect. You can place your choice of one of the following magical effects within the warded area of the stronghold. * Place dancing lights in four corridors. You can designate a simple program that the lights repeat as long as guards and wards lasts. * * Place magic mouth in two locations. * * Place stinking cloud in two locations. The vapors * appear in the places you designate; they return within 10 minutes if dispersed by w ind while guards and wards lasts. * Place a constant gust of wind in one corridor or room. * * Place a suggestion in one location. You select an area of up to 5 feet square, and any creature that enters or passes through the area receives the suggestion mentally * - The whole warded area radiates magic. A dispel magic cast on a specific effect, if successful, removes only that effect. You can create a permanently guarded and warded structure by casting this spell there every day for one year",
                Classes = new string[] { }
            };
            Spells.Add(gaurdsAndWards.Name, gaurdsAndWards);

            Spell guidance = new Spell
            {
                Source = sourceTitle,
                Name = "Guidance",
                SpellLv = SpellLv.cantrip,
                School = SchoolOfMagic.divination,
                CastingTime = DndTime.action,
                Range = Range.touch,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.concentration+ StringTime.minute,
                Concentration = true,
                Description = "You touch one willing creature. Once before the spell ends, the target can roll a d4 and add the number rolled to one ability check of its choice. It can roll the die before or after making the ability check. The spell then ends.",
                Classes = new string[] { }
            };
            Spells.Add(guidance.Name, guidance);

            Spell guidingBolt = new Spell
            {
                Source = sourceTitle,
                Name = "Guiding Bolt",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.evocation,
                CastingTime = DndTime.action,
                Range = "120 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.round,
                Description = "A flash of light streaks toward a creature of your choice within range. Make a ranged spell attack against the target. On a hit, the target takes 4d6 radiant damage, and the next attack roll made against this target before the end of your next turn has advantage, thanks to the mystical dim light glittering on the target until then. At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, the damage increases by 1d6 for each slot level above 1st.",
                Classes = new string[] { },
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.ranged },
                DamageTypes = new string[] { DamageType.radiant }
            };
            Spells.Add(guidingBolt.Name, guidingBolt);

            Spell gustOfWind = new Spell
            {
                Source = sourceTitle,
                Name = "Gust of Wind",
                SpellLv = SpellLv.second,
                School = SchoolOfMagic.evocation,
                CastingTime = DndTime.action,
                Range = Range.self + ", 60" + Range.footLine,
                Verbal = true,
                Somatic = true,
                Materials = "a legume seed",
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "A line of strong wind 60 feet long and 10 feet wide blasts from you in a direction you choose for the spell’s duration. Each creature that starts its turn in the line must succeed on a Strength saving throw or be pushed 15 feet away from you in a direction following the line. Any creature in the line must spend 2 feet of movement for every 1 foot it moves when moving closer to you. The gust disperses gas or vapor, and it extinguishes candles, torches, and similar unprotected flames in the area. It causes protected flames, such as those of lanterns, to dance wildly and has a 50 percent chance to extinguish them. As a bonus action on each of your turns before the spell ends, you can change the direction in which the line blasts from you.",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.strength }
            };
            Spells.Add(gustOfWind.Name, gustOfWind);

            #endregion

            #region H

            Spell hailOfThorns = new Spell
            {
                Source = sourceTitle,
                Name = "Hail of Thorns",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.conjuration,
                CastingTime = DndTime.bounusAction,
                Range = Range.self,
                Verbal = true,
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "The next time you hit a creature with a ranged weapon attack before the spell ends, this spell creates a rain of thorns that sprouts from your ranged weapon or ammunition. In addition to the normal effect of the attack, the target of the attack and each creature within 5 feet of it must make a Dexterity saving throw. A creature takes 1dlO piercing damage on a failed save, or half as much damage on a successful one. At Higher Levels. If you cast this spell using a spell slot of 2nd level or higher, the damage increases by 1d10 for each slot level above 1st (to a maximum of 6 d10).",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.dexterity },
                DamageTypes = new string[] { DamageType.piercing }
            };
            Spells.Add(hailOfThorns.Name, hailOfThorns);

            Spell hallow = new Spell
            {
                Source = sourceTitle,
                Name = "Hallow",
                SpellLv = SpellLv.fifth,
                School = SchoolOfMagic.evocation,
                CastingTime = "24 " + StringTime.hours,
                Range = Range.touch,
                Verbal = true,
                Somatic = true,
                Materials = "herbs, oils, and incense worth at least 1,000gp, which the spell consumes",
                SpellCost = 1000,
                Duration = DndTime.untilDispelled,
                Description = "You touch a point and infuse an area around it with holy (or unholy) power. The area can have a radius up to 60 feet, and the spell fails if the radius includes an area already under the effect a hallow spell. The affected area is subject to the following effects. First, celestials, elementals, fey, fiends, and undead can’t enter the area, nor can such creatures charm, frighten, or possess creatures within it. Any creature charmed, frightened, or possessed by such a creature is no longer charmed, frightened, or possessed upon entering the area. You can exclude one or more of those types of creatures from this effect. Second, you can bind an extra effect to the area. Choose the effect from the following list, or choose an effect offered by the DM. Some of these effects apply to creatures in the area; you can designate whether the effect applies to all creatures, creatures that follow a specific deity or leader, or creatures of a specific sort, such as orcs or trolls. When a creature that would be affected enters the spell’s area for the first time on a turn or starts its turn there, it can make a Charisma saving throw. On a success, the creature ignores the extra effect until it leaves the area. - Courage. Affected creatures can’t be frightened while in the area. - - Darkness. Darkness fills the area. Normal light, as well as magical light created by spells of a lower level than the slot you used to cast this spell, can’t illuminate the area. - - Daylight. Bright light fills the area. Magical darkness created by spells of a lower level than the slot you used to cast this spell can’t extinguish the light. - - Energy Protection. Affected creatures in the area have resistance to one damage type of your choice, except for bludgeoning, piercing, or slashing. - - Energy Vulnerability. Affected creatures in the area have vulnerability to one damage type of your choice, except for bludgeoning, piercing, or slashing. - - Everlasting Rest. Dead bodies interred in the area can’t be turned into undead. - - Extradimensional Interference. Affected creatures can’t move or travel using teleportation or by extradimensional or interplanar means. - - Fear. Affected creatures are frightened while in the area. - - Silence. No sound can emanate from within the area, and no sound can reach into it. - - Tongues. Affected creatures can communicate with any other creature in the area, even if they don’t share a common language. -",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.charisma },
                Conditions = new string[] { Conditions.frightened }
            };
            Spells.Add(hallow.Name, hallow);

            Spell hallucinatoryTerrain = new Spell
            {
                Source = sourceTitle,
                Name = "Hallucinatory Terrain",
                SpellLv = SpellLv.fourth,
                School = SchoolOfMagic.illusion,
                CastingTime = "10 " + StringTime.minutes,
                Range = "300 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a stone, a twig, and a bit of green plant",
                Duration = "24 " + StringTime.hours,
                Concentration = true,
                Description = "You make natural terrain in a 150-foot cube in range look, sound, and smell like some other sort of natural terrain. Thus, open fields or a road can be made to resemble a swamp, hill, crevasse, or some other difficult or impassable terrain. A pond can be made to seem like a grassy meadow, a precipice like a gentle slope, or a rock-strewn gully like a wide and smooth road. Manufactured structures, equipment, and creatures within the area aren’t changed in appearance. The tactile characteristics of the terrain are unchanged, so creatures entering the area are likely to see through the illusion. If the difference isn’t obvious by touch, a creature carefully examining the illusion can attempt an Intelligence (Investigation) check against your spell save DC to disbelieve it. A creature who discerns the illusion for what it is, sees it as a vague image superimposed on the terrain.",
                Classes = new string[] { }
            };
            Spells.Add(hallucinatoryTerrain.Name, hallucinatoryTerrain);

            Spell harm = new Spell
            {
                Source = sourceTitle,
                Name = "Harm",
                SpellLv = SpellLv.sixth,
                School = SchoolOfMagic.necromancy,
                CastingTime = DndTime.action,
                Range = "60 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.instantaneous,
                Description ="You unleash a virulent disease on a creature that you can see within range. The target must make a Constitution saving throw. On a failed save, it takes 14d6 necrotic damage, or half as much damage on a successful save. The damage can’t reduce the target’s hit points below 1. If the target fails the saving throw, its hit point maximum is reduced for 1 hour by an amount equal to the necrotic damage it took. Any effect that removes a disease allows a creature’s hit point maximum to return to normal before that time passes.",
                Classes = new string[] { },
                SingleTarget = true
            };
            Spells.Add(harm.Name, harm);

            Spell haste = new Spell
            {
                Source = sourceTitle,
                Name = "Haste",
                SpellLv = SpellLv.third,
                School = SchoolOfMagic.transmutation,
                CastingTime = DndTime.action,
                Range = "30 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a shaving of licorice root",
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "Choose a willing creature that you can see within range. Until the spell ends, the target’s speed is doubled, it gains a +2 bonus to AC, it has advantage on Dexterity saving throws, and it gains an additional action on each of its turns. That action can be used only to take the Attack (one weapon attack only), Dash, Disengage, Hide, or Use an Object action. When the spell ends, the target can’t move or take actions until after its next turn, as a wave of lethargy sweeps over it.",
                Classes = new string[] { },
                SingleTarget = true
            };
            Spells.Add(haste.Name, haste);

            Spell heal = new Spell
            {
                Source = sourceTitle,
                Name = "Heal",
                SpellLv = SpellLv.sixth,
                School = SchoolOfMagic.evocation,
                CastingTime = DndTime.action,
                Range = "60 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.instantaneous,
                Description = "Choose a creature that you can see within range. A surge of positive energy washes through the creature, causing it to regain 70 hit points. This spell also ends blindness, deafness, and any diseases affecting the target. This spell has no effect on constructs or undead. At Higher Levels. When you cast this spell using a spell slot of 7th level or higher, the amount of healing increases by 10 for each slot level above 6th.",
                Classes = new string[] { },
                SingleTarget = true
            };
            Spells.Add(heal.Name, heal);

            Spell healingWord = new Spell
            {
                Source = sourceTitle,
                Name = "Healing Word",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.evocation,
                CastingTime = DndTime.bounusAction,
                Range = "60 " + Range.feet,
                Verbal = true,
                Duration = DndTime.instantaneous,
                Description = "A creature of your choice that you can see within range regains hit points equal to 1d4 + your spellcasting ability modifier. This spell has no effect on undead or constructs. At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, the healing increases by 1d4 for each slot level above 1st.",
                Classes = new string[] { }
            };
            Spells.Add(healingWord.Name, healingWord);

            Spell heatMetal = new Spell
            {
                Source = sourceTitle,
                Name = "Heat Metal",
                SpellLv = SpellLv.second,
                School = SchoolOfMagic.transmutation,
                CastingTime = DndTime.action,
                Range = "60 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a piece of iron and a flame",
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "Choose a manufactured metal object, such as a metal weapon or a suit of heavy or medium metal armor, that you can see within range. You cause the object to glow red-hot. Any creature in physical contact with the object takes 2d8 fire damage when you cast the spell. Until the spell ends, you can use a bonus action on each of your subsequent turns to cause this damage again. If a creature is holding or wearing the object and takes the damage from it, the creature must succeed on a Constitution saving throw or drop the object if it can. If it doesn’t drop the object, it has disadvantage on attack rolls and ability checks until the start of your next turn. At Higher Levels. When you cast this spell using a spell slot of 3rd level or higher, the damage increases by 1d8 for each slot level above 2nd.",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.constitution },
                DamageTypes = new string[] { DamageType.fire }
            };
            Spells.Add(heatMetal.Name, heatMetal);

            Spell hellishRebuke = new Spell
            {
                Source = sourceTitle,
                Name = "Hellish Rebuke",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.evocation,
                CastingTime = DndTime.reaction + ", which you take in response to being damaged by a creature within 60 feet of you that you can see ",
                Range = "60 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.instantaneous,
                Description = "You point your finger, and the creature that damaged you is momentarily surrounded by hellish flames. The creature must make a Dexterity saving throw. It takes 2d10 fire damage on a failed save, or half as much damage on a successful one. At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, the damage increases by 1dlO for each slot level above 1st.",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.dexterity },
                DamageTypes = new string[] { DamageType.fire }
            };
            Spells.Add(hellishRebuke.Name, hellishRebuke);

            Spell herosFeast = new Spell
            {
                Source = sourceTitle,
                Name = "Heros' Feast",
                SpellLv = SpellLv.sixth,
                School = SchoolOfMagic.conjuration,
                CastingTime = "10 " + StringTime.minutes,
                Range = "30 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a gem-encrusted bowl worth at least 1,000 gp, which the spell consumes",
                SpellCost = 1000,
                Duration = DndTime.instantaneous,
                Description = "You bring forth a great feast, including magnificent food and drink. The feast takes 1 hour to consume and disappears at the end of that time, and the beneficial effects don’t set in until this hour is over. Up to twelve other creatures can partake of the feast. A creature that partakes of the feast gains several benefits. The creature is cured of all diseases and poison, becomes immune to poison and being frightened, and makes all Wisdom saving throws with advantage. Its hit point maximum also increases by 2d10, and it gains the same number of hit points. These benefits last for 24 hours.",
                Classes = new string[] { }
            };
            Spells.Add(herosFeast.Name, herosFeast);

            Spell heroism = new Spell
            {
                Source = sourceTitle,
                Name = "Heroism",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.enchantment,
                CastingTime = DndTime.action,
                Range = Range.touch,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.concentration + StringTime.minute,
                Description = "A willing creature you touch is imbued with bravery. Until the spell ends, the creature is immune to being frightened and gains temporary hit points equal to your spellcasting ability modifier at the start of each of its turns. W hen the spell ends, the target loses any remaining temporary hit points from this spell. At Higher Levels. When you cast this spell using a spell slot of 2nd level or higher, you can target one additional creature for each slot level above 1st.",
                Classes = new string[] { },
                SingleTarget = true
            };
            Spells.Add(heroism.Name, heroism);

            Spell hex = new Spell
            {
                Source = sourceTitle,
                Name = "Hex",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.enchantment,
                CastingTime = DndTime.bounusAction,
                Range = "90 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a petrified eye of a newt",
                Duration = DndTime.concentration + StringTime.hour,
                Concentration = true,
                Description = "You place a curse on a creature that you can see within range. Until the spell ends, you deal an extra 1d6 necrotic damage to the target whenever you hit it with an attack. Also, choose one ability when you cast the spell. The target has disadvantage on ability checks made with the chosen ability. If the target drops to 0 hit points before this spell ends, you can use a bonus action on a subsequent turn of yours to curse a new creature. A remove curse cast on the target ends this spell early. At Higher Levels. When you cast this spell using a spell slot of 3rd or 4th level, you can maintain your concentration on the spell for up to 8 hours. When you use a spell slot of 5th level or higher, you can maintain your concentration on the spell for up to 24 hours.",
                Classes = new string[] { },
                SingleTarget = true,
                DamageTypes = new string[] { DamageType.necrotic }  
            };
            Spells.Add(hex.Name, hex);

            Spell holdMonster = new Spell
            {
                Source = sourceTitle,
                Name = "Hold Monster",
                SpellLv = SpellLv.fifth,
                School = SchoolOfMagic.enchantment,
                CastingTime = DndTime.action,
                Range = "90 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a small, straight piece of iron",
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "Choose a creature that you can see within range. The target must succeed on a Wisdom saving throw or be paralyzed for the duration. This spell has no effect on undead. At the end of each of its turns, the target can make another Wisdom saving throw. On a success, the spell ends on the target. At Higher Levels. When you cast this spell using a spell slot of 6th level or higher, you can target one additional creature for each slot level above 5th. The creatures must be within 30 feet of each other when you target them.",
                Classes = new string[] { },
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.wisdom },
                Conditions = new string[] { Conditions.paralyzed }
            };
            Spells.Add(holdMonster.Name, holdMonster);

            Spell holdPerson = new Spell
            {
                Source = sourceTitle,
                Name = "Hold Person",
                SpellLv = SpellLv.second,
                School = SchoolOfMagic.enchantment,
                CastingTime = DndTime.action,
                Range = "60 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a small, straight piece of iron",
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "Choose a humanoid that you can see within range. The target must succeed on a Wisdom saving throw or be paralyzed for the duration. At the end of each of its turns, the target can make another Wisdom saving throw. On a success, the spell ends on the target. At Higher Levels. When you cast this spell using a spell slot of 3rd level or higher, you can target one additional humanoid for each slot level above 2nd. The humanoids must be within 30 feet of each other when you target them.",
                Classes = new string[] { },
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.wisdom },
                Conditions = new string[] { Conditions.paralyzed }
            };
            Spells.Add(holdPerson.Name, holdPerson);

            Spell holyAura = new Spell
            {
                Source = sourceTitle,
                Name = "Holy Aura",
                SpellLv = SpellLv.eighth,
                School = SchoolOfMagic.abjuration,
                CastingTime = DndTime.action,
                Range = Range.self,
                Verbal = true,
                Somatic = true,
                Materials = "a tiny reliquary worth at least 1,000gp containing a sacred relic, such as a scrap of cloth from a saint’s robe or a piece of parchment from a religious text",
                SpellCost = 1000,
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "Divine light washes out from you and coalesces in a soft radiance in a 30-foot radius around you. Creatures of your choice in that radius when you cast this spell shed dim light in a 5-foot radius and have advantage on all saving throws, and other creatures have disadvantage on attack rolls against them until the spell ends. In addition, when a fiend or an undead hits an affected creature with a melee attack, the aura flashes with brilliant light. The attacker must succeed on a Constitution saving throw or be blinded until the spell ends.",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.constitution },
                Conditions = new string[] { Conditions.blinded }
            };
            Spells.Add(holyAura.Name, holyAura);

            Spell hungerOfHadar = new Spell
            {
                Source = sourceTitle,
                Name = "Hunger of Hadar",
                SpellLv = SpellLv.third,
                School = SchoolOfMagic.conjuration,
                CastingTime = DndTime.action,
                Range = "150 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a pickled octopus tentacle",
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "You open a gateway to the dark between the stars, a region infested with unknown horrors. A 20-foot-radius sphere of blackness and bitter cold appears, centered on a point with range and lasting for the duration. This void is filled with a cacophony of soft whispers and slurping noises that can be heard up to 30 feet away. No light, magical or otherwise, can illuminate the area, and creatures fully within the area are blinded. The void creates a warp in the fabric of space, and the area is difficult terrain. Any creature that starts its turn in the area takes 2d6 cold damage. Any creature that ends its turn in the area must succeed on a Dexterity saving throw or take 2d6 acid damage as milky, otherworldly tentacles rub against it.",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.dexterity },
                DamageTypes = new string[] { DamageType.cold, DamageType.acid },
                Conditions = new string[] { Conditions.blinded }
            };
            Spells.Add(hungerOfHadar.Name, hungerOfHadar);

            Spell huntersMark = new Spell
            {
                Source = sourceTitle,
                Name = "Hunter's Mark",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.divination,
                Ritual = true,
                CastingTime = DndTime.bounusAction,
                Range = "90 " + Range.feet,
                Verbal = true,
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "You choose a creature you can see within range and mystically mark it as your quarry. Until the spell ends, you deal an extra 1d6 damage to the target whenever you hit it with a weapon attack, and you have advantage on any Wisdom (Perception) or Wisdom (Survival) check you make to find it. If the target drops to 0 hit points before this spell ends, you can use a bonus action on a subsequent turn of yours to mark a new creature. At Higher Levels. When you cast this spell using a spell slot of 3rd or 4th level, you can maintain your concentration on the spell for up to 8 hours. When you use a spell slot of 5th level or higher, you can maintain your concentration on the spell for up to 24 hours.",
                Classes = new string[] { },
                SingleTarget = true
            };
            Spells.Add(huntersMark.Name, huntersMark);

            Spell hypnoticPattern = new Spell
            {
                Source = sourceTitle,
                Name = "Hypnotic Pattern",
                SpellLv = SpellLv.third,
                School = SchoolOfMagic.illusion,
                CastingTime = DndTime.action,
                Range = "120 " + Range.feet,
                Somatic = true,
                Materials = "a glowing stick of incense or a crystal vial filled with phosphorescent material",
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "You create a twisting pattern of colors that weaves through the air inside a 30-foot cube within range. The pattern appears for a moment and vanishes. Each creature in the area who sees the pattern must make a Wisdom saving throw. On a failed save, the creature becomes charmed for the duration. While charmed by this spell, the creature is incapacitated and has a speed of 0. The spell ends for an affected creature if it takes any damage or if someone else uses an action to shake the creature out of its stupor.",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.wisdom },
                Conditions = new string[] { Conditions.charmed, Conditions.incapacitated }
            };
            Spells.Add(hypnoticPattern.Name, hypnoticPattern);

            #endregion

            #region I

            Spell iceStorm = new Spell
            {
                Source = sourceTitle,
                Name = "Ice Storm",
                SpellLv = SpellLv.fourth,
                School = SchoolOfMagic.evocation,
                CastingTime = DndTime.action,
                Range = "300 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a pinch of dust and a few drops of water",
                Duration = DndTime.instantaneous,
                Description = "A hail of rock-hard ice pounds to the ground in a 20-foot-radius, 40-foot-high cylinder centered on a point within range. Each creature in the cylinder must make a Dexterity saving throw. A creature takes 2d8 bludgeoning damage and 4d6 cold damage on a failed save, or half as much damage on a successful one. Hailstones turn the storm's area of effect into difficult terrain until the end of your next turn. At Higher Levels. When you cast this spell using a spell slot of 5th level or higher, the bludgeoning damage increases by 1d8 for each slot level above 4th.",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.dexterity },
                DamageTypes = new string[] { DamageType.bludgeoning, DamageType.cold }
            };
            Spells.Add(iceStorm.Name, iceStorm);

            Spell identify = new Spell
            {
                Source = sourceTitle,
                Name = "Identify",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.divination,
                Ritual = true,
                CastingTime = StringTime.minute,
                Range = Range.touch,
                Verbal = true,
                Somatic = true,
                Materials = "a pearl worth at least 100gp and an owl feather",
                SpellCost = 100,
                Duration = DndTime.instantaneous,
                Description = "You choose one object that you must touch throughout the casting of the spell. If it is a magic item or some other magic-imbued object, you learn its properties and how to use them, whether it requires attunement to use, and how many charges it has, if any. You learn whether any spells are affecting the item and what they are. If the item was created by a spell, you learn which spell created it. If you instead touch a creature throughout the casting, you learn what spells, if any, are currently affecting it.",
                Classes = new string[] { }
            };
            Spells.Add(identify.Name, identify);

            Spell illusoryScript = new Spell
            {
                Source = sourceTitle,
                Name = "Illusory Script",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.illusion,
                Ritual = true,
                CastingTime = StringTime.minute,
                Range = Range.touch,
                Somatic = true,
                Materials = "a lead-based ink worth at least 10gp, which the spell consumes",
                SpellCost = 10,
                Duration = "10 " + StringTime.days,
                Description = "You write on parchment, paper, or some other suitable writing material and imbue it with a potent illusion that lasts for the duration. To you and any creatures you designate when you cast the spell, the writing appears normal, written in your hand, and conveys whatever meaning you intended when you wrote the text. To all others, the writing appears as if it were written in an unknown or magical script that is unintelligible. Alternatively, you can cause the writing to appear to be an entirely different message, written in a different hand and language, though the language must be one you know. Should the spell be dispelled, the original script and the illusion both disappear. A creature with truesight can read the hidden message.",
                Classes = new string[] { }
            };
            Spells.Add(illusoryScript.Name, illusoryScript);

            Spell imprisonment = new Spell
            {
                Source = sourceTitle,
                Name = "Imprisonment",
                SpellLv = SpellLv.nineth,
                School = SchoolOfMagic.abjuration,
                CastingTime = StringTime.minute,
                Range = "30 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a vellum depiction or a carved statuette in the likeness of the target, and a special component that varies according to the version of the spell you choose, worth at least 500gp per Hit Die of the target",
                SpellCost = 500,
                Duration = DndTime.untilDispelled,
                Concentration = true,
                Description = "You create a magical restraint to hold a creature that you can see within range. The target must succeed on a Wisdom saving throw or be bound by the spell; if it succeeds, it is immune to this spell if you cast it again. While affected by this spell, the creature doesn't need to breathe, eat, or drink, and it doesn’t age. Divination spells can’t locate or perceive the target. When you cast the spell, you choose one of the following forms of imprisonment - Burial. The target is entombed far beneath the earth in a sphere of magical force that is just large enough to contain the target. Nothing can pass through the sphere, nor can any creature teleport or use planar travel to get into or out of it. The special component for this version of the spell is a small mithral orb. - - Chaining. Heavy chains, firmly rooted in the ground, hold the target in place. The target is restrained until the spell ends, and it can’t move or be moved by any means until then. The special component for this version of the spell is a fine chain of precious metal. - - Hedged Prison. The spell transports the target into a tiny demiplane that is warded against teleportation and planar travel. The demiplane can be a labyrinth, a cage, a tower, or any similar confined structure or area of your choice. The special component for this version of the spell is a miniature representation of the prison made from jade. - - Minimus Containment. The target shrinks to a height of 1 inch and is imprisoned inside a gem stone or similar object. Light can pass through the gemstone normally (allowing the target to see out and other creatures to see in), but nothing else can pass through, even by means of teleportation or planar travel. The gemstone can’t be cut or broken while the spell remains in effect. The special component for this version of the spell is a large, transparent gemstone, such as a corundum , diamond, or ruby. - - Slumber. The target falls asleep and can’t be awoken. The special component for this version of the spell consists of rare soporific herbs. - - Ending the Spell. During the casting of the spell, in any of its versions, you can specify a condition that will cause the spell to end and release the target. The condition can be as specific or as elaborate as you choose, but the DM must agree that the condition is reasonable and has a likelihood of coming to pass. The conditions can be based on a creature’s name, identity, or deity but otherwise must be based on observable actions or qualities and not based on intangibles such as level, class, or hit points. - A dispel magic spell can end the spell only if it is cast as a 9th-level spell, targeting either the prison or the special component used to create it. You can use a particular special component to create only one prison at a time. If you cast the spell again using the same component, the target of the first casting is immediately freed from its binding",
                Classes = new string[] { },
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.wisdom },
                Conditions = new string[] { Conditions.restrained }
            };
            Spells.Add(imprisonment.Name, imprisonment);

            Spell incendiaryCloud = new Spell
            {
                Source = sourceTitle,
                Name = "Incendiary Cloud",
                SpellLv = SpellLv.eighth,
                School = SchoolOfMagic.conjuration,
                CastingTime = DndTime.action,
                Range = "150 " + Range.feet,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.concentration + StringTime.minute,
                Concentration = true,
                Description = "A swirling cloud of smoke shot through with white-hot embers appears in a 20-foot-radius sphere centered on a point within range. The cloud spreads around corners and is heavily obscured. It lasts for the duration or until a wind of moderate or greater speed (at least 10 miles per hour) disperses it. When the cloud appears, each creature in it must make a Dexterity saving throw. A creature takes 10d8 fire damage on a failed save, or half as much damage on a successful one. A creature must also make this saving throw when it enters the spell’s area for the first time on a turn or ends its turn there. The cloud moves 10 feet directly away from you in a direction that you choose at the start of each of your turns.",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.dexterity },
                DamageTypes = new string[] { DamageType.fire }
            };
            Spells.Add(incendiaryCloud.Name, incendiaryCloud);

            Spell inflictWounds = new Spell
            {
                Source = sourceTitle,
                Name = "Inflict Wounds",
                SpellLv = SpellLv.first,
                School = SchoolOfMagic.necromancy,
                CastingTime = DndTime.action,
                Range = Range.touch,
                Verbal = true,
                Somatic = true,
                Duration = DndTime.instantaneous,
                Description = "Make a melee spell attack against a creature you can reach. On a hit, the target takes 3d10 necrotic damage. At Higher Levels. When you cast this spell using a spell slot 2nd level or higher, the damage increases by 1d10 for each slot level above 1st.",
                Classes = new string[] { },
                SingleTarget = true,
                SavingThrows = new string[] { SavingThrows.melee },
                DamageTypes = new string[] { DamageType.necrotic }
            };
            Spells.Add(inflictWounds.Name, inflictWounds);

            Spell insectPlague = new Spell
            {
                Source = sourceTitle,
                Name = "Insect Plague",
                SpellLv = SpellLv.fifth,
                School = SchoolOfMagic.conjuration,
                CastingTime = DndTime.action,
                Range = "300 " +Range.feet,
                Verbal = true,
                Somatic = true,
                Materials = "a few grains of sugar, some kernels of grain, and a smear of fat",
                Duration = DndTime.concentration + "10 " + StringTime.minutes,
                Concentration = true,
                Description = "Swarming, biting locusts fill a 20-foot-radius sphere centered on a point you choose within range. The sphere spreads around corners. The sphere remains for the duration, and its area is lightly obscured. The sphere’s area is difficult terrain. When the area appears, each creature in it must make a Constitution saving throw. A creature takes 4d10 piercing damage on a failed save, or half as much damage on a successful one. A creature must also make this saving throw when it enters the spell’s area for the first time on a turn or ends its turn there. At Higher Levels. W hen you cast this spell using a spell slot of 6th level or higher, the damage increases by 1d10 for each slot level above 5th.",
                Classes = new string[] { },
                SavingThrows = new string[] { SavingThrows.constitution },
                DamageTypes = new string[] { DamageType.piercing }
            };
            Spells.Add(insectPlague.Name, insectPlague);

            Spell invisibility = new Spell
            {
                Source = sourceTitle,
                Name = "Invisibility",
                SpellLv = SpellLv.second,
                School = SchoolOfMagic.illusion,
                CastingTime = DndTime.action,
                Range = Range.touch,
                Verbal = true,
                Somatic = true,
                Materials = "an eyelash encased in gum arabic",
                Duration = DndTime.concentration + StringTime.hour,
                Concentration = true,
                Description = "A creature you touch becomes invisible until the spell ends. Anything the target is wearing or carrying is invisible as long as it is on the target’s person. The spell ends for a target that attacks or casts a spell. At Higher Levels. When you cast this spell using a spell slot of 3rd level or higher, you can target one additional creature for each slot level above 2nd",
                Classes = new string[] { },
                SingleTarget = true,
                Conditions = new string[] { Conditions.invisible }
            };
            Spells.Add(invisibility.Name, invisibility);

            #endregion

            #region J




































            #endregion
        }
    }
}
