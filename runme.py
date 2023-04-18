import random
import os
from tkinter import *

root = Tk()
root.config(bg="black")
Label(root, text="Szia Lajos", fg="white").pack()
root.mainloop()

os.system(f"echo {random.randint(1,1012021)}")

max = random.randint(1,100)
for i in range(max):
    print("*"*i)
for j in range(max, 0, -1):
            print("*"*j)
        