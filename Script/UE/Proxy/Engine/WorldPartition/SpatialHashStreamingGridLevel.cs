using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SpatialHashStreamingGridLevel")]
	public partial class FSpatialHashStreamingGridLevel : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.SpatialHashStreamingGridLevel");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSpatialHashStreamingGridLevel() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSpatialHashStreamingGridLevel() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSpatialHashStreamingGridLevel A, FSpatialHashStreamingGridLevel B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSpatialHashStreamingGridLevel A, FSpatialHashStreamingGridLevel B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSpatialHashStreamingGridLevel;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FSpatialHashStreamingGridLayerCell> LayerCells
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LayerCells, __ReturnBuffer);

					return *(TArray<FSpatialHashStreamingGridLayerCell>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LayerCells, __InBuffer);
				}
			}
		}

		public TMap<long, int> LayerCellsMapping
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LayerCellsMapping, __ReturnBuffer);

					return *(TMap<long, int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LayerCellsMapping, __InBuffer);
				}
			}
		}

		private static uint __LayerCells = 0;

		private static uint __LayerCellsMapping = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}