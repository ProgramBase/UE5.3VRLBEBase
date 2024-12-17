using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Synthesis
{
	public class FOnTableAltered : FMulticastDelegate<Action<int>>
	{
		public FOnTableAltered() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnTableAltered() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(int TableIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = TableIndex;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
