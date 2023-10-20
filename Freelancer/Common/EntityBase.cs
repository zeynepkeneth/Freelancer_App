using System;
using System.Security.Cryptography.X509Certificates;

namespace Freelancer.Common
{
	public class EntityBase<TKey>
	{

        public TKey Id { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
    }
}

