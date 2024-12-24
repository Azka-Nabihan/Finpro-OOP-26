using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class CropDisplay : MonoBehaviour
{
    public CropController.CropType crop;
    public Image cropImage;
    public TMP_Text cropAmount;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateDisplay()
    {
        CropInfo info = CropController.instance.GetCropInfo(crop);

        cropImage.sprite = info.finalCrop;
        cropAmount.text = "x" + info.cropAmount;
    }
}
