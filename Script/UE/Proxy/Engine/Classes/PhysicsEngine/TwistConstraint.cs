using Script.CoreUObject;
using Script.Library;
using Script.PhysicsCore;

namespace Script.Engine
{
	[PathName("/Script/Engine.TwistConstraint")]
	public partial class FTwistConstraint : FConstraintBaseParams, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.TwistConstraint");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTwistConstraint()
		{
		}

		public static bool operator ==(FTwistConstraint A, FTwistConstraint B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTwistConstraint A, FTwistConstraint B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTwistConstraint;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float TwistLimitDegrees
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TwistLimitDegrees, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TwistLimitDegrees, __InBuffer);
				}
			}
		}

		public EAngularConstraintMotion TwistMotion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TwistMotion, __ReturnBuffer);

					return *(EAngularConstraintMotion*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TwistMotion, __InBuffer);
				}
			}
		}

		private static uint __TwistLimitDegrees = 0;

		private static uint __TwistMotion = 0;

	}
}