using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.OnlineSubsystemUtils
{
	public class FAchievementWriteDelegate : FMulticastDelegate<Action<FName, float, int>>
	{
		public FAchievementWriteDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FAchievementWriteDelegate() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FName WrittenAchievementName, float WrittenProgress, int WrittenUserTag)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WrittenAchievementName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = WrittenProgress;

				*(int*)(__InBuffer + 12) = WrittenUserTag;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
