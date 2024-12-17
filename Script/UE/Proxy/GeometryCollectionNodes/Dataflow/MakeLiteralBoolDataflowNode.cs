using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.MakeLiteralBoolDataflowNode")]
	public partial class FMakeLiteralBoolDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.MakeLiteralBoolDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMakeLiteralBoolDataflowNode()
		{
		}

		public static bool operator ==(FMakeLiteralBoolDataflowNode A, FMakeLiteralBoolDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMakeLiteralBoolDataflowNode A, FMakeLiteralBoolDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMakeLiteralBoolDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Value, __InBuffer);
				}
			}
		}

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

		private static uint __Value = 0;

		private static uint __Bool = 0;

	}
}