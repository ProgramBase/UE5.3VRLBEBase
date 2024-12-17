using Script.CoreUObject;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.RigControlLimitEnabled")]
	public partial class FRigControlLimitEnabled : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.RigControlLimitEnabled");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigControlLimitEnabled() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigControlLimitEnabled() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigControlLimitEnabled A, FRigControlLimitEnabled B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigControlLimitEnabled A, FRigControlLimitEnabled B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigControlLimitEnabled;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bMinimum
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bMinimum, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bMinimum, __InBuffer);
				}
			}
		}

		public bool bMaximum
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bMaximum, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bMaximum, __InBuffer);
				}
			}
		}

		private static uint __bMinimum = 0;

		private static uint __bMaximum = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}