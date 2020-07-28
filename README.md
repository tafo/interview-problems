# Algorithm

My codes(answers) to interview questions

***

## Task Scheduler

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

[Answer](https://github.com/tafo/Algorithm/Twenty/TaskScheduler.cs)

***
