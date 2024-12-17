using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryCollectionTracks
{
	[PathName("/Script/GeometryCollectionTracks.MovieSceneGeometryCollectionParams")]
	public partial class FMovieSceneGeometryCollectionParams : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionTracks.MovieSceneGeometryCollectionParams");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneGeometryCollectionParams() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneGeometryCollectionParams() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneGeometryCollectionParams A, FMovieSceneGeometryCollectionParams B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneGeometryCollectionParams A, FMovieSceneGeometryCollectionParams B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneGeometryCollectionParams;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FSoftObjectPath GeometryCollectionCache
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __GeometryCollectionCache, __ReturnBuffer);

					return *(FSoftObjectPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __GeometryCollectionCache, __InBuffer);
				}
			}
		}

		public FFrameNumber StartFrameOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StartFrameOffset, __ReturnBuffer);

					return *(FFrameNumber*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StartFrameOffset, __InBuffer);
				}
			}
		}

		public FFrameNumber EndFrameOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EndFrameOffset, __ReturnBuffer);

					return *(FFrameNumber*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EndFrameOffset, __InBuffer);
				}
			}
		}

		public float PlayRate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PlayRate, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PlayRate, __InBuffer);
				}
			}
		}

		private static uint __GeometryCollectionCache = 0;

		private static uint __StartFrameOffset = 0;

		private static uint __EndFrameOffset = 0;

		private static uint __PlayRate = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}