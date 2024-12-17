using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.EnumParameterNameAndCurve")]
	public partial class FEnumParameterNameAndCurve : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.EnumParameterNameAndCurve");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEnumParameterNameAndCurve() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FEnumParameterNameAndCurve() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FEnumParameterNameAndCurve A, FEnumParameterNameAndCurve B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEnumParameterNameAndCurve A, FEnumParameterNameAndCurve B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEnumParameterNameAndCurve;

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

		public FMovieSceneByteChannel ParameterCurve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ParameterCurve, __ReturnBuffer);

					return *(FMovieSceneByteChannel*)__ReturnBuffer;
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