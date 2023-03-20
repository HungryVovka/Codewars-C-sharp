// -----------------------------------------------------------
// Color Ghost
// Create a class Ghost
// 
// Ghost objects are instantiated without any arguments.
// 
// Ghost objects are given a random color attribute of "white" or "yellow" or "purple" or "red" when instantiated
// 
// ghost = new Ghost();
// ghost.color //=> "white" or "yellow" or "purple" or "red"
// -----------------------------------------------------------

using System;

public class Ghost
{
    string[] colorGhost = {"purple", "red", "white", "yellow"};

    public string GetColor(){
        return colorGhost[new Random().Next(0, colorGhost.Length)];
    }
}
