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