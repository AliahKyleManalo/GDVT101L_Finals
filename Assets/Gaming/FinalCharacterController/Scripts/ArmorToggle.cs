using UnityEngine;
using UnityEngine.InputSystem;

public class ArmorToggle : MonoBehaviour
{
    [Header("Armor Parts")]
    public GameObject chestArmor;
    public GameObject pantsArmor;
    public GameObject bootsArmor;

    [Header("Body Parts")]
    public GameObject chestBody;
    public GameObject armsBody;
    public GameObject legsBody;

    bool equipped = false;

    void Update()
    {
        // Press E on keyboard
        if (Keyboard.current != null && Keyboard.current.eKey.wasPressedThisFrame)
        {
            ToggleArmor();
        }
    }

    void ToggleArmor()
    {
        equipped = !equipped;

        chestArmor.SetActive(equipped);
        pantsArmor.SetActive(equipped);
        bootsArmor.SetActive(equipped);

        chestBody.SetActive(!equipped);
        armsBody.SetActive(!equipped);
        legsBody.SetActive(!equipped);
    }
}
