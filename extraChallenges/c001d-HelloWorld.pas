{
Crea un programa que reciba un entero de la entrada 
estándar y escriba "Hola mundo." tantas veces como 
indique ese número.

Entrada de ejemplo

3

Salida de ejemplo

Hola mundo.
Hola mundo.
Hola mundo.

(Acepta el reto 116)
}
program ChallengeHelloWorld;
var 
    n, i: integer;
begin
    readLn(n);
    for i:= 1 to n do
        writeLn('Hola mundo.');
end.

