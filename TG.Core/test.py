import clr
clr.AddReferenceToFile("TG.Model.dll")
clr.AddReferenceToFile("TG.UI.dll")
from TG.Model import GameState
from TG.UI import Program
import thread
import time
    
def onload():
    print "Hello!"
    state = GameState()
    print state.CharacterName
    print dir(Program)
    Program.SetState(state)
    raw_input()
    

def main():
    #thread.start_new_thread(Program.RunGUI, ())
    Program.RunGUI(onload)
    
        
if __name__ == "__main__":
    main()