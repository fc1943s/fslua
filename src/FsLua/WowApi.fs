namespace FsLua

#nowarn "3390" // disable warnings for invalid XML comments

open System
open Fable.Core
open Fable.Core.JS

module  rec WowApi =

    // ts2fable 0.8.0

    type Function = System.Action

    type [<AllowNullLiteral>] Number = interface end
    type [<AllowNullLiteral>] String = interface end

    type [<AllowNullLiteral>] CreatedFrame =
        abstract Enabled: bool with get, set
        abstract Draggable: bool with get, set
        abstract DropDownFrame: CreatedDropDownFrame with get, set
        abstract General: bool with get, set
        abstract GetPosition: Function with get, set
        abstract Global: bool with get, set
        abstract IsMain: bool with get, set
        abstract IsMoving: bool with get, set
        abstract Identifier: string with get, set
        abstract Line: CreatedLine with get, set
        abstract Name: string with get, set
        abstract NoTooltip: bool with get, set
        abstract PageId: float with get, set
        abstract Parent: CreatedFrame with get, set
        abstract Padding: float with get, set
        abstract Point: IPoint with get, set
        abstract RowIndex: float with get, set
        abstract Size: ISize with get, set
        abstract Title: FontString with get, set
        abstract Toggle: Function with get, set
        abstract TooltipAnchor: CreatedFrame option with get, set
        abstract Tooltip: string option with get, set
        abstract Update: Function option with get, set
        abstract WindowParent: (unit -> CreatedFrame) with get, set
        abstract AddFontStrings: FontString1: FontString * ?FontString2: FontString * ?FontString3: FontString * ?FontString4: FontString -> unit
        abstract AddSpellByID: SpellId: ISpellId -> unit
        abstract ClearFocus: unit -> unit
        abstract ClearLines: unit -> unit
        abstract CreateFontString: Region: string * ?Parent: string * ?Template: string -> FontString
        abstract CreateLine: unit -> CreatedLine
        abstract Disable: unit -> unit
        abstract Enable: unit -> unit
        abstract EnableMouse: Enable: bool -> unit
        abstract GetEffectiveScale: unit -> float
        abstract GetFrameLevel: unit -> float
        abstract GetHeight: unit -> float
        abstract GetPoint: unit -> string * CreatedFrame * string * float * float
        abstract GetRegions: unit -> obj option * obj option * obj option * obj option * obj option * obj option * obj option * obj option * obj option
        abstract GetScale: unit -> float
        abstract GetText: unit -> string
        abstract GetWidth: unit -> float
        abstract Hide: unit -> unit
        abstract ClearAllPoints: unit -> unit
        abstract SetAutoFocus: Enabled: bool -> unit
        abstract SetBackdrop: Backdrop: IBackdrop -> unit
        abstract SetBackdropBorderColor: R: float * G: float * B: float * A: float -> unit
        abstract SetBackdropColor: R: float * G: float * B: float * A: float -> unit
        abstract SetBackground: this: unit * Color: IColor * BorderColor: IColor -> unit
        abstract ForceHide: unit -> unit
        abstract ForceShow: unit -> unit
        abstract GetCenter: unit -> float * float
        abstract GetParent: unit -> CreatedFrame option
        abstract GetStringWidth: unit -> float
        abstract SetClampedToScreen: Enable: bool -> unit
        abstract SetFocus: unit -> unit
        abstract SetFont: FontName: string * ?TextSize: float * ?Params: string -> unit
        abstract SetFrameLevel: Level: float -> unit
        /// <summary><see href="https://wow.gamepedia.com/FrameStrata" /></summary>
        abstract SetFrameStrata: Strata: string -> unit
        abstract SetHeight: Height: float -> unit
        abstract SetIntendedWordWrap: Enabled: bool -> unit
        abstract SetMaxLetters: Amount: float -> unit
        abstract SetJustifyH: Align: string -> unit
        abstract SetMovable: Enable: bool -> unit
        abstract SetMultiLine: Enabled: bool -> unit
        abstract SetNumeric: Enabled: bool -> unit
        abstract SetParent: Parent: CreatedFrame option -> unit
        abstract SetPoint: Point: string * RelativeTo: CreatedFrame * RelativePoint: string * X: float * Y: float -> unit
        abstract SetOwner: WorldFrame: obj option * Anchor: string -> unit
        abstract SetScale: Scale: float -> unit
        abstract SetSize: Width: float * Height: float -> unit
        abstract SetScript: Method: string * Callback: Function -> unit
        abstract SetAllPoints: unit -> unit
        abstract SetText: Text: string -> unit
        abstract SetTextColor: r: float * g: float * b: float * a: float -> unit
        abstract SetTextInsets: l: float * r: float * t: float * b: float -> unit
        abstract SetUnitAura: UnitId: IUnitId * Index: float * ?Filter: string -> unit
        abstract Show: unit -> unit
        abstract StartMoving: unit -> unit
        abstract StopMovingOrSizing: unit -> unit
        abstract IsVisible: unit -> bool
        abstract RegisterEvent: EventType: string -> unit

    type [<AllowNullLiteral>] CreatedWorldFrame =
        inherit CreatedFrame
        abstract GetMapID: unit -> float
        abstract GetNormalizedCursorPosition: unit -> float * float

    type [<AllowNullLiteral>] CreatedWorldFrameStatic =
        [<EmitConstructor>] abstract Create: unit -> CreatedWorldFrame

    type [<AllowNullLiteral>] Vector2DMixin =
        abstract x: float with get, set
        abstract y: float with get, set
        abstract GetXY: unit -> float * float

    type [<AllowNullLiteral>] Vector2DMixinStatic =
        [<EmitConstructor>] abstract Create: unit -> Vector2DMixin


    type [<AllowNullLiteral>] CreatedFrameStatic =
        [<EmitConstructor>] abstract Create: unit -> CreatedFrame

    type [<AllowNullLiteral>] FontString =
        inherit CreatedFrame

    type [<AllowNullLiteral>] FontStringStatic =
        [<EmitConstructor>] abstract Create: unit -> FontString

    type [<AllowNullLiteral>] IPath =
        inherit String

    type [<AllowNullLiteral>] IBackdrop =
        abstract bgFile: IPath option with get, set
        abstract edgeFile: IPath option with get, set
        abstract edgeSize: float with get, set
        abstract tile: bool with get, set
        abstract tileSize: float with get, set

    type [<AllowNullLiteral>] HyperLink =
        inherit String

    type [<AllowNullLiteral>] GameTooltipFrame =
        abstract AddLine: Message: string -> unit
        abstract ClearLines: unit -> unit
        abstract Hide: unit -> unit
        abstract SetBackdrop: Backdrop: IBackdrop -> unit
        abstract SetBackdropColor: R: float * G: float * B: float * A: float -> unit
        abstract SetHyperlink: HyperLink: HyperLink -> unit
        abstract SetOwner: Frame: CreatedFrame * Anchor: string * ?X: float * ?Y: float -> unit
        abstract SetPoint: Point: string * RelativeTo: CreatedFrame * RelativePoint: string * X: float * Y: float -> unit
        abstract SetText: Text: string * R: float option * G: float option * B: float option * Alpha: float * Unknown: bool -> unit
        abstract Show: unit -> unit

    type [<AllowNullLiteral>] TooltipTextLine =
        abstract GetObjectType: unit -> string
        abstract GetText: unit -> string

    type [<AllowNullLiteral>] GameTooltipFrameStatic =
        [<EmitConstructor>] abstract Create: unit -> GameTooltipFrame

    type [<AllowNullLiteral>] TooltipTextLineStatic =
        [<EmitConstructor>] abstract Create: unit -> TooltipTextLine

    type [<AllowNullLiteral>] ICreatureId =
        inherit Number

    type [<AllowNullLiteral>] ICreatureIdStatic =
        [<EmitConstructor>] abstract Create: unit -> ICreatureId

    type [<AllowNullLiteral>] IGuid =
        inherit String

    type [<AllowNullLiteral>] IUnitId =
        inherit IGuid

    type [<AllowNullLiteral>] ISpecId =
        inherit Number

    type [<AllowNullLiteral>] ISpecIdStatic =
        [<EmitConstructor>] abstract Create: unit -> ISpecId

    type [<AllowNullLiteral>] ISpellId =
        inherit Number

    type [<AllowNullLiteral>] ISpellIdStatic =
        [<EmitConstructor>] abstract Create: unit -> ISpellId

    type [<AllowNullLiteral>] INameToFunction =
        [<EmitIndexer>] abstract Item: Name: string -> Function with get, set

    type [<AllowNullLiteral>] INameToFunctions =
        [<EmitIndexer>] abstract Item: Name: string -> Function with get, set

    type [<AllowNullLiteral>] CreatedEquipmentSlot =
        abstract Clear: Function with get, set
        abstract IsEquipmentSlot: Function with get, set
        abstract IsEqualToBagAndSlot: Function with get, set
        abstract GetEquipmentSlot: Function with get, set
        abstract equipmentSlotIndex: float with get, set
        abstract SetBagAndSlot: Function with get, set
        abstract IsBagAndSlot: Function with get, set
        abstract SetEquipmentSlot: Function with get, set
        abstract IsEqualToEquipmentSlot: Function with get, set
        abstract GetBagAndSlot: Function with get, set
        abstract IsEqualTo: Function with get, set
        abstract HasAnyLocation: this: unit -> bool

    type [<AllowNullLiteral>] ItemLocationType =
        abstract CreateFromEquipmentSlot: SlotId: float -> CreatedEquipmentSlot

    type [<AllowNullLiteral>] ItemLocation =
        abstract CreateFromEquipmentSlot: SlotId: float -> CreatedEquipmentSlot

    type [<AllowNullLiteral>] CreatedEquipmentSlotStatic =
        [<EmitConstructor>] abstract Create: SlotId: float -> CreatedEquipmentSlot

    type [<AllowNullLiteral>] ItemLocationTypeStatic =
        [<EmitConstructor>] abstract Create: unit -> ItemLocationType

    type [<AllowNullLiteral>] ItemLocationStatic =
        [<EmitConstructor>] abstract Create: unit -> ItemLocation

    type [<AllowNullLiteral>] IPowerType =
        inherit Number
    /// end





    let [<Import("_G","module")>] _G: obj option = jsNative
    let [<Import("BATTLE_PET_NAME_5","module")>] BATTLE_PET_NAME_5: string = jsNative
    let [<Import("ERR_ATTACK_DEAD","module")>] ERR_ATTACK_DEAD: string = jsNative
    let [<Import("PETTAME_NOTDEAD","module")>] PETTAME_NOTDEAD: string = jsNative
    let [<Import("PETTAME_DEAD","module")>] PETTAME_DEAD: string = jsNative
    let [<Import("SPELL_FAILED_NO_PET","module")>] SPELL_FAILED_NO_PET: string = jsNative
    let [<Import("WorldFrame","module")>] WorldFrame: obj option = jsNative
    let [<Import("UIParent","module")>] UIParent: CreatedFrame = jsNative
    let [<Import("MailFrame","module")>] MailFrame: CreatedFrame = jsNative
    let [<Import("WorldMapFrame","module")>] WorldMapFrame: CreatedWorldFrame = jsNative
    /// <summary><see href="https://wow.gamepedia.com/API_BookTypeSpell" /></summary>
    let [<Import("BookTypeSpell","module")>] BookTypeSpell: float = jsNative
    let [<Import("MINIMAP_TRACKING_MAILBOX","module")>] MINIMAP_TRACKING_MAILBOX: string = jsNative

    type [<AllowNullLiteral>] CreatedDropDownFrame =
        inherit CreatedFrame
        abstract CloseDropDowns: Function with get, set
        abstract DropDownFrameChilds: ResizeArray<CreatedFrame> with get, set
    type [<AllowNullLiteral>] CreatedDropDownFrameStatic =
        [<EmitConstructor>] abstract Create: unit -> CreatedDropDownFrame

    type [<AllowNullLiteral>] CreatedLine =
        inherit CreatedFrame
        abstract SetColorTexture: r: float * g: float * b: float * a: float -> unit
        abstract SetDrawLayer: layer: string -> unit
        abstract SetEndPoint: point: string -> unit
        abstract SetStartPoint: point: string -> unit
        abstract SetThickness: thickness: float -> unit
    type [<AllowNullLiteral>] CreatedLineStatic =
        [<EmitConstructor>] abstract Create: unit -> CreatedLine

    type [<AllowNullLiteral>] IExports =
        abstract CreatedWorldFrame: CreatedWorldFrameStatic
        abstract Vector2DMixin: Vector2DMixinStatic
        abstract CreateVector2D: this: unit * x: float * y: float -> Vector2DMixin
        abstract ICreatureId: ICreatureIdStatic
        abstract ISpecId: ISpecIdStatic
        abstract ISpellId: ISpellIdStatic
        abstract loadstring: this: unit * execString: string -> Function
        abstract ``assert``: this: unit * loadedString: Function -> Function
        abstract GetCVar: this: unit * Name: string -> string
        abstract SetCVar: this: unit * Name: string * Value: obj option -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_TargetNearestEnemy" /></summary>
        abstract TargetNearestEnemy: this: unit -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_ClearTarget" /></summary>
        abstract ClearTarget: this: unit -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_CombatLogGetCurrentEventInfo" /></summary>
        abstract CombatLogGetCurrentEventInfo: this: unit -> ResizeArray<obj option>
        /// <summary><see href="https://wow.gamepedia.com/API_debugstack" /></summary>
        abstract debugstack: this: unit * ?Coroutine: float * ?start: float * ?count1: float * ?count2: float -> string
        /// <summary><see href="https://wow.gamepedia.com/API_Dismount" /></summary>
        abstract Dismount: this: unit -> unit
        /// <summary>Get Cursor Position in the client</summary>
        abstract GetCursorPosition: this: unit -> float * float
        abstract GetGossipOptions: this: unit -> ResizeArray<string>
        abstract GetLatestThreeSenders: this: unit -> string option * string option * string option
        abstract GetInboxNumItems: this: unit -> float * float
        abstract GetLocale: this: unit -> string
        abstract GetNumGossipOptions: this: unit -> float
        abstract SelectGossipOption: this: unit * Index: float -> unit
        /// Get the current number of player in the plaayer's group
        abstract GetNumGroupMembers: this: unit -> float
        /// <param name="index">The index of the item in the loot window</param>
        /// <returns>0 [string] The texture string of the item</returns>
        /// <returns>1 [string] The name of the item</returns>
        /// <returns>2 [number] The quantity of the item</returns>
        /// <returns>3 [number] The rarity of the item</returns>
        /// <returns>4 [boolean] Whether you are eligible to loot the item or not</returns>
        /// <returns>5 [boolean] Is the item a quest item</returns>
        /// <returns>6 [number] The quest ID of the item if [5] is true</returns>
        /// <returns>7 [boolean] IsActive // unknown</returns>
        abstract GetLootSlotInfo: this: unit * index: float -> string * string * float * float * bool * bool * float * bool
        /// Number of Items that can be looted (This is always the index of the last item)
        abstract GetNumLootItems: this: unit -> float
        /// <summary><see href="https://wowwiki.fandom.com/wiki/API_GetNumSkillLines" /></summary>
        abstract GetNumSkillLines: this: unit -> float
        /// <summary><see href="https://wowwiki.fandom.com/wiki/API_GetSkillLineInfo" /></summary>
        abstract GetSkillLineInfo: this: unit * Index: float -> string * float option * float option * float * float * float * float * float option * float option * float option * float * float * string
        /// <summary><see href="https://wow.gamepedia.com/API_GetTime" /></summary>
        abstract GetTime: this: unit -> float
        /// <summary><see href="https://wow.gamepedia.com/API_MouselookStart" /></summary>
        abstract MouselookStart: this: unit -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_IsIndoors" /></summary>
        abstract IsIndoors: this: unit -> bool
        /// <summary><see href="https://wow.gamepedia.com/API_IsOutdoors" /></summary>
        abstract IsOutdoors: this: unit -> bool
        /// <summary><see href="https://wow.gamepedia.com/API_IsMouselooking" /></summary>
        abstract IsMouselooking: this: unit -> bool
        /// <summary><see href="https://wow.gamepedia.com/API_print" /></summary>
        abstract print: this: unit * [<ParamArray>] args: obj option[] -> unit
        /// Trim a string (lua based)
        abstract trim: this: unit * string: string -> string
        /// Reloads the UI
        abstract ReloadUI: this: unit -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_ResetInstances" /></summary>
        abstract ResetInstances: this: unit -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_RunMacroText" /></summary>
        abstract RunMacroText: this: unit * MacroText: string -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_TargetUnit" /></summary>
        abstract TargetUnit: this: unit * UnitId: IUnitId -> unit
        abstract ``mod``: this: unit * a: float * b: float -> float
        abstract tonumber: this: unit * String: string -> float
        abstract tremove: this: unit * table: ResizeArray<CreatedFrame> -> CreatedFrame
        abstract tinsert: this: unit * table: ResizeArray<CreatedFrame> * newValue: CreatedFrame -> unit
        /// <summary><see href="http://wowprogramming.com/docs/api/CloseTaxiMap.html" /></summary>
        abstract CloseTaxiMap: this: unit -> unit
        /// <summary><see href="http://wowprogramming.com/docs/api/NumTaxiNodes.html" /></summary>
        abstract NumTaxiNodes: this: unit -> float
        /// <summary><see href="http://wowprogramming.com/docs/api/TaxiNodeCost.html" /></summary>
        abstract TaxiNodeCost: this: unit * index: float -> float
        /// <summary><see href="http://wowprogramming.com/docs/api/TakeTaxiNode.html" /></summary>
        abstract TakeTaxiNode: this: unit * index: float -> unit
        /// <summary><see href="http://wowprogramming.com/docs/api/TaxiNodeGetType.html" /></summary>
        abstract TaxiNodeGetType: this: unit * index: float -> string
        /// <summary><see href="http://wowprogramming.com/docs/api/TaxiNodeName.html" /></summary>
        abstract TaxiNodeName: this: unit * index: float -> string
        /// <summary><see href="http://wowprogramming.com/docs/api/TaxiNodePosition.html" /></summary>
        abstract TaxiNodePosition: this: unit * index: float -> float * float
        /// <summary><see href="https://wow.gamepedia.com/API_UnitOnTaxi" /></summary>
        abstract UnitOnTaxi: this: unit * UnitId: IUnitId -> bool
        /// <summary>
        /// Get current bandwidth information.
        /// <see href="https://wow.gamepedia.com/API_GetNetStats" />
        /// </summary>
        /// <returns>0 [number] Incoming bandwidth</returns>
        /// <returns>1 [number] Outgoing bandwidth</returns>
        /// <returns>2 [number] Home latency</returns>
        /// <returns>3 [number] World latency</returns>
        abstract GetNetStats: this: unit -> float * float * float * float
        /// <summary><see href="https://wow.gamepedia.com/API_GetInstanceInfo" /></summary>
        /// <returns>0 [string] The name of the Instance</returns>
        /// <returns>1 [string] The Instance Type</returns>
        /// <returns>2 [number] The Difficulty ID</returns>
        /// <returns>3 [string] The Defficulty Name</returns>
        /// <returns>4 [number] Maximum Allowed Players</returns>
        /// <returns>5 [number] Dynamic Difficulty</returns>
        /// <returns>6 [boolean] IsDynamic Difficulty</returns>
        /// <returns>7 [number] Instance ID</returns>
        /// <returns>8 [number] Instance Group Size</returns>
        /// <returns>9 [number] LFG Dungeon Identifieras</returns>
        abstract GetInstanceInfo: this: unit -> string * string * float * string * float * float * bool * float * float
        /// <summary><see href="https://wow.gamepedia.com/API_GetNumSpellTabs" /></summary>
        abstract GetNumSpellTabs: this: unit -> float
        /// <param name="Index">[number] The quest's index</param>
        /// <returns>0 [number] Number of Total Entires incl collapsible entries</returns>
        /// <returns>1 [number] Number of active quests</returns>
        abstract GetNumQuestLogEntries: this: unit -> float * float
        /// <param name="Index">[number] The quest's index</param>
        /// <returns>[number] The Quest ID</returns>
        abstract GetQuestIDFromLogIndex: this: unit * Index: float -> float
        /// <param name="index">questLogID Integer - The index of the quest you wish to get information about, between 1 and GetNumQuestLogEntries()'s first return value. (This is not the ID as used in QuestStrings.)</param>
        /// <returns>0 [string] String - The title of the quest, or nil if the index is out of range.</returns>
        /// <returns>1 [number] Integer - The level of the quest</returns>
        /// <returns>2 [number] Integer - if questTag is GROUP, the positive number of players suggested for the quest or nil (added in 2.0.3)</returns>
        /// <returns>3 [boolean] Boolean - 1 if the entry is not a quest, but a header, eg. "Mulgore" nil otherwise.</returns>
        /// <returns>4 [boolean] Boolean - 1 if the entry is a collapsed header, nil otherwise.</returns>
        /// <returns>5 [number] Integer - -1 if quest is (FAILED), +1 if quest is (COMPLETED), nil otherwise.</returns>
        /// <returns>6 [number]</returns>
        /// <returns>7 [boolean]Integer - The quest identification number. This is the number found in GetQuestsCompleted() after it has been completed. It is also the number used to identify quests on sites such as Wowhead.com (Example: Rest and Relaxation) (added in 3.3.0)</returns>
        /// <returns>8 [boolean]</returns>
        /// <returns>9 [boolean]</returns>
        /// <returns>10 [boolean]</returns>
        /// <returns>11 [boolean]</returns>
        /// <returns>12 [boolean]</returns>
        /// <returns>13 [boolean]</returns>
        /// <returns>14 [boolean]</returns>
        /// <returns>15 [boolean]</returns>
        abstract GetQuestLogTitle: this: unit * index: float -> string * float * float * bool * bool * float * float * bool * bool * bool * bool * bool * bool * bool * bool * bool
        /// Get wether the player actual;ly ahs a gree reticle used for groundcasting
        abstract SpellIsTargeting: this: unit -> bool
        /// <param name="Index">[number] The quest's index</param>
        /// <returns>0 [string] The Description</returns>
        /// <returns>1 [string] The Objective</returns>
        abstract GetQuestLogQuestText: this: unit * Index: float -> string * string
        /// <summary><see href="https://wow.gamepedia.com/API_GetMirrorTimerProgress" /></summary>
        abstract GetMirrorTimerProgress: this: unit * identifier: string -> float
        /// <summary><see href="https://wow.gamepedia.com/API_CameraOrSelectOrMoveStart" /></summary>
        abstract CameraOrSelectOrMoveStart: this: unit -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_CameraOrSelectOrMoveStop" /></summary>
        abstract CameraOrSelectOrMoveStop: this: unit -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_AscendStop" /></summary>
        abstract AscendStop: this: unit -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_DescendStop" /></summary>
        abstract DescendStop: this: unit -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_JumpOrAscendStart" /></summary>
        abstract JumpOrAscendStart: this: unit -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_JumpOrAscendStop" /></summary>
        abstract JumpOrAscendStop: this: unit -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_SitStandOrDescendStart" /></summary>
        abstract SitStandOrDescendStart: this: unit -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_SitStandOrDescendStop" /></summary>
        abstract SitStandOrDescendStop: this: unit -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_StrafeLeftStart" /></summary>
        abstract StrafeLeftStart: this: unit -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_StrafeLeftStop" /></summary>
        abstract StrafeLeftStop: this: unit -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_StrafeRightStart" /></summary>
        abstract StrafeRightStart: this: unit -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_StrafeRightStop" /></summary>
        abstract StrafeRightStop: this: unit -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_TurnLeftStart" /></summary>
        abstract TurnLeftStart: this: unit * startTime: float -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_TurnLeftStop" /></summary>
        abstract TurnLeftStop: this: unit * stopTime: float -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_TurnRightStart" /></summary>
        abstract TurnRightStart: this: unit * startTime: float -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_TurnRightStop" /></summary>
        abstract TurnRightStop: this: unit * stopTime: float -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_MoveBackwardStart" /></summary>
        abstract MoveBackwardStart: this: unit -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_MoveBackwardStop" /></summary>
        abstract MoveBackwardStop: this: unit -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_MoveForwardStart" /></summary>
        abstract MoveForwardStart: this: unit -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_MoveForwardStop" /></summary>
        abstract MoveForwardStop: this: unit -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_PitchUpStart" /></summary>
        abstract PitchUpStart: this: unit -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_PitchDownStop" /></summary>
        abstract PitchDownStop: this: unit -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_PitchDownStart" /></summary>
        abstract PitchDownStart: this: unit -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_PitchUpStop" /></summary>
        abstract PitchUpStop: this: unit -> unit
        /// <summary><see href="http://wowprogramming.com/docs/api/IsAutoRepeatSpell.html" /></summary>
        abstract IsAutoRepeatSpell: this: unit * SpellName: U2<float, string> -> bool
        abstract IsModifierKeyDown: this: unit -> bool
        abstract IsAltKeyDown: this: unit -> bool
        abstract IsControlKeyDown: this: unit -> bool
        abstract IsShiftKeyDown: this: unit -> bool
        abstract IsLeftShiftKeyDown: this: unit -> bool
        abstract IsLeftAltKeyDown: this: unit -> bool
        abstract IsLeftControlKeyDown: this: unit -> bool
        abstract IsRightShiftKeyDown: this: unit -> bool
        abstract IsRightAltKeyDown: this: unit -> bool
        abstract IsRightControlKeyDown: this: unit -> bool
        abstract CreatedEquipmentSlot: CreatedEquipmentSlotStatic
        abstract ItemLocationType: ItemLocationTypeStatic
        abstract ItemLocation: ItemLocationStatic
        /// <param name="ItemId">the identifier of the item we want to equip.</param>
        /// <param name="ItemName">the name of the item we want to equip</param>
        abstract EquipItemByName: this: unit * ?ItemId: float * ?ItemName: string -> unit
        /// <summary>icon, itemCount, locked, quality, readable, lootable, itemLink, isFiltered, noValue, itemID = GetContainerItemInfo(bagID, slot)</summary>
        /// <param name="BagId" />
        /// <param name="SlotId" />
        /// <returns />
        abstract GetContainerItemInfo: this: unit * BagId: float * SlotId: float -> float * float * bool * float * bool * bool * string * bool * bool * float
        /// <summary><see href="https://wow.gamepedia.com/API_GetContainerNumSlots" /></summary>
        abstract GetContainerNumSlots: this: unit * BagNumber: float -> float
        /// <summary>
        /// Get Number of Free Container Slots
        /// <see href="https://wow.gamepedia.com/API_GetContainerNumFreeSlots" />
        /// </summary>
        /// <param name="Slot">[number] Bag Identifier</param>
        /// <returns>0 [number] Number of Empty Bag Slots</returns>
        /// <returns>1 [number] Type of Bag</returns>
        abstract GetContainerNumFreeSlots: this: unit * Slot: float -> float * float
        /// <summary>Get the Enchant Info of your Weapons</summary>
        /// <returns>0 [boolean] - Is Mainhand enchanted.</returns>
        /// <returns>1 [number] - OffHand Expiration Timer in milliseconds.</returns>
        /// <returns>2 [number] - Charges on MainHand Enchant.</returns>
        /// <returns>3 [number] - Mainhand Enchant id.</returns>
        /// <returns>4 [boolean] - Is OffHand enchanted.</returns>
        /// <returns>5 [number] - OffHand Expiration Timer in milliseconds.</returns>
        /// <returns>6 [number] - Charges on MainHand Enchant.</returns>
        /// <returns>7 [number] - Mainhand Enchant id.</returns>
        abstract GetWeaponEnchantInfo: this: unit -> bool * float * float * float * bool * float * float * float
        /// <summary>
        /// Get Cooldown of Item
        /// <see href="https://wow.gamepedia.com/API_GetItemCooldown" />
        /// </summary>
        /// <param name="ItemId">[number] This Item's Identifier</param>
        /// <returns>0 [number] Starting Time (GetTime())</returns>
        /// <returns>1 [number] Total duration of the cooldown</returns>
        /// <returns>2 [number] Whether or not the item is ready (1 for Ready, 0 for Not ready)</returns>
        abstract GetItemCooldown: this: unit * ItemId: float -> float * float * float
        /// <summary><see href="https://wow.gamepedia.com/API_GetInventoryItemCooldown" /></summary>
        /// <param name="UnitId">[string] The unit's Identifier to be queried</param>
        /// <param name="SlotId">[number] The inventory slot to be queried</param>
        /// <returns>0 [number] Starting Time (GetTime())</returns>
        /// <returns>1 [number] Total duration of the cooldown</returns>
        /// <returns>2 [number] Whether or not the item is ready (1 for Ready, 0 for Not ready)</returns>
        abstract GetInventoryItemCooldown: this: unit * UnitId: string * SlotId: float -> float * float * float
        /// <summary>
        /// Get the Item Id for a specific inventory slot.
        /// <see href="https://wow.gamepedia.com/API_GetInventoryItemID" />
        /// </summary>
        /// <param name="UnitId">[string] The unit's Identifier to be queried</param>
        /// <param name="SlotId">[number] The inventory slot to be queried</param>
        /// <returns>[number] Unique Item Identifier</returns>
        abstract GetInventoryItemID: this: unit * UnitId: string * SlotId: float -> float
        /// <summary>Get the Invetory Slot Information</summary>
        /// <param name="Slot">[string] The InventorySlotName to be queried</param>
        /// <returns>0 [number] The Slot Identifier of the Item</returns>
        /// <returns>1 [string] The Texture path</returns>
        abstract GetInventorySlotInfo: this: unit * Slot: string -> float * string
        /// <summary><see href="https://wow.gamepedia.com/API_GetItemCount" /></summary>
        abstract GetItemCount: this: unit * ItemId: float * ?IncludeBank: bool * ?IncludeCharges: bool -> float
        /// <summary>
        /// Get the specific information about an item
        /// <see href="https://wow.gamepedia.com/API_GetItemInfo" />
        /// </summary>
        /// <returns>0 [string] - Item Name</returns>
        /// <returns>1 [string] - Item Link</returns>
        /// <returns>2 [number] - Item Rarity</returns>
        /// <returns>3 [number] - Item Level</returns>
        /// <returns>4 [number] - Minimum Item level</returns>
        /// <returns>5 [string] - Item Type</returns>
        /// <returns>6 [string] - Item Subtype</returns>
        /// <returns>7 [number] - Item Stack Count</returns>
        /// <returns>8 [string] - Item Equipment Loc</returns>
        /// <returns>9 [number] - Item Icon</returns>
        /// <returns>10 [number] - Item Sell Price</returns>
        /// <returns>11 [number] - Item Class ID</returns>
        /// <returns>12 [number] - Item Subclass ID</returns>
        /// <returns>13 [number] - Bind Type</returns>
        /// <returns>14 [number] - Expansion ID</returns>
        /// <returns>15 [number] - Item Set ID</returns>
        /// <returns>16 [boolean] - Is Crafting Reagent</returns>
        abstract GetItemInfo: this: unit * Item: obj option -> string * string * float * float * float * string * string * float * string * float * float * float * float * float * float * float * bool
        /// <summary>
        /// Get the specific information about an item
        /// <see href="https://wow.gamepedia.com/API_GetItemGem" />
        /// </summary>
        /// <returns>0 [string] - Item Name</returns>
        /// <returns>1 [string] - Item Link</returns>
        abstract GetItemGem: this: unit * Item: obj option * Index: float -> string * string
        /// <summary><see href="https://wow.gamepedia.com/API_PickupContainerItem" /></summary>
        abstract PickupContainerItem: this: unit * ?BagId: float * ?SlotId: float -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_PickupMerchantItem" /></summary>
        abstract PickupMerchantItem: this: unit * ?BagId: float * ?SlotId: float -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_UseInventoryItem" /></summary>
        abstract UseInventoryItem: this: unit * SlotId: float -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_UseItemByName" /></summary>
        abstract UseItemByName: this: unit * ItemName: string * ?Unit: IUnitId -> unit
        abstract CreatedDropDownFrame: CreatedDropDownFrameStatic
        /// <summary><see href="https://wow.gamepedia.com/API_CreateFrame" /></summary>
        abstract CreateFrame: this: unit * FrameType: string * ?Name: string * ?UIParent: CreatedFrame * ?Template: string -> CreatedFrame
        abstract CreatedLine: CreatedLineStatic
        abstract CreatedFrame: CreatedFrameStatic
        abstract FontString: FontStringStatic
        abstract GameTooltipFrame: GameTooltipFrameStatic
        abstract TooltipTextLine: TooltipTextLineStatic
        /// <summary><see href="https://wow.gamepedia.com/API_CastSpellByName" /></summary>
        abstract CastSpellByName: this: unit * Name: string * ?Unit: IUnitId -> unit
        abstract CastSpellByID: this: unit * Id: float * ?Unit: IUnitId -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_GetRaidTargetIndex" /></summary>
        abstract GetRaidTargetIndex: this: unit * Unit: IUnitId -> float option
        /// <summary>
        /// Get Rune Duration
        /// <see href="https://wow.gamepedia.com/API_GetRuneCooldown" />
        /// </summary>
        /// <returns>0 [number] Start Value in GetTime()</returns>
        /// <returns>1 [number] Duration of Rune Cooldown</returns>
        /// <returns>2 [boolean] Whtehr or not the Rune is ready</returns>
        abstract GetRuneCooldown: this: unit * RuneId: float -> float * float * bool
        /// <summary><see href="https://wow.gamepedia.com/API_GetSpellBookItemName" /></summary>
        abstract GetSpellBookItemName: this: unit * Index: float * BookTypeSpell: string -> string * string * float
        /// <summary>
        /// Get a spell's cooldown.
        /// <see href="https://wow.gamepedia.com/API_GetSpellCooldown" />
        /// </summary>
        /// <param name="SpellId">[number] The Spell's identifier</param>
        /// <returns>0 [number] When the cooldown was started (from GetTime())</returns>
        /// <returns>1 [number] Current cooldown duration</returns>
        abstract GetSpellCooldown: this: unit * SpellId: U2< ISpellId , string> -> float * float
        /// Get the Count of a Spell
        abstract GetSpellCount: this: unit * SpellId: ISpellId -> float
        /// Get the Spell's Description as seen in the tooltip
        abstract GetSpellDescription: this: unit * SpellId: float -> string
        /// <summary>
        /// Get the spell's recharge values
        /// <see href="https://wow.gamepedia.com/API_GetSpellCharges" />
        /// </summary>
        /// <param name="SpellId">[number] The spell's id</param>
        /// <param name="">0 [number] CurrentCharges</param>
        /// <param name="">1 [number] MaxCharges</param>
        /// <param name="">2 [number] Start</param>
        /// <param name="">3 [number] Duration</param>
        abstract GetSpellCharges: this: unit * SpellId: ISpellId -> float * float * float * float
        /// <summary>
        /// Get information about the specified line of spells.
        /// <see href="https://wow.gamepedia.com/API_GetSpellTabInfo" />
        /// </summary>
        /// <param name="Index">[number] The index of the tab</param>
        /// <returns>0 [string] Name</returns>
        /// <returns>1 [string] Icon</returns>
        /// <returns>2 [number] Spellbook Offset</returns>
        /// <returns>3 [number] Number of Entries</returns>
        /// <returns>4 [boolean] Guild Perk Bool</returns>
        /// <returns>5 [number] Offspec Identifier</returns>
        abstract GetSpellTabInfo: this: unit * Index: float -> string * float * float * float * bool * float * bool
        /// <summary>
        /// Get a Spell's informations from the WoW API
        /// <see href="https://wow.gamepedia.com/API_GetSpellInfo" />
        /// </summary>
        /// <param name="SpellId">[string|number] The spell's id or name</param>
        /// <returns>0 [string] SpellName</returns>
        /// <returns>1 [???] Formerly Rank (Removed in 8.0, may be used in Classic!)</returns>
        /// <returns>2 [number] Icon</returns>
        /// <returns>3 [number] Casting Time (Milliseconds)</returns>
        /// <returns>4 [number] Minimum Range</returns>
        /// <returns>5 [number] Maximum Range</returns>
        /// <returns>6 [number] SpellId</returns>
        abstract GetSpellInfo: this: unit * SpellId: U2<ISpellId, string> -> string * obj * float * float * float * float * float
        abstract GetSpellLink: this: unit * SpellId: U2<float, string> -> HyperLink * float


        /// <summary><see href="http://wowprogramming.com/docs/api/GetTotemTimeLeft.html" /></summary>
        abstract GetTotemTimeLeft: this: unit * totemSlot: float -> float
        /// <summary><see href="https://wow.gamepedia.com/API_GetTotemTimeLeft" /></summary>
//        abstract GetTotemTimeLeft: this: unit * Index: float -> float


        /// <summary><see href="http://wowprogramming.com/docs/api/IsCurrentSpell.html" /></summary>
        abstract IsCurrentSpell: this: unit * SpellId: U2<float, string> -> bool
        /// <summary><see href="https://wow.gamepedia.com/API_IsPlayerSpell" /></summary>
        abstract IsPlayerSpell: this: unit * SpellId: ISpellId -> bool
        /// <summary><see href="https://wow.gamepedia.com/API_IsSpellInRange" /></summary>
        abstract IsSpellInRange: this: unit * SpellName: string * UnitId: IUnitId -> float
        /// <summary><see href="https://wow.gamepedia.com/API_IsUsableSpell" /></summary>
        abstract IsUsableSpell: this: unit * SpellId: ISpellId -> bool
        /// <summary><see href="https://wow.gamepedia.com/API_SpellStopTargeting" /></summary>
        abstract SpellStopTargeting: this: unit -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_SpellStopCasting" /></summary>
        abstract SpellStopCasting: this: unit -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_GetCombatRating" /></summary>
        abstract GetCombatRating: this: unit * CombatRatingId: float -> float
        /// <summary><see href="https://wow.gamepedia.com/API_GetCorruption" /></summary>
        abstract GetCorruption: this: unit -> float
        /// <summary><see href="https://wow.gamepedia.com/API_GetCorruptionResistance" /></summary>
        abstract GetCorruptionResistance: this: unit -> float
        /// <summary><see href="https://wow.gamepedia.com/API_GetCritChance" /></summary>
        abstract GetCritChance: this: unit -> float
        /// <summary><see href="https://wow.gamepedia.com/API_GetSpecialization" /></summary>
        abstract GetSpecialization: this: unit -> obj * obj * obj * obj
        /// <summary><see href="https://wow.gamepedia.com/API_GetShapeshiftForm" /></summary>
        abstract GetShapeshiftForm: this: unit -> float
        /// <summary>
        /// Get the player's specialization.
        /// <see href="https://wow.gamepedia.com/API_GetSpecializationInfo" />
        /// </summary>
        /// <param name="Spec">[number] The index of the player's specialization.</param>
        /// <returns>0 [number] Identifier</returns>
        /// <returns>1 [string] Name</returns>
        /// <returns>2 [string] Description</returns>
        /// <returns>3 [number] Icon</returns>
        /// <returns>4 [string] Background</returns>
        /// <returns>5 [string] Role</returns>
        abstract GetSpecializationInfo: this: unit * Spec: obj * obj * obj * obj -> float * string * string * float * string * float
        /// <summary><see href="https://wow.gamepedia.com/API_IsFalling" /></summary>
        abstract IsFalling: this: unit -> bool
        /// <summary><see href="https://wow.gamepedia.com/API_IsFlying" /></summary>
        abstract IsFlying: this: unit -> bool
        /// Get wether the player is in a Group
        abstract IsInGroup: this: unit -> bool
        /// Get wether the player is in a Raid
        abstract IsInRaid: this: unit -> bool
        /// <summary><see href="https://wow.gamepedia.com/API_IsMounted" /></summary>
        abstract IsMounted: this: unit -> bool
        /// <summary><see href="https://wow.gamepedia.com/API_IsPetActive" /></summary>
        abstract IsPetActive: this: unit -> bool
        /// <summary><see href="https://wow.gamepedia.com/API_IsSwimming" /></summary>
        abstract IsSwimming: this: unit -> bool
        /// <summary><see href="https://wow.gamepedia.com/API_PetAttack" /></summary>
        abstract PetAttack: this: unit * UnitId: IUnitId -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_PetAssistMode" /></summary>
        abstract PetAssistMode: this: unit -> unit
        /// <summary><see href="https://wow.gamepedia.com/API_PetPassiveMode" /></summary>
        abstract PetPassiveMode: this: unit -> unit
        /// <summary>
        /// Get current Power Regeneration
        /// <see href="https://wow.gamepedia.com/API_GetPowerRegen" />
        /// </summary>
        /// <returns>0 [number] Focus Regeneration</returns>
        /// <returns>1 [number] ?</returns>
        abstract GetPowerRegen: this: unit * UnitId: IUnitId -> float * float
        /// <summary>
        /// Get the specified unit's speed.
        /// <see href="https://wow.gamepedia.com/API_GetUnitSpeed" />
        /// </summary>
        /// <param name="UnitId">[IUnitId] Identifier of the specified Unit</param>
        /// <returns>0 [number] Current Speed</returns>
        /// <returns>1 [number] Running Speed</returns>
        /// <returns>2 [number] Flight Speed</returns>
        /// <returns>3 [number] Swimming Speed</returns>
        abstract GetUnitSpeed: this: unit * UnitId: IUnitId -> float * float * float * float
        /// <summary><see href="https://wow.gamepedia.com/API_UnitAffectingCombat" /></summary>
        abstract UnitAffectingCombat: this: unit * UnitId: IUnitId -> bool
        /// <summary><see href="https://wow.gamepedia.com/API_GetCombatRatingBonus" /></summary>
        abstract GetCombatRatingBonus: this: unit * Identifier: float -> float
        abstract GetVersatilityBonus: this: unit * Identifier: float -> float
        /// <summary>
        /// Get the specified unit's Attack Power
        /// <see href="https://wow.gamepedia.com/API_UnitAttackPower" />
        /// </summary>
        /// <param name="UnitId">[IUnitId] The UnitId to be queried</param>
        /// <returns>0 [number] The base attack power</returns>
        /// <returns>1 [number] The number of positive buffs to attack power</returns>
        /// <returns>2 [number] The number pf negative buffs to attack power</returns>
        abstract UnitAttackPower: this: unit * UnitId: IUnitId -> float * float * float
        /// <summary>
        /// Get the specified unit's Attack Speed
        /// <see href="https://wow.gamepedia.com/API_UnitAttackSpeed" />
        /// </summary>
        /// <param name="UnitId">[IUnitId] The UnitId to be queried</param>
        /// <returns>0 [number] The Mainhand Attack Speed</returns>
        /// <returns>1 [number] The Offhand Attack speed</returns>
        abstract UnitAttackSpeed: this: unit * UnitId: IUnitId -> float * float option
        /// <summary>
        /// Get the properties for the aura on a unit by it's index, and possibly with filters.
        /// <see href="https://wow.gamepedia.com/API_UnitAura" />
        /// </summary>
        /// <param name="UnitId" />
        /// <param name="Index" />
        /// <param name="Filter" />
        /// <returns>0 - Name</returns>
        /// <returns>1 - IconId - number</returns>
        /// <returns>2 - Count - number</returns>
        /// <returns>3 - DebuffType - DebuffType</returns>
        /// <returns>4 - Duration - number</returns>
        /// <returns>5 - ExpirationTime - number</returns>
        /// <returns>6 - UnitCaster - Guid</returns>
        /// <returns>7 - CanStealOrPurge - boolean</returns>
        /// <returns>8 - NameplateShowPersonal - boolean</returns>
        /// <returns>9 - SpellId - number</returns>
        /// <returns>10 - CanApplyAura - boolean</returns>
        /// <returns>11 - IsBossDebuff - boolean</returns>
        /// <returns>12 - IsCastByPlayer - boolean</returns>
        /// <returns>13 - NameplateShowAll - boolean</returns>
        /// <returns>14 - TimeMod - number</returns>
        abstract UnitAura: this: unit * UnitId: IUnitId * Index: float * ?Filter: string -> U2<string * float * float * string * float * float * string * bool * bool * float * bool * bool * bool * bool * float * float, obj option>
        /// <summary>
        /// Get the specified unit's casting information.
        /// ** CLASSIC **
        /// <see href="https://wow.gamepedia.com/API_UnitCastingInfo" />
        /// </summary>
        /// <param name="Unit">[IUnitId] The Identifier for the specified unit.</param>
        /// <returns>0 [string] Name</returns>
        /// <returns>1 [string] Text</returns>
        /// <returns>2 [string] Icon</returns>
        /// <returns>3 [number] Start Time in Milliseconds</returns>
        /// <returns>4 [number] End Time in Milliseconds</returns>
        /// <returns>5 [boolean] Is Tradeskill Bool</returns>
        /// <returns>6 [string] Cast Identifier</returns>
        /// <returns>7 [boolean] Not Interruptible Boolean</returns>
        /// <returns>8 [number] Spell Identifier</returns>
        abstract CastingInfo: this: unit -> string * string * string * float * float * bool * string * bool * float
        /// <summary>
        /// Get the specified unit's casting information.
        /// ** CLASSIC **
        /// <see href="https://wow.gamepedia.com/API_UnitChannelInfo" />
        /// </summary>
        /// <param name="Unit">[IUnitId] The Identifier for the specified unit.</param>
        /// <returns>0 [string] Name</returns>
        /// <returns>1 [string] Text</returns>
        /// <returns>2 [string] Icon</returns>
        /// <returns>3 [number] Start Time in Milliseconds</returns>
        /// <returns>4 [number] End Time in Milliseconds</returns>
        /// <returns>5 [boolean] Is Tradeskill Bool</returns>
        /// <returns>6 [boolean] Not Interruptible Boolean</returns>
        /// <returns>7 [number] Spell Identifier</returns>
        abstract ChannelInfo: this: unit -> string * string * string * float * float * bool * bool * float
        /// <summary>
        /// Get the specified unit's casting information.
        /// ** BFA **
        /// <see href="https://wow.gamepedia.com/API_UnitCastingInfo" />
        /// </summary>
        /// <param name="Unit">[IUnitId] The Identifier for the specified unit.</param>
        /// <returns>0 [string] Name</returns>
        /// <returns>1 [string] Text</returns>
        /// <returns>2 [string] Icon</returns>
        /// <returns>3 [number] Start Time in Milliseconds</returns>
        /// <returns>4 [number] End Time in Milliseconds</returns>
        /// <returns>5 [boolean] Is Tradeskill Bool</returns>
        /// <returns>6 [string] Cast Identifier</returns>
        /// <returns>7 [boolean] Not Interruptible Boolean</returns>
        /// <returns>8 [number] Spell Identifier</returns>
        abstract UnitCastingInfo: this: unit * Unit: IUnitId -> string * string * string * float * float * bool * string * bool * float
        /// <summary>
        /// Get the specified unit's casting information.
        /// ** BFA **
        /// <see href="https://wow.gamepedia.com/API_UnitChannelInfo" />
        /// </summary>
        /// <param name="Unit">[IUnitId] The Identifier for the specified unit.</param>
        /// <returns>0 [string] Name</returns>
        /// <returns>1 [string] Text</returns>
        /// <returns>2 [string] Icon</returns>
        /// <returns>3 [number] Start Time in Milliseconds</returns>
        /// <returns>4 [number] End Time in Milliseconds</returns>
        /// <returns>5 [boolean] Is Tradeskill Bool</returns>
        /// <returns>6 [boolean] Not Interruptible Boolean</returns>
        /// <returns>7 [number] Spell Identifier</returns>
        abstract UnitChannelInfo: this: unit * Unit: IUnitId -> string * string * string * float * float * bool * bool * float
        /// <summary><see href="https://wow.gamepedia.com/API_UnitCanAttack" /></summary>
        abstract UnitCanAttack: this: unit * Unit: IUnitId * OtherUnit: IUnitId -> bool
        /// <summary>
        /// Get the Unit's Class.
        /// <see href="https://wow.gamepedia.com/API_UnitClass." />
        /// </summary>
        /// <param name="UnitId">[IUnitId] The Unit's ID</param>
        /// <returns>0 [string] Localised Name</returns>
        /// <returns>1 [string] Enum Name</returns>
        /// <returns>2 [number] Class Id</returns>
        abstract UnitClass: this: unit * UnitId: IUnitId -> string * string * float
        /// <summary><see href="https://wow.gamepedia.com/API_UnitCreatureId" /></summary>
        abstract UnitCreatureId: this: unit * UnitId: IUnitId -> float
        /// <summary><see href="https://wow.gamepedia.com/API_UnitCreatureType" /></summary>
        abstract UnitCreatureType: this: unit * UnitId: IUnitId -> string
        /// <param name="Unit">The first unit we want to check threat from</param>
        /// <param name="OtherUnit">The unit's threat table we are checking against</param>
        /// <example>if (UnitDetailedThreatSituation("player", "target")[1] &gt; 1) { print("Player is Tanking the Target")}</example>
        /// <returns>0 [boolean] - Whether or not you are currently tanking the OtherUnit</returns>
        /// <returns>1 [number] - returns what status your threat is : 0 = not tanking, 1 = not tanking but close to, 2 = tanking but barely, 3 = firmly tanking or nil if not in threat list</returns>
        /// <returns>2 [number] - returns the threat percentage aggregated to how much needed to pull aggro</returns>
        /// <returns>3 [number] - returns the raw threat percentage or nil if not in threat list or nil if not in threat list</returns>
        /// <returns>4 [number] - returns total threat on the OtherUnit</returns>
        abstract UnitDetailedThreatSituation: this: unit * Unit: IUnitId * OtherUnit: IUnitId -> U2<bool, float> * float * float * float * float
        /// <summary><see href="https://wow.gamepedia.com/API_UnitExists" /></summary>
        abstract UnitExists: this: unit * UnitId: IUnitId -> bool
        /// <summary><see href="https://wow.gamepedia.com/API_UnitGroupRolesAssigned" /></summary>
        abstract UnitGroupRolesAssigned: this: unit * UnitId: IUnitId -> string
        /// <summary><see href="https://wow.gamepedia.com/API_UnitGetIncomingHeals" /></summary>
        abstract UnitGetIncomingHeals: this: unit * UnitId: IUnitId -> float
        /// <summary><see href="https://wow.gamepedia.com/API_UnitGetTotalHealAbsorbs" /></summary>
        abstract UnitGetTotalHealAbsorbs: this: unit * UnitId: IUnitId -> float
        /// <summary><see href="https://wow.gamepedia.com/API_UnitGUID" /></summary>
        abstract UnitGUID: this: unit * UnitId: IUnitId -> string
        /// <summary><see href="https://wow.gamepedia.com/API_UnitHealth" /></summary>
        abstract UnitHealth: this: unit * UnitId: IUnitId -> float
        /// <summary><see href="https://wow.gamepedia.com/API_UnitHealthMax" /></summary>
        abstract UnitHealthMax: this: unit * UnitId: IUnitId -> float
        /// <summary><see href="https://wow.gamepedia.com/API_UnitInBattleground" /></summary>
        abstract UnitInBattleground: this: unit * Unit: IUnitId -> bool
        /// <summary><see href="https://wow.gamepedia.com/API_UnitInVehicle" /></summary>
        abstract UnitInVehicle: this: unit * UnitId: IUnitId -> bool
        /// <summary><see href="https://wow.gamepedia.com/API_UnitInParty" /></summary>
        abstract UnitInParty: this: unit * UnitId: IUnitId -> bool
        /// <summary><see href="https://wow.gamepedia.com/API_UnitInRaid" /></summary>
        abstract UnitInRaid: this: unit * UnitId: IUnitId -> bool
        /// <summary><see href="https://wow.gamepedia.com/API_UnitInPhase" /></summary>
        abstract UnitInPhase: this: unit * UnitId: IUnitId -> bool
        /// <summary><see href="https://wow.gamepedia.com/API_UnitIsDead" /></summary>
        abstract UnitIsDead: this: unit * UnitId: IUnitId -> bool
        /// <summary><see href="https://wow.gamepedia.com/API_UnitIsDeadOrGhost" /></summary>
        abstract UnitIsDeadOrGhost: this: unit * UnitId: IUnitId -> bool
        /// <summary><see href="https://wow.gamepedia.com/API_UnitIsGhost" /></summary>
        abstract UnitIsGhost: this: unit * UnitId: IUnitId -> bool
        /// <summary><see href="https://wow.gamepedia.com/API_UnitIsUnit" /></summary>
        abstract UnitIsUnit: this: unit * FirstUnit: IUnitId * SecondUnit: IUnitId -> bool
        /// <summary><see href="https://wow.gamepedia.com/API_UnitIsPlayer" /></summary>
        abstract UnitIsPlayer: this: unit * UnitId: IUnitId -> bool
        /// <summary><see href="https://wow.gamepedia.com/API_UnitIsTapped" /></summary>
        abstract UnitIsTapped: this: unit * UnitId: IUnitId -> bool
        /// <summary><see href="https://wow.gamepedia.com/API_UnitIsTapDenied" /></summary>
        abstract UnitIsTapDenied: this: unit * UnitId: IUnitId -> bool
        /// <summary><see href="https://wow.gamepedia.com/API_UnitIsWarModeDesired" /></summary>
        abstract UnitIsWarModeDesired: this: unit * Unit: IUnitId -> bool
        /// <summary><see href="https://wow.gamepedia.com/API_UnitIsWildBattlePet" /></summary>
        abstract UnitIsWildBattlePet: this: unit * UnitId: IUnitId -> bool
        /// <summary><see href="https://wow.gamepedia.com/API_UnitLevel" /></summary>
        abstract UnitLevel: this: unit * UnitId: IUnitId -> float
        /// <summary><see href="https://wow.gamepedia.com/API_UnitName" /></summary>
        abstract UnitName: this: unit * UnitId: IUnitId -> string
        /// <summary><see href="https://wow.gamepedia.com/API_UnitPower" /></summary>
        abstract UnitPower: this: unit * UnitId: IUnitId * PowerType: IPowerType * Modified: bool -> float
        /// <summary><see href="https://wow.gamepedia.com/API_UnitPowerMax" /></summary>
        abstract UnitPowerMax: this: unit * UnitId: IUnitId * PowerType: IPowerType * Modified: bool -> float
        /// <summary><see href="https://wow.gamepedia.com/API_UnitReaction" /></summary>
        abstract UnitReaction: this: unit * UnitId: IUnitId * OtherUnitId: IUnitId -> float
        /// <summary><see href="https://wow.gamepedia.com/API_UnitDamage" /></summary>
        abstract UnitDamage: this: unit * UnitId: IUnitId -> float * float * float * float * float * float * float
        /// <summary><see href="https://wow.gamepedia.com/API_UnitSpellHaste" /></summary>
        abstract UnitSpellHaste: this: unit * UnitId: IUnitId -> float
        /// <summary><see href="https://wow.gamepedia.com/API_GetMasteryEffect" /></summary>
        abstract GetMasteryEffect: this: unit * UnitId: IUnitId -> float
        /// <summary><see href="https://wow.gamepedia.com/API_UnitStagger" /></summary>
        abstract UnitStagger: this: unit * Unit: IUnitId -> float
        /// <param name="this" />
        /// <param name="Unit" />
        /// <param name="OtherUnit" />
        /// <returns>returns what status your threat is : 0 = not tanking, 1 = not tanking but close to, 2 = tanking but barely, 3 = firmly tanking</returns>
        abstract UnitThreatSituation: this: unit * Unit: IUnitId * OtherUnit: IUnitId -> float option
        /// <summary>Get the items durability current and max</summary>
        abstract GetInventoryItemDurability: this: unit * slotId: float -> float * float


    type [<AllowNullLiteral>] IMapInfo =
        abstract mapType: float with get, set
        abstract mapID: float with get, set
        abstract name: string with get, set
        abstract parentMapID: float with get, set

    module C_Map =

        type [<AllowNullLiteral>] IExports =
            abstract GetBestMapForUnit: this: unit * UnitId: string -> float
            abstract GetMapInfo: this: unit * MapId: float -> IMapInfo
            abstract GetPlayerMapPosition: this: unit * MapId: float * UnitId: string -> Vector2DMixin
            abstract GetWorldPosFromMapPos: this: unit * MapId: float * Position: Vector2DMixin -> obj option


    module Enum =

        module PowerType =

            type [<AllowNullLiteral>] IExports =
                abstract Alternate: float
                abstract ArcaneCharges: float
                abstract Chi: float
                abstract ComboPoints: float
                abstract Energy: float
                abstract Focus: float
                abstract Fury: float
                abstract Insanity: float
                abstract Happiness: float
                abstract HolyPower: float
                abstract LunarPower: float
                abstract Maelstrom: float
                abstract Mana: float
                abstract Obselete: float
                abstract Obselete2: float
                abstract Pain: float
                abstract Rage: float
                abstract Runes: float
                abstract RunicPower: float
                abstract SoulShards: float

        let [<Import("PowerType","module/Enum")>] powerType: PowerType.IExports = jsNative

    module C_ChallengeMode =

        type [<AllowNullLiteral>] IExports =
            /// <summary>Get the Active Keystone Information</summary>
            /// <returns>0 [number] The Active Keystone Level</returns>
            /// <returns>1 [number[]] The active affixes in an array</returns>
            /// <returns>2 [boolean] WasActiveKeystoneCharged (No idea what this does, maybe its for the Tourney Realm)</returns>
            abstract GetActiveKeystoneInfo: this: unit -> float * ResizeArray<float> * bool

    /// <summary><see href="https://wow.gamepedia.com/API_C_MountJournal" /></summary>
    module C_MountJournal =

        type [<AllowNullLiteral>] IExports =
            /// Summon mount by Index (0 for random favorite)
            abstract SummonByID: this: unit * index: float -> unit

    module C_Spell =

        type [<AllowNullLiteral>] IExports =
            /// Get wether a spell exists by it's Id
            abstract DoesSpellExist: this: unit * SpellId: float -> bool

    /// <summary><see href="https://wow.gamepedia.com/API_C_Timer" /></summary>
    module C_Timer =

        type [<AllowNullLiteral>] IExports =
            /// <summary><see href="https://wow.gamepedia.com/API_C_Timer.After" /></summary>
            abstract After: this: unit * Duration: float * Function: Function -> unit
            /// <summary><see href="https://wow.gamepedia.com/API_C_Timer.NewTicker" /></summary>
            abstract NewTicker: this: unit * Duration: float * Function: Function * ?Iterations: float -> unit

    module Math =

        type [<AllowNullLiteral>] IExports =
            abstract cos: this: unit * value: float -> float
            abstract rad: this: unit * value: float -> float
            abstract sin: this: unit * value: float -> float

    type [<AllowNullLiteral>] ITaskPoi =
        abstract questId: float with get, set
        abstract x: float with get, set
        abstract y: float with get, set
        abstract inProgress: bool with get, set
        abstract numObjectives: float with get, set
        abstract mapID: float with get, set
        abstract isQuestStart: bool with get, set
        abstract isDaily: bool with get, set
        abstract isCombatAllyQuest: bool with get, set
        abstract childDepth: float option with get, set

    module C_TaskQuest =

        type [<AllowNullLiteral>] IExports =
            /// <summary><see href="https://wow.gamepedia.com/C_TaskQuest.GetQuestInfoByQuestID" /></summary>
            /// <param name="questId">[number] The quest Identifier</param>
            /// <returns>0 [string] Quest Title</returns>
            /// <returns>1 [number | undefined] Faction Identifier</returns>
            /// <returns>2 [boolean | undefined] Capped (not sure what this refers to)</returns>
            abstract GetQuestInfoByQuestID: this: unit * questId: float -> string * float option * bool option
            /// <param name="MapId">[number] MapId to check.</param>
            /// <returns>TaskPOI [object] Table of TaskPOI objects</returns>
            abstract GetQuestsForPlayerByMapID: this: unit * MapId: float -> ResizeArray<ITaskPoi>

    type [<AllowNullLiteral>] GetPowerInfoResult =
        abstract azeritePowerID: float with get, set
        abstract spellID: float with get, set


    type [<AllowNullLiteral>] IHexColor =
        inherit String

    /// Frame API
    type [<AllowNullLiteral>] IColor =
        abstract R: float with get, set
        abstract G: float with get, set
        abstract B: float with get, set
        abstract A: float with get, set
        abstract Hex: IHexColor with get, set



    type [<AllowNullLiteral>] IPoint =
        abstract Anchor: string with get, set
        abstract X: float with get, set
        abstract Y: float with get, set


    type [<AllowNullLiteral>] ISize =
        abstract Height: float with get, set
        abstract Width: float with get, set


    type [<AllowNullLiteral>] CreatedScrollFrame =
        inherit CreatedFrame
        abstract GetVerticalScroll: unit -> float
        abstract GetVerticalScrollRange: unit -> float
        abstract SetScrollChild: child: CreatedFrame -> unit
        abstract SetVerticalScroll: range: float -> float

    type [<AllowNullLiteral>] CreatedTextField =
        inherit CreatedFrame
        abstract First: bool with get, set
        abstract MaxChar: float option with get, set
        abstract Tooltip: string with get, set
        abstract TooltipAnchor: CreatedFrame option with get, set
        abstract Set: this: unit * Value: float -> unit

    type [<AllowNullLiteral>] CreatedTextArea =
        inherit CreatedTextField
    type [<AllowNullLiteral>] CreatedScrollableTextArea =
        inherit CreatedScrollFrame
        abstract Children: CreatedTextArea with get, set



    /// A frame that acts as a button with text on it
    type [<AllowNullLiteral>] CreatedButton =
        inherit CreatedFrame
        abstract First: bool with get, set
        abstract OnClick: Function option with get, set
        abstract Click: this: unit -> unit
        abstract SetEnabled: this: unit * Enabled: bool -> unit
        abstract Set: this: unit * Value: float -> unit

    /// A frame that can be clicked to display a menu
    type [<AllowNullLiteral>] CreatedDropDown =
        inherit CreatedFrame
        /// The currently selected value
        abstract Current: string with get, set
        /// The frame that pops up when the user click the dropdown
        abstract DropDownFrame: CreatedDropDownFrame with get, set
        /// Wether the frame is meant to appear first or second (soon to be changed)
        abstract First: bool with get, set
        /// The options that were passed when we created the dropdown
        abstract Options: ResizeArray<string> with get, set
        /// The FontString that display the currently selected value
        abstract TitleFontString: FontString with get, set
        /// Event called when the user clicks
        abstract OnClick: Function option with get, set
        /// Event called when the user clicks
        abstract OnMouseWheel: Function option with get, set
        /// Event called when the user select an element in the dropdown frame
        abstract OnSelected: Function option with get, set
        /// Perform click event
        abstract Click: this: unit -> unit
        /// Disable or enable the control
        abstract SetEnabled: this: unit * Enabled: bool -> unit
        /// Set the current value of this control
        abstract Set: this: unit * Value: string -> unit

    type [<AllowNullLiteral>] CreatedNumericField =
        inherit CreatedFrame
        abstract AfterChanged: Function option with get, set
        abstract First: bool with get, set
        abstract Max: float with get, set
        abstract Min: float with get, set
        abstract Step: float with get, set
        abstract Value: float with get, set
        abstract Set: this: unit * Value: float -> unit

    type [<AllowNullLiteral>] CreatedCheckbox =
        inherit CreatedFrame
        abstract AfterClicked: Function option with get, set
        abstract Checked: bool with get, set
        abstract Set: this: unit * Enabled: bool -> unit

    type [<AllowNullLiteral>] CreatedIconFrame =
        inherit CreatedFrame
        abstract SetNormalTexture: iconIdOrPath: U2<float, string> -> unit
        abstract SetPushedTexture: iconIdOrPath: U2<float, string> -> unit
        abstract SetHighlightTexture: iconIdOrPath: U2<float, string> -> unit

    type [<AllowNullLiteral>] ChildrenFrames =
        abstract Check: CreatedCheckbox with get, set
        abstract Title: FontString with get, set
        abstract Value: CreatedNumericField with get, set
        abstract Value2: CreatedNumericField with get, set
        abstract Select: CreatedDropDown with get, set
        abstract Select2: CreatedDropDown with get, set

    type [<AllowNullLiteral>] CreatedRow =
        inherit CreatedFrame
        abstract Childs: ChildrenFrames with get, set



    module C_Item =

        type [<AllowNullLiteral>] IExports =
            /// <summary>
            /// Get whether or not an item exists in a specific equipment slot.
            /// <see href="https://wow.gamepedia.com/API_C_Item.DoesItemExist" />
            /// </summary>
            /// <param name="ItemLocation">[CreatedEquipmentSlot] - The virtual equipment slot.</param>
            /// <returns>[boolean] - Whether or not the item exists</returns>
            abstract DoesItemExist: this: unit * ItemLocation: CreatedEquipmentSlot -> bool
            /// <summary>
            /// Get the Item ID an equipment slot.
            /// <see href="https://wow.gamepedia.com/API_C_Item.GetItemID" />
            /// </summary>
            /// <param name="ItemLocation">[CreatedEquipmentSlot] - The virtual equipment slot.</param>
            /// <returns>[number] - Item ID</returns>
            abstract GetItemID: this: unit * ItemLocation: CreatedEquipmentSlot -> float

    module C_AzeriteEmpoweredItem =

        type [<AllowNullLiteral>] IExports =
            abstract GetPowerInfo: this: unit * Index: float -> GetPowerInfoResult option
            abstract IsAzeriteEmpoweredItem: this: unit * ItemLoc: CreatedEquipmentSlot -> bool
            abstract IsPowerSelected: this: unit * ItemLoc: CreatedEquipmentSlot * AzeriteId: float -> bool



    type [<RequireQualifiedAccess>] ObjectType =
        | Object = 0
        | Item = 1
        | Container = 2
        | AzeriteEmpoweredItem = 3
        | AzeriteItem = 4
        | Unit = 5
        | Player = 6
        | ActivePlayer = 7
        | GameObject = 8
        | DynamicObject = 9
        | Corpse = 10
        | AreaTrigger = 11
        | SceneObject = 12
        | ConversationData = 13

    /// Simple library that we use to store data
    module Json =

        type [<AllowNullLiteral>] IExports =
            /// Encode an object into a string
            abstract encode: this: unit * value: obj * ?state: obj -> string
            /// Decode a string into an object
            abstract decode: this: unit * obj: string * ?pos: float * ?nullval: bool -> obj

    type [<RequireQualifiedAccess>] TOwnerIndex =
        | N1 = 1
        | N2 = 2

    type [<RequireQualifiedAccess>] TPetIndex =
        | N1 = 1
        | N2 = 2
        | N3 = 3

    type [<RequireQualifiedAccess>] TAbilityIndex =
        | N1 = 1
        | N2 = 2
        | N3 = 3

    module C_PetBattles =

        type [<AllowNullLiteral>] IExports =
            abstract CanActivePetSwapOut: this: unit -> bool
            abstract CanPetSwapIn: this: unit * petIndex: float -> bool
            /// <summary>
            /// C_PetBattles.GetAbilityInfo	Returns information on a battle pet's ability
            /// <see href="http://wowprogramming.com/docs/api/C_PetBattles.GetAbilityInfo.html" />
            /// 0 = Ability Id
            /// 1 = Ability Name
            /// 2 = Icon Id
            /// 3 = MaxCooldown
            /// 4 = Description
            /// 5 = NumTurns
            /// 6 = AbilityPetType
            /// 7 = NoStrongWeak
            /// </summary>
            abstract GetAbilityInfo: this: unit * ownerIndex: TOwnerIndex * petIndex: TPetIndex * abilityIndex: TAbilityIndex -> float * string * float * float * string * float * float * bool
            abstract GetAbilityState: this: unit * ownerIndex: TOwnerIndex * petIndex: TPetIndex * abilityIndex: TAbilityIndex -> bool
            abstract GetActivePet: this: unit * ownerIndex: TOwnerIndex -> float
            abstract GetHealth: this: unit * ownerIndex: float * petIndex: float -> float
            abstract GetLevel: this: unit * ownerIndex: float * petIndex: float -> float
            abstract GetMaxHealth: this: unit * ownerIndex: float * petIndex: float -> float
            /// <summary>
            /// Returns the name of a pet
            /// First return is player defined name
            /// Second return is real name
            /// </summary>
            abstract GetName: this: unit * ownerIndex: float * petIndex: float -> string * string
            abstract GetNumAuras: this: unit * ownerIndex: float * petIndex: float -> float
            abstract GetNumPets: this: unit * ownerIndex: float -> float
            abstract GetPetType: this: unit * ownerIndex: float * petIndex: float -> float
            /// <summary>C_PetBattles.GetTurnTimeInfo	Returns the remaining time and max time for waiting on a turn</summary>
            abstract GetTurnTimeInfo: this: unit -> float * float * float
            abstract IsInBattle: this: unit -> bool
            abstract IsWildBattle: this: unit -> bool
