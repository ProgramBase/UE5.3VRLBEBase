using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.SelectionToVertexListDataflowNode")]
	public partial class FSelectionToVertexListDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.SelectionToVertexListDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSelectionToVertexListDataflowNode()
		{
		}

		public static bool operator ==(FSelectionToVertexListDataflowNode A, FSelectionToVertexListDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSelectionToVertexListDataflowNode A, FSelectionToVertexListDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSelectionToVertexListDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FDataflowVertexSelection VertexSelection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __VertexSelection, __ReturnBuffer);

					return *(FDataflowVertexSelection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __VertexSelection, __InBuffer);
				}
			}
		}

		public TArray<int> VertexList
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __VertexList, __ReturnBuffer);

					return *(TArray<int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __VertexList, __InBuffer);
				}
			}
		}

		private static uint __VertexSelection = 0;

		private static uint __VertexList = 0;

	}
}