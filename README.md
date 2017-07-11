### Planet and Spaceships

Exercise

In the Main method, place the following code

List<string> planetList = new List<string>(){"Mercury", "Mars"};
Add() Jupiter and Saturn at the end of the list.
Create another List that contains that last two planet of our solar system.
Combine the two lists by using AddRange().
Use Insert() to add Earth, and Venus in the correct order.
Use Add() again to add Pluto to the end of the list.
Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets.
Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList.