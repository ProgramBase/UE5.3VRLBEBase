using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.LevelEditor
{
	public class FOnLevelEditorPreSaveWorld : FMulticastDelegate<Action<int, UWorld>>
	{
		public FOnLevelEditorPreSaveWorld() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnLevelEditorPreSaveWorld() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(int SaveFlags, UWorld World)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = SaveFlags;

				*(nint*)(__InBuffer + 4) = World?.GarbageCollectionHandle ?? nint.Zero;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
