//Victor Tebar,Gonzalo Martinez,Miguel Garcia,Renata Pestana
// V1: Approx 1.450 bytes
using System;
using System.Collections.Generic;
public static class C{
 public static void w(string s){Console.Write(s);}
 public static void p(int x,int y){Console.SetCursorPosition(x, y);}
 public static void slp(int t){System.Threading.Thread.Sleep(t);}
}
public class E{
 public int x;
 public int y;
}
public class B:E{
 public B(int x1){x=x1;y=4;}
 public void Drw(){
  C.p(x, y);
  C.w("#");
 }
 public void Mv(){
  x--;
 }
}
public class P:E{
 int jmp;
 public P(){x=10;y=4;}
 public void Jmp(){if(jmp==0)jmp=1;}
 public void Mv(){
  if(jmp==1){y--;jmp++;}
  else if(jmp==2){y--;jmp++;}
  else if(jmp==3){y++;jmp++;}
  else if(jmp==4){y++;jmp++;}
  else if(jmp==5){jmp=0;}
 }
 public void Drw(){C.p(x,y);C.w("0");}
}
public class M{
public static void Main(){
 Random r=new Random();
 ConsoleKeyInfo k;
 P p=new P();
 List<B> blck = new List<B>();
 int lst=20;
 for(int i=0;i<20;i++){
  int rn=r.Next(3,7)+lst;
  lst+=rn;
  blck.Add(new B(rn));
 }
 do{
  foreach(B b in blck){if(b.x<=20)b.Drw();b.Mv();}
  if(Console.KeyAvailable){
   do{k=Console.ReadKey();}while(Console.KeyAvailable);
   if(k.Key==ConsoleKey.Spacebar)p.Jmp();
  }
  p.Mv();
  p.Drw();
  for(int i=0;i<blck.Count;i++){if(blck[i].x==0){blck.RemoveAt(i);i--;}}
  C.p(0,5);
  C.w(new string('#',20));
  C.slp(200);
  Console.Clear();
 }while(true);
}
}
