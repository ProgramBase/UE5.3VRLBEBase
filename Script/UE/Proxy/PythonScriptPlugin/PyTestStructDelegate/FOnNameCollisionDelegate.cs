using System;
using Script.CoreUObject;
using Script.Library;
using Script.PythonScriptPlugin;

namespace Script.PythonScriptPlugin.PyTestStructDelegate
{
	public class FOnNameCollisionDelegate : FMulticastDelegate<Action<FPyTestStruct>>
	{
		public FOnNameCollisionDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnNameCollisionDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FPyTestStruct PyStruct)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PyStruct?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
