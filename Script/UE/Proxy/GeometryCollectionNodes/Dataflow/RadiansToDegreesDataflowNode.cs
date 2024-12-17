using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.RadiansToDegreesDataflowNode")]
	public partial class FRadiansToDegreesDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.RadiansToDegreesDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRadiansToDegreesDataflowNode()
		{
		}

		public static bool operator ==(FRadiansToDegreesDataflowNode A, FRadiansToDegreesDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRadiansToDegreesDataflowNode A, FRadiansToDegreesDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRadiansToDegreesDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float Radians
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Radians, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Radians, __InBuffer);
				}
			}
		}

		public float Degrees
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Degrees, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Degrees, __InBuffer);
				}
			}
		}

		private static uint __Radians = 0;

		private static uint __Degrees = 0;

	}
}