using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.LevelEditor
{
	public class FOnLevelEditorPostSaveWorld : FMulticastDelegate<Action<int, UWorld, bool>>
	{
		public FOnLevelEditorPostSaveWorld() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnLevelEditorPostSaveWorld() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(int SaveFlags, UWorld World, bool bSuccess)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(int*)(__InBuffer) = SaveFlags;

				*(nint*)(__InBuffer + 4) = World?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 12) = bSuccess;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
