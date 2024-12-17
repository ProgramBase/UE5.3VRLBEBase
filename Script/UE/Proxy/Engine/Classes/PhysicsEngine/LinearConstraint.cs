using Script.CoreUObject;
using Script.Library;
using Script.PhysicsCore;

namespace Script.Engine
{
	[PathName("/Script/Engine.LinearConstraint")]
	public partial class FLinearConstraint : FConstraintBaseParams, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.LinearConstraint");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLinearConstraint()
		{
		}

		public static bool operator ==(FLinearConstraint A, FLinearConstraint B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLinearConstraint A, FLinearConstraint B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLinearConstraint;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float Limit
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Limit, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Limit, __InBuffer);
				}
			}
		}

		public ELinearConstraintMotion XMotion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __XMotion, __ReturnBuffer);

					return *(ELinearConstraintMotion*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __XMotion, __InBuffer);
				}
			}
		}

		public ELinearConstraintMotion YMotion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __YMotion, __ReturnBuffer);

					return *(ELinearConstraintMotion*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __YMotion, __InBuffer);
				}
			}
		}

		public ELinearConstraintMotion ZMotion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ZMotion, __ReturnBuffer);

					return *(ELinearConstraintMotion*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ZMotion, __InBuffer);
				}
			}
		}

		private static uint __Limit = 0;

		private static uint __XMotion = 0;

		private static uint __YMotion = 0;

		private static uint __ZMotion = 0;

	}
}