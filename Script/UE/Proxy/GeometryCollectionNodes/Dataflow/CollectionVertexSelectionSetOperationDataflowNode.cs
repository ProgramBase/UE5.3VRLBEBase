using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.CollectionVertexSelectionSetOperationDataflowNode")]
	public partial class FCollectionVertexSelectionSetOperationDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.CollectionVertexSelectionSetOperationDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCollectionVertexSelectionSetOperationDataflowNode()
		{
		}

		public static bool operator ==(FCollectionVertexSelectionSetOperationDataflowNode A, FCollectionVertexSelectionSetOperationDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCollectionVertexSelectionSetOperationDataflowNode A, FCollectionVertexSelectionSetOperationDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCollectionVertexSelectionSetOperationDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ESetOperationEnum Operation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Operation, __ReturnBuffer);

					return *(ESetOperationEnum*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Operation, __InBuffer);
				}
			}
		}

		public FDataflowVertexSelection VertexSelectionA
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __VertexSelectionA, __ReturnBuffer);

					return *(FDataflowVertexSelection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __VertexSelectionA, __InBuffer);
				}
			}
		}

		public FDataflowVertexSelection VertexSelectionB
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __VertexSelectionB, __ReturnBuffer);

					return *(FDataflowVertexSelection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __VertexSelectionB, __InBuffer);
				}
			}
		}

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

		private static uint __Operation = 0;

		private static uint __VertexSelectionA = 0;

		private static uint __VertexSelectionB = 0;

		private static uint __VertexSelection = 0;

	}
}