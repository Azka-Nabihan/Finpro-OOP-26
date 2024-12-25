using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else
        {
            Destroy(gameObject);
        }
    }
    
    public GameObject[] toolbarActivatorIcons;
    public TMP_Text timeText;
    public InventoryController theIC;
    public ShopController theShop;
    public Image seedImage;
    public TMP_Text moneyText;


    void Start()
    {
        // SwitchTool(1);
    }


    void Update()
    {
        // Jika pencet I maka akan membuka inventory
        if(Keyboard.current.iKey.wasPressedThisFrame)   
        {
            theIC.OpenClose();
        }

#if UNITY_EDITOR
        // Jika pencet B maka akan membuka shop
        if(Keyboard.current.bKey.wasPressedThisFrame)
        {
            theShop.OpenClose();
        }
    }
#endif

    public void SwitchTool(int selected)
    {
        foreach(GameObject icon in toolbarActivatorIcons)
        {
            icon.SetActive(false);
        }

        toolbarActivatorIcons[selected].SetActive(true);
    }


    public void UpdateTimeText(float currentTime)
    {
        if (currentTime < 12)
        {
            timeText.text = Mathf.FloorToInt(currentTime) + "AM";
        } else if (currentTime < 13)
        {
            timeText.text = "12PM";
        } else if (currentTime < 24)
        {
            timeText.text = Mathf.FloorToInt(currentTime - 12) + "PM";
        } else if (currentTime < 25)
        {
            timeText.text = "12AM";
        } else {
            timeText.text = Mathf.FloorToInt(currentTime - 24) + "AM";
        }
    }

    // Untuk mengganti tampilan seed
    public void SwitchSeed(CropController.CropType crop)
    {
        seedImage.sprite = CropController.instance.GetCropInfo(crop).seedType;
    }

    public void UpdateMoneyText(float currentMoney)
    {
        moneyText.text = "$" + CurrencyController.instance.currentMoney;
    }



}

