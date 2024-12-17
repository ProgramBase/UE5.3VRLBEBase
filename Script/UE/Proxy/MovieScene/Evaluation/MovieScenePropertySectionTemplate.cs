using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieScenePropertySectionTemplate")]
	public partial class FMovieScenePropertySectionTemplate : FMovieSceneEvalTemplate, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieScenePropertySectionTemplate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieScenePropertySectionTemplate()
		{
		}

		public static bool operator ==(FMovieScenePropertySectionTemplate A, FMovieScenePropertySectionTemplate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieScenePropertySectionTemplate A, FMovieScenePropertySectionTemplate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieScenePropertySectionTemplate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMovieScenePropertySectionData PropertyData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PropertyData, __ReturnBuffer);

					return *(FMovieScenePropertySectionData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PropertyData, __InBuffer);
				}
			}
		}

		private static uint __PropertyData = 0;

	}
}