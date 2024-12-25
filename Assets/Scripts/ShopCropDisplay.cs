using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShopCropDisplay : MonoBehaviour
{
    public CropController.CropType crop;
    public Image cropImage;
    public TMP_Text amountText, priceText;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateDisplay()
    {
        CropInfo info = CropController.instance.GetCropInfo(crop);

        cropImage.sprite = info.finalCrop;
        amountText.text = "x" + info.cropAmount;
        priceText.text = "$" + info.cropPrice + " each";    
    }

    public void sellCrop()
    {
        CropInfo info = CropController.instance.GetCropInfo(crop);

        if (info.cropAmount > 0)
        {
            // Nambahin uang
            CurrencyController.instance.AddMoney(info.cropPrice * info.cropAmount);
            // Mengurangi jumlah seed
            CropController.instance.RemoveCrop(crop);
            // Update UI
            UpdateDisplay();
        }
    
    }
}
