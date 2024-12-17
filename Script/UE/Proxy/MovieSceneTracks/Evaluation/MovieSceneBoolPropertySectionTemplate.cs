using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneBoolPropertySectionTemplate")]
	public partial class FMovieSceneBoolPropertySectionTemplate : FMovieScenePropertySectionTemplate, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieSceneTracks.MovieSceneBoolPropertySectionTemplate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneBoolPropertySectionTemplate()
		{
		}

		public static bool operator ==(FMovieSceneBoolPropertySectionTemplate A, FMovieSceneBoolPropertySectionTemplate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneBoolPropertySectionTemplate A, FMovieSceneBoolPropertySectionTemplate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneBoolPropertySectionTemplate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMovieSceneBoolChannel BoolCurve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoolCurve, __ReturnBuffer);

					return *(FMovieSceneBoolChannel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoolCurve, __InBuffer);
				}
			}
		}

		private static uint __BoolCurve = 0;

	}
}