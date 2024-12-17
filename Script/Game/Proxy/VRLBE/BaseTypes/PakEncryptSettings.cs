using Script.CoreUObject;
using Script.Library;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.PakEncryptSettings")]
	public partial class FPakEncryptSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/HotPatcherRuntime.PakEncryptSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPakEncryptSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPakEncryptSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPakEncryptSettings A, FPakEncryptSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPakEncryptSettings A, FPakEncryptSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPakEncryptSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bUseDefaultCryptoIni
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bUseDefaultCryptoIni, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bUseDefaultCryptoIni, __InBuffer);
				}
			}
		}

		public FFilePath CryptoKeys
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CryptoKeys, __ReturnBuffer);

					return *(FFilePath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CryptoKeys, __InBuffer);
				}
			}
		}

		private static uint __bUseDefaultCryptoIni = 0;

		private static uint __CryptoKeys = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}