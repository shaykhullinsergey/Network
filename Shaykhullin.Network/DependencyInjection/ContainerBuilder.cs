﻿using System;

namespace Shaykhullin.Network.Core
{
	internal class ContainerBuilder : IDependencyContainerBuilder
	{
		public void UseContainer<TContainer>() 
			where TContainer : IContainerBuilder
		{
			throw new NotImplementedException();
		}
	}
}