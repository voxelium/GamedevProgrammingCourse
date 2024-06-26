using UnityEngine;

public class QuizCalculator : MonoBehaviour
{
    private float num01, num02, num03, num04, num05;

    private void Start()
    {
        num01 = Randomizer();
        num02 = Randomizer();
        num03 = Randomizer();
        num04 = Randomizer();
        num05 = Randomizer();

        float average = (num01 + num02 + num03 + num04 + num05) / 5;

        Debug.Log("num01 = " + num01);
        Debug.Log("num02 = " + num02);
        Debug.Log("num03 = " + num03);
        Debug.Log("num04 = " + num04);
        Debug.Log("num05 = " + num05);
        Debug.Log("Average = " + average);
    }

    private float Randomizer()
    {
        float randomNum = Random.Range(0, 100);
        return randomNum;
    }

}
