using Script.CoreUObject;
using Script.Library;
using Script.Reflection.Property;

namespace Script.ConfigEditor
{
	[PathName("/Script/ConfigEditor.ConfigHierarchyPropertyView")]
	public partial class UConfigHierarchyPropertyView : UObject, IStaticClass
	{
		public TFieldPath<FProperty> EditProperty
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EditProperty, __ReturnBuffer);

					return *(TFieldPath<FProperty>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EditProperty, __InBuffer);
				}
			}
		}

		public TArray<UPropertyConfigFileDisplayRow> ConfigFilePropertyObjects
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ConfigFilePropertyObjects, __ReturnBuffer);

					return *(TArray<UPropertyConfigFileDisplayRow>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ConfigFilePropertyObjects, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ConfigEditor.ConfigHierarchyPropertyView");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __EditProperty = 0;

		private static uint __ConfigFilePropertyObjects = 0;
	}
}