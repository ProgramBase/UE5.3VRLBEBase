using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Library;

namespace Script.Documentation
{
	[PathName("/Script/Documentation.DocumentationSettings")]
	public partial class UDocumentationSettings : UDeveloperSettings, IStaticClass
	{
		public TArray<FDocumentationBaseUrl> DocumentationBaseUrls
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DocumentationBaseUrls, __ReturnBuffer);

					return *(TArray<FDocumentationBaseUrl>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DocumentationBaseUrls, __InBuffer);
				}
			}
		}

		public TArray<FDocumentationRedirect> DocumentationRedirects
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DocumentationRedirects, __ReturnBuffer);

					return *(TArray<FDocumentationRedirect>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DocumentationRedirects, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Documentation.DocumentationSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __DocumentationBaseUrls = 0;

		private static uint __DocumentationRedirects = 0;
	}
}