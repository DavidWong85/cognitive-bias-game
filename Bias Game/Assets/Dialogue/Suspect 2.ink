-> main

===main===
This is Suspect 2.
This is just a place holder file.
With some choices.
->Choice

===Choice===
Please choose an option: 
    + [1st]
        Are you sure to chose this option?
            + + Yes!
                -> chosen("first option!")
            + + No.
                -> Choice
    + [2nd]
        Are you sure to chose this option?
            + + Yes!
                -> chosen("second option!")
            + + No.
                -> Choice
    + [3nd]
        Are you sure to chose this option?
            + + Yes!
                -> chosen("third option!")
            + + No.
                -> Choice
    + [4nd]
        Are you sure to chose this option?
            + + Yes!
                -> chosen("forth option!")
            + + No.
                -> Choice
        
===chosen(option)===
You chose the {option}
-> END