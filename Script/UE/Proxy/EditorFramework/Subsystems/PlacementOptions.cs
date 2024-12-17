using Script.CoreUObject;
using Script.Library;

namespace Script.EditorFramework
{
	[PathName("/Script/EditorFramework.PlacementOptions")]
	public partial class FPlacementOptions : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EditorFramework.PlacementOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPlacementOptions() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPlacementOptions() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPlacementOptions A, FPlacementOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPlacementOptions A, FPlacementOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPlacementOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FGuid InstancedPlacementGridGuid
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InstancedPlacementGridGuid, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InstancedPlacementGridGuid, __InBuffer);
				}
			}
		}

		public bool bPreferBatchPlacement
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bPreferBatchPlacement, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bPreferBatchPlacement, __InBuffer);
				}
			}
		}

		public bool bIsCreatingPreviewElements
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsCreatingPreviewElements, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsCreatingPreviewElements, __InBuffer);
				}
			}
		}

		private static uint __InstancedPlacementGridGuid = 0;

		private static uint __bPreferBatchPlacement = 0;

		private static uint __bIsCreatingPreviewElements = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}