﻿namespace Shaykhullin.Network.Core
{
	internal class ChannelConfig : IChannelConfig
	{
		public IRegisterBuilder<TRegister> Register<TRegister>() 
			where TRegister : class
		{
			return new RegisterBuilder<TRegister>();
		}
	}
}
