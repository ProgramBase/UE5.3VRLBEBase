using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.FloatArrayToIntArrayDataflowNode")]
	public partial class FFloatArrayToIntArrayDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.FloatArrayToIntArrayDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFloatArrayToIntArrayDataflowNode()
		{
		}

		public static bool operator ==(FFloatArrayToIntArrayDataflowNode A, FFloatArrayToIntArrayDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFloatArrayToIntArrayDataflowNode A, FFloatArrayToIntArrayDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFloatArrayToIntArrayDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public EFloatArrayToIntArrayFunctionEnum Function
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Function, __ReturnBuffer);

					return *(EFloatArrayToIntArrayFunctionEnum*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Function, __InBuffer);
				}
			}
		}

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

		public TArray<int> IntArray
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __IntArray, __ReturnBuffer);

					return *(TArray<int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __IntArray, __InBuffer);
				}
			}
		}

		private static uint __Function = 0;

		private static uint __FloatArray = 0;

		private static uint __IntArray = 0;

	}
}