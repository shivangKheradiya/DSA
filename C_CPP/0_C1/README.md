## Hello World

[1.HelloWorld.c](./1.HelloWorld.c)

## Data Types
Data types in C are used for declaring Variables and deciding on storage and computations

- Built-in/ Basic Data types are used to define raw data
    - char
    - int
    - float
    - double
    
    Additionally, C89 defins:
     - _Bool

    All Data items of a given type has the same size (in bytes). the size is *implimentation-defined*

- Enumerated Type data are internally of int type and operates on a select subset.

Data types in C further include:
- void: The type specifier void indicates no type
- Derived data type include:
    - Array
    - Structure- struct & union
    - Pointer
    - Function
    - String - C-Strings are really not a type; but can made to behave as such using functions from <string.h> in standard library

- Type modifiers include:
    - short
    - long
    - signed
    - unsigned

## Variables

A variable is a name given to a storage area

Deleration of Variables

- Each variable in C has a specific type, which determines the size and layout of the storage (memory) for the variable
- The name of a variable can be composed of letters, digits, and the underscore character. It must begin with either a letter or an underscore

```C
int                 i, noOfData;
char                c, endOfSession;
float               f, velocity;
double              d, dist_in_light_years;
unsigned int        i, nPeople;
short int           i, nCount;
unsigned char       c, ascii_char;
int                 a[10], ;
```

Initialization of variables

- Initialization is setting an intial value to a variable at it's declaration
- C variables declared can be initialized with the help of operators '='
- Multiple variables can be initialized in a single statement by single value

```C
int                 i = 10 , j = 20, numberOfWorkDays = 20;
char                c = 'x';
float               weight = 40;
double              desity = 0.0;
const int           nElements = 100;
char*               name[] = {"Partha", "Pratim", "Das" };
```

Definition of Variables

- A variable is defined when a value is written to it using
    - Assignment operator '='
    - pointer aliasing

```C
int                 i = 10; // int i is set to 10
int*                p = &i; // Address of i set to p
i = 20                      // Assignment  
*p = 30                     // Pointer Aliasing
```

## Literals

Literals Refer to fixed values of a built in-type.

Literals can be of any of the basic data types
```C

```

In C*9 literals are constant values having const types as;