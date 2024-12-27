using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShopSeedDisplay : MonoBehaviour
{
    public CropController.CropType crop;

    public Image seedImage;
    public TMP_Text seedAmount, priceText;

    public void updateDisplay()
    {
        CropInfo info = CropController.instance.GetCropInfo(crop);

        seedImage.sprite = info.seedType;
        seedAmount.text = "x" + info.seedAmount;

        priceText.text = "$" + info.seedPrice + " each";
    }

    public void BuySeed(int amount)
    {
        CropInfo info = CropController.instance.GetCropInfo(crop);

        if(CurrencyController.instance.CheckMoney(info.seedPrice * amount))
        {
            // Kurangi uang
            CurrencyController.instance.SpendMoney(info.seedPrice * amount);

            // Tambah seed
            CropController.instance.AddSeed(crop, amount);

            // Update display
            updateDisplay();

            AudioManager.instance.PlaySFXPitchAdjusted(5);
        }
    }
}
