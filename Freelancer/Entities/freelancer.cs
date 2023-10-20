using System;
using Freelancer.Abstract;
using Freelancer.Common;
using Freelancer.ValueObjects;

namespace Freelancer.Entities
{
	public class freelancer: Person<Guid>, ICsvConvertible
    {
        public string WorkExperience { get; set; }

        public List<Review> Reviews { get; set; }

        public string GetValuesCSV()
        {
            return $"{Id}, {CreatedOn},{FirstName},{LastName},{WorkExperience}";
        }
        public void SetValuesCSV(string csvLine)
        {
            string[] data = csvLine.Split(',');
            Id = Guid.Parse(data[0]);
            CreatedOn = DateTimeOffset.Parse(data[1]);
            FirstName = data[2];
            LastName = data[3];
            WorkExperience = data[4];
        }


    }
}

