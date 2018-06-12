using UnityEngine;

public class CountClicker : MonoBehaviour {

    public GameObject popUp;
    public static int click_count = 0;

	void Update () {
        if (click_count==10)
        {
            popUp.SetActive(true);
            click_count = 0;
        }
	}
}
