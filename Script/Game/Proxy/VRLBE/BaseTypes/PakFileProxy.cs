using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.PakFileProxy")]
	public partial class FPakFileProxy : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/HotPatcherRuntime.PakFileProxy");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPakFileProxy() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPakFileProxy() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPakFileProxy A, FPakFileProxy B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPakFileProxy A, FPakFileProxy B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPakFileProxy;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString ChunkStoreName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ChunkStoreName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ChunkStoreName, __InBuffer);
				}
			}
		}

		public ETargetPlatform Platform
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Platform, __ReturnBuffer);

					return *(ETargetPlatform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Platform, __InBuffer);
				}
			}
		}

		public FString StorageDirectory
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __StorageDirectory, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __StorageDirectory, __InBuffer);
				}
			}
		}

		public TArray<FPakCommand> PakCommands
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PakCommands, __ReturnBuffer);

					return *(TArray<FPakCommand>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PakCommands, __InBuffer);
				}
			}
		}

		public TArray<FString> IoStoreCommands
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __IoStoreCommands, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __IoStoreCommands, __InBuffer);
				}
			}
		}

		private static uint __ChunkStoreName = 0;

		private static uint __Platform = 0;

		private static uint __StorageDirectory = 0;

		private static uint __PakCommands = 0;

		private static uint __IoStoreCommands = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}