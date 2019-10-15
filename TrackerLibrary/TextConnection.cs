using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TextConnection : IDataConnection
    {
        public PrizeModel CreatePrizeMethod(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
