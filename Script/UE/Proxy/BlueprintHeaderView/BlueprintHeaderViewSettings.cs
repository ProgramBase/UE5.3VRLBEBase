using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Library;

namespace Script.BlueprintHeaderView
{
	[PathName("/Script/BlueprintHeaderView.BlueprintHeaderViewSettings")]
	public partial class UBlueprintHeaderViewSettings : UDeveloperSettings, IStaticClass
	{
		public FHeaderViewSyntaxColors SyntaxColors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SyntaxColors, __ReturnBuffer);

					return *(FHeaderViewSyntaxColors*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SyntaxColors, __InBuffer);
				}
			}
		}

		public FLinearColor SelectionColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SelectionColor, __ReturnBuffer);

					return *(FLinearColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SelectionColor, __InBuffer);
				}
			}
		}

		public int FontSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FontSize, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FontSize, __InBuffer);
				}
			}
		}

		public EHeaderViewSortMethod SortMethod
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SortMethod, __ReturnBuffer);

					return *(EHeaderViewSortMethod*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SortMethod, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintHeaderView.BlueprintHeaderViewSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SyntaxColors = 0;

		private static uint __SelectionColor = 0;

		private static uint __FontSize = 0;

		private static uint __SortMethod = 0;
	}
}