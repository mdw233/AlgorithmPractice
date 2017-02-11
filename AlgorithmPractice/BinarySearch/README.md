Binary Search
===========================

How it works?
--------------------------
Input:

* sorted array
* search value

Output:

* index of search value

Approach:

1. Grab the middle index (whole int rounded down)
1. Is the value we're looking for ==, <, or > than the 
  * == - ok cool, we found it
  * < - set max == current index - 1 and jump back to step 2
  * > - set min == current index + 1 and jump back to step 2

Complexity
-----------------------
First - [watch this 7 min refresher on logarithms](https://www.khanacademy.org/math/algebra2/exponential-and-logarithmic-functions/introduction-to-logarithms/v/logarithms).  It is easy to follow and really helpful for the next part.

To figure out the max number of iterations we would:
 1. find the array size
 1. x = round up to the next power of 2 (for instance, for an array of 1000 elements we will round up to 1024)
 1. y = solve for LOG2(x) 
     * in this case LOG2(1024) = 10
 1. final answer is y + 1
     * in this case 10 + 1 == 11

So for 1000 elements, a max number of 11 guesses is needed.
