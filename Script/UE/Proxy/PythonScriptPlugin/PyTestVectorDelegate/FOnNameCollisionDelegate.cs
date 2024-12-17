using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.PythonScriptPlugin.PyTestVectorDelegate
{
	public class FOnNameCollisionDelegate : FMulticastDelegate<Action<FVector2D>>
	{
		public FOnNameCollisionDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnNameCollisionDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FVector2D Vec)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Vec?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
