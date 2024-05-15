class Personaje 
{
    public int x = 0; 
    public int y = 0;

    public Personaje(int x, int y)
    {
        this.x=x;
        this.y=y;
    }

    public int GetX ()
    {
        return x;
    }

    public int GetY ()
    {
        return x;
    }

    public void moverhaciaarriba(int cantidad)
    {
        y+= cantidad ;
    }
   public void moverhaciaabajo(int cantidad)
    {
        y-= cantidad ;
    }
    public void moverhacialaderecha(int cantidad)
    {
        x+= cantidad;
    }
    public void moverhacialaizquierda(int cantidad)
    {
        x-= cantidad;
    }
}