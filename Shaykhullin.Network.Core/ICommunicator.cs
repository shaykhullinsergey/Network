﻿using System.Threading.Tasks;

namespace Network.Core
{
	public interface ICommunicator
	{
		bool IsConnected { get; }
		Task Connect();
		Task<IPacket> Receive();
		Task Send(IPacket packet);
	}
}