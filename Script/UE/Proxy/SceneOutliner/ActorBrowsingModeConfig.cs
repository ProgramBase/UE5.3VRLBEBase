using Script.CoreUObject;
using Script.Library;

namespace Script.SceneOutliner
{
	[PathName("/Script/SceneOutliner.ActorBrowsingModeConfig")]
	public partial class FActorBrowsingModeConfig : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SceneOutliner.ActorBrowsingModeConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FActorBrowsingModeConfig() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FActorBrowsingModeConfig() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FActorBrowsingModeConfig A, FActorBrowsingModeConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FActorBrowsingModeConfig A, FActorBrowsingModeConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FActorBrowsingModeConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bHideTemporaryActors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bHideTemporaryActors, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bHideTemporaryActors, __InBuffer);
				}
			}
		}

		public bool bShowOnlyActorsInCurrentLevel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bShowOnlyActorsInCurrentLevel, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bShowOnlyActorsInCurrentLevel, __InBuffer);
				}
			}
		}

		public bool bShowOnlyActorsInCurrentDataLayers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bShowOnlyActorsInCurrentDataLayers, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bShowOnlyActorsInCurrentDataLayers, __InBuffer);
				}
			}
		}

		public bool bShowOnlyActorsInCurrentContentBundle
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bShowOnlyActorsInCurrentContentBundle, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bShowOnlyActorsInCurrentContentBundle, __InBuffer);
				}
			}
		}

		public bool bShowOnlySelectedActors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bShowOnlySelectedActors, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bShowOnlySelectedActors, __InBuffer);
				}
			}
		}

		public bool bHideActorComponents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bHideActorComponents, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bHideActorComponents, __InBuffer);
				}
			}
		}

		public bool bHideLevelInstanceHierarchy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bHideLevelInstanceHierarchy, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bHideLevelInstanceHierarchy, __InBuffer);
				}
			}
		}

		public bool bHideUnloadedActors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bHideUnloadedActors, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bHideUnloadedActors, __InBuffer);
				}
			}
		}

		public bool bHideEmptyFolders
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bHideEmptyFolders, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bHideEmptyFolders, __InBuffer);
				}
			}
		}

		public bool bAlwaysFrameSelection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bAlwaysFrameSelection, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bAlwaysFrameSelection, __InBuffer);
				}
			}
		}

		private static uint __bHideTemporaryActors = 0;

		private static uint __bShowOnlyActorsInCurrentLevel = 0;

		private static uint __bShowOnlyActorsInCurrentDataLayers = 0;

		private static uint __bShowOnlyActorsInCurrentContentBundle = 0;

		private static uint __bShowOnlySelectedActors = 0;

		private static uint __bHideActorComponents = 0;

		private static uint __bHideLevelInstanceHierarchy = 0;

		private static uint __bHideUnloadedActors = 0;

		private static uint __bHideEmptyFolders = 0;

		private static uint __bAlwaysFrameSelection = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}