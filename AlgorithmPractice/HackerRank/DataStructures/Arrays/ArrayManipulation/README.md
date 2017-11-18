[Source](https://www.hackerrank.com/challenges/crush/problem)

I originally got this working pretty well by storing the values in arrays. But that was timing out on larger data sets. So I need to do it in some way that doesn't loop through the indexes a -> b.

I ended up getting the editorial - now I will work through the code to make sense of what is going on.

### Editorial
Even after reading the editorial, I was confused. I mean I understand in theory how this works ... you don't store 
the actual array - that would be too complesx.  Instead you store the differences between each array element.  And then track a running total, 
keeping track of the max value that the running total ever had (max prefix sum). Ok then ... so I kept digging ...

__Links__

    * This seems to be one of the things I should understand to get this answer: https://wcipeg.com/wiki/Prefix_sum_array_and_difference_array
	* Here is a codereview page for this problem: https://codereview.stackexchange.com/questions/95755/algorithmic-crush-problem-hitting-timeout-errors

