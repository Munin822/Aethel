extends Node

class Equipment:
    var name = ""
    var slot = ""
    var stats = {}
    var class_restrictions = []
    var upgrade_level = 0

    func _init(_name: String, _slot: String, _stats: Dictionary, _class_restrictions: Array = [], _upgrade_level: int = 0):
        name = _name
        slot = _slot
        stats = _stats
        class_restrictions = _class_restrictions
        upgrade_level = _upgrade_level

var equipment_list = []

func add_equipment(name: String, slot: String, stats: Dictionary, class_restrictions: Array = [], upgrade_level: int = 0):
    var equipment = Equipment.new(name, slot, stats, class_restrictions, upgrade_level)
    equipment_list.append(equipment)

func get_equipment_by_slot(slot: String):
    return equipment_list.filter(func(e): return e.slot == slot)

func upgrade_equipment(name: String):
    for equipment in equipment_list:
        if equipment.name == name:
            equipment.upgrade_level += 1
            # Enhance stats based on upgrade level
            for key in equipment.stats.keys():
                equipment.stats[key] += equipment.upgrade_level * 2
            break