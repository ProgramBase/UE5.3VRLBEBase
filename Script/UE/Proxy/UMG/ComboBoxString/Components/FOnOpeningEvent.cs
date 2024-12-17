using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.UMG.ComboBoxString
{
	public class FOnOpeningEvent : FMulticastDelegate<Action>
	{
		public FOnOpeningEvent() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnOpeningEvent() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
