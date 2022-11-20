using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Creatures", menuName = "Dragon/Create dragon")]

public class Creature : ScriptableObject
{
    [SerializeField] new string name;
    [SerializeField] Sprite frontSprite;
    [TextArea]
    [SerializeField] string description;
    [SerializeField] Element elementType;


    [SerializeField] int life;
    [SerializeField] int defense;
    [SerializeField] int attack;
    [SerializeField] int passive1;
    [SerializeField] int passive2;
    [SerializeField] int ultimate;

    public string Name{
    get{return name;}
}

public string Description{
    get{return description;}
}

public Sprite FrontSprite{
    get{return frontSprite;}
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
    Fire,
    Water,
    Air,
    Earth
}

