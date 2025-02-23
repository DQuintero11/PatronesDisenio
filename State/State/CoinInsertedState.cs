using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class CoinInsertedState : IVendingMachineState
    {
        private VendingMachine _machine;

        public CoinInsertedState(VendingMachine machine)
        {
            _machine = machine;
        }

        public void InsertCoin()
        {
            Console.WriteLine("🚫 Ya hay una moneda insertada.");
        }

        public void PressButton()
        {
            Console.WriteLine("🔘 Botón presionado. Dispensando producto...");
            _machine.SetState(_machine.DispensingState);
            _machine.Dispense();
        }

        public void Dispense()
        {
            Console.WriteLine("🚫 Presiona el botón para dispensar.");
        }
    }

}
