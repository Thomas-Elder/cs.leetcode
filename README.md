# cs.leetcode
A respository for solutions to leetcode.com problems.

# Structure
The solution is broken into several projects: 
- Leetcode: currently an empty console application
- PerformanceTesting: a small console application for timing execution of solutions
- Solutions: containing solutions to the LeetCode problems
- Solutions.Tests: which tests those solutions
- Utility: for reusable functions/objects, eg computing primes
- Utility.Tests: which tests these utility functions

# Testing
## Unit tests
Tests for this solution are written using the built in Visual Studio testing library, and most of the test cases are derived from the LeetCode example, or from the failed tests when submitting the solution. 

## Performance testing
Mostly to get visibility on the difference in solutions for the Trapping Rain problem, there is a console app (PerformanceTesting) which calls the solution for a problem multiple times, and times the execution of the function. 
