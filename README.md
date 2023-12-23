A non empty zero indexed array A consisting of N integers is given. 
A pair of indices (P, Q), where 0 <= P < Q < N, is said to have 'adjacent values' 
if no value in the array lies strictly between values A[P] and A[Q], 
and in addition A[P] != A[Q] 

For example, in array A such that: 

A[0] = 0 

A[1] = 3 

A[2] = 3

A[3] = 7

A[4] = 5

A[5] = 3

A[6] = 11

A[7] = 1 


the following pairs of indices have adjacent values: 

 (0,7), (1,4), (1,7)
 
 (2,4), (2,7), (3,4)
 
 (3,6), (4,5), (5,7)
 

For example, indices 4 and 5 have adjacent values because the values a[4] = 5 and A[5] = 3 are different 
and there is no value in array A that lies strictly between them 
the only such value could be the number 4, which is not present in the array 

Given two indices P and Q, their distance is defined as abs(P-Q) 

where abs(X) = X for X>=0

and abs(X) = -X for X<=0

For example the distance between indices 4 and 5 is 1 because abs(4-5) = abs(5-4) = 1 


Write a function that given a non-empty zero-indexed array A consisting of N integers 
returns the maximum distance between indices of this array that have adjacent values 
The function should return -1 if no adjacent indices exist 
