using System;
using Script.CoreUObject;
using Script.Library;
using Script.EnhancedInput;

namespace Script.EnhancedInput.EnhancedInputUserSettings
{
	public class FEnhancedInputUserSettingsChanged : FMulticastDelegate<Action<UEnhancedInputUserSettings>>
	{
		public FEnhancedInputUserSettingsChanged() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FEnhancedInputUserSettingsChanged() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UEnhancedInputUserSettings Settings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Settings?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
