using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimationTrackAddedPayload")]
	public partial class FAnimationTrackAddedPayload : FAnimationTrackPayload, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimationTrackAddedPayload");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimationTrackAddedPayload()
		{
		}

		public static bool operator ==(FAnimationTrackAddedPayload A, FAnimationTrackAddedPayload B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimationTrackAddedPayload A, FAnimationTrackAddedPayload B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimationTrackAddedPayload;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int TrackIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TrackIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TrackIndex, __InBuffer);
				}
			}
		}

		private static uint __TrackIndex = 0;

	}
}