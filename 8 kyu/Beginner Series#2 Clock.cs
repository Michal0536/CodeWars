// Clock shows h hours, m minutes and s seconds after midnight.
// Your task is to write a function which returns the time since midnight in milliseconds.

using System;
public static class Clock
{
public static int Past(int h, int m, int s)
{
    return (h*60*60*1000) + (m*60*1000) + (s*1000);
}
}
