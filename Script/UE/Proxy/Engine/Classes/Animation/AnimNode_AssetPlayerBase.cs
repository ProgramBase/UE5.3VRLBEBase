using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimNode_AssetPlayerBase")]
	public partial class FAnimNode_AssetPlayerBase : FAnimNode_AssetPlayerRelevancyBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimNode_AssetPlayerBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_AssetPlayerBase()
		{
		}

		public static bool operator ==(FAnimNode_AssetPlayerBase A, FAnimNode_AssetPlayerBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_AssetPlayerBase A, FAnimNode_AssetPlayerBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_AssetPlayerBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float BlendWeight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BlendWeight, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BlendWeight, __InBuffer);
				}
			}
		}

		public float InternalTimeAccumulator
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InternalTimeAccumulator, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InternalTimeAccumulator, __InBuffer);
				}
			}
		}

		private static uint __BlendWeight = 0;

		private static uint __InternalTimeAccumulator = 0;

	}
}