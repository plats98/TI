using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIProject.BE
{
    public class Project
    {
        private Plant _Plant = new Plant();
        private BindingList<AnalogSignal> _AnalogSignals = new BindingList<AnalogSignal>();

        public Plant Plant
        {
            get
            {
                return _Plant;
            }

            set
            {
                _Plant = value;
            }
        }

        public BindingList<AnalogSignal> AnalogSignals
        {
            get
            {
                return _AnalogSignals;
            }

            set
            {
                _AnalogSignals = value;
            }
        }
    }
}
