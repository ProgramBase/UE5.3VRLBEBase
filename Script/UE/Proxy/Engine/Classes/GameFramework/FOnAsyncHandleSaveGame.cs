using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnAsyncHandleSaveGame : FMulticastDelegate<Action<USaveGame, bool>>
	{
		public FOnAsyncHandleSaveGame() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnAsyncHandleSaveGame() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(USaveGame SaveGame, bool bSuccess)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = SaveGame?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSuccess;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
