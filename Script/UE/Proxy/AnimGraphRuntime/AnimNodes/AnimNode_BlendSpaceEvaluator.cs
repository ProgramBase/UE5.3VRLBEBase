using Script.CoreUObject;
using Script.Library;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.AnimNode_BlendSpaceEvaluator")]
	public partial class FAnimNode_BlendSpaceEvaluator : FAnimNode_BlendSpacePlayer, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.AnimNode_BlendSpaceEvaluator");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_BlendSpaceEvaluator()
		{
		}

		public static bool operator ==(FAnimNode_BlendSpaceEvaluator A, FAnimNode_BlendSpaceEvaluator B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_BlendSpaceEvaluator A, FAnimNode_BlendSpaceEvaluator B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_BlendSpaceEvaluator;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float NormalizedTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NormalizedTime, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NormalizedTime, __InBuffer);
				}
			}
		}

		public bool bTeleportToNormalizedTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bTeleportToNormalizedTime, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bTeleportToNormalizedTime, __InBuffer);
				}
			}
		}

		private static uint __NormalizedTime = 0;

		private static uint __bTeleportToNormalizedTime = 0;

	}
}