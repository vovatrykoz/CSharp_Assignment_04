# CSharp_Assignment_04
Assignment 4

Requiremenents 

4.1 The Party class should only define instance variables for storing input, as in the figure below (costPerCapita and guestList). Do not
use any other instance variable, but you may (should) use as many local variables (variables inside a method) as you may need.

4.2 Write also a constructor with one parameter in the Party class, as shown in the code snippet below.

4.3 All output values should be provided to the caller through the return statement of the methods that you write for calculation of a value.
For small calculations, a read-only Property, i.e. a Property with only get-accessor, can be used.

4.4 The guestList array should be sized with a capacity given by the user on the GUI. It should store names of every guest in the format
“firstName all caps” + “,” and “lastName”, e.g. “SIMPSON, Homer”.

4.5 MainForm should only have one instance variable, the party as shown in the code clip here.
The Constructor of
the Party class
This values comes
from the caller
(MainForm)
The array is created here
Note. Do not write a
property for the array!

4.6 When the user clicks the Add button, MainForm should check so the contents of the two textboxes intended for input of first name
and last name are not empty. It should then send the names to the Party class where they should be formatted and put together to
one string (LAST NAME, first name, as given by the user) and saved in the first vacant position in the array.

4.7 When the user clicks the Delete button, the MainForm should fetch the index to the ListBox item selected and call a method in the
Party class with this information as a method parameter to mark the array element at that position as vacant (empty).

4.8 When adding or deleting an item, the ListBox should be updated (clear and refill with values from the array in the Party class.
