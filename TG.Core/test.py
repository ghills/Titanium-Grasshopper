#Test python script to experiment with C# interoperability

import clr
clr.AddReferenceToFile("TG.Model.dll")
clr.AddReferenceToFile("TG.UI.dll")
from TG.UI import Program
from TG.UI import MainWindow
from Models.GameState import GameState
from Windows.GameStateLayer import ExportGameState

state = GameState()
    
def onload( sender, e):
    new_state = ExportGameState(state)
    Program.SetState(ExportGameState(state))
    Program.SetInputHandler(handleInput)
    
def handleInput(sender, e):
    state = GameState()
    state.GameText = "You said: " + sender.Text
    Program.SetState( ExportGameState(state) )
    myFunction()
    
def main():
    state = GameState()
    state.HitPoints = 100
    Program.RunGUI(onload)
    
def myFunction():
    print "here is where we would do some exciting processing...."

if __name__ == "__main__":
    main()