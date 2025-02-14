extends Node2D

var player
var enemies = []

func _ready():
    player = get_parent().get_node("Player")
    enemies = get_parent().get_nodes_in_group("enemies")

func start_combat():
    # Start combat logic
    pass

func player_attack(target):
    # Player attack logic
    pass

func enemy_attack():
    # Enemy attack logic
    pass

func end_combat():
    # End combat logic
    pass