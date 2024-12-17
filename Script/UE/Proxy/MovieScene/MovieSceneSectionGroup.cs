using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneSectionGroup")]
	public partial class FMovieSceneSectionGroup : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneSectionGroup");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneSectionGroup() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneSectionGroup() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneSectionGroup A, FMovieSceneSectionGroup B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneSectionGroup A, FMovieSceneSectionGroup B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneSectionGroup;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<TWeakObjectPtr<UMovieSceneSection>> Sections
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Sections, __ReturnBuffer);

					return *(TArray<TWeakObjectPtr<UMovieSceneSection>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Sections, __InBuffer);
				}
			}
		}

		private static uint __Sections = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}