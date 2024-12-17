using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.LevelStreamingDynamic")]
	public partial class ULevelStreamingDynamic : ULevelStreaming, IStaticClass
	{
		public bool bInitiallyLoaded
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bInitiallyLoaded, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bInitiallyLoaded, __InBuffer);
				}
			}
		}

		public bool bInitiallyVisible
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bInitiallyVisible, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bInitiallyVisible, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.LevelStreamingDynamic");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static ULevelStreamingDynamic LoadLevelInstanceBySoftObjectPtr(UObject WorldContextObject, TSoftObjectPtr<UWorld> Level, FVector Location, FRotator Rotation, ref bool bOutSuccess, FString OptionalLevelNameOverride, TSubclassOf<ULevelStreamingDynamic> OptionalLevelStreamingClass, bool bLoadAsTempPackage)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[50];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Level?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Rotation?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 32) = bOutSuccess;

				*(nint*)(__InBuffer + 33) = OptionalLevelNameOverride?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 41) = OptionalLevelStreamingClass?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 49) = bLoadAsTempPackage;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __LoadLevelInstanceBySoftObjectPtr, __InBuffer, __OutBuffer, __ReturnBuffer);

				bOutSuccess = *(bool*)(__OutBuffer);

				return *(ULevelStreamingDynamic*)__ReturnBuffer;
			}
		}

		/// <param name="LevelName">
		/// - Level package name to load, ex: /Game/Maps/MyMapName, specifying short name like MyMapName will force very slow search on disk
		/// </param>
		/// <param name="Location">
		/// - World space location where the level should be spawned
		/// </param>
		/// <param name="Rotation">
		/// - World space rotation for rotating the entire level
		/// </param>
		/// <param name="bOutSuccess">
		/// - Whether operation was successful (map was found and added to the sub-levels list)
		/// </param>
		/// <param name="OptionalLevelNameOverride">
		/// - If set, the loaded level package have this name, which is used by other functions like UnloadStreamLevel. Note this is necessary for server and client networking because the level must have the same name on both.
		/// </param>
		/// <param name="OptionalLevelStreamingClass">
		/// - If set, the level streaming class will be used instead of ULevelStreamingDynamic
		/// </param>
		/// <param name="bLoadAsTempPackage">
		/// - If set, package path is prefixed by /Temp
		/// </param>
		/// <returns>
		/// Streaming level object for a level instance
		/// </returns>
		public static ULevelStreamingDynamic LoadLevelInstance(UObject WorldContextObject, FString LevelName, FVector Location, FRotator Rotation, ref bool bOutSuccess, FString OptionalLevelNameOverride, TSubclassOf<ULevelStreamingDynamic> OptionalLevelStreamingClass, bool bLoadAsTempPackage)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[50];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LevelName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Rotation?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 32) = bOutSuccess;

				*(nint*)(__InBuffer + 33) = OptionalLevelNameOverride?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 41) = OptionalLevelStreamingClass?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 49) = bLoadAsTempPackage;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __LoadLevelInstance, __InBuffer, __OutBuffer, __ReturnBuffer);

				bOutSuccess = *(bool*)(__OutBuffer);

				return *(ULevelStreamingDynamic*)__ReturnBuffer;
			}
		}

		private static uint __bInitiallyLoaded = 0;

		private static uint __bInitiallyVisible = 0;

		private static uint __LoadLevelInstanceBySoftObjectPtr = 0;

		private static uint __LoadLevelInstance = 0;
	}
}