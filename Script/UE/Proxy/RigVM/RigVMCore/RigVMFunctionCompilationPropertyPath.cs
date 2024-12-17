using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMFunctionCompilationPropertyPath")]
	public partial class FRigVMFunctionCompilationPropertyPath : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMFunctionCompilationPropertyPath");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMFunctionCompilationPropertyPath() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigVMFunctionCompilationPropertyPath() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigVMFunctionCompilationPropertyPath A, FRigVMFunctionCompilationPropertyPath B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMFunctionCompilationPropertyPath A, FRigVMFunctionCompilationPropertyPath B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMFunctionCompilationPropertyPath;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int PropertyIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PropertyIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PropertyIndex, __InBuffer);
				}
			}
		}

		public FString HeadCPPType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __HeadCPPType, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __HeadCPPType, __InBuffer);
				}
			}
		}

		public FString SegmentPath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SegmentPath, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SegmentPath, __InBuffer);
				}
			}
		}

		private static uint __PropertyIndex = 0;

		private static uint __HeadCPPType = 0;

		private static uint __SegmentPath = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}