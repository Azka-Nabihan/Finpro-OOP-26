using UnityEngine;
using UnityEngine.UI;
using TMPro;    

public class SeedDisplay : MonoBehaviour
{
    public CropController.CropType crop;

    public Image seedImage;
    public TMP_Text seedAmount;

    public void UpdateDisplay()
    { 
        CropInfo info = CropController.instance.GetCropInfo(crop);

        seedImage.sprite = info.seedType;
        seedAmount.text = "x" + info.seedAmount;
    }

    // Akan dipanggil ketika tombol seed dipilih 'select'
    public void SelectSeed()
    {
        // Akan merubah jenis seed yang dipilih pada player
        PlayerController.instance.SwitchSeed(crop);
        // Merubah UI seed yang dipilih pada tool bar
        UIController.instance.SwitchSeed(crop);
    }
}
