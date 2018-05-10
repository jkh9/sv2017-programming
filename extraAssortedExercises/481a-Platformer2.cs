//Victor Tebar,Gonzalo Martinez,Miguel Garcia,Renata Pestana
using System;
using System.Collections.Generic;
using System.Threading;
public static class C{
 public static void w(string s){Console.Write(s);}
 public static void p(int x,int y){Console.SetCursorPosition(x, y);}
 public static void slp(int t){System.Threading.Thread.Sleep(t);}
 public static void clr(ConsoleColor c){Console.ForegroundColor=c;}
}
public class E{
 public int x;
 public int y;
}
public class B:E{
 public B(int x1,int y1){x=x1;y=y1;}
 public void Drw(){
  C.p(x, y);
  C.clr(ConsoleColor.Yellow);
  C.w("#");
 }
 public void Mv(){
  x--;
 }
}
public class P:E{
 int jmp;
 public bool isCrwl;
 public P(){x=10;y=4;}
 public void Jmp(){if(jmp==0)jmp=1;}
 public void Crwl(){isCrwl=!isCrwl;}
 public void Mv(){
  if(jmp==1){y--;jmp++;}
  else if(jmp==2){y--;jmp++;}
  else if(jmp==3){y++;jmp++;}
  else if(jmp==4){y++;jmp++;}
  else if(jmp==5){jmp=0;}
 }
 public void Drw(){
  C.p(x,y);
  C.clr(ConsoleColor.Red);
  if(isCrwl)
   C.w("o");
  else 
   C.w("0");
 }
}
public class M{
public static void Msc(){
 Random rnd=new Random();
 for(;;){
  Console.Beep(rnd.Next(300,3000),rnd.Next(100,1000));
 }
}
public static void Main(){
 bool exit=false;
 bool win=false;
 Thread m = new Thread(Msc);
 m.IsBackground=true;
 m.Start();
 int score=0;
 Random r=new Random();
 ConsoleKeyInfo k;
 P p=new P();
 List<B> blck = new List<B>();
 int lst=20;
 for(int i=0;i<r.Next(50,100);i++){
  int rn=r.Next(5,8)+lst;
  lst=rn;
  blck.Add(new B(rn,r.Next(3,5)));
 }
 do{
  foreach(B b in blck){b.Mv();if(b.x<=50)b.Drw();}
  if(Console.KeyAvailable){
   do{k=Console.ReadKey();}while(Console.KeyAvailable);
   if(k.Key==ConsoleKey.Spacebar && !p.isCrwl)p.Jmp();
   if(k.Key==ConsoleKey.Q)p.Crwl();
  }
  p.Mv();
  p.Drw();
  for(int i=0;i<blck.Count;i++){
   if(blck[i].x==p.x && blck[i].y==p.y)exit=true;
   else if(blck[i].x==p.x && blck[i].y==p.y-1 && !p.isCrwl)exit=true;
   if(blck[i].x==0){blck.RemoveAt(i);i--;}
  }
  score++;
  if(blck.Count==0){
   exit=true;
   win=true;
  }
  C.p(0,5);
  C.clr(ConsoleColor.White);
  C.w(new string('#',50));
  C.slp(100);
  Console.Clear();
 }while(!exit);
 if(win)
  C.w("You win! - Score: "+score);
 else
  C.w("You lose! - Score: "+score);
}
}
