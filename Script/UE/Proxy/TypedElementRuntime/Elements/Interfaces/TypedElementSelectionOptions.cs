using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementRuntime
{
	[PathName("/Script/TypedElementRuntime.TypedElementSelectionOptions")]
	public partial class FTypedElementSelectionOptions : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TypedElementRuntime.TypedElementSelectionOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTypedElementSelectionOptions() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTypedElementSelectionOptions() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTypedElementSelectionOptions A, FTypedElementSelectionOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTypedElementSelectionOptions A, FTypedElementSelectionOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTypedElementSelectionOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bAllowHidden
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bAllowHidden, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bAllowHidden, __InBuffer);
				}
			}
		}

		public bool bAllowGroups
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bAllowGroups, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bAllowGroups, __InBuffer);
				}
			}
		}

		public bool bAllowLegacyNotifications
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bAllowLegacyNotifications, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bAllowLegacyNotifications, __InBuffer);
				}
			}
		}

		public bool bWarnIfLocked
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bWarnIfLocked, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bWarnIfLocked, __InBuffer);
				}
			}
		}

		public ETypedElementChildInclusionMethod ChildElementInclusionMethod
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ChildElementInclusionMethod, __ReturnBuffer);

					return *(ETypedElementChildInclusionMethod*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ChildElementInclusionMethod, __InBuffer);
				}
			}
		}

		private static uint __bAllowHidden = 0;

		private static uint __bAllowGroups = 0;

		private static uint __bAllowLegacyNotifications = 0;

		private static uint __bWarnIfLocked = 0;

		private static uint __ChildElementInclusionMethod = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}