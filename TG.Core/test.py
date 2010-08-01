import clr
clr.AddReferenceToFile("TG.Model.dll")
clr.AddReferenceToFile("TG.UI.dll")
from TG.Model import GameState
from TG.UI import Program
import thread
import time
    
        
def main():
    print "Hello!"
    state = GameState()
    print state.CharacterName
    print dir(Program)
    thread.start_new_thread(Program.RunGUI, ())
    #Program.RunGUI()
    time.sleep(2)
    Program.SetState(state)
    raw_input()
    
        
if __name__ == "__main__":
    main()