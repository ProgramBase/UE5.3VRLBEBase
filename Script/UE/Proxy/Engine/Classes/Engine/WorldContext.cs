using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.WorldContext")]
	public partial class FWorldContext : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.WorldContext");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FWorldContext() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FWorldContext() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FWorldContext A, FWorldContext B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FWorldContext A, FWorldContext B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FWorldContext;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FURL LastURL
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LastURL, __ReturnBuffer);

					return *(FURL*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LastURL, __InBuffer);
				}
			}
		}

		public FURL LastRemoteURL
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LastRemoteURL, __ReturnBuffer);

					return *(FURL*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LastRemoteURL, __InBuffer);
				}
			}
		}

		public UPendingNetGame PendingNetGame
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PendingNetGame, __ReturnBuffer);

					return *(UPendingNetGame*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PendingNetGame, __InBuffer);
				}
			}
		}

		public TArray<FFullyLoadedPackagesInfo> PackagesToFullyLoad
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PackagesToFullyLoad, __ReturnBuffer);

					return *(TArray<FFullyLoadedPackagesInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PackagesToFullyLoad, __InBuffer);
				}
			}
		}

		public TArray<ULevel> LoadedLevelsForPendingMapChange
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LoadedLevelsForPendingMapChange, __ReturnBuffer);

					return *(TArray<ULevel>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LoadedLevelsForPendingMapChange, __InBuffer);
				}
			}
		}

		public TArray<UObjectReferencer> ObjectReferencers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ObjectReferencers, __ReturnBuffer);

					return *(TArray<UObjectReferencer>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ObjectReferencers, __InBuffer);
				}
			}
		}

		public TArray<FLevelStreamingStatus> PendingLevelStreamingStatusUpdates
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PendingLevelStreamingStatusUpdates, __ReturnBuffer);

					return *(TArray<FLevelStreamingStatus>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PendingLevelStreamingStatusUpdates, __InBuffer);
				}
			}
		}

		public UGameViewportClient GameViewport
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GameViewport, __ReturnBuffer);

					return *(UGameViewportClient*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GameViewport, __InBuffer);
				}
			}
		}

		public UGameInstance OwningGameInstance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OwningGameInstance, __ReturnBuffer);

					return *(UGameInstance*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OwningGameInstance, __InBuffer);
				}
			}
		}

		public TArray<FNamedNetDriver> ActiveNetDrivers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ActiveNetDrivers, __ReturnBuffer);

					return *(TArray<FNamedNetDriver>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ActiveNetDrivers, __InBuffer);
				}
			}
		}

		private static uint __LastURL = 0;

		private static uint __LastRemoteURL = 0;

		private static uint __PendingNetGame = 0;

		private static uint __PackagesToFullyLoad = 0;

		private static uint __LoadedLevelsForPendingMapChange = 0;

		private static uint __ObjectReferencers = 0;

		private static uint __PendingLevelStreamingStatusUpdates = 0;

		private static uint __GameViewport = 0;

		private static uint __OwningGameInstance = 0;

		private static uint __ActiveNetDrivers = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}