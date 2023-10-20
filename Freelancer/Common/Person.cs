using System;
namespace Freelancer.Common
{
	public class Person<TKey>: EntityBase<TKey>
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}

