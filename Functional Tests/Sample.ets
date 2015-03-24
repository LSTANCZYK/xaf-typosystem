;#DropDB DigiPrintEasyTest

#Application DigiPrintWin
#Application DigiPrintWeb

*Action Navigation(User)

*ProcessRecord
 Full Name = ''

#IfDef DigiPrintWeb
*Action Edit
#EndIf
 
*FillForm
 Full Name = Test User
 
*Action Cancel

#IfDef DigiPrintWin
*HandleDialog
 Respond = Yes
#EndIf

*CheckFieldValues
 Full Name = ''
