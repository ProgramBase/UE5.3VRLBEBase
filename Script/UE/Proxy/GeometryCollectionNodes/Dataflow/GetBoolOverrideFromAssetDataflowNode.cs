using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.GetBoolOverrideFromAssetDataflowNode")]
	public partial class FGetBoolOverrideFromAssetDataflowNode : FDataflowOverrideNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.GetBoolOverrideFromAssetDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGetBoolOverrideFromAssetDataflowNode()
		{
		}

		public static bool operator ==(FGetBoolOverrideFromAssetDataflowNode A, FGetBoolOverrideFromAssetDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGetBoolOverrideFromAssetDataflowNode A, FGetBoolOverrideFromAssetDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGetBoolOverrideFromAssetDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool Bool
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Bool, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Bool, __InBuffer);
				}
			}
		}

		public bool BoolDefault
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoolDefault, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoolDefault, __InBuffer);
				}
			}
		}

		private static uint __Bool = 0;

		private static uint __BoolDefault = 0;

	}
}