using UnityEngine;

public class Fade : MonoBehaviour
{
    SceneTransition sceneTransition;
    void Start() {
        sceneTransition = GameObject.FindGameObjectWithTag("Player").GetComponent<SceneTransition>();
    }
    public void FadeEvent() {
        sceneTransition.OnFadeComplete();
    }
}
