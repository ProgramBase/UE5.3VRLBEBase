using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.AnimationStateMachineReference")]
	public partial class FAnimationStateMachineReference : FAnimNodeReference, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.AnimationStateMachineReference");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimationStateMachineReference()
		{
		}

		public static bool operator ==(FAnimationStateMachineReference A, FAnimationStateMachineReference B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimationStateMachineReference A, FAnimationStateMachineReference B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimationStateMachineReference;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}