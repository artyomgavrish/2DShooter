using System;
using UnityEngine;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace Geekbrains
{
    public class Logger : EditorWindow
    {

        public static Logger ShowWindow()
        {
            Logger window = GetWindow<Logger>();
            return window;
        }

        private void OnEnable()
        {
            TextField message = new TextField("Сообщение");
            ColorField color = new ColorField("Выбор цвета");

            Button send = new Button(() =>
            {
                Debug.Log(message);
            });
            send.text = "Отправить!";
            
            rootVisualElement.Add(message);
            rootVisualElement.Add(color);
            rootVisualElement.Add(send);
        }
    }
}