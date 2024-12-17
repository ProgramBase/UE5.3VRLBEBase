using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SpatialHashStreamingGridLayerCell")]
	public partial class FSpatialHashStreamingGridLayerCell : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SpatialHashStreamingGridLayerCell");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSpatialHashStreamingGridLayerCell() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSpatialHashStreamingGridLayerCell() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSpatialHashStreamingGridLayerCell A, FSpatialHashStreamingGridLayerCell B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSpatialHashStreamingGridLayerCell A, FSpatialHashStreamingGridLayerCell B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSpatialHashStreamingGridLayerCell;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<UWorldPartitionRuntimeCell> GridCells
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GridCells, __ReturnBuffer);

					return *(TArray<UWorldPartitionRuntimeCell>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GridCells, __InBuffer);
				}
			}
		}

		private static uint __GridCells = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}