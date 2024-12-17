using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.PartialNetObjectAttachmentHandlerConfig")]
	public partial class UPartialNetObjectAttachmentHandlerConfig : USequentialPartialNetBlobHandlerConfig, IStaticClass
	{
		public uint BitCountSplitThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BitCountSplitThreshold, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BitCountSplitThreshold, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IrisCore.PartialNetObjectAttachmentHandlerConfig");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __BitCountSplitThreshold = 0;
	}
}