using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ManagerObjective : MonoBehaviour
{
    [SerializeField] Image[] img;
    [SerializeField] TextMeshProUGUI[] percent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int currentPercentage = 1;
    int leftPercentage = 100;
    public void Randomize()
    {
        for(int i = 0; i < 5; i++)
        {
            img[i].color = Color.clear;
            percent[i].enabled = false;
        }
        int RandomBottle = Random.Range(2, 5);
        int val = 0;
        for(int i = 0; i < RandomBottle; i++)
        {
            percent[i].enabled = true;
            // count random
            int rnd = Random.Range(1, 100-val);
            if(i != RandomBottle-1)
            {
                Debug.Log("pass");
                val += rnd;
                percent[i].text = rnd.ToString();
            }else if(i == RandomBottle-1)
            {
                rnd = 100 - val;
                Debug.Log(rnd);
                percent[i].text = rnd.ToString();
            }
            img[i].color = Color.white;
        }
    }
}
