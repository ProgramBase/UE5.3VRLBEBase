using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.CollectionTransformSelectionInvertDataflowNode")]
	public partial class FCollectionTransformSelectionInvertDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.CollectionTransformSelectionInvertDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCollectionTransformSelectionInvertDataflowNode()
		{
		}

		public static bool operator ==(FCollectionTransformSelectionInvertDataflowNode A, FCollectionTransformSelectionInvertDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCollectionTransformSelectionInvertDataflowNode A, FCollectionTransformSelectionInvertDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCollectionTransformSelectionInvertDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

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

		private static uint __TransformSelection = 0;

	}
}