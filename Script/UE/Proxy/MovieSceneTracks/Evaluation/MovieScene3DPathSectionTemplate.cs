using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieScene3DPathSectionTemplate")]
	public partial class FMovieScene3DPathSectionTemplate : FMovieSceneEvalTemplate, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieSceneTracks.MovieScene3DPathSectionTemplate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieScene3DPathSectionTemplate()
		{
		}

		public static bool operator ==(FMovieScene3DPathSectionTemplate A, FMovieScene3DPathSectionTemplate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieScene3DPathSectionTemplate A, FMovieScene3DPathSectionTemplate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieScene3DPathSectionTemplate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMovieSceneObjectBindingID PathBindingID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PathBindingID, __ReturnBuffer);

					return *(FMovieSceneObjectBindingID*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PathBindingID, __InBuffer);
				}
			}
		}

		public FMovieSceneFloatChannel TimingCurve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TimingCurve, __ReturnBuffer);

					return *(FMovieSceneFloatChannel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TimingCurve, __InBuffer);
				}
			}
		}

		public MovieScene3DPathSection_Axis FrontAxisEnum
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FrontAxisEnum, __ReturnBuffer);

					return *(MovieScene3DPathSection_Axis*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FrontAxisEnum, __InBuffer);
				}
			}
		}

		public MovieScene3DPathSection_Axis UpAxisEnum
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UpAxisEnum, __ReturnBuffer);

					return *(MovieScene3DPathSection_Axis*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UpAxisEnum, __InBuffer);
				}
			}
		}

		public bool bFollow
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bFollow, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bFollow, __InBuffer);
				}
			}
		}

		public bool bReverse
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bReverse, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bReverse, __InBuffer);
				}
			}
		}

		public bool bForceUpright
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bForceUpright, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bForceUpright, __InBuffer);
				}
			}
		}

		private static uint __PathBindingID = 0;

		private static uint __TimingCurve = 0;

		private static uint __FrontAxisEnum = 0;

		private static uint __UpAxisEnum = 0;

		private static uint __bFollow = 0;

		private static uint __bReverse = 0;

		private static uint __bForceUpright = 0;

	}
}