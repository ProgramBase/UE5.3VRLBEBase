using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.DegreesToRadiansDataflowNode")]
	public partial class FDegreesToRadiansDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.DegreesToRadiansDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDegreesToRadiansDataflowNode()
		{
		}

		public static bool operator ==(FDegreesToRadiansDataflowNode A, FDegreesToRadiansDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDegreesToRadiansDataflowNode A, FDegreesToRadiansDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDegreesToRadiansDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

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

		private static uint __Degrees = 0;

		private static uint __Radians = 0;

	}
}