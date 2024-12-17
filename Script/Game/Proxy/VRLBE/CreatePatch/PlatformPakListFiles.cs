using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.PlatformPakListFiles")]
	public partial class FPlatformPakListFiles : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/HotPatcherRuntime.PlatformPakListFiles");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPlatformPakListFiles() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPlatformPakListFiles() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPlatformPakListFiles A, FPlatformPakListFiles B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPlatformPakListFiles A, FPlatformPakListFiles B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPlatformPakListFiles;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ETargetPlatform TargetPlatform
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TargetPlatform, __ReturnBuffer);

					return *(ETargetPlatform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TargetPlatform, __InBuffer);
				}
			}
		}

		public TArray<FFilePath> PakResponseFiles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PakResponseFiles, __ReturnBuffer);

					return *(TArray<FFilePath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PakResponseFiles, __InBuffer);
				}
			}
		}

		public TArray<FFilePath> PakFiles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PakFiles, __ReturnBuffer);

					return *(TArray<FFilePath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PakFiles, __InBuffer);
				}
			}
		}

		public FString AESKey
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AESKey, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AESKey, __InBuffer);
				}
			}
		}

		private static uint __TargetPlatform = 0;

		private static uint __PakResponseFiles = 0;

		private static uint __PakFiles = 0;

		private static uint __AESKey = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}