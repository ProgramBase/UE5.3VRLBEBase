using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneCameraShakeSourceTrigger")]
	public partial class FMovieSceneCameraShakeSourceTrigger : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieSceneTracks.MovieSceneCameraShakeSourceTrigger");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneCameraShakeSourceTrigger() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneCameraShakeSourceTrigger() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneCameraShakeSourceTrigger A, FMovieSceneCameraShakeSourceTrigger B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneCameraShakeSourceTrigger A, FMovieSceneCameraShakeSourceTrigger B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneCameraShakeSourceTrigger;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TSubclassOf<UCameraShakeBase> ShakeClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ShakeClass, __ReturnBuffer);

					return *(TSubclassOf<UCameraShakeBase>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ShakeClass, __InBuffer);
				}
			}
		}

		public float PlayScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PlayScale, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PlayScale, __InBuffer);
				}
			}
		}

		public ECameraShakePlaySpace PlaySpace
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PlaySpace, __ReturnBuffer);

					return *(ECameraShakePlaySpace*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PlaySpace, __InBuffer);
				}
			}
		}

		public FRotator UserDefinedPlaySpace
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UserDefinedPlaySpace, __ReturnBuffer);

					return *(FRotator*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UserDefinedPlaySpace, __InBuffer);
				}
			}
		}

		private static uint __ShakeClass = 0;

		private static uint __PlayScale = 0;

		private static uint __PlaySpace = 0;

		private static uint __UserDefinedPlaySpace = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}