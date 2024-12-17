using Script.CoreUObject;
using Script.Library;
using Script.MediaAssets;
using Script.MovieScene;

namespace Script.MediaCompositing
{
	[PathName("/Script/MediaCompositing.MovieSceneMediaSectionParams")]
	public partial class FMovieSceneMediaSectionParams : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MediaCompositing.MovieSceneMediaSectionParams");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneMediaSectionParams() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneMediaSectionParams() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneMediaSectionParams A, FMovieSceneMediaSectionParams B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneMediaSectionParams A, FMovieSceneMediaSectionParams B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneMediaSectionParams;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UMediaSoundComponent MediaSoundComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MediaSoundComponent, __ReturnBuffer);

					return *(UMediaSoundComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MediaSoundComponent, __InBuffer);
				}
			}
		}

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

		public FMovieSceneObjectBindingID MediaSourceProxy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MediaSourceProxy, __ReturnBuffer);

					return *(FMovieSceneObjectBindingID*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MediaSourceProxy, __InBuffer);
				}
			}
		}

		public int MediaSourceProxyIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MediaSourceProxyIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MediaSourceProxyIndex, __InBuffer);
				}
			}
		}

		public UMediaTexture MediaTexture
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MediaTexture, __ReturnBuffer);

					return *(UMediaTexture*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MediaTexture, __InBuffer);
				}
			}
		}

		public UMediaPlayer MediaPlayer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MediaPlayer, __ReturnBuffer);

					return *(UMediaPlayer*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MediaPlayer, __InBuffer);
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

		public FFrameNumber SectionEndFrame
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SectionEndFrame, __ReturnBuffer);

					return *(FFrameNumber*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SectionEndFrame, __InBuffer);
				}
			}
		}

		public bool bLooping
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bLooping, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bLooping, __InBuffer);
				}
			}
		}

		public FFrameNumber StartFrameOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StartFrameOffset, __ReturnBuffer);

					return *(FFrameNumber*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StartFrameOffset, __InBuffer);
				}
			}
		}

		public FMovieSceneFloatChannel ProxyTextureBlend
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ProxyTextureBlend, __ReturnBuffer);

					return *(FMovieSceneFloatChannel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ProxyTextureBlend, __InBuffer);
				}
			}
		}

		private static uint __MediaSoundComponent = 0;

		private static uint __MediaSource = 0;

		private static uint __MediaSourceProxy = 0;

		private static uint __MediaSourceProxyIndex = 0;

		private static uint __MediaTexture = 0;

		private static uint __MediaPlayer = 0;

		private static uint __SectionStartFrame = 0;

		private static uint __SectionEndFrame = 0;

		private static uint __bLooping = 0;

		private static uint __StartFrameOffset = 0;

		private static uint __ProxyTextureBlend = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}