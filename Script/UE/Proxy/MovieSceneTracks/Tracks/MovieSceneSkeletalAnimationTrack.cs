using Script.CoreUObject;
using Script.MovieScene;
using Script.AnimGraphRuntime;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationTrack")]
	public partial class UMovieSceneSkeletalAnimationTrack : UMovieSceneNameableTrack, IStaticClass
	{
		public TArray<UMovieSceneSection> AnimationSections
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AnimationSections, __ReturnBuffer);

					return *(TArray<UMovieSceneSection>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AnimationSections, __InBuffer);
				}
			}
		}

		public bool bUseLegacySectionIndexBlend
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseLegacySectionIndexBlend, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseLegacySectionIndexBlend, __InBuffer);
				}
			}
		}

		public FMovieSceneSkeletalAnimRootMotionTrackParams RootMotionParams
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RootMotionParams, __ReturnBuffer);

					return *(FMovieSceneSkeletalAnimRootMotionTrackParams*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RootMotionParams, __InBuffer);
				}
			}
		}

		public bool bBlendFirstChildOfRoot
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bBlendFirstChildOfRoot, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bBlendFirstChildOfRoot, __InBuffer);
				}
			}
		}

		public ESwapRootBone SwapRootBone
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SwapRootBone, __ReturnBuffer);

					return *(ESwapRootBone*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SwapRootBone, __InBuffer);
				}
			}
		}

		public bool bShowRootMotionTrail
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShowRootMotionTrail, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShowRootMotionTrail, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationTrack");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetSwapRootBone(ESwapRootBone InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSwapRootBone, __InBuffer);
			}
		}

		public virtual ESwapRootBone GetSwapRootBone()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetSwapRootBone, __ReturnBuffer);

				return *(ESwapRootBone*)__ReturnBuffer;
			}
		}

		private static uint __AnimationSections = 0;

		private static uint __bUseLegacySectionIndexBlend = 0;

		private static uint __RootMotionParams = 0;

		private static uint __bBlendFirstChildOfRoot = 0;

		private static uint __SwapRootBone = 0;

		private static uint __bShowRootMotionTrail = 0;

		private static uint __SetSwapRootBone = 0;

		private static uint __GetSwapRootBone = 0;
	}
}