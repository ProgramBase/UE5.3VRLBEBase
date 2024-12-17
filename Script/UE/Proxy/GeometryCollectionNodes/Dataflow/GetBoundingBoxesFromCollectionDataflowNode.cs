using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;
using Script.Chaos;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.GetBoundingBoxesFromCollectionDataflowNode")]
	public partial class FGetBoundingBoxesFromCollectionDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.GetBoundingBoxesFromCollectionDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGetBoundingBoxesFromCollectionDataflowNode()
		{
		}

		public static bool operator ==(FGetBoundingBoxesFromCollectionDataflowNode A, FGetBoundingBoxesFromCollectionDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGetBoundingBoxesFromCollectionDataflowNode A, FGetBoundingBoxesFromCollectionDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGetBoundingBoxesFromCollectionDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FManagedArrayCollection Collection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Collection, __ReturnBuffer);

					return *(FManagedArrayCollection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Collection, __InBuffer);
				}
			}
		}

		public FDataflowTransformSelection TransformSelection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TransformSelection, __ReturnBuffer);

					return *(FDataflowTransformSelection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TransformSelection, __InBuffer);
				}
			}
		}

		public TArray<FBox> BoundingBoxes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoundingBoxes, __ReturnBuffer);

					return *(TArray<FBox>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoundingBoxes, __InBuffer);
				}
			}
		}

		private static uint __Collection = 0;

		private static uint __TransformSelection = 0;

		private static uint __BoundingBoxes = 0;

	}
}