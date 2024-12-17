using Script.CoreUObject;
using Script.Library;
using Script.PhysicsCore;

namespace Script.Engine
{
	[PathName("/Script/Engine.ConeConstraint")]
	public partial class FConeConstraint : FConstraintBaseParams, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ConeConstraint");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FConeConstraint()
		{
		}

		public static bool operator ==(FConeConstraint A, FConeConstraint B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FConeConstraint A, FConeConstraint B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FConeConstraint;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float Swing1LimitDegrees
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Swing1LimitDegrees, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Swing1LimitDegrees, __InBuffer);
				}
			}
		}

		public float Swing2LimitDegrees
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Swing2LimitDegrees, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Swing2LimitDegrees, __InBuffer);
				}
			}
		}

		public EAngularConstraintMotion Swing1Motion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Swing1Motion, __ReturnBuffer);

					return *(EAngularConstraintMotion*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Swing1Motion, __InBuffer);
				}
			}
		}

		public EAngularConstraintMotion Swing2Motion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Swing2Motion, __ReturnBuffer);

					return *(EAngularConstraintMotion*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Swing2Motion, __InBuffer);
				}
			}
		}

		private static uint __Swing1LimitDegrees = 0;

		private static uint __Swing2LimitDegrees = 0;

		private static uint __Swing1Motion = 0;

		private static uint __Swing2Motion = 0;

	}
}