using UnityEngine;

public class DisplayScript : MonoBehaviour
{
    [SerializeField]
    private GameObject bird1;
    [SerializeField] 
    private GameObject bird2;
    private int selectedBird = 1;
    [SerializeField]
    private GameObject activeBird;

    private TMPro.TextMeshProUGUI clock;
    private float gameTime;

    void Start()
    {
        gameTime = 0f;
        clock = GameObject.Find("ClockTMP").GetComponent<TMPro.TextMeshProUGUI>();
    }

    void Update()
    {
        gameTime += Time.deltaTime;
        int t = (int) gameTime;
        int h = t / 3600;
        int m = t % 3600 / 60;
        float s = gameTime - h * 3600 - m * 60;
        clock.text = $"{h:00}:{m:00}:{s:00.0}";
    }

    public void OnBird1ButtonClick()
    {
        Debug.Log("Bird 1");
        if (selectedBird != 1 && !GameState.isBirdFly)
        {
            GameObject.Destroy(activeBird);
            activeBird = GameObject.Instantiate(bird1);
            selectedBird = 1;
        }
    }
    public void OnBird2ButtonClick()
    {
        Debug.Log("Bird 2");
        if (selectedBird != 2 && !GameState.isBirdFly)
        {
            GameObject.Destroy(activeBird);
            activeBird = GameObject.Instantiate(bird2);
            selectedBird = 2;
        }
    }
}
