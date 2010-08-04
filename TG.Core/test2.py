import clr
clr.AddReferenceToFile("TG.Model.dll")
clr.AddReference('System')
clr.AddReference("System.Windows.Forms")
from TG.Model import GameState
from System import *
from System.Reflection import *
from System.Threading import *
from System.Windows.Forms import Application
from time import sleep

def RunMeCallBack(var):
    global App
    asm = Assembly.LoadFrom('TG.UI.exe')
    asm_type = asm.GetType('TG.UI.frmGUIAT')
    App = Activator.CreateInstance(asm_type)
    Application.Run(App)

def main():
    App = None
    ThreadPool.QueueUserWorkItem(WaitCallback(RunMeCallBack))
    while not App:
        sleep(0.2)

if __name__ == "__main__":
    main()