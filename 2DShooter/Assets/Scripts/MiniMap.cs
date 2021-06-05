using UnityEngine;

namespace Geekbrains
{
    public sealed class MiniMap : MonoBehaviour
    {
        private Transform Player;
        private void Start()
        {
            Player = Camera.main.transform;
            transform.parent = null;
            transform.rotation = Quaternion.Euler(90.0f, 0, 0);
            transform.position = Player.position + new Vector3(0, 10.0f, 0);

            var rt = Resources.Load<RenderTexture>("MiniMap/1");

            GetComponent<Camera>().targetTexture = rt;
        }

        private void LateUpdate()
        {
            var newPosition = Player.position;
            newPosition.y = transform.position.y;
            transform.position = newPosition;
            transform.rotation = Quaternion.Euler(90, Player.eulerAngles.y, 0);
        }
    }

}
