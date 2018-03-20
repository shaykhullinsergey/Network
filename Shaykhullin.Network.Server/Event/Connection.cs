﻿using Shaykhullin.Network.Core;

namespace Shaykhullin.Network
{
	public class Connection : IEvent<IConnectionConfig>
	{
		public Connection(IConnectionConfig context)
		{
			Context = context;
		}

		public IConnectionConfig Context { get; }
	}
}