using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.BlendListBaseReference")]
	public partial class FBlendListBaseReference : FAnimNodeReference, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.BlendListBaseReference");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBlendListBaseReference()
		{
		}

		public static bool operator ==(FBlendListBaseReference A, FBlendListBaseReference B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBlendListBaseReference A, FBlendListBaseReference B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBlendListBaseReference;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}