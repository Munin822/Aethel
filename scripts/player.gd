extends KinematicBody2D

var stats = {
    "strength": 10,
    "magic": 10,
    "dexterity": 10
}

var current_class = null
var character_name = ""
var hair_style = "Short"
var skin_tone = "Light"
var equipment = {
    "head": null,
    "body": null,
    "legs": null,
    "weapon": null
}

func set_class(class_name: String):
    var job_system = preload("res://scripts/job_system.gd").new()
    current_class = job_system.get_class(class_name)

func set_name(name: String):
    character_name = name

func set_appearance(hair: String, skin: String):
    hair_style = hair
    skin_tone = skin

func equip_item(slot: String, item: Resource):
    equipment[slot] = item
    update_sprite()

func update_sprite():
    # Update the character sprite based on the current equipment
    pass

func use_ability(ability_name: String, target):
    if current_class:
        current_class.use_ability(ability_name, target)