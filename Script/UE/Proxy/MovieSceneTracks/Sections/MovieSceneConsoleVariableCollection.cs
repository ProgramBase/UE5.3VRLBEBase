using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneConsoleVariableCollection")]
	public partial class FMovieSceneConsoleVariableCollection : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieSceneTracks.MovieSceneConsoleVariableCollection");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneConsoleVariableCollection() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneConsoleVariableCollection() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneConsoleVariableCollection A, FMovieSceneConsoleVariableCollection B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneConsoleVariableCollection A, FMovieSceneConsoleVariableCollection B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneConsoleVariableCollection;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TScriptInterface<IMovieSceneConsoleVariableTrackInterface> Interface
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Interface, __ReturnBuffer);

					return *(TScriptInterface<IMovieSceneConsoleVariableTrackInterface>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Interface, __InBuffer);
				}
			}
		}

		public bool bOnlyIncludeChecked
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bOnlyIncludeChecked, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bOnlyIncludeChecked, __InBuffer);
				}
			}
		}

		private static uint __Interface = 0;

		private static uint __bOnlyIncludeChecked = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}