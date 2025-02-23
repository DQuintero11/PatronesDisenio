using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class VendingMachine
    {
        public IVendingMachineState NoCoinState { get; private set; }
        public IVendingMachineState CoinInsertedState { get; private set; }
        public IVendingMachineState DispensingState { get; private set; }

        private IVendingMachineState _currentState;

        public VendingMachine()
        {
            NoCoinState = new NoCoinState(this);
            CoinInsertedState = new CoinInsertedState(this);
            DispensingState = new DispensingState(this);

            _currentState = NoCoinState; // Estado inicial
        }

        public void SetState(IVendingMachineState newState)
        {
            _currentState = newState;
        }

        public void InsertCoin()
        {
            _currentState.InsertCoin();
        }

        public void PressButton()
        {
            _currentState.PressButton();
        }

        public void Dispense()
        {
            _currentState.Dispense();
        }
    }

}
