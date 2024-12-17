using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PhysicsConstraintProfileHandle")]
	public partial class FPhysicsConstraintProfileHandle : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.PhysicsConstraintProfileHandle");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPhysicsConstraintProfileHandle() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPhysicsConstraintProfileHandle() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPhysicsConstraintProfileHandle A, FPhysicsConstraintProfileHandle B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPhysicsConstraintProfileHandle A, FPhysicsConstraintProfileHandle B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPhysicsConstraintProfileHandle;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FConstraintProfileProperties ProfileProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ProfileProperties, __ReturnBuffer);

					return *(FConstraintProfileProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ProfileProperties, __InBuffer);
				}
			}
		}

		public FName ProfileName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ProfileName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ProfileName, __InBuffer);
				}
			}
		}

		private static uint __ProfileProperties = 0;

		private static uint __ProfileName = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}