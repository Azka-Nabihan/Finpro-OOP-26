using UnityEngine;
using UnityEngine.InputSystem;

public class ShopActivator : MonoBehaviour
{
    private bool canOpen;

    void Update()
    {
        if(canOpen == true)
        {
            if(Keyboard.current.spaceKey.wasPressedThisFrame || Keyboard.current.eKey.wasPressedThisFrame)
            {
                if(UIController.instance.theShop.gameObject.activeSelf == false)
                {
                    UIController.instance.theShop.OpenClose();

                    AudioManager.instance.PlaySFX(0);
                }
            }
        }
    }
    

    // Jika player terkena trigger area dari shop
    private void OnTriggerEnter2D(Collider2D collison)
    {
        if(collison.tag == "Player")
        {
            canOpen = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collison)
    {
        if(collison.tag == "Player")
        {
            canOpen = false;
        }
    }
}
