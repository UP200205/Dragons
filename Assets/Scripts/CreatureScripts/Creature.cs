using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Creatures", menuName = "Dragon/Create dragon")]

public class Creature : ScriptableObject
{
    [SerializeField] new string name;
    [SerializeField] Sprite mainSprite;
    [SerializeField] Sprite elementSprite;
    [TextArea]
    [SerializeField] string description;
    [SerializeField] Element elementType;


    [SerializeField] int life;
    [SerializeField] int defense;
    [SerializeField] int attack;
    [SerializeField] int passive1;
    [SerializeField] int passive2;
    [SerializeField] int ultimate;
    [SerializeField] int cost;

    public string Name{
    get{return name;}
}

public string Description{
    get{return description;}
}

public int Cost{
    get{return cost;}
}

public Sprite MainSprite{
    get{return mainSprite;}
}

public Sprite ElementSprite{
    get{return elementSprite;}
}


public Element ElementType{
    get{return elementType;}
}

public int Life{
    get{return life;}
}

public int Defense{
    get{return defense;}
}

public int Attack{
    get{return attack;}
}

public int Passive1{
    get{return passive1;}
}

public int Passive2{
    get{return passive2;}
}

public int Ultimate{
    get{return ultimate;}
}
}

public enum Element{
    Fuego,
    Agua,
    Aire,
    Tierra
}



