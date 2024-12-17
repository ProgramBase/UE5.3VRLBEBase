using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;

namespace Script.DataflowNodes
{
	[PathName("/Script/DataflowNodes.SelectionSetDataflowNode")]
	public partial class FSelectionSetDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/DataflowNodes.SelectionSetDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSelectionSetDataflowNode()
		{
		}

		public static bool operator ==(FSelectionSetDataflowNode A, FSelectionSetDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSelectionSetDataflowNode A, FSelectionSetDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSelectionSetDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString Indices
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Indices, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Indices, __InBuffer);
				}
			}
		}

		public TArray<int> IndicesOut
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __IndicesOut, __ReturnBuffer);

					return *(TArray<int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __IndicesOut, __InBuffer);
				}
			}
		}

		private static uint __Indices = 0;

		private static uint __IndicesOut = 0;

	}
}