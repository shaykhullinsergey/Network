﻿using System.Threading.Tasks;

namespace Network.Core
{
	public interface ICommunicator
	{
		Task Connect();
		Task<IPacket> Receive();
		Task Send(IPacket packet);
	}
}