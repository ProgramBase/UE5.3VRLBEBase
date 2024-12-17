using Script.CoreUObject;
using Script.Library;

namespace Script.SourceControlWindows
{
	[PathName("/Script/SourceControlWindows.SourceControlMenuContext")]
	public partial class USourceControlMenuContext : UObject, IStaticClass
	{
		public TArray<FString> SelectedFiles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SelectedFiles, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SelectedFiles, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SourceControlWindows.SourceControlMenuContext");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SelectedFiles = 0;
	}
}