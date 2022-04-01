﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile_7 : ScriptableObject
{
    private int topColor = 1;
    private int bottomColor = 2;
    private int rightColor = 2;
    private int leftColor = 1;

    public Sprite sprite;

    // Accesor functions
    public int GetTopColor() { return topColor; }
    public int GetBottomColor() { return bottomColor; }
    public int GetRightColor() { return rightColor; }
    public int GetLeftColor() { return leftColor; }
}