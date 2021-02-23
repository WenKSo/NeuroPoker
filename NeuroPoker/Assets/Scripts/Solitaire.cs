using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class Solitaire : MonoBehaviour
{
    public Sprite[] cardFaces;
    public GameObject cardPrefab;
    public GameObject Cards;

    public static string[] suits = new string[] { "C", "D", "H", "S" };
    public static string[] values = new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

    public List<string> deck;

    void Start()
    {
        RandomizeCards();
    }

    public void RandomizeCards()
    {
        deck = GenerateDeck();
        Shuffle(deck);

        //test the cards in the deck:
        //print(deck.Count);
        //foreach (string card in deck)
        //{
        //    print(card);
        //}

        for (int i = 0; i < 52; i++)
        {
            Debug.Log(i);
            //Cards.transform.GetChild(i).gameObject.GetComponent<Selectable>().suit = Char.ToString(card[0]);
            Cards.transform.GetChild(i).gameObject.transform.name = deck[i];
        }

        //CoroutineExample();
        //Flip();
        Debug.Log("Random");
    }


    public static List<string> GenerateDeck()
    {
        List<string> newDeck = new List<string>();
        foreach (string s in suits)
        {
            foreach (string v in values)
            {
                newDeck.Add(s + v);
            }
        }
        return newDeck;
    }

    void Shuffle<T>(List<T> list)
    {
        System.Random random = new System.Random();
        int n = list.Count;
        while (n > 1)
        {
            int k = random.Next(n);
            n--;
            T temp = list[k];
            list[k] = list[n];
            list[n] = temp;
        }
    }

    public void Flip()
    {
        CoroutineExample();
        for (int i = 0; i < 52; i++)
        {
            Cards.transform.GetChild(i).gameObject.GetComponent<Selectable>().faceUp = false;
        }
        Debug.Log("Flip");
    }

    public void waitforsometime() {

        CoroutineExample();
    }


    public IEnumerator CoroutineExample()
    {
        Debug.Log("CoroutineExample started at " + Time.time.ToString() + "s");

        yield return new WaitForSeconds(5);

        Debug.Log("Coroutine Iteration Successful at " + Time.time.ToString() + "s");
    }

}
