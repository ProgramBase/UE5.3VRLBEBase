using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Library;

namespace Script.CollectionManager
{
	[PathName("/Script/CollectionManager.CollectionSettings")]
	public partial class UCollectionSettings : UDeveloperSettings, IStaticClass
	{
		public bool bAutoCommitOnSave
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoCommitOnSave, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoCommitOnSave, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/CollectionManager.CollectionSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bAutoCommitOnSave = 0;
	}
}