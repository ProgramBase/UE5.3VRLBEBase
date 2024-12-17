using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.SequenceEvaluatorReference")]
	public partial class FSequenceEvaluatorReference : FAnimNodeReference, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.SequenceEvaluatorReference");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSequenceEvaluatorReference()
		{
		}

		public static bool operator ==(FSequenceEvaluatorReference A, FSequenceEvaluatorReference B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSequenceEvaluatorReference A, FSequenceEvaluatorReference B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSequenceEvaluatorReference;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}