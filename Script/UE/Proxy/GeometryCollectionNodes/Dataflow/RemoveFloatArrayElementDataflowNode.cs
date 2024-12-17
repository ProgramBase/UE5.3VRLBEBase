using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.RemoveFloatArrayElementDataflowNode")]
	public partial class FRemoveFloatArrayElementDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.RemoveFloatArrayElementDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRemoveFloatArrayElementDataflowNode()
		{
		}

		public static bool operator ==(FRemoveFloatArrayElementDataflowNode A, FRemoveFloatArrayElementDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRemoveFloatArrayElementDataflowNode A, FRemoveFloatArrayElementDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRemoveFloatArrayElementDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int Index
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Index, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Index, __InBuffer);
				}
			}
		}

		public bool bPreserveOrder
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bPreserveOrder, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bPreserveOrder, __InBuffer);
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

		private static uint __Index = 0;

		private static uint __bPreserveOrder = 0;

		private static uint __FloatArray = 0;

	}
}