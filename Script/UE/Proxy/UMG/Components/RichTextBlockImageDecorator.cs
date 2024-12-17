using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.RichTextBlockImageDecorator")]
	public partial class URichTextBlockImageDecorator : URichTextBlockDecorator, IStaticClass
	{
		public UDataTable ImageSet
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ImageSet, __ReturnBuffer);

					return *(UDataTable*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ImageSet, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.RichTextBlockImageDecorator");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ImageSet = 0;
	}
}