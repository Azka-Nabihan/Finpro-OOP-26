using UnityEngine;

public class ShopController : MonoBehaviour
{
    public ShopSeedDisplay[] seeds;

    public void OpenClose()
    {
        // Selama Inventory tidak dibuka, maka Shop bisa dibuka
        if(UIController.instance.theIC.gameObject.activeSelf == false)
        {
            gameObject.SetActive(!gameObject.activeSelf);

            if(gameObject.activeSelf == true)
            {
                foreach (ShopSeedDisplay seed in seeds)
                {
                    seed.updateDisplay();
                }   
            }
        }
        
    }
}
