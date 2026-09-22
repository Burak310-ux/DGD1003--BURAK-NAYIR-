using UnityEngine;

public class Exercise02 : MonoBehaviour
{
    public string playerName = "EMBERLING";
    public string playerType = "Fire";
    public int playerMaxHp = 20;
    public int playerAttack = 11;
    public int playerDefense = 10;

    public string rivalName = "DRIPLET";
    public string rivalType = "Water";
    public int rivalMaxHp = 21;
    public int rivalAttack = 10;
    public int rivalDefense = 11;

    public int level = 5;
    public int movePower = 40;

    string MakeHpBar(int currentHp, int maxHp)
    {
        int totalSlots = 10;
        int filledSlots = currentHp * totalSlots / maxHp;
        string bar = "[";
        for (int i = 0; i < totalSlots; i++)
        {
            if (i < filledSlots)
            {
                bar = bar + "#";
            }
            else
            {
                bar = bar + "-";
            }
        }
        bar = bar + "]";
        return bar;
    }

    void Start()
