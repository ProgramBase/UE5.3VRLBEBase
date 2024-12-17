using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.EditorUtilityBlueprintFactory")]
	public partial class UEditorUtilityBlueprintFactory : UFactory, IStaticClass
	{
		public TSubclassOf<UObject> ParentClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ParentClass, __ReturnBuffer);

					return *(TSubclassOf<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ParentClass, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.EditorUtilityBlueprintFactory");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ParentClass = 0;
	}
}