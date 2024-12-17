using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.LevelEditor
{
	public class FOnLevelEditorMapChanged : FMulticastDelegate<Action<int>>
	{
		public FOnLevelEditorMapChanged() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnLevelEditorMapChanged() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(int MapChangeEventFlags)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = MapChangeEventFlags;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
