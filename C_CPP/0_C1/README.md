# Quick Recap C1

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
212             // (int) Decimal literal
0173            // (int) Octal literal
0b1010          // (int) Binary literal
0xF2            // (int) Hexadecimal literal
3.14            // (double) Floating-Point literal
'x'             // (char) Character literal
"Hello"         // (char *) String literal
```

In C*9 literals are constant values having const types as;
```C
212             // (const int) Decimal literal
0173            // (const int) Octal literal
0b1010          // (const int) Binary literal
0xF2            // (const int) Hexadecimal literal
3.14            // (const double) Floating-Point literal
'x'             // (const char) Character literal
"Hello"         // (const char *) String literal
```

## Operator

An operator denotes a specific operation. C has the following types of operators:

- Arithmetic Operators: + - * / % ++ --
- Relational Operators: == != < >  <= =>
- Logical Operators: && || !
- Bit-wise Operators: & | ~ << >>
- Assignment Operators: = += -= *= /= ...
- Miscellaneous Operators: . , sizeof & * ? :

Arity of Operators: Number of operands for an operator

- +, -, *, & Operators can be unary (1 operand) or binary (2 operands)
- ==, !=, <, >, <=, =>, =, +=, -=, *=, /=, &, |, <<, >>, can work onnly as binary (2 operands) Operators
- sizeof !, ~, ++, --, can work only as unary (1 operand) operator
- ?: works as ternary (3 operands) Operator. the condition is the first operand and the if true logic and if false logic corrosponds to the other two operands.

Operator Precedence: Determins which operator will be performed first in a chain of different operators
- The Precedence of all operators are defined in the following order: ( left to right - Highest to lowest Precedence)
- (). [], ++, --, +(unary), -(unary), !, ~, !, *, &, sizeof, *, /, %, +, -, <<, >>, ==, !=, *=, /=, =, &, |, &&, ||, ?:, =, +=, -=, <<=, >>=

Oerator Associativity indicates in what order operators of equal precedence in an expression are applied.

Consider the expression a @ b @ c. if the operator @ has left associativity, this expression would be interpreted as a @ ( b @ c).
- Right to Left: ?:, =, +=, -=, *=, /=, <<=, >>=, -, +, +-, !, ~, *, &, sizeof
- Left to Right: *, /, %, +, -, <<, >>, ==, !=, *=, =, /=, &, |, &&, ||

## Expressions

- A literal is an expression
- a variable is an expression
- 1, 2 or 3, expressions connected by an operator (of approriate arity) is an expression a function call is an expression.

Examples:
- for
```C
int i = 10, j = 20, k;
int f(int x , int y){return x + y;}
```
- Expression are:
```C
10                  // Value 10
i                   // Value 10
-i                  // Value -10
i - j               // Value -10
k = 5               // Value 5
f(i, j)             // Value 30
i + j == i * 3      // Value true
( i == j) ? 1 : 2   // Value 2
```

## Statement

A statement is a command for a specific action. It has no value

- A :(semicolon) is a (null) statement
- An expression terminated by a :(semicolon) is a statement
- alist of one or more statements enclosed within a pair of curly braces { and } or block is a compound statement.
- Control constructs like if, ifelse, switch, for, which, do-while, goto, continoue, break, return are statements

Examples: Expression Statement
```C
//Expression              //Statement
i + j                     i + j;
k = i + j                 k = i + j;
funct(i,j)                funct(i,j);
k = funct(i,j)            k = funct(i,j);

```

Examples: Compund Statement
```C
{
  int i = 2, j = 3, t;
  t = i;
  i = j;
  j = t;
}
```

## Control constructs

These statements control the flow based on conditions;
- Selection-Statement: if, if-else, switch
- Labeled-Statement: Statement labeled with identifier, case, or default
- Iteration-Statement:for, which, do-while
- Jump-Statement: goto, continoue, break, return