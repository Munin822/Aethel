extends KinematicBody2D

var faction = ""
var dialogue = []

func _ready():
    # Placeholder for NPC initialization logic
    pass

func interact():
    # Logic for interacting with the player
    show_dialogue()

func show_dialogue():
    for line in dialogue:
        print(line)