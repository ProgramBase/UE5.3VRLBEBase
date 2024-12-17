using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimationFrameSnapshot")]
	public partial class FAnimationFrameSnapshot : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimationFrameSnapshot");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimationFrameSnapshot() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAnimationFrameSnapshot() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAnimationFrameSnapshot A, FAnimationFrameSnapshot B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimationFrameSnapshot A, FAnimationFrameSnapshot B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimationFrameSnapshot;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}