using Script.CoreUObject;
using Script.Library;
using Script.TakeTrackRecorders;

namespace Script.CacheTrackRecorder
{
	[PathName("/Script/CacheTrackRecorder.CachedTrackSource")]
	public partial class FCachedTrackSource : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CacheTrackRecorder.CachedTrackSource");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCachedTrackSource() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCachedTrackSource() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCachedTrackSource A, FCachedTrackSource B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCachedTrackSource A, FCachedTrackSource B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCachedTrackSource;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UMovieSceneTrackRecorder Recorder
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Recorder, __ReturnBuffer);

					return *(UMovieSceneTrackRecorder*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Recorder, __InBuffer);
				}
			}
		}

		private static uint __Recorder = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}