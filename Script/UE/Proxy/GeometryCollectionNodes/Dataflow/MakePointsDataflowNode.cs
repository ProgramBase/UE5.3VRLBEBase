using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.MakePointsDataflowNode")]
	public partial class FMakePointsDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.MakePointsDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMakePointsDataflowNode()
		{
		}

		public static bool operator ==(FMakePointsDataflowNode A, FMakePointsDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMakePointsDataflowNode A, FMakePointsDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMakePointsDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FVector> Point
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Point, __ReturnBuffer);

					return *(TArray<FVector>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Point, __InBuffer);
				}
			}
		}

		public TArray<FVector> Points
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Points, __ReturnBuffer);

					return *(TArray<FVector>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Points, __InBuffer);
				}
			}
		}

		private static uint __Point = 0;

		private static uint __Points = 0;

	}
}