# Validate Stack Sequences

## Description

This algorithm determines whether the popped array could have been the result of a sequence of 
push and pop operations on an initially empty stack, given two integer arrays `pushed` and `popped`, 
each with distinct values.

## Examples

### Example 1

```plaintext
Input: pushed = [1,2,3,4,5], popped = [4,5,3,2,1]
Output: true
Explanation: We might do the following sequence:
push(1), push(2), push(3), push(4),
pop() -> 4,
push(5),
pop() -> 5, pop() -> 3, pop() -> 2, pop() -> 1

Input: pushed = [1,2,3,4,5], popped = [4,3,5,1,2]
Output: false
Explanation: 1 cannot be popped before 2.
