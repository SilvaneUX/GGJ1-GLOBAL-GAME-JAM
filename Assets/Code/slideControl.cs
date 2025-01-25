using UnityEngine;
using UnityEngine.UI;

public class slideControl : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] float speedSlider;
    [SerializeField] float[] bottlePourSlide = new float[5];

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(bottlePourSlide[0] + bottlePourSlide[1] + bottlePourSlide[2] + bottlePourSlide[3] + bottlePourSlide[4] < 100){
            // Debug.Log("RUN");
            if(Input.GetKey(KeyCode.Alpha1))
            {
                var calc = 1 * speedSlider * Time.deltaTime;
                slider.value += calc;
                bottlePourSlide[0] += calc;
            }
            else if(Input.GetKey(KeyCode.Alpha2))
            {
                var calc = 1 * speedSlider * Time.deltaTime;
                slider.value += calc;
                bottlePourSlide[1] += calc;
            }
            else if(Input.GetKey(KeyCode.Alpha3))
            {
                var calc = 1 * speedSlider * Time.deltaTime;
                slider.value += calc;
                bottlePourSlide[2] += calc;
            }
            else if(Input.GetKey(KeyCode.Alpha4))
            {
                var calc = 1 * speedSlider * Time.deltaTime;
                slider.value += calc;
                bottlePourSlide[3] += calc;
            }
            else if(Input.GetKey(KeyCode.Alpha5))
            {
                var calc = 1 * speedSlider * Time.deltaTime;
                slider.value += calc;
                bottlePourSlide[4] += calc;
            }
        }
    }

    public void Matching()
    {

        foreach(int bottlePour in bottlePourSlide)
        {
            foreach(int BottlesObjective in ManagerObjective.Bottles)
            {
                
                if(bottlePour == BottlesObjective || 
                BottlesObjective + 5 > bottlePour && 
                BottlesObjective - 5 < bottlePour)
                {
                     Debug.Log("SUCC");
                }
            }
        }
    }
}
