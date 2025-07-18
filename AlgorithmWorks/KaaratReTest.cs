﻿/*
You are reading a Build Your Own Story book. It is like a normal book except that choices on some pages affect the story, 
sending you to one of two options for your next page.

These choices are really stressing you out, so you decide that you'll either always pick the first option, or always pick the second option.

You start reading at page 1 and read forward one page at a time unless you reach a choice or an ending.

The choices are provided in a list, sorted by the page containing the choice, and each choice has two options of pages to go to next. 
In this example, you are on page 3, where there is a choice. Option 1 goes to page 14 and Option 2 goes to page 2.

choices1 = [[3, 14, 2]] => [current_page, option_1, option_2]
The ending pages are also given in a sorted list:

endings = [6, 15, 21, 30]

Given a list of endings, a list of choices with their options, and the choice you will always take (Option 1 or Option 2), 
return the ending you will reach. If you get stuck in a loop, return -1.

Example:
find_ending(endings, choices1, 1) (always Option 1)
  Start: 1 -> 2 -> 3(choice) -> 14 -> 15(end) => Return 15

find_ending(endings, choices1, 2) (always Option 2)
  Start: 1 -> 2 -> 3(choice) -> 2 -> 3(choice) -> 2... => Return -1

Additional inputs:
choices2 = [[5, 11, 28], [9, 19, 29], [14, 16, 20], [18, 7, 22], [25, 6, 30]]
choices3 = []
choices4 = [[2, 10, 15], [3, 4, 10], [4, 3, 15], [10, 3, 15]]

Complexity Variable:
n = number of pages
(endings and choices are bound by the number of pages)

All Test Cases - snake_case:
find_ending(endings, choices1, 1) => 15
find_ending(endings, choices1, 2) => -1
find_ending(endings, choices2, 1) => 21
find_ending(endings, choices2, 2) => 30
find_ending(endings, choices3, 1) => 6
find_ending(endings, choices3, 2) => 6
find_ending(endings, choices4, 1) => -1
find_ending(endings, choices4, 2) => 15

All Test Cases - camelCase:
findEnding(endings, choices1, 1) => 15
findEnding(endings, choices1, 2) => -1
findEnding(endings, choices2, 1) => 21
findEnding(endings, choices2, 2) => 30
findEnding(endings, choices3, 1) => 6
findEnding(endings, choices3, 2) => 6
findEnding(endings, choices4, 1) => -1
findEnding(endings, choices4, 2) => 15
*/

using System;
using System.Collections.Generic;
using System.Linq;

public class SolutionKaratRetryTest
{

    public static void StartTest(String[] args)
    {
        var endings = new int[] { 6, 15, 21, 30 };
        var choices1 = new int[][] {
            new int[] {3, 14, 2}
        };

        var choices2 = new int[][] {
            new int[] {5, 11, 28},
            new int[] {9, 19, 29},
            new int[] {14, 16, 20},
            new int[] {18, 7, 22},
            new int[] {25, 6, 30}
        };
        var choices3 = new int[][] { };
        var choices4 = new int[][] {
            new int[] {2, 10, 15},
            new int[] {3, 4, 10},
            new int[] {4, 3, 15},
            new int[] {10, 3, 15}
        };
        Console.WriteLine(FindEnding(endings, choices1, 1));
        Console.WriteLine(FindEnding(endings, choices1, 2));
        Console.WriteLine(FindEnding(endings, choices2, 1));
        Console.WriteLine(FindEnding(endings, choices2, 2));
        Console.WriteLine(FindEnding(endings, choices3, 1));
        Console.WriteLine(FindEnding(endings, choices3, 2));
        Console.WriteLine(FindEnding(endings, choices4, 1));
        Console.WriteLine(FindEnding(endings, choices4, 2));
    }


    public static int FindEnding(int[] endings, int[][] choises, int selection)
    {
        if (endings.Count() == 0) return -1; // No endings available
        if (choises.Count() == 0) return endings[0]; // No choices available, return the first ending

        int pageNumber = 1;
        bool runLoop = true;
        List<int> visitedPages = new List<int>();
        while (runLoop)
        {
            if (visitedPages.Contains(pageNumber)) 
                return -1; // Loop detected, return -1
            
            visitedPages.Add(pageNumber);
            if (CheckEndings(endings, pageNumber))
            {
                return pageNumber; // Return the ending page number
            }

            var choicedPage = CheckChoises(choises, selection, pageNumber);
            if (choicedPage != -1)
            {
                pageNumber = choicedPage;
            }
            else
            {
                pageNumber++;
            }
        }

        return -1; // Should not reach here, but just in case
    }

    public static bool CheckEndings(int[] endings, int pageNum)
    {
        return endings.Contains(pageNum) ? true : false;
    }

    public static int CheckChoises(int[][] choises, int selection, int pageNum)
    {
        foreach (var choice in choises)
        {
            if (choice[0] == pageNum)
            {
                return choice[selection];
            }
        }
        return -1; // No choice found for the current page
    }
}
