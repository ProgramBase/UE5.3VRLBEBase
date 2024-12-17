using Script.CoreUObject;
using Script.MovieScene;
using Script.MovieSceneTracks;
using Script.Library;

namespace Script.TakeMovieScene
{
	[PathName("/Script/TakeMovieScene.MovieSceneTakeSection")]
	public partial class UMovieSceneTakeSection : UMovieSceneSection, IStaticClass
	{
		public FMovieSceneIntegerChannel HoursCurve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HoursCurve, __ReturnBuffer);

					return *(FMovieSceneIntegerChannel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HoursCurve, __InBuffer);
				}
			}
		}

		public FMovieSceneIntegerChannel MinutesCurve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MinutesCurve, __ReturnBuffer);

					return *(FMovieSceneIntegerChannel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MinutesCurve, __InBuffer);
				}
			}
		}

		public FMovieSceneIntegerChannel SecondsCurve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SecondsCurve, __ReturnBuffer);

					return *(FMovieSceneIntegerChannel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SecondsCurve, __InBuffer);
				}
			}
		}

		public FMovieSceneIntegerChannel FramesCurve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FramesCurve, __ReturnBuffer);

					return *(FMovieSceneIntegerChannel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FramesCurve, __InBuffer);
				}
			}
		}

		public FMovieSceneFloatChannel SubFramesCurve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SubFramesCurve, __ReturnBuffer);

					return *(FMovieSceneFloatChannel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SubFramesCurve, __InBuffer);
				}
			}
		}

		public FMovieSceneStringChannel Slate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Slate, __ReturnBuffer);

					return *(FMovieSceneStringChannel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Slate, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TakeMovieScene.MovieSceneTakeSection");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __HoursCurve = 0;

		private static uint __MinutesCurve = 0;

		private static uint __SecondsCurve = 0;

		private static uint __FramesCurve = 0;

		private static uint __SubFramesCurve = 0;

		private static uint __Slate = 0;
	}
}