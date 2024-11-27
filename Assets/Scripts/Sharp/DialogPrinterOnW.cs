using DialogueEditor;
using UnityEngine;

namespace Sharp
{
    public class DialogPrinterOnW : MonoBehaviour
    {
        [SerializeField] private NPCConversation conversation;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.U))
                ConversationManager.Instance.StartConversation(conversation);
        }
    }
}