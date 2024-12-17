using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnGameUserSettingsUINeedsUpdate : FMulticastDelegate<Action>
	{
		public FOnGameUserSettingsUINeedsUpdate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnGameUserSettingsUINeedsUpdate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
