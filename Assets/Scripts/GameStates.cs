using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameStates 
{
    public static List<GameData> data = new List<GameData>();
    public static void GameInit()
    {
        data.Add(new GameData("score", 0));
    }
}

public class  GameData
{
    public void AddPoint(int valueToAdd =1)
    {
        value+= valueToAdd;
    }
    public GameData(string _name, double _value)
    {
        name = _name;
        value = _value;
    }
    public string name;
    public double value;
}

