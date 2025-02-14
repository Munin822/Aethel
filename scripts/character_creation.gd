extends Control

var selected_class = "Hekatean Weaver"
var character_name = ""
var hair_style = "Short"
var skin_tone = "Light"

func _ready():
    $ClassSelection.connect("item_selected", self, "_on_ClassSelection_item_selected")
    $HairSelection.connect("item_selected", self, "_on_HairSelection_item_selected")
    $SkinSelection.connect("item_selected", self, "_on_SkinSelection_item_selected")
    $CreateButton.connect("pressed", self, "_on_CreateButton_pressed")

func _on_ClassSelection_item_selected(index):
    selected_class = $ClassSelection.get_item_text(index)

func _on_HairSelection_item_selected(index):
    hair_style = $HairSelection.get_item_text(index)

func _on_SkinSelection_item_selected(index):
    skin_tone = $SkinSelection.get_item_text(index)

func _on_CreateButton_pressed():
    character_name = $NameEdit.text
    var player_scene = preload("res://scenes/player.tscn").instance()
    player_scene.set_class(selected_class)
    player_scene.set_name(character_name)
    player_scene.set_appearance(hair_style, skin_tone)
    get_tree().change_scene("res://scenes/game_world.tscn")
    var game_world = get_tree().current_scene
    game_world.add_child(player_scene)
    player_scene.position = Vector2(100, 100)  # Set initial position