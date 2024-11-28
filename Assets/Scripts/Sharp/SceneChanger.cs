using System.Collections;
using UnityEngine;

namespace Sharp
{
    public class SceneChanger : MonoBehaviour
    {
        [SerializeField] private GameObject currentScene;
        [SerializeField] private GameObject nextScene;

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (!other.transform.TryGetComponent<PlayerTag>(out _)) return;

            StartCoroutine(ChangeScene());
        }

        private IEnumerator ChangeScene()
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