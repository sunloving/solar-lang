# Integrated types
## `Number`
Class of numeric types:
* bit number (can be `1` or `0`)
* integer numbers (of 8, 16, 32, 64 bits)
* real floating point numbers (of 32 or 64 bits)

## `Boolean`
Can has one of two values: `true` or `false`. Equeals to bit-`Number` type and there is no need for cast bit-`Number` to `Boolean` or vice versa.

## `String`
* one character (placed in stack) of 2 byte
* special type of `Array` of characters by 2 byte
 
## `Array`
```
someArray <- [-100..100]
```
Placed in a heap.

## `Function`
Function is a sequence of actions.
```
printNewLine: { console.printNewLine() }
printNewLine is Function = true
```
```
showMessage: m => console.print(m)
showMessage is Function = true
```
```
drawPoint: (x, y) => painter.drawPoint(x, y)
drawPoint is Function = true
```
### Functions signatures
For functions
```
(x, y) => painter.getPoint(x, y)
getSomePoint: (x, y, z) => painter.getPoint(x, y) + painter.getPoint(x, z)
```
signature is
```
(Number, Number) -> Point
getSomePoint(Number, Number) -> Point
```

## `Const`
Constants — it is compile-time defined immutable variables. 
```
Pi: 3.14
```
```
Six: 2 * 3
```
```
Six: mult(2, 3)
```
where `mult(Number, Number)` — it is compile-time function accessable throught interface:
```
mult: (op1, op2) => op1 * op2
```

### `EnumConst`
```
Colors: Red, Green, Blue
```
```
Colors: [
  Red: 'Red color'
  Green: 'Green color'
  Blue: 'Blue color'
]
```
```
Colors: [
  Red: 1
  Green: 2
  Blue: 3
]
```