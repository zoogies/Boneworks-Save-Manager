#download current save to 100 profile

#imports
import os
import sys
import shutil #might not use this
from pathlib import Path

#open users boneworks path
with open(os.path.join(sys.path[0], "saved_path.txt"),"r") as savedatapathfile:
    savedatapath = savedatapathfile.read()
    savedatapathfile.close()

hundredsavepath = Path("C:/Program Files (x86)/Yoyolick/Boneworks Save Manager/data/hundred_save/resources1.dat")
errors = ""
results = ""

shutil.move(savedatapath, hundredsavepath)
#results = "operation success"
#print("operation success")

    #print("an error has occured, check your save data path")
    #errors = "an error has occured, check your save data path"
#code by ryan zmuda 2020