# Perform formulas calculation with variables and values using CalcQuickBase

## About the sample

This example will explain how to store the values with variable name and perform the calculation using expressions and built-in functions.

The below code explain how to store the values with variable name using CalcQuickBase.

```c#
CalcQuickBase calcQuick = new CalcQuickBase();

calcQuick["A"] = "5";
calcQuick["B"] = "6";
calcQuick["C"] = "11";
```
Now compute with any expressions or built-in functions with these variables.

```c#
//Computing expressions,
calcQuick["result"] = "=([A]+[B])/[C]";

//Computing In-Built formulas,
calcQuick["result1"] = "=SUM([A],[B])";
```
The output of expressions and functions calculation,

![](https://blog.syncfusion.com/wp-content/uploads/2018/11/Output-for-CalcQuickBase.png)
