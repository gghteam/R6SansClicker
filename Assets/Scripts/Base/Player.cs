using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Player
{
    public long unionPerClick = 154;
    public long union = 0;
    public long bobBurger = 0;
    public Pants[] pants;
}

[Serializable]
public class Pants
{
    public long level = 1;
    public long upgradeCost = 10101;
    public long unionPerSecond = 19;
}
