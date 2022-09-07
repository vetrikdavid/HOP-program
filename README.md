# HOP-program

You have an input file with this type of struct<br/>
-finalnum (this stores the final result)<br/>
in the txt file:<br/>
```
 -acc + (+/-[number]) - sum or subtraction
 -jmp + (+/-[number]) - jump to line [number] with sum or sub
 -nop + (+/-[number]) - do nothing, it just exist
```
This code detect, when we're in the same line/stuck in an infinity loop.<br/>
for example:<br/>
jump to line 49, jump back to 20, and later we jump again to line 49 or 20.<br/>
