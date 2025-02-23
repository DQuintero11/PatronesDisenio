using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class DispensingState : IVendingMachineState
    {
        private VendingMachine _machine;

        public DispensingState(VendingMachine machine)
        {
            _machine = machine;
        }

        public void InsertCoin()
        {
            Console.WriteLine("⏳ Espera a que se dispense el producto.");
        }

        public void PressButton()
        {
            Console.WriteLine("⏳ Ya presionaste el botón. Dispensando...");
        }

        public void Dispense()
        {
            Console.WriteLine("🍫 Producto dispensado. Vuelve al estado inicial.");
            _machine.SetState(_machine.NoCoinState);
        }
    }

}
