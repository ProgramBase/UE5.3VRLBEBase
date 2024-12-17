using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneSegmentIdentifier")]
	public partial class FMovieSceneSegmentIdentifier : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneSegmentIdentifier");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneSegmentIdentifier() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneSegmentIdentifier() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneSegmentIdentifier A, FMovieSceneSegmentIdentifier B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneSegmentIdentifier A, FMovieSceneSegmentIdentifier B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneSegmentIdentifier;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int IdentifierIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __IdentifierIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __IdentifierIndex, __InBuffer);
				}
			}
		}

		private static uint __IdentifierIndex = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}