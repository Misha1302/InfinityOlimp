using System.Collections;
using UnityEngine;

namespace Sharp
{
    public class SceneChanger : MonoBehaviour
    {
        public static SceneChanger Instance { get; private set; }

        private void Awake()
        {
            Instance = this;
        }

        public void NextScene(GameObject currentScene, GameObject nextScene)
        {
            StartCoroutine(ChangeSceneCoroutine(currentScene, nextScene));
        }

        private IEnumerator ChangeSceneCoroutine(GameObject currentScene, GameObject nextScene)
        {
            var blackScreen = FindAnyObjectByType<BlackScreenTag>(FindObjectsInactive.Include);
            var movement = FindAnyObjectByType<PlayerMovementManager>(FindObjectsInactive.Include);


            movement.enabled = false;
            blackScreen.gameObject.SetActive(true);
            yield return new WaitForSeconds(0.6f);

            currentScene.gameObject.SetActive(false);
            nextScene.gameObject.SetActive(true);

            yield return new WaitForSeconds(0.6f);
            blackScreen.gameObject.SetActive(false);
            movement.enabled = true;
        }
    }
}