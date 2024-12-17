using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneExpansionState")]
	public partial class FMovieSceneExpansionState : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneExpansionState");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneExpansionState() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneExpansionState() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneExpansionState A, FMovieSceneExpansionState B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneExpansionState A, FMovieSceneExpansionState B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneExpansionState;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bExpanded
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bExpanded, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bExpanded, __InBuffer);
				}
			}
		}

		private static uint __bExpanded = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}