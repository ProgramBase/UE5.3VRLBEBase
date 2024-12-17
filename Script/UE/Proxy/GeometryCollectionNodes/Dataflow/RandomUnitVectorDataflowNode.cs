using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.RandomUnitVectorDataflowNode")]
	public partial class FRandomUnitVectorDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.RandomUnitVectorDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRandomUnitVectorDataflowNode()
		{
		}

		public static bool operator ==(FRandomUnitVectorDataflowNode A, FRandomUnitVectorDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRandomUnitVectorDataflowNode A, FRandomUnitVectorDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRandomUnitVectorDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bDeterministic
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bDeterministic, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bDeterministic, __InBuffer);
				}
			}
		}

		public float RandomSeed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RandomSeed, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RandomSeed, __InBuffer);
				}
			}
		}

		public FVector ReturnValue
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ReturnValue, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ReturnValue, __InBuffer);
				}
			}
		}

		private static uint __bDeterministic = 0;

		private static uint __RandomSeed = 0;

		private static uint __ReturnValue = 0;

	}
}