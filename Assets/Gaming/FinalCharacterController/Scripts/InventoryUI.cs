using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI TomatoText;
    private TextMeshProUGUI tomatoText;

    public TextMeshProUGUI GetTomatoText()
    {
        return tomatoText;
    }

    private void SetTomatoText(TextMeshProUGUI value)
    {
        tomatoText = value;
    }

    // Start is called before the first frame update
    void Start()
    {
        SetTomatoText(GetComponent<TextMeshProUGUI>());
    }

    public void UpdateTomatoText(PlayerInventory playerInventory)
    {
        GetTomatoText().text = playerInventory.NumberOfTomato.ToString();
    }
}
