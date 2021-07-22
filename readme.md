# Harish OS
## version beta 1.0
##
##
## Video -  https://www.youtube.com/watch?v=wPPsCIoCY-U
## How to contribute - https://youtu.be/a19tddFNn-o
## How to develop with cosmos framework for OS - https://www.youtube.com/watch?v=XK54xhGCM9w


## What to contribute
 - cosmos os is just a basic c# console application which is complied into a OS
 - basic knowledge of c# is needed to use cosmos
 - cosmos does not invlove any unknown libraries but uses native c#
 - its a good project for beginners and experts
 - you can make changes in the c# code, like - add new features, commands and bug fixes
 - the code is very simple to understand, even for begineers
 - i have a video attached for beginners if they dont know about contributing in github
 - I Hope best of luck for the community, even i will be commiting regular updates on this project


## 
##
## How To Run Harish OS
 - First Download The zip file from realeases and extract it, which will have the iso and vmdk for virtualbox
 - use a virtual box or vmware to run the iso
 - as a hard disk please use FileSystem.vmdk
 - And please use AHCI controller type in virtual machine 
 - !!! The OS is not recommended to run in physical computer

##
## HarishOS commands
| command | work
| ------ | -----|
| ls | list the directories in the current working directory
| cd <dir>  | changes the working directory to <dir>
| disk | show the disk options
| miv | opens the miv text editor
| echo *<args> | prints out the *<agrs> provided
| mkdir <dir> | creates a directory in the working directory
| rmdir <dir> | removes a directory in the working directory
| cat <fs_path> | print out the contents of the file *please use full path
| rmfile <fs_path| removes a file *please use full path
| add | opens addition
| sub | opens subtraction
| mul | opens multiplication
| div | opens division
| shutdown | powers off the system
| restart| restarts the system
| prompt <arg> | changes the bash prompt to <arg>
| clear | clears the screen
| game | starts the snake game
##
##
## Disk Commands
| command | work |
| ---- |----|
| size | tells the dirve size
| space | tells the amount of space available in the hard disk
| format | formats the hard disk
| -h | opens help menu


##
##
## MIV Text Editor (MInimalistic Vi)
 - the miv text editor is made by https://github.com/bartashevich/MIV
 - miv works just like vim
 
 ##### Possible arguments
- miv(null) - open blank page
- miv(String) - open page with String

 ##### Possible action inside editor (key shotcuts)
 - i (Enter INSERT mode)
 - ESC button (Exit INSERT mode)
 - :wq (Save and Exit), returns String of text
 - :q (Quit without saving), returns null 
 

 ## Please Feel Free to contribute to this os
