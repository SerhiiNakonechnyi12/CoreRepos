
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Задание 1. Разработать приложение «Резервная копия». 
	Цель: произвести расчет необходимого количества внешних носителей информации
    при переносе за один раз важной информации (565 Гб, файлы по 780 Мб) с рабочего
    компьютера на домашний компьютер и затрачиваемое на данный процесс время.
    Вы имеете в распоряжении следующие типы носителей информации: 
Flash-память, 
DVD - диск, 
съемный HDD. 
Каждый носитель информации является объектом соответствующего класса:
- Flash - память  - класс «Flash»;
- класс DVD – диск - класс «DVD»;
- класс съемный HDD - класс «HDD».
Все три класса являются производными от абстрактного класса «Носитель информации» -
класс «Storage». 
Базовый класс («Storage») содержит следующие закрытые поля:
наименование носителя
модель 

Класс обладает всеми необходимыми свойствами для доступа к полям, а также абстрактными методами: 
получение объема памяти;
копирование данных (файлов/папок) на устройство,
получение информации о свободном объеме памяти на устройстве; 
получение общей/полной информации об устройстве.

Кроме того, каждый из производных классов дополняется следующими полями:
- класс Flash-память: скорость USB 3.0, объем памяти;
- класс DVD - диск: скорость чтения / записи, тип (односторонний (4.7 Гб) /двусторонний (9 Гб));
- класс съемный HDD: скорость USB 2.0, количество разделов, объем разделов.

Работа с объектами соответствующих классов производится через ссылки на базовый
класс («Storage»), которые хранятся в массиве.
Приложение должно предоставлять следующие возможности:
расчет общего количества памяти всех устройств;
копирование информации на устройства;
расчет времени необходимого для копирования;
расчет необходимого количества носителей информации представленных типов для переноса информации. 
*/

namespace CodeFile6
{
    abstract class Storage
    {
        protected string carrierName;
        protected string model;

        public Storage()
        {
            carrierName = "";
            model = "";
        }

        public Storage(string carrierName_1, string model_1)
        {
            this.carrierName = carrierName_1;
            this.model = model_1;
        }

        public abstract double CopyDataTime();
        public abstract int DeviceCount();
        public abstract void Print();
    }
    // public 
    class Flash : Storage
    {
        private int memorySize;
        private double time;
        private double fileSize = 565;
        private double writingSpeed = 0.48;
        private double quantity;

        public Flash(string nameCarrier_1, string model_1, int memorySize_1)
            : base(nameCarrier_1, model_1)
        {
            this.memorySize = memorySize_1;
        }

        // Метод расчета времени копирования данных
        public override double CopyDataTime()
        {
            return time = fileSize / writingSpeed;
        }

        // Необходимое количество устройств для записи
        public override int DeviceCount()
        {
            quantity = fileSize / memorySize;
            return (int)quantity;
        }

        public string GetCarrierName()
        { return carrierName; }
        public string GetModel()
        { return model; }

        public override void Print()
        {
            Console.WriteLine("Устройтсво: " + GetCarrierName());
            Console.WriteLine("Модель: " + GetModel());
            Console.WriteLine("Время на копирование: " + CopyDataTime() + " c");
            Console.WriteLine("Количиество флешек: " + DeviceCount());
            Console.WriteLine();
        }
    }

    class DVD : Storage
    {
        private double memorySize;
        private double speedOneSide = 0.02112;//4.7
        private double speedDoubleSide = 0.01056;//9
        private double fileSize = 565;
        private double time;
        private double quantity;


        public DVD(string nameCarrier_1, string model_1, double memorySize_1)
            : base(nameCarrier_1, model_1)
        {
            this.memorySize = memorySize_1;
        }

        // Метод расчета времени копирования данных (диск 1)
        public override double CopyDataTime()
        {
            return time = fileSize / speedOneSide;
        }

        // Метод расчета времени копирования данных (диск 2)
        public double CopyDataTime2()
        {
            return time = fileSize / speedDoubleSide;
        }

        // Необходимое количество устройств для записи (диск 1)
        public override int DeviceCount()
        {
            quantity = fileSize / memorySize;
            return (int)quantity;
        }

        public string GetCarrierName()
        { return carrierName; }
        public string GetModel()
        { return model; }

        public override void Print()
        {
            Console.WriteLine("Устройтсво: " + GetCarrierName());
            Console.WriteLine("Модель: " + GetModel());
            Console.WriteLine("Время на копирование: " + CopyDataTime() + " c");
            Console.WriteLine("Количиество DVD: " + DeviceCount());
            Console.WriteLine();
        }

    }

    class HDD : Storage
    {
        private double memorySize;
        private double time;
        private double fileSize = 565;
        private double writingSpeed = 0.048;
        private double quantity;


        public HDD(string nameCarrier_1, string model_1, double memorySize_1)
            : base(nameCarrier_1, model_1)
        {
            this.memorySize = memorySize_1;
        }

        public override double CopyDataTime()
        {
            return time = fileSize / writingSpeed;
        }

        public override int DeviceCount()
        {
            quantity = fileSize / memorySize;
            return (int)quantity;
        }

        public string GetCarrierName()
        { return carrierName; }
        public string GetModel()
        { return model; }

        public override void Print()
        {
            Console.WriteLine("Устройтсво: " + GetCarrierName());
            Console.WriteLine("Модель: " + GetModel());
            Console.WriteLine("Время на копирование: " + CopyDataTime() + " c");
            Console.WriteLine("Количиество HDD: " + DeviceCount());
            Console.WriteLine();
        }
    }
    /*
    class Program
    {
        static void Main(string[] args)
        {
            Storage[] storage = { new Flash("Flash", "San Disk", 64),
                new DVD("DVD односторонний", "Esperanza", 4.7),
                new DVD("DVD двусторонний", "TDK", 9),
                new HDD("HDD", "Seagate", 500)
            };

            foreach (Storage item in storage)
            {
                item.Print();
            }
        }
    }
    */
}




