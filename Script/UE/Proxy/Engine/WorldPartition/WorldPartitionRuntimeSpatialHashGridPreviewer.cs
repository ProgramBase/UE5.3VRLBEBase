using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.WorldPartitionRuntimeSpatialHashGridPreviewer")]
	public partial class FWorldPartitionRuntimeSpatialHashGridPreviewer : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.WorldPartitionRuntimeSpatialHashGridPreviewer");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FWorldPartitionRuntimeSpatialHashGridPreviewer() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FWorldPartitionRuntimeSpatialHashGridPreviewer() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FWorldPartitionRuntimeSpatialHashGridPreviewer A, FWorldPartitionRuntimeSpatialHashGridPreviewer B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FWorldPartitionRuntimeSpatialHashGridPreviewer A, FWorldPartitionRuntimeSpatialHashGridPreviewer B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FWorldPartitionRuntimeSpatialHashGridPreviewer;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UMaterial Material
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Material, __ReturnBuffer);

					return *(UMaterial*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Material, __InBuffer);
				}
			}
		}

		public UMaterialInstanceDynamic MID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MID, __ReturnBuffer);

					return *(UMaterialInstanceDynamic*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MID, __InBuffer);
				}
			}
		}

		public APostProcessVolume Volume
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Volume, __ReturnBuffer);

					return *(APostProcessVolume*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Volume, __InBuffer);
				}
			}
		}

		private static uint __Material = 0;

		private static uint __MID = 0;

		private static uint __Volume = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}