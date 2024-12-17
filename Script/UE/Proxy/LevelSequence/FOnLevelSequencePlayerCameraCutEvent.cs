using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.LevelSequence
{
	public class FOnLevelSequencePlayerCameraCutEvent : FMulticastDelegate<Action<UCameraComponent>>
	{
		public FOnLevelSequencePlayerCameraCutEvent() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnLevelSequencePlayerCameraCutEvent() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(UCameraComponent CameraComponent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = CameraComponent?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
