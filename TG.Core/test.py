#Test python script to experiment with C# interoperability

import clr
clr.AddReferenceToFile("TG.Model.dll")
clr.AddReferenceToFile("TG.UI.dll")
from TG.Model import GameState
from TG.UI import Program
from TG.UI import MainWindow
    
def onload( sender, e):
    state = GameState()
    Program.SetState(state)
    Program.SetInputHandler(handleInput)
    
def handleInput(sender, e):
    state = GameState()
    state.GameText = "You said: " + sender.Text
    Program.SetState( state )
    myFunction()
    
def main():
    Program.RunGUI(onload)
    
def myFunction():
    print "here is where we would do some exciting processing...."

if __name__ == "__main__":
    main()