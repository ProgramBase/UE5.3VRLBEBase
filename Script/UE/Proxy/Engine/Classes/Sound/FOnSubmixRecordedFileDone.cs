using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	public class FOnSubmixRecordedFileDone : FMulticastDelegate<Action<USoundWave>>
	{
		public FOnSubmixRecordedFileDone() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnSubmixRecordedFileDone() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(USoundWave ResultingSoundWave)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ResultingSoundWave?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
