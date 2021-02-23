using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectable : MonoBehaviour
{
    public int suit;
    public int value;
    public bool faceUp = true;

    void Update()
    {
        UpdateValue();
    }

    void UpdateValue()
    {

        if (transform.name[1] == 'A')
        {
            value = 0;
        }
        if (transform.name[1] == '2')
        {
            value = 1;
        }
        if (transform.name[1] == '3')
        {
            value = 2;
        }
        if (transform.name[1] == '4')
        {
            value = 3;
        }
        if (transform.name[1] == '5')
        {
            value = 4;
        }
        if (transform.name[1] == '6')
        {
            value = 5;
        }
        if (transform.name[1] == '7')
        {
            value = 6;
        }
        if (transform.name[1] == '8')
        {
            value = 7;
        }
        if (transform.name[1] == '9')
        {
            value = 8;
        }
        if (transform.name.Length==3 && transform.name[1] == '1')
        {
            value = 9;
        }
        if (transform.name[1] == 'J')
        {
            value = 10;
        }
        if (transform.name[1] == 'Q')
        {
            value = 11;
        }
        if (transform.name[1] == 'K')
        {
            value = 12;
        }

        if (transform.name[0] == 'C') suit = 0;
        if (transform.name[0] == 'D') suit = 1;
        if (transform.name[0] == 'H') suit = 2;
        if (transform.name[0] == 'S') suit = 3;

    }
}
