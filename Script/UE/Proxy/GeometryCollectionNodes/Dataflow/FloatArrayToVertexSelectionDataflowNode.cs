using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.FloatArrayToVertexSelectionDataflowNode")]
	public partial class FFloatArrayToVertexSelectionDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.FloatArrayToVertexSelectionDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFloatArrayToVertexSelectionDataflowNode()
		{
		}

		public static bool operator ==(FFloatArrayToVertexSelectionDataflowNode A, FFloatArrayToVertexSelectionDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFloatArrayToVertexSelectionDataflowNode A, FFloatArrayToVertexSelectionDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFloatArrayToVertexSelectionDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<float> FloatArray
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FloatArray, __ReturnBuffer);

					return *(TArray<float>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FloatArray, __InBuffer);
				}
			}
		}

		public ECompareOperation1Enum Operation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Operation, __ReturnBuffer);

					return *(ECompareOperation1Enum*)__ReturnBuffer;
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

		public float Threshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Threshold, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Threshold, __InBuffer);
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

		private static uint __FloatArray = 0;

		private static uint __Operation = 0;

		private static uint __Threshold = 0;

		private static uint __VertexSelection = 0;

	}
}