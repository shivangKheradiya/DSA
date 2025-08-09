# L03: Arrays and Strings

## Arrays and Vectors

### Program 03.01: Fixed Size Array

C
```C
#include <stdio.h>

int main(){
    short age[4];

    age[0] = 23;
    age[1] = 34;
    age[2] = 65;
    age[3] = 74;

    printf("%d", age[0]);
    printf("%d", age[1]);
    printf("%d", age[2]);
    printf("%d", age[3]);
    return 0;
}
```

C++
```C
#include <iostream>

int main(){
    short age[4];

    age[0] = 23;
    age[1] = 34;
    age[2] = 65;
    age[3] = 74;

    std::cout <<  age[0] << " " ;
    std::cout <<  age[1] << " " ;
    std::cout <<  age[2] << " " ;
    std::cout <<  age[3] << " " ;

    return 0;
}
```

### Program 03.01: Fixed Size Large Array in C and vector in cpp

Hard Coded Size C
```C
#include <stdio.h>
#include <stdlib.h>

int main(){
    int arr[100], sum = 0, i;
    printf("Enter no. of ellements: ");
    int count;
    scanf("%d", &count);

    for(i = 0; i < count; i++){
        arr[i] = i;
        sum += arr[i];
    }

    printf( "Array Sum : %d", sum );
    return 0;
}
```

Using Manifest Constant
```C
#include <stdio.h>
#include <stdlib.h>
#define MAX 100;

int main(){
    int arr[MAX], sum = 0, i;
    printf("Enter no. of ellements: ");
    int count;
    scanf("%d", &count);

    for(i = 0; i < count; i++){
        arr[i] = i;
        sum += arr[i];
    }

    printf( "Array Sum : %d", sum );
    return 0;
}
```

## Arbitrary Size Array

CASE 1: Delaring a large array with size greater then the size given by user in all (most) of the cases

- Hard-code the maximum size in code
- Declare a manifest constant for the maximum size

CASE 2: Using malloc(new[]) do dynamically allocate space at run-time for the array

C++
```C
#include <iostream>
#include <vector>
#define MAX 100;

using namespace std;

int main(){
    vector<int> arr[MAX];
    int sum = 0;

    cout<<"Enter no. of ellements: "<< endl;

    int count;
    cin >> count;

    for(int i = 0; i < count; i++){
        arr[i] = i;
        sum += arr[i];
    }

    cout<< "Array Sum : " << sum << endl;
    return 0;
}
```

### Program 03.04: Dynamically managed Array  Size

C
```C
#include <stdio.h>
#include <stdlib.h>

int main(){
    int sum = 0, i;
    printf("Enter no. of ellements: ");
    int count;
    scanf("%d", &count);

    int *arr = (int*)malloc(sizeof(int)*count);

    for(i = 0; i < count; i++){
        arr[i] = i;
        sum += arr[i];
    }

    printf( "Array Sum : %d", sum );
    return 0;
}
```

C++
```C
#include <iostream>
#include <vector>

using namespace std;

int main(){
    int sum = 0, count;

    cout<<"Enter no. of ellements: "<< endl;
    cin >> count;

    vector<int> arr;
    arr.resize(count);
    
    for(int i = 0; i < count; i++){
        arr[i] = i;
        sum += arr[i];
    }

    cout << "Array Sum : " << sum << endl;
    return 0;
}
```

## String in C and C++

C-String and string.h library
- C-String is an array of char terminated by NULL
- C-String is supported by functions in string.h in C standard library

string type in c++ standard library
- string is a type
- with operators( like + for concatenation) it behaves like a built-in type
- In addition, for functions from C Standard Library string.h can be used in c++ as cstring in std namespace

### Program 03.05: Concatenation of Strings

C
```C
#include <stdio.h>
#include <string.h>

int main(){
    char str1[] = { 'H', 'E', 'L', 'L', 'O', ' ' };
    char str2[] = "World";

    char str[20];
    strcpy(str, str1);
    strcpy(str, str2);

    printf("%s\n", str);
}

// output
// HELLO World
```

C++
```C
#include <iostream>
#include <string>

using namespace std;

int main(){
    string str1[] = "HELLO";
    string str2[] = "World";

    string str = str1 + str2;
    cout << str;

    return 0;
}
```

![C Cpp string](./src/C%20vs%20cpp%20string.png)