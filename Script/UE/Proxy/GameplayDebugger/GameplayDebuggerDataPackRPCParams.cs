using Script.CoreUObject;
using Script.Library;

namespace Script.GameplayDebugger
{
	[PathName("/Script/GameplayDebugger.GameplayDebuggerDataPackRPCParams")]
	public partial class FGameplayDebuggerDataPackRPCParams : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GameplayDebugger.GameplayDebuggerDataPackRPCParams");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGameplayDebuggerDataPackRPCParams() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGameplayDebuggerDataPackRPCParams() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGameplayDebuggerDataPackRPCParams A, FGameplayDebuggerDataPackRPCParams B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGameplayDebuggerDataPackRPCParams A, FGameplayDebuggerDataPackRPCParams B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGameplayDebuggerDataPackRPCParams;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName CategoryName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CategoryName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CategoryName, __InBuffer);
				}
			}
		}

		public int DataPackIdx
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DataPackIdx, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DataPackIdx, __InBuffer);
				}
			}
		}

		public FGameplayDebuggerDataPackHeader Header
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Header, __ReturnBuffer);

					return *(FGameplayDebuggerDataPackHeader*)__ReturnBuffer;
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

		private static uint __CategoryName = 0;

		private static uint __DataPackIdx = 0;

		private static uint __Header = 0;

		private static uint __Data = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}