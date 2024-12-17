using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.CollectionFaceSelectionInvertDataflowNode")]
	public partial class FCollectionFaceSelectionInvertDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.CollectionFaceSelectionInvertDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCollectionFaceSelectionInvertDataflowNode()
		{
		}

		public static bool operator ==(FCollectionFaceSelectionInvertDataflowNode A, FCollectionFaceSelectionInvertDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCollectionFaceSelectionInvertDataflowNode A, FCollectionFaceSelectionInvertDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCollectionFaceSelectionInvertDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FDataflowFaceSelection FaceSelection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FaceSelection, __ReturnBuffer);

					return *(FDataflowFaceSelection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FaceSelection, __InBuffer);
				}
			}
		}

		private static uint __FaceSelection = 0;

	}
}