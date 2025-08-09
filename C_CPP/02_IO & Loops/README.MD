# L2 : IO & Loops

## Program 02.01: Hello World

HelloWorld.c
```C
#include <stdio.h>

int main(){
    printf("Hello World");
    printf("\n");
    return 0;
}
```

HelloWorld.cpp
```C
#include <iostream>

int main(){
    std::cout << "Hello World";
    std::cout << std::endl;
    return 0;
}
```

## Program 02.02: Add Two Numbers

AddTwoNumbers.c
```C
#include <stdio.h>

int main(){
    int a, b, sum;
    printf("Input two numbers: \n");
    scanf("%d%d", &a, &b);
    sum = a + b;

    printf("Sum of %d and %d is: %d\n", a , b, sum);
    return 0;
}
```

AddTwoNumbers.cpp
```C
#include <iostream>

int main(){
    int a, b;
    std::cout << "Input two numbers: \n";
    std::cin >> a >> b;

    int sum = a + b;

    std::cout << "Sum of " << a << " and " << b << " is: " << sum << std::endl;
    return 0;
}
```

## Program 02.03: Sqrt Root of a number

Sqrt.c
```C
#include <stdio.h>
#include <math.h>

int main(){
    double x, sqrt_x;
    printf("Input a numbers: \n");
    scanf("%lf", &x,);
    sqrt_x = sqrt(x);

    printf("Sqrt of %d is: %d\n", x , sqrt_x );
}
```

Sqrt.cpp
```C
#include <iostream>
#include <cmath>

using namespace std;

int main(){
    double x;
    cout << "Input a numbers: \n";
    cin >> x ;

    double sqrt_x = sqrt(x);

    cout << "Sqrt of " << x << " is: " << sqrt_x << endl;
    return 0;
}
```

## C and C++ Standard Library Headers & std

![c vs cpp](./src/c%20vs%20cpp.png)

## Standard Library: C/ C++ Headers Convention

![Convention](./src/c%20vs%20cpp%20Header.png)

## Program 02.04: Sum of n natural number

AddNNumbers.c
```C
#include <stdio.h>

int main(){
    int n, i, sum = 0;

    printf("Input limit numbers: \n");
    scanf("%d", &n);

    for(i = 0; i <= n; i++)
        sum += i;

    printf("Sum of %d Number is: %d\n", n , sum);
    return 0;
}
```

AddNNumbers.cpp
```C
#include <iostream>

int main(){
    int n;
    std::cout << "Input limit numbers: " << std::endl ;
    std::cin >> n;

    int sum = 0;
    for(int i = 0; i <= n; i++)
        sum += i;

    std::cout << "Sum of " << a << " Number is: " << sum << std::endl;
    return 0;
}
```

## Program 02.05: Using bool

K&RC
```C
#include <stdio.h>
#define TRUE 1
#define FALSE 0

int main(){
    int x = TRUE;
    printf("Bool is %d\n", x);
    return 0;
}
```

C89
```C
#include <stdio.h>
#include <stdbool.h>

int main(){
    bool x = true;
    printf("Bool is %d\n", x);
    return 0;
}
```

C++
```C
#include <iostream>

using namespace std;

int main(){
    bool x = true;
    std::cout << "Bool is " << x;
    std::cout << std::endl;
    return 0;
}
```

output: Bool is 1