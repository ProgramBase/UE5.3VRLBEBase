using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimationPotentialTransition")]
	public partial class FAnimationPotentialTransition : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimationPotentialTransition");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimationPotentialTransition() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAnimationPotentialTransition() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAnimationPotentialTransition A, FAnimationPotentialTransition B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimationPotentialTransition A, FAnimationPotentialTransition B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimationPotentialTransition;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}