using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.AnimationStateResultReference")]
	public partial class FAnimationStateResultReference : FAnimNodeReference, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.AnimationStateResultReference");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimationStateResultReference()
		{
		}

		public static bool operator ==(FAnimationStateResultReference A, FAnimationStateResultReference B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimationStateResultReference A, FAnimationStateResultReference B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimationStateResultReference;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}