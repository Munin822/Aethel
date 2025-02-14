extends Node

class Lore:
    var title = ""
    var content = ""
    var is_hidden = false
    var discovered = false
    var easter_egg = false

    func _init(_title: String, _content: String, _is_hidden: bool = false, _discovered: bool = false, _easter_egg: bool = false):
        title = _title
        content = _content
        is_hidden = _is_hidden
        discovered = _discovered
        easter_egg = _easter_egg

var lore_list = []

func add_lore(title: String, content: String, is_hidden: bool = false, easter_egg: bool = false):
    var lore = Lore.new(title, content, is_hidden, false, easter_egg)
    lore_list.append(lore)

func discover_lore(title: String):
    for lore in lore_list:
        if lore.title == title:
            lore.discovered = true
            break

func get_discovered_lore():
    return lore_list.filter(func(l): return l.discovered)

func get_hidden_lore():
    return lore_list.filter(func(l): return l.is_hidden and not l.discovered)

func get_easter_eggs():
    return lore_list.filter(func(l): return l.easter_egg)