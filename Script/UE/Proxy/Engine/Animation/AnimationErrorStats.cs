using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimationErrorStats")]
	public partial class FAnimationErrorStats : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimationErrorStats");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimationErrorStats() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAnimationErrorStats() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAnimationErrorStats A, FAnimationErrorStats B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimationErrorStats A, FAnimationErrorStats B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimationErrorStats;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}