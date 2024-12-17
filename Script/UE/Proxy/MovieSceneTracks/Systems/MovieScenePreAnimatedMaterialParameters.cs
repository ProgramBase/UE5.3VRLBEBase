using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieScenePreAnimatedMaterialParameters")]
	public partial class FMovieScenePreAnimatedMaterialParameters : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieSceneTracks.MovieScenePreAnimatedMaterialParameters");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieScenePreAnimatedMaterialParameters() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieScenePreAnimatedMaterialParameters() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieScenePreAnimatedMaterialParameters A, FMovieScenePreAnimatedMaterialParameters B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieScenePreAnimatedMaterialParameters A, FMovieScenePreAnimatedMaterialParameters B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieScenePreAnimatedMaterialParameters;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UMaterialInterface PreviousMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PreviousMaterial, __ReturnBuffer);

					return *(UMaterialInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PreviousMaterial, __InBuffer);
				}
			}
		}

		public TSoftObjectPtr<UMaterialInterface> SoftPreviousMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SoftPreviousMaterial, __ReturnBuffer);

					return *(TSoftObjectPtr<UMaterialInterface>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SoftPreviousMaterial, __InBuffer);
				}
			}
		}

		private static uint __PreviousMaterial = 0;

		private static uint __SoftPreviousMaterial = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}