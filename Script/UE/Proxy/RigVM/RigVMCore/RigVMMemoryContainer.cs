using Script.CoreUObject;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.RigVMMemoryContainer")]
	public partial class FRigVMMemoryContainer : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/RigVM.RigVMMemoryContainer");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FRigVMMemoryContainer() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FRigVMMemoryContainer() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FRigVMMemoryContainer A, FRigVMMemoryContainer B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FRigVMMemoryContainer A, FRigVMMemoryContainer B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FRigVMMemoryContainer;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bUseNameMap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bUseNameMap, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bUseNameMap, __InBuffer);
				}
			}
		}

		public ERigVMMemoryType MemoryType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MemoryType, __ReturnBuffer);

					return *(ERigVMMemoryType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MemoryType, __InBuffer);
				}
			}
		}

		public TArray<FRigVMRegister> Registers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Registers, __ReturnBuffer);

					return *(TArray<FRigVMRegister>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Registers, __InBuffer);
				}
			}
		}

		public TArray<FRigVMRegisterOffset> RegisterOffsets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RegisterOffsets, __ReturnBuffer);

					return *(TArray<FRigVMRegisterOffset>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RegisterOffsets, __InBuffer);
				}
			}
		}

		public TArray<byte> Data
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Data, __ReturnBuffer);

					return *(TArray<byte>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Data, __InBuffer);
				}
			}
		}

		public TArray<UScriptStruct> ScriptStructs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ScriptStructs, __ReturnBuffer);

					return *(TArray<UScriptStruct>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ScriptStructs, __InBuffer);
				}
			}
		}

		public TMap<FName, int> NameMap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NameMap, __ReturnBuffer);

					return *(TMap<FName, int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NameMap, __InBuffer);
				}
			}
		}

		public bool bEncounteredErrorDuringLoad
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bEncounteredErrorDuringLoad, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bEncounteredErrorDuringLoad, __InBuffer);
				}
			}
		}

		private static uint __bUseNameMap = 0;

		private static uint __MemoryType = 0;

		private static uint __Registers = 0;

		private static uint __RegisterOffsets = 0;

		private static uint __Data = 0;

		private static uint __ScriptStructs = 0;

		private static uint __NameMap = 0;

		private static uint __bEncounteredErrorDuringLoad = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}