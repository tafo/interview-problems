using System;
using System.Collections.Generic;

namespace Interview.Code.Twenty.TaskScheduler
{
    public class Task
    {
        public Task(char key)
        {
            Key = key;
            Count = 1;
        }

        public char Key;
        public int Count;
    }

    /// <summary>
    /// ToDo: Not optimized!
    /// </summary>
    public class Solution
    {
        public int Run(char[] tasks, int n)
        {
            var output = 0;
            var taskList = new List<Task>();
            Array.ForEach(tasks, taskKey =>
            {
                var task = taskList.Find(x => x.Key == taskKey);
                if (task != null)
                {
                    task.Count++;
                    return;
                }

                task = new Task(taskKey);
                taskList.Add(task);
            });
            do
            {
                taskList.Sort((x, y) => y.Count.CompareTo(x.Count));
                int i;
                for (i = 0; i <= n && i < taskList.Count; i++)
                {
                    taskList[i].Count--;
                    output++;
                }

                taskList.RemoveAll(x => x.Count == 0);
                if (taskList.Count == 0) break;
                if (i > n) continue;
                output += n - i + 1;
            } while (true);

            return output;
        }
    }
}