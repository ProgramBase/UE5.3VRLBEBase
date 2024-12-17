using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.RootMotionSource_MoveToForce")]
	public partial class FRootMotionSource_MoveToForce : FRootMotionSource, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.RootMotionSource_MoveToForce");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRootMotionSource_MoveToForce()
		{
		}

		public static bool operator ==(FRootMotionSource_MoveToForce A, FRootMotionSource_MoveToForce B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRootMotionSource_MoveToForce A, FRootMotionSource_MoveToForce B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRootMotionSource_MoveToForce;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FVector StartLocation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StartLocation, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StartLocation, __InBuffer);
				}
			}
		}

		public FVector TargetLocation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TargetLocation, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TargetLocation, __InBuffer);
				}
			}
		}

		public bool bRestrictSpeedToExpected
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bRestrictSpeedToExpected, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bRestrictSpeedToExpected, __InBuffer);
				}
			}
		}

		public UCurveVector PathOffsetCurve
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PathOffsetCurve, __ReturnBuffer);

					return *(UCurveVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PathOffsetCurve, __InBuffer);
				}
			}
		}

		private static uint __StartLocation = 0;

		private static uint __TargetLocation = 0;

		private static uint __bRestrictSpeedToExpected = 0;

		private static uint __PathOffsetCurve = 0;

	}
}