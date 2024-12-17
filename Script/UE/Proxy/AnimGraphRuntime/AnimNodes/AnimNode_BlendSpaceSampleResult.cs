using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.AnimNode_BlendSpaceSampleResult")]
	public partial class FAnimNode_BlendSpaceSampleResult : FAnimNode_Root, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.AnimNode_BlendSpaceSampleResult");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_BlendSpaceSampleResult()
		{
		}

		public static bool operator ==(FAnimNode_BlendSpaceSampleResult A, FAnimNode_BlendSpaceSampleResult B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_BlendSpaceSampleResult A, FAnimNode_BlendSpaceSampleResult B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_BlendSpaceSampleResult;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}