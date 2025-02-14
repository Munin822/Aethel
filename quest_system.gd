extends Node

class Quest:
    var title = ""
    var description = ""
    var is_completed = false

    func _init(_title: String, _description: String):
        title = _title
        description = _description

var quests = []

func add_quest(title: String, description: String):
    var quest = Quest.new(title, description)
    quests.append(quest)

func complete_quest(title: String):
    for quest in quests:
        if quest.title == title:
            quest.is_completed = true
            break

func get_active_quests():
    return quests.filter(func(q): return not q.is_completed)