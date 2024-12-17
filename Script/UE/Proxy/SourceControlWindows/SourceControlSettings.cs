using Script.CoreUObject;
using Script.Library;

namespace Script.SourceControlWindows
{
	[PathName("/Script/SourceControlWindows.SourceControlSettings")]
	public partial class USourceControlSettings : UObject, IStaticClass
	{
		public bool bShowAssetTypeColumn
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShowAssetTypeColumn, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShowAssetTypeColumn, __InBuffer);
				}
			}
		}

		public bool bShowAssetLastModifiedTimeColumn
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShowAssetLastModifiedTimeColumn, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShowAssetLastModifiedTimeColumn, __InBuffer);
				}
			}
		}

		public bool bShowAssetCheckedOutByColumn
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShowAssetCheckedOutByColumn, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShowAssetCheckedOutByColumn, __InBuffer);
				}
			}
		}

		public bool bEnableSubmitContentMenuAction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableSubmitContentMenuAction, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableSubmitContentMenuAction, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SourceControlWindows.SourceControlSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bShowAssetTypeColumn = 0;

		private static uint __bShowAssetLastModifiedTimeColumn = 0;

		private static uint __bShowAssetCheckedOutByColumn = 0;

		private static uint __bEnableSubmitContentMenuAction = 0;
	}
}