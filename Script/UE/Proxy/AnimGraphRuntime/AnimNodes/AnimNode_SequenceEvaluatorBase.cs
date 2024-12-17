using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.AnimNode_SequenceEvaluatorBase")]
	public partial class FAnimNode_SequenceEvaluatorBase : FAnimNode_AssetPlayerBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.AnimNode_SequenceEvaluatorBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_SequenceEvaluatorBase()
		{
		}

		public static bool operator ==(FAnimNode_SequenceEvaluatorBase A, FAnimNode_SequenceEvaluatorBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_SequenceEvaluatorBase A, FAnimNode_SequenceEvaluatorBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_SequenceEvaluatorBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}