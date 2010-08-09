import clr
clr.AddReferenceToFile("TG.Model.dll")
clr.AddReferenceToFile("TG.UI.dll")
from TG.Model import GameState
    
def ExportGameState(state):
    winState = GameState()
    winState.HitPoints = state.HitPoints
    winState.Damage = state.Damage
    winState.CharacterName = state.Name
    winState.GameText = state.GameText
    return winState