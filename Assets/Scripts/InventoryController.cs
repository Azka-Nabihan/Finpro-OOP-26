using UnityEngine;

public class InventoryController : MonoBehaviour
{

    public SeedDisplay[] seeds;
    public CropDisplay[] crops;

    public void OpenClose()
    {
        // Selama Shop tidak dibuka, maka Inventory bisa dibuka
        if (UIController.instance.theShop.gameObject.activeSelf == false)
        {
            if(gameObject.activeSelf == false)
            {
                gameObject.SetActive(true);
                UpdateDisplay();
            } else
            {
                gameObject.SetActive(false);
            }
        }
        
        
    }


    public void UpdateDisplay()
    {
        foreach (SeedDisplay seed in seeds)
        {
            seed.UpdateDisplay();
        }

        foreach (CropDisplay crop in crops)
        {
            crop.UpdateDisplay();
        }
    }
}
