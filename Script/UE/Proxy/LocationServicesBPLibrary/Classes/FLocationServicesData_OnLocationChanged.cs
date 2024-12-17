using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.LocationServicesBPLibrary
{
	public class FLocationServicesData_OnLocationChanged : FMulticastDelegate<Action<FLocationServicesData>>
	{
		public FLocationServicesData_OnLocationChanged() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FLocationServicesData_OnLocationChanged() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FLocationServicesData LocationData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LocationData?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
