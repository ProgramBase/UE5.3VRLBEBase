using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneObjectBindingIDs")]
	public partial class FMovieSceneObjectBindingIDs : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneObjectBindingIDs");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneObjectBindingIDs() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneObjectBindingIDs() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneObjectBindingIDs A, FMovieSceneObjectBindingIDs B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneObjectBindingIDs A, FMovieSceneObjectBindingIDs B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneObjectBindingIDs;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FMovieSceneObjectBindingID> IDs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __IDs, __ReturnBuffer);

					return *(TArray<FMovieSceneObjectBindingID>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __IDs, __InBuffer);
				}
			}
		}

		private static uint __IDs = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}