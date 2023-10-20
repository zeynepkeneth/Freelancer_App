using System;
using Freelancer.Common;

namespace Freelancer.ValueObjects
{
	public class Review: EntityBase<Guid>
    {
		public string Text { get; set; }
		public int Point { get; set; }

	}
}

