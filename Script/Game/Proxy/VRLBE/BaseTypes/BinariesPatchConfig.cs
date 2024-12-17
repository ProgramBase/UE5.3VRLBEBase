using Script.CoreUObject;
using Script.Library;
using Script.BinariesPatchFeature;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.BinariesPatchConfig")]
	public partial class FBinariesPatchConfig : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/HotPatcherRuntime.BinariesPatchConfig");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBinariesPatchConfig() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FBinariesPatchConfig() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FBinariesPatchConfig A, FBinariesPatchConfig B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBinariesPatchConfig A, FBinariesPatchConfig B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBinariesPatchConfig;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public EBinariesPatchFeature BinariesPatchType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BinariesPatchType, __ReturnBuffer);

					return *(EBinariesPatchFeature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BinariesPatchType, __InBuffer);
				}
			}
		}

		public FPakEncryptSettings EncryptSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EncryptSettings, __ReturnBuffer);

					return *(FPakEncryptSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EncryptSettings, __InBuffer);
				}
			}
		}

		public TArray<FPlatformBasePak> BaseVersionPaks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BaseVersionPaks, __ReturnBuffer);

					return *(TArray<FPlatformBasePak>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BaseVersionPaks, __InBuffer);
				}
			}
		}

		public TArray<FMatchRule> MatchRules
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MatchRules, __ReturnBuffer);

					return *(TArray<FMatchRule>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MatchRules, __InBuffer);
				}
			}
		}

		private static uint __BinariesPatchType = 0;

		private static uint __EncryptSettings = 0;

		private static uint __BaseVersionPaks = 0;

		private static uint __MatchRules = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}