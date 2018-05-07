program example2;

var
  n1, n2: integer;
  division: integer;

begin
  write('Enter first number: ');
  readLn(n1);
  write('Enter second number: ');
  readLn(n2);
  
  if n2 = 0 then
    writeLn('Cannot divide by zero')
  else if n1 = 0 then
    writeLn('0 / n = 0')
  else
    begin
    division := n1 div n2;
    writeLn('Division = ', division);
    end;

end.
