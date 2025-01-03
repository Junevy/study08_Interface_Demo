using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study08_Interface {
    internal class Program {
        static void Main(string[] args) {
            #region engine and car
            //Engine engine = new Engine();
            //Car car = new Car(engine);
            //car.Run(2);
            //Console.WriteLine(car.Speed);
            #endregion



        }
    }

    #region engine and car
    class Engine {
        public int RPM { get; private set; }

        public void Work(int gas) {
            this.RPM = gas * 1000;
        }
    }

    class Car {
        private Engine engine;
        public double Speed { get; private set; }
        public Car(Engine engine) {
            this.engine = engine;
        }

        public void Run(int gas) {
            engine.Work(gas);
            this.Speed = engine.RPM / 100;
        }
    }

    #endregion 

    interface IPhone {
        void Dail();
        void PickUp();
        void SendMsg();
        void ReceiveMsg();
    }

    class NokiaPhone : IPhone {


    }

}
