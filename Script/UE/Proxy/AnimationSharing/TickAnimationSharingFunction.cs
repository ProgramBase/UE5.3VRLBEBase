using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimationSharing
{
	[PathName("/Script/AnimationSharing.TickAnimationSharingFunction")]
	public partial class FTickAnimationSharingFunction : FTickFunction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimationSharing.TickAnimationSharingFunction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTickAnimationSharingFunction()
		{
		}

		public static bool operator ==(FTickAnimationSharingFunction A, FTickAnimationSharingFunction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTickAnimationSharingFunction A, FTickAnimationSharingFunction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTickAnimationSharingFunction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}