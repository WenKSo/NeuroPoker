using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateSprite : MonoBehaviour
{
    public Sprite cardFace;
    public Sprite cardBack;
    private SpriteRenderer spriteRenderer;
    private Selectable selectable;
    private Solitaire solitaire;

    void Start()
    {
        //List<string> deck = Solitaire.GenerateDeck();
        solitaire = FindObjectOfType<Solitaire>();
        selectable = GetComponent<Selectable>();
        cardFace = solitaire.cardFaces[selectable.suit*13+selectable.value];
        //print(selectable.suit);
        spriteRenderer = GetComponent<SpriteRenderer>();
   
    }

    void Update()
    {
        if (selectable.faceUp == true)
        {
            cardFace = solitaire.cardFaces[selectable.suit * 13 + selectable.value];
            spriteRenderer.sprite = cardFace;
        }
        else
        {
            spriteRenderer.sprite = cardBack;
        }
    }
}
