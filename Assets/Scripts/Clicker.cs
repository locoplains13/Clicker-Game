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
        machinePerSecondText.text = "Codys/s: " + MachinePerSecond*100;
        MachinePerSecond = x * Time.deltaTime;
        machines += MachinePerSecond;
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
}
