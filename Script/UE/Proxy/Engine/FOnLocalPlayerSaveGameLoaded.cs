using System;
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Engine
{
	public class FOnLocalPlayerSaveGameLoaded : FDelegate<Action<ULocalPlayerSaveGame>>
	{
		public FOnLocalPlayerSaveGameLoaded() => FDelegateImplementation.FDelegate_RegisterImplementation(this);

		~FOnLocalPlayerSaveGameLoaded() => FDelegateImplementation.FDelegate_UnRegisterImplementation(GarbageCollectionHandle);

		public void Execute(ULocalPlayerSaveGame SaveGame)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SaveGame?.GarbageCollectionHandle ?? nint.Zero;

				FDelegateImplementation.FDelegate_GenericExecute2Implementation(GarbageCollectionHandle, __InBuffer);
			}
		}
	}
}
