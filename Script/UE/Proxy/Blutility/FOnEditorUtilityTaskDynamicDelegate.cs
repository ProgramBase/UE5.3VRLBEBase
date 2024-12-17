using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Blutility
{
	public class FOnEditorUtilityTaskDynamicDelegate : FMulticastDelegate<Action<UEditorUtilityTask>>
	{
		public FOnEditorUtilityTaskDynamicDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnEditorUtilityTaskDynamicDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UEditorUtilityTask Task)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Task?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
