using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickerGame : MonoBehaviour 
{
    //Clicker
    public Text scoreText;
    public float currentScore;
    public float hitPower;
    public float scoreIncreasePerSecond;
    public float x;

    //Shop
    public int shop1cost;
    public Text shop1text;
    
    public int shop2cost;
    public Text shop2text;

    public int shop3cost;
    public Text shop3text;

    public int shop4cost;
    public Text shop4text;

    public int shop5cost;
    public Text shop5text;

    //Amount
    public Text amount1Text;
    public int amount1;
    public float amount1Profit;

    public Text amount2text;
    public int amount2;
    public float amount2Profit;

    public Text amount3Text;
    public int amount3;
    public float amount3Profit;

    public Text amount4Text;
    public int amount4;
    public float amount4Profit;

    public Text amount5Text;
    public int amount5;
    public float amount5Profit;



    //Hit Upgrade
    public int upgradecost;
    public Text upgradeText;

    // Start is called before the first frame update
    void Start() {
        //Clicker
        currentScore = 0;
        hitPower = 1;
        scoreIncreasePerSecond = 1;
        x = 0f;
    }

    // Update is called once per frame
    void Update() {
        //Clicker
        scoreText.text = (int)currentScore+" $";
        scoreIncreasePerSecond = x * Time.deltaTime;
        currentScore = currentScore + scoreIncreasePerSecond;
        
        //Shop
        shop1text.text = "Upgrade 1: "+shop1cost+" $";
        shop2text.text = "Upgrade 2: "+shop2cost+" $";
        shop3text.text = "Upgrade 3: "+shop3cost+" $";
        shop4text.text = "Upgrade 4: "+shop4cost+" $";
        shop5text.text = "Upgrade 5: "+shop5cost+" $";

        //Amount
        amount1Text.text = "Upgrade 1: "+amount1+" cookies $: "+amount1Profit+"/s";
        amount2text.text = "Upgrade 2: "+amount2+" cookies $: "+amount2Profit+"/s";
        amount3Text.text = "Upgrade 3: "+amount3+" cookies $: "+amount3Profit+"/s";
        amount4Text.text = "Upgrade 4: "+amount4+" cookies $: "+amount4Profit+"/s";
        amount5Text.text = "Upgrade 5: "+amount5+" cookies $: "+amount5Profit+"/s";

        //Hit Upgrade
        upgradeText.text = "Cost: "+upgradecost+" $";
    }

    //Click
    public void Hit()
    {
        currentScore += hitPower;    //Change sprite on click
    }

    //Shop
    public void Shop1()
    {
        if(currentScore >= shop1cost)
        {
            currentScore -= shop1cost;
            amount1 += 1;
            amount1Profit += 1;
            x += 1;
            shop1cost += 25;
        }
    }

    public void Shop2()
    {
        if(currentScore >= shop2cost)
        {
            currentScore -= shop2cost;
            amount2 += 1;
            amount2Profit += 5;
            x += 5;
            shop2cost += 125;
        }
    }

    public void Shop3()
    {
        if(currentScore >= shop3cost)
        {
            currentScore -= shop3cost;
            amount3 += 1;
            amount3Profit += 15;
            x += 15;
            shop3cost += 300;
        }
    }

    public void Shop4()
    {
        if(currentScore >= shop4cost)
        {
            currentScore -= shop4cost;
            amount4 += 1;
            amount4Profit += 50;
            x += 50;
            shop4cost += 500;
        }
    }

    public void Shop5()
    {
        if(currentScore >= shop5cost)
        {
            currentScore -= shop5cost;
            amount5 += 1;
            amount5Profit += 500;
            x += 500;
            shop5cost += 5000;
        }
    }

    //Hit Upgrade
    public void Upgrade()
    {
        if(currentScore >= upgradecost)
        {
            currentScore -= upgradecost;
            hitPower *= 2;
            upgradecost *= 3;
        }
    }
}
