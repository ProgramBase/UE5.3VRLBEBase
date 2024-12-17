using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.AppleImageUtils
{
	public class FAppleImageConversionDelegate : FMulticastDelegate<Action<FAppleImageUtilsImageConversionResult>>
	{
		public FAppleImageConversionDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FAppleImageConversionDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FAppleImageUtilsImageConversionResult ConversionResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ConversionResult?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
