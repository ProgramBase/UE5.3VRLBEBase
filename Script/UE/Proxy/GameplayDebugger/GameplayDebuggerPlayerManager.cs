using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.GameplayDebugger
{
	[PathName("/Script/GameplayDebugger.GameplayDebuggerPlayerManager")]
	public partial class AGameplayDebuggerPlayerManager : AActor, IStaticClass
	{
		public TArray<FGameplayDebuggerPlayerData> PlayerData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlayerData, __ReturnBuffer);

					return *(TArray<FGameplayDebuggerPlayerData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlayerData, __InBuffer);
				}
			}
		}

		public TArray<AGameplayDebuggerCategoryReplicator> PendingRegistrations
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PendingRegistrations, __ReturnBuffer);

					return *(TArray<AGameplayDebuggerCategoryReplicator>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PendingRegistrations, __InBuffer);
				}
			}
		}

		public FGameplayDebuggerPlayerData EditorWorldData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EditorWorldData, __ReturnBuffer);

					return *(FGameplayDebuggerPlayerData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EditorWorldData, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameplayDebugger.GameplayDebuggerPlayerManager");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __PlayerData = 0;

		private static uint __PendingRegistrations = 0;

		private static uint __EditorWorldData = 0;
	}
}