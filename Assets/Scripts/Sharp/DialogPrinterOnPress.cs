using DialogueEditor;
using DialogueEditor.Assets.Scripts;
using DialogueEditor.Assets.Scripts.UI;
using TMPro;
using UnityEngine;

namespace Sharp
{
    public class DialogPrinterOnPress : MonoBehaviour
    {
        [SerializeField] private KeyCode pressKey = KeyCode.F;
        [SerializeField] private float radius;
        [SerializeField] private TMP_Text hintText;
        [SerializeField] private NPCConversation conversation;

        private Transform _player;

        private void Start()
        {
            _player = FindAnyObjectByType<PlayerTag>(FindObjectsInactive.Include).transform;
        }

        private void Update()
        {
            if (Vector2.Distance(_player.position, transform.position) > radius)
                DisableConversation();
            else EnableConversation();
        }

        private void DisableConversation()
        {
            hintText.gameObject.SetActive(false);
            ConversationManager.Instance.EndConversation();
            ConversationManager.Instance.gameObject.SetActive(false);
        }

        private void EnableConversation()
        {
            hintText.gameObject.SetActive(true);
            if (!Input.GetKeyDown(pressKey)) return;

            ConversationManager.Instance.gameObject.SetActive(true);
            ConversationManager.Instance.StartConversation(conversation);
        }
    }
}