using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class NoCoinState : IVendingMachineState
    {
        private VendingMachine _machine;

        public NoCoinState(VendingMachine machine)
        {
            _machine = machine;
        }

        public void InsertCoin()
        {
            Console.WriteLine("💰 Moneda insertada.");
            _machine.SetState(_machine.CoinInsertedState);
        }

        public void PressButton()
        {
            Console.WriteLine("🚫 Inserta una moneda primero.");
        }

        public void Dispense()
        {
            Console.WriteLine("🚫 No se puede dispensar sin una moneda.");
        }
    }

}
