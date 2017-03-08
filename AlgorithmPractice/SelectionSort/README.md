Selection Sort
====================

The basic approach goes like this:

1. Step over the array from left to right
1. For each step, take the value (called the __key__) and start comparing it to the sub-array made up of all elements to the left of the current element
  * In other words, step over all previous elements from right to left
1. For each right to left step, slide the current rtl index one element to the right
1. Then compare the key to the current index
  * If the key is > than the current index do nothing - just move one step left
  * If the key is <= the current index, put the key value in the current + 1 index and leave the loop


Imagine you had a deck of 5 cards, sorted, on a table.  And someone gave you a 6th card then asked to put it into the deck, in order.  That is basically insertion sort.