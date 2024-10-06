using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Academic_Challenge
{
    internal class DragDropWindow
    {
        // Импортируем функции из библиотеки user32.dll для управления окнами
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Константы для управления событиями мыши
        private const int WM_NCLBUTTONDOWN = 0x112; // Сообщение о нажатии кнопки мыши
        private const int HTCAPTION = 0xf012; // Область заголовка окна

        // Метод для реализации перетаскивания окна
        public void Drag(Form form)
        {
            // Освобождаем захват курсора
            ReleaseCapture();
            // Отправляем сообщение о нажатии кнопки мыши в область заголовка окна
            SendMessage(form.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
        }
    }
}
