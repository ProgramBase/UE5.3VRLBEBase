using Script.CoreUObject;
using Script.Library;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.ModifyContextOptions")]
	public partial class FModifyContextOptions : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/EnhancedInput.ModifyContextOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FModifyContextOptions() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FModifyContextOptions() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FModifyContextOptions A, FModifyContextOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FModifyContextOptions A, FModifyContextOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FModifyContextOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bIgnoreAllPressedKeysUntilRelease
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIgnoreAllPressedKeysUntilRelease, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIgnoreAllPressedKeysUntilRelease, __InBuffer);
				}
			}
		}

		public bool bForceImmediately
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bForceImmediately, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bForceImmediately, __InBuffer);
				}
			}
		}

		public bool bNotifyUserSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bNotifyUserSettings, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bNotifyUserSettings, __InBuffer);
				}
			}
		}

		private static uint __bIgnoreAllPressedKeysUntilRelease = 0;

		private static uint __bForceImmediately = 0;

		private static uint __bNotifyUserSettings = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}