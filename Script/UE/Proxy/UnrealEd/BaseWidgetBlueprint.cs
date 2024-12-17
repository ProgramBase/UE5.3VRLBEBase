using Script.CoreUObject;
using Script.UMG;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.BaseWidgetBlueprint")]
	public partial class UBaseWidgetBlueprint : UUserWidgetBlueprint, IStaticClass
	{
		public UWidgetTree WidgetTree
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WidgetTree, __ReturnBuffer);

					return *(UWidgetTree*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WidgetTree, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.BaseWidgetBlueprint");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __WidgetTree = 0;
	}
}