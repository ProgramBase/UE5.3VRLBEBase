using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CheatManagerExtension")]
	public partial class UCheatManagerExtension : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.CheatManagerExtension");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void RemovedFromCheatManager()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __RemovedFromCheatManager);
			}
		}

		public virtual APlayerController GetPlayerController()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPlayerController, __ReturnBuffer);

				return *(APlayerController*)__ReturnBuffer;
			}
		}

		public virtual void AddedToCheatManager()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __AddedToCheatManager);
			}
		}

		private static uint __RemovedFromCheatManager = 0;

		private static uint __GetPlayerController = 0;

		private static uint __AddedToCheatManager = 0;
	}
}