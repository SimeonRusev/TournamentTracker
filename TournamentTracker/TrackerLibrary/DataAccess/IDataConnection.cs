using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        //TODO - wire up the CreatePrize for text files.
        PrizeModel CreatePrize(PrizeModel model); 

    }
}
