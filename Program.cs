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

            #region phone
            PhoneUser phoneUser = new PhoneUser(new NokiaPhone());
            phoneUser.send();


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
            this.engine = engine ?? throw new NullReferenceException();
        }

        public void Run(int gas) {
            engine.Work(gas);
            this.Speed = engine.RPM / 100;
        }
    }

    #endregion


    #region interface and 依赖注入
    interface IPhone {
        void Dail();
        void PickUp();
        void SendMsg();
        void ReceiveMsg();
    }

    class NokiaPhone : IPhone {
        public void Dail() {
            Console.WriteLine("Nokia Dailing...");
        }

        public void PickUp() {
            Console.WriteLine("Nokia Pick uped...");
        }


        public void ReceiveMsg() {
            Console.WriteLine("Nokia Receivced a message : Good night!!");
        }

        public void SendMsg() {
            Console.WriteLine("NOkia Send a Message : night!");
        }
    }

    class Motorolar : IPhone {
        public void Dail() {
            Console.WriteLine("Motor Dailing...");
        }

        public void PickUp() {
            Console.WriteLine("Motor Pick uped...");
        }

        public void ReceiveMsg() {
            Console.WriteLine("Motor Receivced a message : Good night!!");
        }

        public void SendMsg() {
            Console.WriteLine("Motor Send a Message : night!");
        }
    }

    class PhoneUser {
        private IPhone phone;
        public PhoneUser(IPhone phone) {
            this.phone = phone;
        }
        public void send() {
            phone.SendMsg();
        }

    }

    #endregion
}
