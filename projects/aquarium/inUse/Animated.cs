//Guillermo Pator, Daniel Miquel, Querubin Santana
//Sabater, Lopez, Rebollo
class Animated : Sprite
{
    protected int direction;
    protected int speed;

    public void Move()
    {
        x += speed * direction;
    }
}
