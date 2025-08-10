# L04: Sorting and Searching

## Program 04.01: Bubble Sort

C
```C
#include <stdio.h>

int main(){
    int data[] = { 31, 71, 12, 46, 26};
    int i, setp, n = 5, temp;
    for (setp = 0; setp < n - 1; ++setp)
    {
        for (i = 0; i < n - setp - 1; ++i)
        {
            if (data[i] > data[i+1])
            {
                temp = data[i];
                data[i] = data[i + 1];
                data[i + 1] = temp;
            }
        }
    }
    for (i = 0; i < n; ++i)
    {
        printf("%d ", data[i]);
    }
}
```

C++
```C
#include <iostream>

using namespace std;

int main(){
    int data[] = { 31, 71, 12, 46, 26};
    int n = 5, temp;
    for (int setp = 0; setp < n - 1; ++setp)
    {
        for (int i = 0; i < n - setp - 1; ++i)
        {
            if (data[i] > data[i+1])
            {
                temp = data[i];
                data[i] = data[i + 1];
                data[i + 1] = temp;
            }
        }
    }
    for (int i = 0; i < n; ++i)
    {
        cout << data[i] << " ";
    }
}
```

## Program 04.02: Using Sort from standard library

C
```C
#include <stdio.h>
#include <stdlib.h>

// compare function pointer needed
int compare(const void *a, const void *b){  // Type unsafe
    return ( *(int*)a < *(int*)b );         // Cast Needed
}

int main(){
    int data[] = { 31, 71, 12, 46, 26};
    int i, setp, n = 5;
    
    qsort(data, n, sizeof(int), compare);
    
    for (i = 0; i < n; ++i)
    {
        printf("%d ", data[i]);
    }
}
```

C++
```C
#include <iostream>
#include <algorithm>

using namespace std;

// compare function pointer
bool compare(int a, int b){
    return ( a > b ); 
}

int main(){
    int data[] = { 31, 71, 12, 46, 26};
    
    sort(data, data + 5, compare);
    
    for (int i = 0; i < 5; ++i)
    {
        cout << data[i] << " ";
    }
}
```

## Program 04.03: Using Sort from <algorithm> standard library

C++ Asc Order (no compare function needed)
```C
#include <iostream>
#include <algorithm>

using namespace std;

int main(){
    int data[] = { 31, 71, 12, 46, 26};
    
    sort(data, data + 5);
    
    for (int i = 0; i < 5; ++i)
    {
        cout << data[i] << " ";
    }
}
```

## Program 04.04: Binary Search

C
```C
#include <stdio.h>
#include <stdlib.h> // bseach function

// compare function pointer needed
int compare(const void *a, const void *b){  // Type unsafe
    if ( *(int*)a < *(int*)b ) return -1;         // Cast Needed
    if ( *(int*)a == *(int*)b ) return 0;         // Cast Needed
    if ( *(int*)a > *(int*)b ) return 1;         // Cast Needed
}

int main(){
    int data[] = { 1, 2, 3, 4, 5}, k = 3;
    
    if ( bseach (&k, data, 5, sizeof(int), compare) )
        printf("Found !\n");
    else
        printf("Not Found !\n");
}
```

C++ No compare function needed
```C
#include <iostream>
#include <algorithm>

using namespace std;

int main(){
    int data[] = { 1, 2, 3, 4, 5}, k = 3;
    
    if ( binary_search ( data, data + 5, k) )
        cout << "Found !" << endl;
    else
        cout << "Not Found !" << endl;
}
```

## STL: algorithm, The algorithm Library

The algorithm Library of c++ helps us to easily impliment commonly used complex functions. we discussed the functions for sort and search. Let us look at some more useful functions.

- Replace element in an array
- Rotate the order of the elements

## Program 04.05: Replace and rotate functions

C++ 
```C
#include <iostream>
#include <algorithm>

using namespace std;

int main(){
    int data[] = { 1, 2, 3, 4, 5}, k = 3;
    
    replace(data, data+5 , 3 , 2);
    for (int i = 0; i < 5; ++i)
    {
        cout << data[i] << " ";
    }
}

// Output: 1 2 2 4 5
```

C++ 
```C
#include <iostream>
#include <algorithm>

using namespace std;

int main(){
    int data[] = { 1, 2, 3, 4, 5}, k = 3;
    
    rotate(data, data+2, data+5);
    for (int i = 0; i < 5; ++i)
    {
        cout << data[i] << " ";
    }
}

// Output: 3 4 5 1 2
```

## Module Summary

- Flexibility of defining customised sort algorithms to be passed as parameter to sort and search functions defined in the algoritm library.
- Predefined optimised versions of these sort and search functions can also be used.
- There are a number of useful functions like rotate, replace, merge, swap, remove, etc. in algorihm library