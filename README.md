# Algorithm

My codes(answers) to interview questions

***

## Task Scheduler

```
You are given a char array representing tasks CPU need to do

It contains capital letters A to Z where each letter represents a different task

Tasks could be done without the original order of the array

Each task is done in one unit of time

For each unit of time, the CPU could complete either one task or just be idle

However
{
    There is a non-negative integer n that represents the cooldown period between two same tasks
    {
        There must be at least n units of time between any two same tasks
    }
}

Return the least number of units of times that the CPU will take to finish all the given tasks
```
```
Example 1
{
    Input: tasks = ["A","A","A","B","B","B"], n = 2
    Output: 8
    Explanation: 
    A -> B -> idle -> A -> B -> idle -> A -> B
    There is at least 2 units of time between any two same tasks.
}
Example 2
{
    Input: tasks = ["A","A","A","B","B","B"], n = 0
    Output: 6
    Explanation: On this case any permutation of size 6 would work since n = 0.
    ["A","A","A","B","B","B"]
    ["A","B","A","B","A","B"]
    ["B","B","B","A","A","A"]
    ...
}
```
[Answer](/Interview.Code/Twenty/TaskScheduler/Solution.cs)
***
## Word Break
```
Given a non-empty string s and a dictionary wordDict containing a list of non-empty words

Add spaces in s to construct a sentence where each word is a valid dictionary word

Return all such possible sentences

Note:
{
    The same word in the dictionary may be reused multiple times in the segmentation

    You may assume the dictionary does not contain duplicate words
}

```
Example 1:
{
    Input:
    {
        s = "catsanddog"
        wordDict = ["cat", "cats", "and", "sand", "dog"]
    }
    Output:
    {
        [
            "cats and dog",
            "cat sand dog"
        ]
    }
}

Example 2:
{
    Input:
    {
        s = "pineapplepenapple"
        wordDict = ["apple", "pen", "applepen", "pine", "pineapple"]
    }
    Output:
    {
        [
            "pine apple pen apple",
            "pineapple pen apple",
            "pine applepen apple"
        ]
    }
    Explanation: Note that you are allowed to reuse a dictionary word

}
Example 3:
{
    Input:
    {
        s = "catsandog"
        wordDict = ["cats", "dog", "sand", "and", "cat"]    
    }
    Output:
    {
        []
    }
}
```
```
The given method
{
    public IList<string> WordBreak(string s, IList<string> wordDict) { }
}
```
[Answer](/Interview.Code/Twenty/WordBreak/Solution.cs)
```

```