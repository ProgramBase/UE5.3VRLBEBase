using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.BoolParameterNameAndCurve")]
	public partial class FBoolParameterNameAndCurve : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieSceneTracks.BoolParameterNameAndCurve");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBoolParameterNameAndCurve() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBoolParameterNameAndCurve() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBoolParameterNameAndCurve A, FBoolParameterNameAndCurve B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBoolParameterNameAndCurve A, FBoolParameterNameAndCurve B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBoolParameterNameAndCurve;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName ParameterName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ParameterName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ParameterName, __InBuffer);
				}
			}
		}

		public FMovieSceneBoolChannel ParameterCurve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ParameterCurve, __ReturnBuffer);

					return *(FMovieSceneBoolChannel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ParameterCurve, __InBuffer);
				}
			}
		}

		private static uint __ParameterName = 0;

		private static uint __ParameterCurve = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}