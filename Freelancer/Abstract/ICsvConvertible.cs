using System;
namespace Freelancer.Abstract
{
	internal interface ICsvConvertible
	{
        string GetValuesCSV();
        void SetValuesCSV(string csv);
    }
}

