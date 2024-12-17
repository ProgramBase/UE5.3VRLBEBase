using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneCVarOverrides")]
	public partial class FMovieSceneCVarOverrides : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieSceneTracks.MovieSceneCVarOverrides");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneCVarOverrides() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneCVarOverrides() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneCVarOverrides A, FMovieSceneCVarOverrides B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneCVarOverrides A, FMovieSceneCVarOverrides B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneCVarOverrides;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TMap<FString, FString> ValuesByCVar
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ValuesByCVar, __ReturnBuffer);

					return *(TMap<FString, FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ValuesByCVar, __InBuffer);
				}
			}
		}

		private static uint __ValuesByCVar = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}