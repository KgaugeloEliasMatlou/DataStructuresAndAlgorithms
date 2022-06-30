using System;
using System.Collections;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        float[] gradesArray = new float[5];

        addGrades(gradesArray);
        displayGrades(gradesArray);

        //Creating A new Stack

        System.Collections.Stack myStack = new System.Collections.Stack();

        pushStack(gradesArray, myStack);

        popStack(myStack);
        popStack(myStack);

        SortedList myCourses = new SortedList();

        populateList(myCourses);
        displayList(myCourses, "CS101");
        removeListItem(myCourses, "CS201");

    }


    static void addGrades(float[] gradesArray)
    {
        gradesArray[0] = 98;
        gradesArray[1] = 99;
        gradesArray[2] = 89;
        gradesArray[3] = 95;
        gradesArray[4] = 96;
    }
    static void displayGrades(float[] gradesArray)
    {
        foreach (double item in gradesArray)
        {
            Console.WriteLine(item);
        }
    }

    private static void pushStack(float[] gradesArray, System.Collections.Stack stack)
    {
        foreach (float item in gradesArray)
        {
            stack.Push(item);
        }
    }
    // pop the top item from the stack object passed in
    // and write the value out to the console window
    static void popStack(System.Collections.Stack stack)
    {
        Console.WriteLine("Item removed from the stack: ");
        float item = (float)stack.Pop();
        Console.WriteLine(item);
    }
    static void populateList(SortedList list)
    {
        list.Add("CS101", "Introduction to Computer Science");
        list.Add("CS102", "Data Structures and Algorithm Analysis");
        list.Add("CS201", "Introduction to Databases");
        list.Add("CS301", "Introduction to Object-Oriented Programming");
    }
    static void displayList(SortedList list, string key)
    {
        int index;
        string course;
        index = list.IndexOfKey(key);
        course = (string)list.GetByIndex(index);
        Console.WriteLine(course);
    }
    static void removeListItem(SortedList list, string key)
    {
        int index;
        string course;
        index = list.IndexOfKey(key);
        course = (string)list.GetByIndex(index);
        list.Remove(key);
        Console.WriteLine(course + " was removed from the list.");
    }


}
