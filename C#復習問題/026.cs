using UnityEngine;

public class CarManager : MonoBehaviour
{
    // CarDataという内部クラスを定義
    public class CarData
    {
        private string model;
        private int year;

        public CarData(string model, int year)
        {
            this.model = model;
            this.year = year;
        }

        public void DisplayInfo()
        {
            Debug.Log($"Model: {model}, Year: {year}");
        }
    }

    void Start()
    {
        // CarDataクラスのインスタンスを作成し、初期化
        CarData myCar = new CarData("Toyota", 2020);
        // 車の情報を表示
        myCar.DisplayInfo();
    }
}
