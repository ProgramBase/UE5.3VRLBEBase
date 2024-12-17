using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Library;

namespace Script.PlasticSourceControl
{
	[PathName("/Script/PlasticSourceControl.PlasticSourceControlProjectSettings")]
	public partial class UPlasticSourceControlProjectSettings : UDeveloperSettings, IStaticClass
	{
		public TMap<FString, FString> UserNameToDisplayName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UserNameToDisplayName, __ReturnBuffer);

					return *(TMap<FString, FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UserNameToDisplayName, __InBuffer);
				}
			}
		}

		public bool bHideEmailDomainInUsername
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHideEmailDomainInUsername, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHideEmailDomainInUsername, __InBuffer);
				}
			}
		}

		public bool bPromptForCheckoutOnChange
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bPromptForCheckoutOnChange, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bPromptForCheckoutOnChange, __InBuffer);
				}
			}
		}

		public int LimitNumberOfRevisionsInHistory
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LimitNumberOfRevisionsInHistory, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LimitNumberOfRevisionsInHistory, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/PlasticSourceControl.PlasticSourceControlProjectSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __UserNameToDisplayName = 0;

		private static uint __bHideEmailDomainInUsername = 0;

		private static uint __bPromptForCheckoutOnChange = 0;

		private static uint __LimitNumberOfRevisionsInHistory = 0;
	}
}