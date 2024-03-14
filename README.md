# Metasploit-Log-Parser

## Installation:
1. Download Visual Studio 2022
2. During installation you would need to include the .NET Desktop Development in your Visual Studio Installer or you can always modify your current installation

## Usage:
For meterpreter logs:
1.  It excludes the bg and help commands since those are usually useless
2.  Just click on the On? checkbox and it would auto to "meterpreter", which would get the line after the meterpreter line
3.  When you are ready you can just click on "Output To File" and it would write to a file named "test.log" in the pwd where the exe was executed

![Alt text](screenshot/filter_meterpreter.png?raw=true "Title")

For any other logs:
1. Just click on the On? checkbox and type in the text you want for e.g. in the below i want any lines that contains "getuid"
2. When you are ready you can just click on "Output To File" and it would write to a file named "test.log" in the pwd where the exe was executed

![Alt text](screenshot/filtering_others.png?raw=true "Title")

## Description:
This application's main objective is for you to parse the meterpreter logs, so that you are able to filter out the actual commands that you have executed in a meterpreter shell, for ease during report writing.
As seen in meterpreter's logs, the input you specified always has a prefixed meterpreter   > before the command you executed in your shell,
e.g. 
[03/07/2024 02:09:10]   meterpreter   >
[03/07/2024 02:09:10] help 
As such this application would find for  meterpreter and get the next line in the logs
It also formats and output the logs with ] so that you can later import it into an excel file with the delimeter ]
