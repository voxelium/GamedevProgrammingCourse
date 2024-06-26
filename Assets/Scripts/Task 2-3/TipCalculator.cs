using UnityEngine;

public class TipCalculator : MonoBehaviour
{
    //стоимость обеда
    [SerializeField] private float _costOfFood = 100f;

    // % чаевых будет добавлен к счету
    [SerializeField] public float _tipPercentage = 10f;

    //сумма для оплаты
    public float Total { get; private set; }

    private void Start()
    {
        float _percentInMoney = _costOfFood / 100f * _tipPercentage;
        Total = _costOfFood + _percentInMoney;

        Debug.Log("Стоимость еды: " + _costOfFood + "$");
        Debug.Log("Процент чаевых: " + _tipPercentage + "%" + " = " + _percentInMoney + "$");
    }

}
