using Script.CoreUObject;
using Script.Library;

namespace Script.AssetManagerEditor
{
	[PathName("/Script/AssetManagerEditor.SizeMapSettings")]
	public partial class USizeMapSettings : UObject, IStaticClass
	{
		public FName SizeType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SizeType, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SizeType, __InBuffer);
				}
			}
		}

		public ESizeMapDependencyType DependencyType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DependencyType, __ReturnBuffer);

					return *(ESizeMapDependencyType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DependencyType, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AssetManagerEditor.SizeMapSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SizeType = 0;

		private static uint __DependencyType = 0;
	}
}