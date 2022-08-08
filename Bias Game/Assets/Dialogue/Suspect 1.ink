-> main

===main===
This is Suspect 1.
Then this is the second line.
And the 3rd line of the test dialogue.
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