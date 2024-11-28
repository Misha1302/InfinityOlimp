using System.Linq;
using UnityEngine;

namespace Sharp
{
    public class OnCollisionSceneChanger : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D other)
        {
            if (!other.transform.TryGetComponent<PlayerTag>(out _)) return;

            var children = GetComponentInParent<ScenesContainerTag>().GetComponentsInChildren<SceneTag>();
            var curScene = GetComponentInParent<SceneTag>();
            var nextScene = children.First(x => x.Index == curScene.Index + 1);

            SceneChanger.Instance.NextScene(curScene.gameObject, nextScene.gameObject);
        }
    }
}