﻿using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneVector3dKeyStruct")]
	public partial class FMovieSceneVector3dKeyStruct : FMovieSceneDoubleVectorKeyStructBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieSceneTracks.MovieSceneVector3dKeyStruct");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneVector3dKeyStruct()
		{
		}

		public static bool operator ==(FMovieSceneVector3dKeyStruct A, FMovieSceneVector3dKeyStruct B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneVector3dKeyStruct A, FMovieSceneVector3dKeyStruct B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneVector3dKeyStruct;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FVector3d Vector
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Vector, __ReturnBuffer);

					return *(FVector3d*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Vector, __InBuffer);
				}
			}
		}

		private static uint __Vector = 0;

	}
}