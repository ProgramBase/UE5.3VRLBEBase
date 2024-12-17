using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneBinding")]
	public partial class FMovieSceneBinding : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneBinding");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneBinding() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneBinding() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneBinding A, FMovieSceneBinding B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneBinding A, FMovieSceneBinding B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneBinding;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FGuid ObjectGuid
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ObjectGuid, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ObjectGuid, __InBuffer);
				}
			}
		}

		public FString BindingName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BindingName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BindingName, __InBuffer);
				}
			}
		}

		public TArray<UMovieSceneTrack> Tracks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Tracks, __ReturnBuffer);

					return *(TArray<UMovieSceneTrack>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Tracks, __InBuffer);
				}
			}
		}

		public int SortingOrder
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SortingOrder, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SortingOrder, __InBuffer);
				}
			}
		}

		private static uint __ObjectGuid = 0;

		private static uint __BindingName = 0;

		private static uint __Tracks = 0;

		private static uint __SortingOrder = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}