using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraAnimNotifies
{
	[PathName("/Script/NiagaraAnimNotifies.CurveParameterPair")]
	public partial class FCurveParameterPair : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NiagaraAnimNotifies.CurveParameterPair");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCurveParameterPair() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCurveParameterPair() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCurveParameterPair A, FCurveParameterPair B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCurveParameterPair A, FCurveParameterPair B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCurveParameterPair;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName AnimCurveName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AnimCurveName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AnimCurveName, __InBuffer);
				}
			}
		}

		public FName UserVariableName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UserVariableName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UserVariableName, __InBuffer);
				}
			}
		}

		private static uint __AnimCurveName = 0;

		private static uint __UserVariableName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}