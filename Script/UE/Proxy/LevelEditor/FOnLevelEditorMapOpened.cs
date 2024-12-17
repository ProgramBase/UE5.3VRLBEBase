using System;
using Script.CoreUObject;
using Script.Library;

namespace Script.LevelEditor
{
	public class FOnLevelEditorMapOpened : FMulticastDelegate<Action<FString, bool>>
	{
		public FOnLevelEditorMapOpened() => FMulticastDelegateImplementation.FMulticastDelegate_RegisterImplementation(this);

		~FOnLevelEditorMapOpened() => FMulticastDelegateImplementation.FMulticastDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Broadcast(FString Filename, bool bAsTemplate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Filename?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bAsTemplate;

				FMulticastDelegateImplementation.FMulticastDelegate_GenericBroadcast2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
