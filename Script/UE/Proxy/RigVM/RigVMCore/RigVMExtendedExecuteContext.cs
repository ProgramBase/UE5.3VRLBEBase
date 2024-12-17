using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMExtendedExecuteContext")]
	public partial class FRigVMExtendedExecuteContext : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMExtendedExecuteContext");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMExtendedExecuteContext() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigVMExtendedExecuteContext() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigVMExtendedExecuteContext A, FRigVMExtendedExecuteContext B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMExtendedExecuteContext A, FRigVMExtendedExecuteContext B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMExtendedExecuteContext;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public uint VMHash
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __VMHash, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __VMHash, __InBuffer);
				}
			}
		}

		public uint NumExecutions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NumExecutions, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NumExecutions, __InBuffer);
				}
			}
		}

		public URigVM DeferredVMToCopy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DeferredVMToCopy, __ReturnBuffer);

					return *(URigVM*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DeferredVMToCopy, __InBuffer);
				}
			}
		}

		private static uint __VMHash = 0;

		private static uint __NumExecutions = 0;

		private static uint __DeferredVMToCopy = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}