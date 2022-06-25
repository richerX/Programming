using System;

public class Element 
{
    public string Name { get; set; }
    public string Align { get; set; }
    public int PosX { get; set; }
    public int PosY { get; set; }

    public Element(string name, string align, int posX, int posY)
    {
        this.Name = name;
        this.Align = align;
        this.PosX = posX;
        this.PosY = posY;
    }

    public Element ()
    {

    }
}
