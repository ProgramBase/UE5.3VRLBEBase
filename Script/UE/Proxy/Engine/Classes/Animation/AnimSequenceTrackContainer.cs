using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimSequenceTrackContainer")]
	public partial class FAnimSequenceTrackContainer : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimSequenceTrackContainer");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimSequenceTrackContainer() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAnimSequenceTrackContainer() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAnimSequenceTrackContainer A, FAnimSequenceTrackContainer B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimSequenceTrackContainer A, FAnimSequenceTrackContainer B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimSequenceTrackContainer;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FRawAnimSequenceTrack> AnimationTracks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AnimationTracks, __ReturnBuffer);

					return *(TArray<FRawAnimSequenceTrack>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AnimationTracks, __InBuffer);
				}
			}
		}

		public TArray<FName> TrackNames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TrackNames, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TrackNames, __InBuffer);
				}
			}
		}

		private static uint __AnimationTracks = 0;

		private static uint __TrackNames = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}