using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class CropController : MonoBehaviour
{
    public static CropController instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }
    
    public enum CropType
    {
        pumpkin,
        letuce,
        carrot,
        hay,
        potato,
        strawberry,
        tomato,
        avocado
    }

    public List<CropInfo> cropList = new List<CropInfo>();

    public CropInfo GetCropInfo(CropType cropToGet)
    {
        int position = -1;

        for(int i=0; i<cropList.Count; i++)
        {
            if(cropList[i].cropType == cropToGet)
            {
                position = i;
            }
        }

        if(position >= 0)
        {
            return cropList[position];
        } else
        {
            return null;
        }
    }


    public void UseSeed(CropType seedToUse)
    {
        foreach (CropInfo info in cropList)
        {
            if (info.cropType == seedToUse)
            {
                info.seedAmount--;
            }
        }
    }

    public void AddCrop(CropType cropToAdd)
    {
        foreach (CropInfo info in cropList)
        {
            if (info.cropType == cropToAdd)
            {
                info.cropAmount++;
            }
        }
    }

    public void AddSeed(CropType seedToAdd, int amount)
    {
        foreach (CropInfo info in cropList)
        {
            if (info.cropType == seedToAdd)
            {
                info.seedAmount += amount;
            }
        }
    }

    public void RemoveCrop(CropType cropTosell)
    {
        foreach (CropInfo info in cropList)
        {
            // Jual semua crop
            if(info.cropType == cropTosell)
            {
                info.cropAmount = 0;
            }
        }
    }
    
}

[System.Serializable]
public class CropInfo
{
    public CropController.CropType cropType;
    public Sprite finalCrop, seedType, planted, growStage1, growStage2, ripe;

    public int seedAmount, cropAmount;

    [Range(0f, 100f)]
    public float growthFailChance;

    public float seedPrice, cropPrice;
}