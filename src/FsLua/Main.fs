namespace FsLua

open System.Reflection.Metadata
open Fable.Core
open WowApi

module Main =
    module Classes =
        type Mage =
            | Arcane
            | Fire
            | Frost

        type Paladin =
            | Holy
            | Protection
            | Retribution

        type Warrior =
            | Arms
            | Fury
            | Protection

        type Druid =
            | Balance
            | Feral
            | Guardian
            | Restoration

        type DeathKnight =
            | Blood
            | Frost
            | Unholy

        type Hunter =
            | BeastMastery
            | Marksmanship
            | Survival

        type Priest =
            | Discipline
            | Holy
            | Shadow

        type Rogue =
            | Assassination
            | Combat
            | Subtlety

        type Shaman =
            | Elemental
            | Enhancement
            | Restoration

        type Warlock =
            | Affliction
            | Demonology
            | Destruction

        type Monk =
            | Brewmaster
            | Windwalker
            | Mistweaver

        type DemonHunter =
            | Havoc
            | Vengeance

    open Classes

    type Class =
        | Mage of Classes.Mage
        | Paladin of Classes.Paladin
        | Warrior of Classes.Warrior
        | Druid of Classes.Druid
        | DeathKnight of Classes.DeathKnight
        | Hunter of Classes.Hunter
        | Priest of Classes.Priest
        | Rogue of Classes.Rogue
        | Shaman of Classes.Shaman
        | Warlock of Classes.Warlock
        | Monk of Classes.Monk
        | DemonHunter of Classes.DemonHunter

    type Stat =
        | Intellect
        | Agility
        | Strength

    type SpecId = SpecId of int

    let specInfo ``class`` =
        match ``class`` with
        | Mage mage ->
            match mage with
            | Mage.Arcane -> SpecId 62, Intellect
            | Mage.Fire -> SpecId 63, Intellect
            | Mage.Frost -> SpecId 64, Intellect
        | Paladin paladin ->
            match paladin with
            | Paladin.Holy -> SpecId 65, Intellect
            | Paladin.Protection -> SpecId 66, Strength
            | Paladin.Retribution -> SpecId 70, Strength
        | Warrior warrior ->
            match warrior with
            | Warrior.Arms -> SpecId 71, Strength
            | Warrior.Fury -> SpecId 72, Strength
            | Warrior.Protection -> SpecId 73, Strength
        | Druid druid ->
            match druid with
            | Druid.Balance -> SpecId 102, Intellect
            | Druid.Feral -> SpecId 103, Agility
            | Druid.Guardian -> SpecId 104, Agility
            | Druid.Restoration -> SpecId 105, Intellect
        | DeathKnight deathKnight ->
            match deathKnight with
            | DeathKnight.Blood -> SpecId 250, Strength
            | DeathKnight.Frost -> SpecId 251, Strength
            | DeathKnight.Unholy -> SpecId 252, Strength
        | Hunter hunter ->
            match hunter with
            | Hunter.BeastMastery -> SpecId 253, Agility
            | Hunter.Marksmanship -> SpecId 254, Agility
            | Hunter.Survival -> SpecId 255, Agility
        | Priest priest ->
            match priest with
            | Priest.Discipline -> SpecId 256, Intellect
            | Priest.Holy -> SpecId 257, Intellect
            | Priest.Shadow -> SpecId 258, Intellect
        | Rogue rogue ->
            match rogue with
            | Rogue.Assassination -> SpecId 259, Agility
            | Rogue.Combat -> SpecId 260, Agility
            | Rogue.Subtlety -> SpecId 261, Agility
        | Shaman shaman ->
            match shaman with
            | Shaman.Elemental -> SpecId 262, Intellect
            | Shaman.Enhancement -> SpecId 263, Agility
            | Shaman.Restoration -> SpecId 264, Intellect
        | Warlock warlock ->
            match warlock with
            | Warlock.Affliction -> SpecId 265, Intellect
            | Warlock.Demonology -> SpecId 266, Intellect
            | Warlock.Destruction -> SpecId 267, Intellect
        | Monk monk ->
            match monk with
            | Monk.Brewmaster -> SpecId 268, Agility
            | Monk.Windwalker -> SpecId 269, Agility
            | Monk.Mistweaver -> SpecId 270, Intellect
        | DemonHunter demonHunter ->
            match demonHunter with
            | DemonHunter.Havoc -> SpecId 577, Agility
            | DemonHunter.Vengeance -> SpecId 581, Agility



    type Hotkey = Hotkey of string


    let main () =
        let actionBarSettings =
            [
                Hotkey "1",
                function
                | Priest _ -> "Smite"
                | _ -> null

                Hotkey "2",
                function
                | Priest priest ->
                    match priest with
                    | Discipline -> "Penance"
                    | Holy -> "Holy Word: Chastise"
                    | Shadow -> "Mind Blast"
                | _ -> null
            ]

        let ``global`` : IExports = Fable.Core.JsInterop.jsThis

        let spec = ``global``.GetSpecialization ()

        ()
