using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.IntegerParameterNameAndCurve")]
	public partial class FIntegerParameterNameAndCurve : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.IntegerParameterNameAndCurve");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FIntegerParameterNameAndCurve() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FIntegerParameterNameAndCurve() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FIntegerParameterNameAndCurve A, FIntegerParameterNameAndCurve B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FIntegerParameterNameAndCurve A, FIntegerParameterNameAndCurve B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FIntegerParameterNameAndCurve;

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

		public FMovieSceneIntegerChannel ParameterCurve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ParameterCurve, __ReturnBuffer);

					return *(FMovieSceneIntegerChannel*)__ReturnBuffer;
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