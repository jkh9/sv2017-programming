(* This example is a bit harder to translate
   from Pascal to C# if you are not careful... *) 

PROGRAM example2;

VAR
  n1, n2: integer;
  division: integer;

BEGIN
  Write('Enter first number: ');
  ReadLn(n1);
  Write('Enter second number: ');
  ReadLn(n2);
  
  if n2 = 0 then
    WriteLn('Cannot divide by zero even if you try...')
  else if n1 = 0 then
    WriteLn('0 / n = 0 for any number...')
  else
    begin
    division := n1 div n2;
    WriteLn('Division = ', division);
    end;

END.
