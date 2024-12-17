using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.AnimNode_BlendSpacePlayerBase")]
	public partial class FAnimNode_BlendSpacePlayerBase : FAnimNode_AssetPlayerBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.AnimNode_BlendSpacePlayerBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_BlendSpacePlayerBase()
		{
		}

		public static bool operator ==(FAnimNode_BlendSpacePlayerBase A, FAnimNode_BlendSpacePlayerBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_BlendSpacePlayerBase A, FAnimNode_BlendSpacePlayerBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_BlendSpacePlayerBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UBlendSpace PreviousBlendSpace
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PreviousBlendSpace, __ReturnBuffer);

					return *(UBlendSpace*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PreviousBlendSpace, __InBuffer);
				}
			}
		}

		private static uint __PreviousBlendSpace = 0;

	}
}