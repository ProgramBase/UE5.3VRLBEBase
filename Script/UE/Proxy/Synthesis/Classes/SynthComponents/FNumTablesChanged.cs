using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Synthesis
{
	public class FNumTablesChanged : FMulticastDelegate<Action>
	{
		public FNumTablesChanged() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FNumTablesChanged() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
