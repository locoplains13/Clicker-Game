using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
    [SerializeField] public Text scoreText;
    [SerializeField] public Text machinePerSecondText;
    public float machines;
    public float MachinePerSecond;
    public float x;
    public GameObject[] buyButtons;
    public int[] buyprices;
    public int numMachine = 0;

    // Start is called before the first frame update
    void Start()
    {
        MachinePerSecond = 1f;
        x = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Machines: "+ machines;
        machinePerSecondText.text = "Machine/s: " + MachinePerSecond*100;
        MachinePerSecond = x * Time.deltaTime;
        machines += MachinePerSecond;
        if (machines > buyprices[numMachine])
        {
            buyButtons[numMachine].SetActive(true);
            numMachine++;
        }
    }

    public void click(){
        machines += 1;
    }
    
    public void BuyCursor(){
        if(machines >= 15){
            x += 1f;
            machines = machines - 15f;
        }
    }

    public void BuyBitcoin(){
        if(machines >= 500){
            x += 50f;
            machines = machines - 500f;
        }
    }
    
    public void BuyNasa(){
        if(machines >= 10000){
            x += 1000f;
            machines = machines - 10000f;
        }
    }
    
}
