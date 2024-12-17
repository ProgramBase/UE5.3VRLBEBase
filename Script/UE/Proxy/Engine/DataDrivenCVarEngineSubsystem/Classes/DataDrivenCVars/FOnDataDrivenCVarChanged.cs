using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine.DataDrivenCVarEngineSubsystem
{
	public class FOnDataDrivenCVarChanged : FMulticastDelegate<Action<FString>>
	{
		public FOnDataDrivenCVarChanged() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnDataDrivenCVarChanged() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FString CVarName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = CVarName?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
