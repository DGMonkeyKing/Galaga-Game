using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour {

	public static GUIManager S;
	public UnityEngine.UI.Text scoringText;

	void Awake () {
		S = this;
	}
	
	// Update is called once per frame
	public void UpdateScore (int newScore) {
		string score = "Score: " + newScore;
		scoringText.text = score;
	}

    public void startPressed()
    {
        SceneManager.LoadScene("Scene_0");
    }
}
