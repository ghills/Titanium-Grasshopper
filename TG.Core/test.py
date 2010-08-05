#Test python script to experiment with C# interoperability

import clr
clr.AddReferenceToFile("TG.Model.dll")
clr.AddReferenceToFile("TG.UI.dll")
from TG.Model import GameState
from TG.UI import Program
from TG.UI import MainWindow
    
def onload( sender, e):
    print "Hello!"
    state = GameState()
    print state.CharacterName
    print dir(Program)
    #Program.SetState(state)
    

def main():
    Program.RunGUI(onload)
    
        
if __name__ == "__main__":
    main()