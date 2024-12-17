using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.BoolArrayToFaceSelectionDataflowNode")]
	public partial class FBoolArrayToFaceSelectionDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.BoolArrayToFaceSelectionDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBoolArrayToFaceSelectionDataflowNode()
		{
		}

		public static bool operator ==(FBoolArrayToFaceSelectionDataflowNode A, FBoolArrayToFaceSelectionDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBoolArrayToFaceSelectionDataflowNode A, FBoolArrayToFaceSelectionDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBoolArrayToFaceSelectionDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<bool> BoolAttributeData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoolAttributeData, __ReturnBuffer);

					return *(TArray<bool>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoolAttributeData, __InBuffer);
				}
			}
		}

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

		private static uint __BoolAttributeData = 0;

		private static uint __FaceSelection = 0;

	}
}