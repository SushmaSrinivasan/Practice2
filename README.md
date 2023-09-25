# Practice2

C# exercise - Flow via loops and string manipulation

NOTE - The result of the exercise must be shown to teachers and approved before it can be considered completed.
The exercise can be written entirely in the program class using the menu of the Main method.


Main menu
Create a main menu for the program that keeps it alive and informs
User.
To create the main menu of the program, do the following:

1. Tell the user that they have arrived at the main menu and they will navigate
by entering numbers to test different functions.
2. Create the skin of a Switch statement that initially has Two Cases. One for "0" as
shuts down the program and a default telling you that it is incorrect input.
3. Create an infinite iteration, that is, something that does not end before we tell it
is about to end. You solve this by creating your own bool with associated while-loop.
4. Expand the menu with choices to execute the other exercises.


Menu option 1: Youth or retired
To exemplify if statements, you should implement, on behalf of a theoretical local bio,
A program that checks whether a person is retired or young at the specified age. To
To get to this function, a case in the main menu should be created for "1", this should also
appear in the text that explains the menu.
To do this, you should use a nested if statement. It shall be done as follows
process:
1. User enters an age in numbers
2. The program converts this from a string to an int
3. The program sees if the person is a youth (under 20 years old)
4. If the above is true, the program should print: Youth price: 80kr
5. Otherwise, the program checks if the person is a pensioner (over 64 years old)
6. If the above is true, the program should screw out: Senior price: 90kr
7. Otherwise, the program must print: Standard price: 120kr
We also want to be able to calculate the price for an entire party. Add it
option in the main menu (a case "2"). It's also ok to have the option in a submenu.
We then first indicate how many of us are going to the cinema. 
. Then asks for the age of each one
, and then print a summary in the console that should include the following:
● Number of persons
● As well as total cost for the whole party


Menu option 2: Repeat ten times
To use a different type of iteration, you should implement a for-loop here. This shall:
You create to repeat something a user types in ten times. In other words, it should not:
be written via ten pieces "Console.Write(Input);" but via a loop that does this ten
times. To get to this function, you should add a case for "3" in you
main menu as well as text explaining this.
The sequence of events is shown below:
1. User enters an arbitrary text
2. The program saves the text as a variable
3. The program writes, via a for-loop this text ten times in a row, ie WITHOUT
line breakage. Examples of outputs: 1. Input, 2. Input, 3. Input, etc


Menu option 3: The third word
You have previously learned how we convert strings to integers (eg int. Parse, int. TryParse)men
Now let's split a string. The user must enter a sentence, which the program divides
in words via the string's . Split(char) method. You shall divide the string of each space. To
Simply store this, input should be saved as one each, as you will get back more than one string.
To test this, you should create case "4" in your main menu and write an explanation in
Text.
The sequence of events is explained below:
1. The user enters a sentence of at least 3 words
2. The program splits the string using the split method on each space
3. The program picks out the third string (word) from input
4. The program prints the third string(word)
Document

Don't forget to comment on your code carefully so that you or others can easily understand it in
Future.
Extra tasks for those who have time to spare:
1. Validate all inputs from the user. Make sure that the program does not crash at
Incorrect input.
2. Children under five and seniors over 100 go for free.
3. Deal with multiple spaces in a row in Part 3.
4. What you think seems to be interesting to include or want to practice!
