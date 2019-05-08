using System;

namespace Sample4Event
{
    //定义合适的委托，名称可以更具情况带一些时态信息（-ing,-ed 等）;两个必要的参数：sender,args 
    public delegate void TemperatureChanged(object sender, TemperatureChangedEventArgs args);

    //参数 可以使用系统内建的合适的参数类型，也可以继承自EventArgs
    public class TemperatureChangedEventArgs : EventArgs
    {
        public TemperatureChangedEventArgs(int currentDegrees) => CurrentDegrees = currentDegrees;
        public int CurrentDegrees { get; }
    }

    public class Kettle
    {
        public event TemperatureChanged TemperatureChanged;
        //提供可重写的事件触发方法
        protected virtual void OnTemperatureChanged(object sender, int currentDegress)
        {
            TemperatureChanged?.Invoke(sender, new TemperatureChangedEventArgs(currentDegress));
        }
        public void HeatingWater()
        {
            for (var i = 0; i <= 100; i++)
            {
                OnTemperatureChanged(this, i);
            }
        }
    }


    public class Client
    {
        private Kettle kettle = new Kettle();

        public void RegistEventHandler()
        {
            kettle.TemperatureChanged += Kettle_TemperatureChanged;
        }

        ~Client()
        {
            kettle.TemperatureChanged -= Kettle_TemperatureChanged;
        }

        private void Kettle_TemperatureChanged(object sender, TemperatureChangedEventArgs args)
        {
            a = Kettle_TemperatureChanged;
            a += Kettle_TemperatureChanged;

            throw new NotImplementedException();
        }

        TemperatureChanged a;
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
