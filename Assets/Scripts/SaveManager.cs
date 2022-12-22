using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveManager : MonoBehaviour
{
    
    public Text positionText;
    public Text nameText;
    public GameObject cubos;
    public float x, y, z;
    
    
    // Start is called before the first frame update
    void Start()
    {
        LoadData();
    }

    public void Save()
    {
        x = transform.position.x;
        y = transform.position.y;
        z = transform.position.z;

        PlayerPrefs.SetFloat("x" ,x);
        PlayerPrefs.SetFloat("y" ,y);
        PlayerPrefs.SetFloat("z" ,z);

        positionText.text = "Position: " +PlayerPrefs.GetFloat("x").ToString() + "x " + PlayerPrefs.GetFloat("y").ToString() + "y " + PlayerPrefs.GetFloat("z").ToString() +"z ";
    }

    public void Azul()
    {
        nameText.text = "Name Object:" + PlayerPrefs.GetString("name", "Azul");
        positionText.text = "User Position:" + PlayerPrefs.GetFloat("posX", 5.3f).ToString() + "x" + PlayerPrefs.GetFloat("posY", 0.72f).ToString() + "y" + PlayerPrefs.GetFloat("posZ", 8.97f).ToString() + "z";
    }

    public void Amarillo()
    {
        nameText.text = "Name Object:" + PlayerPrefs.GetString("name", "Amarillo");
        positionText.text = "User Position:" + PlayerPrefs.GetFloat("posX", 16).ToString() + "x" + PlayerPrefs.GetFloat("posY", 0.72f).ToString() + "y" + PlayerPrefs.GetFloat("posZ", 16).ToString() + "z";
    }

    public void Verde()
    {
        nameText.text = "Name Object:" + PlayerPrefs.GetString("name", "Verde");
        positionText.text = "User Position:" + PlayerPrefs.GetFloat("posX", -17).ToString() + "x" + PlayerPrefs.GetFloat("posY", 0.72f).ToString() + "y" + PlayerPrefs.GetFloat("posZ", 7).ToString() + "z";
    }

    public void LoadData()
    {
        x = PlayerPrefs.GetFloat("x");
        y = PlayerPrefs.GetFloat("y");
        z = PlayerPrefs.GetFloat("z");

        Vector3 LoadPosition = new Vector3(x,y,z);
        transform.position = LoadPosition;
    }

    public void Cubo()
    {
        Save();
        
    }


}
