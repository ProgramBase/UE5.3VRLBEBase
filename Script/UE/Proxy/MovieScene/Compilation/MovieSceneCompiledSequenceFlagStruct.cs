using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneCompiledSequenceFlagStruct")]
	public partial class FMovieSceneCompiledSequenceFlagStruct : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneCompiledSequenceFlagStruct");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneCompiledSequenceFlagStruct() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneCompiledSequenceFlagStruct() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneCompiledSequenceFlagStruct A, FMovieSceneCompiledSequenceFlagStruct B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneCompiledSequenceFlagStruct A, FMovieSceneCompiledSequenceFlagStruct B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneCompiledSequenceFlagStruct;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bParentSequenceRequiresLowerFence
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bParentSequenceRequiresLowerFence, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bParentSequenceRequiresLowerFence, __InBuffer);
				}
			}
		}

		public bool bParentSequenceRequiresUpperFence
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bParentSequenceRequiresUpperFence, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bParentSequenceRequiresUpperFence, __InBuffer);
				}
			}
		}

		private static uint __bParentSequenceRequiresLowerFence = 0;

		private static uint __bParentSequenceRequiresUpperFence = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}