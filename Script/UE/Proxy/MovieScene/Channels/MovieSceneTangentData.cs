using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneTangentData")]
	public partial class FMovieSceneTangentData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneTangentData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneTangentData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneTangentData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneTangentData A, FMovieSceneTangentData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneTangentData A, FMovieSceneTangentData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneTangentData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float ArriveTangent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ArriveTangent, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ArriveTangent, __InBuffer);
				}
			}
		}

		public float LeaveTangent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LeaveTangent, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LeaveTangent, __InBuffer);
				}
			}
		}

		public float ArriveTangentWeight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ArriveTangentWeight, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ArriveTangentWeight, __InBuffer);
				}
			}
		}

		public float LeaveTangentWeight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LeaveTangentWeight, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LeaveTangentWeight, __InBuffer);
				}
			}
		}

		public ERichCurveTangentWeightMode TangentWeightMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TangentWeightMode, __ReturnBuffer);

					return *(ERichCurveTangentWeightMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TangentWeightMode, __InBuffer);
				}
			}
		}

		private static uint __ArriveTangent = 0;

		private static uint __LeaveTangent = 0;

		private static uint __ArriveTangentWeight = 0;

		private static uint __LeaveTangentWeight = 0;

		private static uint __TangentWeightMode = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}