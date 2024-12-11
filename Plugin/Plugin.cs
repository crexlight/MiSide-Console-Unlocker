using UnityEngine;

public class Plugin : MonoBehaviour{
	private void Start(){
        ConsoleMain.active = true;
    }
	
	void Update(){
        if (UnityEngine.Input.GetKeyDown(KeyCode.F9)){
			if (Time.timeScale != 0.0f)
				Time.timeScale = 0.0f;
			else
				Time.timeScale = 1.0f;
        }
	}
}
