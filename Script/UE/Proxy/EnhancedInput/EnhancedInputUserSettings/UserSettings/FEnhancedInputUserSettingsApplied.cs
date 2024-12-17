using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.EnhancedInput.EnhancedInputUserSettings
{
	public class FEnhancedInputUserSettingsApplied : FMulticastDelegate<Action>
	{
		public FEnhancedInputUserSettingsApplied() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FEnhancedInputUserSettingsApplied() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast()
		{
			unsafe
			{
				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast0Implementation(GarbageCollectionHandle);
			}
		}
	}
}
