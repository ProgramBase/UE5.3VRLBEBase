using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;
using Script.MediaAssets;

namespace Script.MediaCompositing
{
	[PathName("/Script/MediaCompositing.MovieSceneMediaPlayerPropertySectionTemplate")]
	public partial class FMovieSceneMediaPlayerPropertySectionTemplate : FMovieScenePropertySectionTemplate, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MediaCompositing.MovieSceneMediaPlayerPropertySectionTemplate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneMediaPlayerPropertySectionTemplate()
		{
		}

		public static bool operator ==(FMovieSceneMediaPlayerPropertySectionTemplate A, FMovieSceneMediaPlayerPropertySectionTemplate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneMediaPlayerPropertySectionTemplate A, FMovieSceneMediaPlayerPropertySectionTemplate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneMediaPlayerPropertySectionTemplate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UMediaSource MediaSource
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MediaSource, __ReturnBuffer);

					return *(UMediaSource*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MediaSource, __InBuffer);
				}
			}
		}

		public FFrameNumber SectionStartFrame
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SectionStartFrame, __ReturnBuffer);

					return *(FFrameNumber*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SectionStartFrame, __InBuffer);
				}
			}
		}

		public bool bLoop
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bLoop, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bLoop, __InBuffer);
				}
			}
		}

		private static uint __MediaSource = 0;

		private static uint __SectionStartFrame = 0;

		private static uint __bLoop = 0;

	}
}