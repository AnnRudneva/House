using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    namespace RoomLibrary
{
    public class Room
    {
        double roomLenght;//длина комнаты
        double roomWidth;//ширина комнаты
        public double RoomLenght
        {
            get { return roomLenght; }
            set { roomLenght = value; }
        }
        public double RoomWidth
        {
            get { return roomWidth; }
            set { roomWidth = value; }
        }
        /// <summary>
        /// Метод вычисляет периметр комнаты
        /// </summary>
        /// <returns>Возвращает значение периметра</returns>
        public double RoomPerimetr()
        {
            return 2 * (roomLenght + roomWidth);
        }
        /// <summary>
        ///Метод вычисляет площадь комнаты 
        /// </summary>
        /// <returns>Возвращает значение площади</returns>
        public double RoomAreas()
        {
            return roomLenght * roomWidth;
        }
        /// <summary>
        /// Метод вычисляет число квадратных метров
        /// нв одного человека
        /// </summary>
        /// <param name="np">Число человек </param>
        /// <returns>Возвращает число квадратных метров</returns>
        public double PersonArea(int np)
        {
            return RoomAreas() / np;
        }
        /// <summary>
        /// Информация о комнате
        /// </summary>
        /// <returns>Возвращаеь строку</returns>
        public string Info()
        {
            return "Комната площадью" + RoomAreas() + "кв.м";
        }
    }
    /// <summary>
    /// Класс жилая комната
    /// </summary>
    public class LivingRoom : Room
    {
        int numWin; //число окон
        public int NumWin
        { get { return numWin; } set { numWin = value; } }

        /// <summary>
        /// Метод возвращает информацию о коинате
        /// </summary>
        /// <returns>Возвращвет строку с информацией</returns>
        public string Info()
        {
            return "Жилая комната площадью" + RoomAreas() + "кв.м , с" + numWin + "окнами";
        }
    }

}