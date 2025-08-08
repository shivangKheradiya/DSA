# Quick Recap C2

## Containers and Pointers

C Supports two types of Containers:
- Array: Container for one or more elements of the same type. this is an indexed container
- Structure: Container for one or more memebers of the one or more different/ same type/s. This container allows access by member name
    - Union: It is a special type of structure where only one out of all the members can be populated at a time. this is useful to deal with variant types.

C supports two types of addressing;
- Indexed: This is used in an array
- Referential: This is available as Pointers where the address of a variable can be stored and manipulated as a value.

Using array, structure and pointer a various derived containers can be built in C including lists, trees, graphs, stack, and queue

C Standard Library has no additinal support for containers.

## Arrays

An array is a collection of data items of the same type, accessed using a common names
- Delaration Arrays
    ```C
    #define SIZE 10
    int name[SIZE];     // SIZE must be an integer constant greater than zero
    double balance[10]; // Direct use of constant size
    ```
- Initialize Array
    ```C
    int primes[] = { 2, 3, 5, 7, 11};                   // Size = 5 by initialization
    int sizeOfPrimes = sizeof(primes)/ sizeof(int);     // Size is computed as 5
    int primes[5] = { 2, 3, 5, 7, 11};                  // Size = 5
    int primes[5] = { 2, 3};                            // Size = 5, last 3 elements set to 0
    ```
- Access Array Elements
    ```C
    int primes[5] = { 2, 3};                 
    int EvenPrime = primes[0];  // Read 1st Element 
    primes[2] = 5;              // Write 3rd element
    ```
- Multidimensional Arrays
    ```C
    int mat[3][4];               // Array is stored as row - major
    ```

## Structures

A structure is a collection of data items of different types. Data items are called members. the size of a structure is the sum of the size of it's members or more( to take care of alignment).

- Delare Structures
    ```C
    struct Complex{     // Complex Number
        double re;      // Real component
        double im;      // Imaginary component
    } c;                // C is a variable of struct complext type
    
    printf("size = %d\n", sizeof(struct Complex)); //Prints: Size = 16

    typedef struct _Books{  // Tag _Books
        char title[50];     // Data Member
        char author[50];    // Data Member
        int book_id;        // Data Member
    } Books;                // Books is an alias for struct _Books type
    ```
- Initialize Structures
    ```C
    struct Complex x = { 2.0, 3.5};
    struct Complex y = { 4.2};
    ```
- Access Structure members
    ```C
    struct Complex x = {2.0, 3.5};
    double norm = sqrt(x.re*x.re + x.im*x.im); // Accessed using . operator
    Books book;
    book.book.id = 6495407;
    strcpy(book.title, "C Programming");
    ```

## Unions

A union is special structure that allocates memory only for the largest data member and holds only one member at a time.

- Declare Union
    ```C
    typedef union _Packet{          //Mixed Data Packet which can be an int, double, or char
        int     iData;              // integer data
        double  dData;              // floating point data
        char    cData;              // character data
    } Packet;
    printf("%d\n", sizeof(Packet)); // Prints: 8 = max ( sizeof( int ),  sizeof( double ),  sizeof( char ))
    ```

- Initialze Union
    ```C
    Packet p = { 10 };                  // Initialze only with a value of the type of first member ( int )
    printf("iData = %d\n", p.iData);    // Prints: iData = 10
    ```
- Access Union Memebrs
    ```C
    p.iData = 2;
    printf("iData = %d\n", p.iData);        // Prints: iData = 2
    p.dData = 2.2;
    printf("dData = %f\n", p.dData);        // Prints: dData = 2.2
    p.cData = 'a';
    printf("cData = %c\n", p.cData);        // Prints: cData = a

    p.iData = 122; // ASCII('z') = 122
    printf("iData = %d\n", p.iData);        // Prints: iData = 122: Correct
    printf("dData = %f\n", p.dData);        // Prints: dData = 2.1999999 as 2.2 is partially changed by 122
    printf("cData = %c\n", p.cData);        // Prints: cData = z as chr(122) is 'z' which is incidentially correct.
    ```

## Pointers

A pointer is a variable whose value is a memory address. The type of a pointer is determined by the type of it's pointee.

Defining a pointer
```C
int     *ip;    // pointer to an integer
double  *dp;    // pointer to an double
float   *fp;    // pointer to an float
char    *cp;    // pointer to an character
void    *vp;    // pointer to unknown/ no type - will need a cast before use
```

Using a Pointer
```C
int main(){
    int i = 20; // variable declaration
    int *ip;    // pointer declaration
    ip = &i;    // store address of i in pointer ip

    printf("Address of variable: %p\n", &i);    // Prints: Address of variable: 00A8F73C
    printf("Value Pointer: %p\n", ip);          // Prints: Value Pointer: 00A8F73C
    printf("Value Pointee: %p\n", *ip);         // Prints: Value Pointee: 20
}
```

## Array Pointer Duality and Pointer to Structures

Array Pointer Duality
```C
int a[] = { 1, 2, 3, 4, 5};
int *p;
p = a;                              // base of array a as pointer p

printf("a[0] = %d\n", *p);          // a[0] = 1
printf("a[0] = %d\n", *++p);        // a[1] = 2
printf("a[0] = %d\n", *(p + 1));    // a[2] = 3

p = *a[2]                           // Pointer to a location of array
*p = -10;
printf("a[2] = %d\n", a[2]);        // a[2] = -10
```

malloc-free
```C
//Allocate and Cast void* to int*
int *p = (int *)malloc(sizeof(int));
printf("%x\n", *p)                  // 0x8F7E1A2B
unsigned char *q = p;               // Little endian : LSB 1st
printf("%x\n", *q++)                // 0x2B
printf("%x\n", *q++)                // 0x1A
printf("%x\n", *q++)                // 0x7E
printf("%x\n", *q++)                // 0x8F
free(p)
```

Pointer to Structures
```C
struct Complex{                 // Complex Number
    double re;                  // Real component
    double im;                  // Imaginary component
} c = 0.0 , 0.0 ;

struct Complex *p = &c;         // Pointer to Structrue
(*p).re = 2.5                   // Member selection
p->im = 3.6                     // Access by redirection

printf("re = %lf\n", c.re);     // re = 2.5
printf("im = %lf\n", c.im);     // re = 3.6
```

Dynamically allocated arrays
```C
// Allocate array p[3] and cast void* to int*
int *p = (int *)malloc(sizeof(int)*3);

p[0] = 1;   // Used as array
p[1] = 2;   // Used as array
p[2] = 3;   // Used as array

// Pointer-Array Duality on dynamic allocation
printf("p[1] = %d\n", *(p+1) ) // p[1] = 2
free(p);
```

## Functions: Declaration and Defination

Has 0, 1 or more parameters. Every parameters has a type( void for no parameters)

- if the parameter list is empty, the function can be called by any number of parameters
- if the parameter list is void, the function can be called only without any parameter

May or may not return a result. return value has a type( void for no result)

- if the function has retrun type void, it cannot reutn any value 
    ```C
    void funct(...){ return; }
    ```
    except void
    ```C
    void funct(...) {return <void>;}
    ```

Function Declaration
```C
// Function Prototype / Header / Signature
// Name of the function: funct
// Parameters: x and y. Types of parameters: int
// return type: int
int funct(int x, int y);
int func(int, int); //possible
```
Function Defination
```C
int funct(int x, int y){
    return (x + y);
}
```

## Functions: Call and Return by Value

Call-by-value mechanism for passing arguments. The Value of an actual parameter is copied to the formal parameter.

Return by valye mechanism to return the value, if any.
```C
int funct(int x, int y){
    ++x; ++y;
    return (x + y);
}

int main(){
    int a = 5, b = 10, z;
    z = funct(a,b);     //Call by value, a copied to x. x become 5, b copied by y. x becomes 10
                        // x in funct changes to 6 
                        // y in funct changes to 11
                        // return value (x + y) copied to z
    printf("funct = %d\n", z);          //Prints: funct = 17 

    // Actual parameters do not change on return (call-by-value)
    printf("a = %d, b = %d\n", a, b);   //Prints: a = 5, b = 10
}
```

## Functions: Call and Return by Reference

Call-by-reference is not supported in C in general. However, arrays are passed by reference.
```C
#include<stdio.h>

// Reference parameter - The base array address of array a is passed
// Value parameter
int arraySum( int a[], int n) {
    int sum = 0;
    for(int i = 0; i < n ; ++i){
        sum += a[i];
        a[i] = 0;
    }
    return sum;
}

int main(){
    int a[3] = {1 , 2, 3};
    printf("Sum = %d\n", arraySum(a,3));    // Prints: Sum = 6 and changes the array a to all 0
    printf("Sum = %d\n", arraySum(a,3));    // Prints: Sum = 0 as elements of a changeed in arraySum()
}
```

## Functions: Recursion

A function may be recursive(call itself)
- Has Recursive step/s
- Has exit condition/s

```C
// Factorial of n
unsigned int factorial(unsigned int n){
    if(n > 0) return n * factorial(n-1);        // Recursive Step
    else return 1;                              // Exit condition
}

// Number of 1's in the binary representation of n
unsigned int nOnes(unsigned int n){
    if(n == 0) return 0;                        // Exit condition
    else                                        // recursive steps
        if (n % 2 == 0) return nOnes(n / 2);    // n is even
        else return nOnes(n / 2) + 1;           // n is odd 
}
```

Two or more functions can be Co-recursive - mutually calling each other. Like f() calling g() and g() calling f(). either f() or g() or both may have exit conditions - at least one is a must.

## Function pointers: Delegation of function calls

```C
#include<stdio.h>
struct GeoObject{
    enum { CIR = 0, REC, TRG} gCode;
    union{
        struct Cir { double x, y, r;} c;
        struct Rec { double x, y, ,w ,h;} r;
        struct Trg { double x, y, b, h;} t;
    };
};

// function pointer type
typedef void(*DrawFunc) (struct GeoObject)

// Draw Functions for Callback
void drawCir(struct GeoObject go){
    printf("Circle : (%lf,%lf,%lf)\n", go.c.x, go.c.y, go.c.r )
}

void drawRec(struct GeoObject go){
    printf("Rect : (%lf,%lf,%lf,%lf)\n", go.r.x, go.r.y, go.r.w, go.r.h )
}

void drawTrg(struct GeoObject go){
    printf("Triag : (%lf,%lf,%lf,%lf)\n", go.t.x, go.t.y, go.t.b, go.t.h )
}

DrawFunc DrawArr[] = {
    //Array of func. ptrs
    drawCir, drawRec, drawTrg
};

int main(){
    struct GeoObject go;

    go.gCode = CIR;
    g.c.x = 2.3;
    g.c.y = 3.6;
    g.c.r = 1.2;
    DrawArr[go.gCode] (go); // Call drawCir() by ptr
    
    go.gCode = REC;
    g.r.x = 4.5;
    g.r.y = 1.9;
    g.r.w = 4.2;
    g.r.h = 3.8;
    DrawArr[go.gCode] (go); // Call drawRec() by ptr

    go.gCode = TRG;
    g.t.x = 3.1;
    g.t.y = 2.8;
    g.t.b = 4.4;
    g.t.h = 2.7;
    DrawArr[go.gCode] (go); // Call drawTrg() by ptr
}

// Output
// Circle : (2.3, 3.6, 1.2)
// Rect : (4.5, 1.9, 4.2, 3.8)
// Triag : (3.1, 2.8, 4.4, 2.7)
```

## Input / Output: stdio & stdout

- `printf(const char *format, ...)` writes to `stdout` by the format and returns the *number of characters written*. This is a **Variadic** function.
- `scanf(const char *format, ...)` reads from `stdin` by the format and returns the *number of input values that are scanned*. This is also a **Variadic** function.

Use format specifiers to print/scan different types:
- `%s` for **string**
- `%d` for **int**
- `%c` for **char**
- `%lf` for **double**

```c
#include <stdio.h>

int main() {
    char str[100];
    int i;

    printf("Enter a value :\n");           // prints a constant string
    scanf("%s %d", str, &i);               // reads a string and an integer value
    printf("You entered: %s %d\n", str, i); // prints string and integer
}
```

- Use `stderr` to print errors.

## Input / Output: Files

To *write* to or *read* from a file in C, you can use `fscanf()` and `fprintf()`. These functions are **variadic**.

```c
#include <stdio.h>
#include <stdlib.h> // for exit() function

int main() {
    FILE *fp = NULL;  // Pointer to handle IO using buffers
    int i;

    // Open in read mode by "r"
    fp = fopen("Input.dat", "r");
    if (!fp) {
        fprintf(stderr, "Failed to open Input.dat\n");
        exit(1);
    }

    fscanf(fp, "%d", &i);  // Scan integer from Input.dat
    fclose(fp);            // Clear buffers and close file

    // Open in write mode ("w") or append mode ("a")
    fp = fopen("Output.dat", "w");
    if (!fp) {
        fprintf(stderr, "Failed to open Output.dat\n");
        exit(1);
    }

    fprintf(fp, "%d^2 = %d\n", i, i*i); // Write to Output.dat
    fclose(fp);                         // Write back and clear buffers
}
```
## Input / Output: Strings

To **write to** or **read from** strings, `sscanf()` and `sprintf()` are **variadic** functions.

Below is an example demonstrating:

- Parsing and tokenizing a string
- Converting an integer to ASCII
- Extracting digits from the string

Example code:

```c
#include <stdio.h>
#include <stdlib.h> // for itoa()

// char* itoa(
//     int value,  // Number
//     char* str,  // ASCII array
//     int base    // Base (e.g., 10 for decimal)
// );

int main() {
    // Parsing a string
    char instring[] = "C++ Programming";  // Input string
    char str1[20], str2[20];              // Parsed strings

    // Read and tokenize
    sscanf(instring, "%s %s", str1, str2); // Tokenize by space
    printf("Input to be parsed = \n\t%s\n", instring);
    printf("Token 1 = %s\n", str1);
    printf("Token 2 = %s\n\n", str2);

    // int to ASCII conversion and parsing a number
    int i = 786;
    char num[10];                         // Number as string
    sprintf(num, "%d", i);                // Convert number to string
    printf("Number %d has digits ", i);
    printf("%c %c %c\n\n", num[0], num[1], num[2]);
    printf("itoa(%d) = %s\n", i, itoa(i, num, 10)); // Convert using itoa()
}

// Input to be parsed =
//     C++ Programming
// Token 1 = C++
// Token 2 = Programming
// 
// Number 786 has digits 7 8 6
// 
// itoa(786) = 786
```

- `sprintf()` is also useful to nicely edit the output before writing to console or file.