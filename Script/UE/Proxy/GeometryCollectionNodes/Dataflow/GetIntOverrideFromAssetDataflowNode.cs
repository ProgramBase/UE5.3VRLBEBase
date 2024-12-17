using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.GetIntOverrideFromAssetDataflowNode")]
	public partial class FGetIntOverrideFromAssetDataflowNode : FDataflowOverrideNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.GetIntOverrideFromAssetDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGetIntOverrideFromAssetDataflowNode()
		{
		}

		public static bool operator ==(FGetIntOverrideFromAssetDataflowNode A, FGetIntOverrideFromAssetDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGetIntOverrideFromAssetDataflowNode A, FGetIntOverrideFromAssetDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGetIntOverrideFromAssetDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int Int
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Int, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Int, __InBuffer);
				}
			}
		}

		public int IntDefault
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __IntDefault, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __IntDefault, __InBuffer);
				}
			}
		}

		private static uint __Int = 0;

		private static uint __IntDefault = 0;

	}
}