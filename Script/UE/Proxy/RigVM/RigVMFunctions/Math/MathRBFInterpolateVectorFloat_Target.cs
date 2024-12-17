using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.MathRBFInterpolateVectorFloat_Target")]
	public partial class FMathRBFInterpolateVectorFloat_Target : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.MathRBFInterpolateVectorFloat_Target");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMathRBFInterpolateVectorFloat_Target() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMathRBFInterpolateVectorFloat_Target() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMathRBFInterpolateVectorFloat_Target A, FMathRBFInterpolateVectorFloat_Target B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMathRBFInterpolateVectorFloat_Target A, FMathRBFInterpolateVectorFloat_Target B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMathRBFInterpolateVectorFloat_Target;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FVector Target
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Target, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Target, __InBuffer);
				}
			}
		}

		public float Value
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Value, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Value, __InBuffer);
				}
			}
		}

		private static uint __Target = 0;

		private static uint __Value = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}