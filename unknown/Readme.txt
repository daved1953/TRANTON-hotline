Name: CustPhrs

Description:

This sample shows the use of VBVoice custom greeting code, 
where code can change or add greetings.


Steps Required:
The VBVoice manual provides a listing of available greeting 
and  phrase methods, as well as the phrase properties.


Implementation:
In this sample, the LineGroup control answers the call.  
The GetDigits "GetNum" control will prompt the user to enter 
a single digit 1-6 (* to end the call).  Code in the enter 
event of "PlayData" will examine the digit entered, and take 
different actions based on the data.  By default, the 
PlayData control is set up to play a System Phrase, Initial 
greeting (this is defined on the Greetings property page of 
the control.

-If a 1 is entered, all the phrases in the greeting are 
removed.
-If a 2 is entered, some system phrases are inserted before 
the existing phrase.
-If a 3 is entered, the existing phrase is changed to a 
system phrase, Money, and the value to be said is changed.
-If a 4 is entered, a .wav file is inserted and a vap phrase 
is inserted.  Note that the vap phrase could also be inserted 
using the mechanism used in the second phrase of option 2.
-If a 5 is entered, a new phrase object is created, its 
parameters and data set, and it replaces the existing phrase.
-If a 6 is entered, the same code as option 5 is used, except
the CheckPhrase method is invoked to test that the phrase is 
set up correctly.  This method is especially valuable when 
using variables inside the custom greeting code.  If an error
is found, a trappable VB error happens, and VB "On Error" 
handling code will trap this.
-If a 7 is entered, nothing happens (the default Initial 
Greeting plays).


Notes:
The declaration for the enter event of any VBVoice control 
that can play greetings is:

 Private Sub PlayData_Enter(ByVal Channel As Integer, ByVal Greeting As Object)

The "Greetings As Object" is a copy of the Greeting that 
is set up in the property pages of the control.  
Modifications to this object by VB code only effect the 
current call on the current channel.  Subsequent calls, 
or calls on other channels are unaffected, unless VB code 
also changes the greeting for those calls.

Custom greeting code can also use VB variables and 
functions to get the data to play.

For situations where the data to be played changes but 
the type of phrase to be played doesn't (e.g. a changing 
balance), most users will find it easier to use a transfer 
property and simply set up a System Phrase.  See the 
"Transfer" example for details on using transfer properties.
