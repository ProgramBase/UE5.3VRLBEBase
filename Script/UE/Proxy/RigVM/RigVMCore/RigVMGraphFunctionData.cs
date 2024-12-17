using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMGraphFunctionData")]
	public partial class FRigVMGraphFunctionData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMGraphFunctionData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMGraphFunctionData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigVMGraphFunctionData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigVMGraphFunctionData A, FRigVMGraphFunctionData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMGraphFunctionData A, FRigVMGraphFunctionData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMGraphFunctionData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FRigVMGraphFunctionHeader Header
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Header, __ReturnBuffer);

					return *(FRigVMGraphFunctionHeader*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Header, __InBuffer);
				}
			}
		}

		public FRigVMFunctionCompilationData CompilationData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CompilationData, __ReturnBuffer);

					return *(FRigVMFunctionCompilationData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CompilationData, __InBuffer);
				}
			}
		}

		public FString SerializedCollapsedNode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SerializedCollapsedNode, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SerializedCollapsedNode, __InBuffer);
				}
			}
		}

		private static uint __Header = 0;

		private static uint __CompilationData = 0;

		private static uint __SerializedCollapsedNode = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}