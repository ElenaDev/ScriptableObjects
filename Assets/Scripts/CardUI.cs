using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CardUI : MonoBehaviour
{
    public Card card;

    public Image spriteUI;
    public TextMeshProUGUI nameCardUI;
    public TextMeshProUGUI attackUI;
    public TextMeshProUGUI healthUI;
    public TextMeshProUGUI manaUI;

    void Start()
    {
        card.ShowName();
        spriteUI.sprite = card.spriteCard;
        nameCardUI.text = card.nameCard;
        attackUI.text = card.attack.ToString();
        healthUI.text = card.health.ToString();
        manaUI.text = card.mana.ToString();
    }

    void Update()
    {
        
    }
}
