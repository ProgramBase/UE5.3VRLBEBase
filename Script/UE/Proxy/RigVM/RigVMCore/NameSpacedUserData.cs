using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.RigVM
{
	[PathName("/Script/RigVM.NameSpacedUserData")]
	public partial class UNameSpacedUserData : UAssetUserData, IStaticClass
	{
		public FString NameSpace
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NameSpace, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NameSpace, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/RigVM.NameSpacedUserData");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __NameSpace = 0;
	}
}