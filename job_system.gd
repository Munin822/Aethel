extends Node

var classes = {
    "Hekatean Weaver": preload("res://scripts/classes/hekatean_weaver.gd"),
    "Lupine Legionnaire": preload("res://scripts/classes/lupine_legionnaire.gd"),
    "Artificer": preload("res://scripts/classes/artificer.gd"),
    "Inspired": preload("res://scripts/classes/inspired.gd"),
    "Umbrevian Wraith": preload("res://scripts/classes/umbrevian_wraith.gd")
}

func get_class(class_name: String):
    if classes.has(class_name):
        return classes[class_name].new()
    return null