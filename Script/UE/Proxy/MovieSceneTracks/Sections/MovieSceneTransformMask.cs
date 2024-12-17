using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneTransformMask")]
	public partial class FMovieSceneTransformMask : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieSceneTracks.MovieSceneTransformMask");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneTransformMask() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneTransformMask() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneTransformMask A, FMovieSceneTransformMask B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneTransformMask A, FMovieSceneTransformMask B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneTransformMask;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public uint Mask
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Mask, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Mask, __InBuffer);
				}
			}
		}

		private static uint __Mask = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}