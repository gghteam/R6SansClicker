using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Player
{
    public long union;
    public long bobBurger;
    public Pants[] pants;
}

[Serializable]
public class Pants
{
    public long level;
    public long upgradeCost;
    public long unionPerSecond;
}
