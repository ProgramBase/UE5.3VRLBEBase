using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.RootMotionSource_ConstantForce")]
	public partial class FRootMotionSource_ConstantForce : FRootMotionSource, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.RootMotionSource_ConstantForce");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRootMotionSource_ConstantForce()
		{
		}

		public static bool operator ==(FRootMotionSource_ConstantForce A, FRootMotionSource_ConstantForce B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRootMotionSource_ConstantForce A, FRootMotionSource_ConstantForce B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRootMotionSource_ConstantForce;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FVector Force
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Force, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Force, __InBuffer);
				}
			}
		}

		public UCurveFloat StrengthOverTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StrengthOverTime, __ReturnBuffer);

					return *(UCurveFloat*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StrengthOverTime, __InBuffer);
				}
			}
		}

		private static uint __Force = 0;

		private static uint __StrengthOverTime = 0;

	}
}