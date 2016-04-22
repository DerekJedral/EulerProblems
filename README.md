# EulerProblems
Solutions to Euler problems posted online. This repository isn't meant to be a place for people to find answers, but just somewhere I can store my solutions, and compare them with my friends. Basic explanations are here too, so my friends will understand what I wrote.
The solutions are meant to be as generic as possible, so if values in the questions change, only a few variable values need to be modified.
<h3>Euler_001</h3>
<b>Q:</b> Find the sum of all multiples of 3 or 5 under 1000
<br>
<b>A:</b> For loop with cases divisible by 3 and 5, divisible by 3, and divisible by 5

<h3>Euler_002</h3>
<b>Q:</b> Find the sum of all fibonacci numbers less than 4 million
<br>
<b>A:</b> While loop

<h3>Euler_003</h3>
<b>Q:</b> Find the largest prime factor of 600851475143
<br>
<b>A:</b> Loop dividing by smallest primes possible, until the remaining value is prime

<h3>Euler_004</h3>
<b>Q:</b> Find the largest palindrome made by multiplying two 3-digit numbers
<br>
<b>A:</b> For loop multiplying combinations of 3-digit numbers and checking if the result is a palindrome

<h3>Euler_005</h3>
<b>Q:</b> Find the smallest positive number divisible by all numbers from 1 to 20
<br>
<b>A:</b> Array to hold prime factors of values from 1 to 20. Find and store max of each prime factor using for loop. Multiply max of each prime factor from 1 to 20 to find the smallest value.

<h3>Euler_006</h3>
<b>Q:</b> Compute the difference (1 + 2 + ... 100)<sup>2</sup> - (1<sup>2</sup> + 2<sup>2</sup> + ... + 100<sup>2</sup>)
<br>
<b>A:</b> Use a for loop and the equation 1 + 2 + ... + <i>n</i> = (<i>n</i>+1)*<i>n</i>/2

<h3>Euler_007</h3>
<b>Q:</b> Find the 10001st prime
<br>
<b>A:</b> While loop of numbers until counter reaches 10001. For loop to determine if numbers are prime

<h3>Euler_008</h3>
<b>Q:</b> Find the largest product of 13 adjacent digits in a 1000-digit number
<br>
<b>A:</b> For loop through the number stored as a string

<h3>Euler_009</h3>
<b>Q:</b> Given <i>a</i><sup>2</sup> + <i>b</i><sup>2</sup> = <i>c</i><sup>2</sup> and <i>a</i> + <i>b</i> + <i>c</i> = 1000, find abc
<br>
<b>A:</b> For loop of numbers from 1 to 1000 based on the condition that <i>a</i> + <i>b</i> + <i>c</i> = 1000. Check to see if <i>a</i><sup>2</sup> + <i>b</i><sup>2</sup> = <i>c</i><sup>2<sup>

<h3>Euler_010</h3>
<b>Q:</b> Find the sum of all primes below two million
<br>
<b>A:</b> For loop of all numbers under two million. For loop to check if numbers are prime

<h3>Euler_011</h3>
<b>Q:</b> Given a 20x20 grid of numbers, find the largest product of four adjacent numbers in a straight line (up, down, left, right, diagonal)
<br>
<b>A:</b> For loop from top left to bottom right corner of grid, checking down, right, down-right diagonal, and down-left diagonal.

<h3>Euler_012</h3>
<b>Q:</b> Find the first triangle number to have over five hundred divisors
<br>
<b>A:</b> <br>
&nbsp;&nbsp;&nbsp;<b>1)</b> For loop triangle numbers<br>
&nbsp;&nbsp;&nbsp;<b>2)</b> Prime factor triangle numbers by dividing by smallest possible prime. Store prime factors in array<br>
&nbsp;&nbsp;&nbsp;<b>3)</b> If a number <i>n</i> can be expressed as <i>a</i><sup><i>x</i></sup> * <i>b</i><sup><i>y</i></sup> *......., where <i>a</i>,<i>b</i>,... are primes, then: <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Number of factors of <i>n</i> = (<i>x</i>+1)* (<i>y</i>+1) * .....

<h3>Euler_013</h3>
<b>Q:</b> Find the sum of the following one-hundred 50-digit numbers
<br>
<b>A:</b> Store numbers as strings, do addition by adding individual characters converted back to integers

<h3>Euler_014</h3>
<b>Q:</b> What starting number under a million produces the longest chain using the Collatz Sequence? <br>
Note: The Collatz sequence is as follows: <br>
<i>n</i> -> <i>n</i>/2 (<i>n</i> is even) <br>
<i>n</i> -> 3<i>n</i> + 1 (<i>n</i> is odd) <br>
The sequence stops when <i>n</i>=1<br>
<b>A:</b><br>
&nbsp;&nbsp;&nbsp;<b>1)</b> Create an array of size one millions, where the index of the array corresponds to the number <br>
&nbsp;&nbsp;&nbsp;<b>2)</b> For loop of numbers from 1 to 1 000 000 <br>
&nbsp;&nbsp;&nbsp;<b>3)</b> If a number is encountered in a chain, flag it. The flag signifies a sequence does not need to be started at this number, since it is part of a longer sequence <br>
&nbsp;&nbsp;&nbsp;<b>4)</b> Store the length of the sequence with the starting number<br>
&nbsp;&nbsp;&nbsp;<b>5)</b> For loop of the array to find the longest sequence

<h3>Euler_015</h3>
<b>Q:</b> Starting in the top left corner of a 20x20 grid, and only being able to move down and right, how many paths are there to the bottom right corner?
<br>
<b>A:</b> Number of paths to coordinates (<i>i</i>,<i>j</i>) = number of paths to (<i>i</i>-1, <i>j</i>) + number of paths to (<i>i</i>, <i>j</i>-1)<br>
For loop to go through the array using this method

<h3>Euler_016</h3>
<b>Q:</b> What is the sum of the digits of 2<sup>1000</sup>
<br>
<b>A:</b> Similar to <b>Euler_013</b>, store numbers as strings, do multiplication by multiplying individual characters converted back to integers

<h3>Euler_017</h3>
<b>Q:</b> If the numbers from 1 to 1000 were written out in words, how many letters would be used?
<br>
<b>A:</b> Array to hold number of letters given a number. For loop of the numbers from 1 to 1000

<h3>Euler_018</h3>
<b>Q:</b> Given a triangle of numbers, find the path that gives the maximum sum
<br>
<b>A:</b> <br>
&nbsp;&nbsp;&nbsp;<b>1)</b> Store the numbers in an array, and find the height of the triangle <br>
&nbsp;&nbsp;&nbsp;<b>2)</b> Start from the bottom row, and add the larger of two adjacent numbers to the number above it in the triangle. This can also be thought of as collapsing the triangle from the bottom-up <br>
&nbsp;&nbsp;&nbsp;<b>3)</b> Repeat step 2 using recursion until there is only one number left. This number is the maximum <br>
&nbsp;&nbsp;&nbsp;<b>NOTE:</b> This solution isn't the simplest, but also works with <b>Euler_067</b> as well.

<h3>Euler_019</h3>
<b>Q:</b> Find the number of months that started with a Sunday from Jan 1<sup>st</sup> 1901 to Dec 31<sup>st</sup> 2000 
<br>
<b>A:</b> Array to hold number of days in each month, basic function to check whether year is a leap year. Counter to keep track of what day it is. Add the number of days in a month to the counter and see if it's a Sunday using the remainder when divided by 7

<h3>Euler_020</h3>
<b>Q:</b> Find the sum of the digits of 100!
<br>
<b>A:</b> Similar to <b>Euler_016</b>, store numbers as strings, do multiplication by multiplying individual characters converted back to integers

<h3>Euler_021</h3>
<b>Q:</b> Let d(<i>n</i>) be the sum of proper divisors of <i>n</i>. If d(<i>a</i>)=<i>b</i> and d(<i>b</i>)=<i>a</i>, where a and b are not equal, then a and b are amicable numbers<br>
Find the sum of all amicable numbers under 10000.
<br>
<b>A:</b> <br>
&nbsp;&nbsp;&nbsp;<b>1)</b> Similar to <b>Euler_012</b>, we store the prime factors of numbers in an array <br>
&nbsp;&nbsp;&nbsp;<b>2)</b> If a number <i>n</i> can be expressed as <i>a</i><sup><i>x</i></sup> * <i>b</i><sup><i>y</i></sup> *......., where a,b,... are primes, then: <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;The sum of its divisors, <i>s</i>, is the sum of combinations of <i>a</i><sup>0-><i>x</i></sup> * <i>b</i><sup>0-><i>y</i></sup> *... <br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;The sum of its proper divisors is therefore <i>s</i> - <i>n</i> <br>
&nbsp;&nbsp;&nbsp;<b>3)</b> Create array of size 10000, where the index corresponds to what the cell represents <br>
&nbsp;&nbsp;&nbsp;<b>3)</b> For loop to go through the numbers from 1 to 10000, with index <i>i</i> <br>
&nbsp;&nbsp;&nbsp;<b>4)</b> Suppose d(<i>i</i>) = <i>x</i> and d(<i>x</i>) &ne; <i>i</i>. Since we aim to minimize runtime, we flag <i>i</i> as not amicable in the array, and now see if <i>x</i> is amicable. This continues until <i>x</i> is greater than 10000 or we find an amicable pair <br>
&nbsp;&nbsp;&nbsp;<b>5)</b> Go through the array, and add the indexes of all cells that were flagged as amicable

<h3>Euler_022</h3>
<b>Q:</b> Given a list of names, first sort them alphabetically <br>
The score of a name is (product of the score of the digits, where A=1, B=2,......) * (index of the name in the sorted list) <br>
Find the total score of the names
<br>
<b>A:</b> Sort the names using insertion sort. Then for loop through the array.

<h3>Euler_023</h3>
<b>Q:</b> An abundant number is a number where the sum of its proper divisors is larger than the number itself <br>
Given that all integers greater than 28123 can be written as the sum of two abundant numbers, find the sum of all positive integers which cannot be written as the sum of two abundant numbers <br>
<br>
<b>A:</b><br>
&nbsp;&nbsp;&nbsp;<b>1)</b> Similar to <b>Euler_021</b>, we can use the same method to find the sum of a number's proper divisors <br>
&nbsp;&nbsp;&nbsp;<b>2)</b> Find all numbers less than or equal to 28123 that are abundant, and store them in an array <br>
&nbsp;&nbsp;&nbsp;<b>3)</b> Create another array of size 28124, where each index corresponds to the value the cell represents <br>
&nbsp;&nbsp;&nbsp;<b>4)</b> Add all possible combinations of two abundant numbers, and flag these sums in the array defined in <b>3)</b><br>
&nbsp;&nbsp;&nbsp;<b>5)</b> Go through the array, and add the indexes of all cells that were not flagged

<h3>Euler_024</h3>
<b>Q:</b> Find the millionth lexicographic permutation of the digits 0,1,2,3,4,5,6,7,8, and 9
<br>
<b>A:</b> <br>
&nbsp;&nbsp;&nbsp;<b>1)</b> If  <i>x</i> digits follow the digit at index <i>i</i>, then the number of possible permutations following <i>i</i> is <i>x</i>! <br>
&nbsp;&nbsp;&nbsp;<b>2)</b> For loop, starting at the left most digit. If the number of permutations of the remaining digits would be bigger than the max we are looking for, we cannot increase the digit we are currently on <br>
&nbsp;&nbsp;&nbsp;<b>3)</b> Therefore, the left most digit is determined. Remove it from the list of possible digits, and subtract the number of permutations we have passed in the lexicographic order <br>
&nbsp;&nbsp;&nbsp;<b>4)</b> Repeat recursively, until there is only one digit left

<h3>Euler_025</h3>
<b>Q:</b> Find the index of the first term in the Fibonacci sequence with 1000 digits
<br>
<b>A:</b> Similar to <b>Euler_013</b>, store numbers as strings, do addition by adding individual characters converted back to integers
