#download current save to 100 profile

#imports
import os
import shutil
import pathlib

#open users boneworks path
savedatapathfile = open("saved_path.txt","r")
savedatapath = savedatapathfile.read()
savedatapathfile.close()

100savepath = "C:\Program Files (x86)\Yoyolick\Boneworks Save Manager\data\100_save"
errors = ""
results = ""

if not 100savepath.exists():
    errors = "File path to save profile not found, did you install it in the right place?"

shutil.move(savedatapath, 100savepath)
#   print("an error has occured, check your save data path")

#code by ryan zmuda 2020