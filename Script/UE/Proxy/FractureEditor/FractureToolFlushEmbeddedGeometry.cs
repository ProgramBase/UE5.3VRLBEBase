using Script.CoreUObject;
using Script.Library;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.FractureToolFlushEmbeddedGeometry")]
	public partial class UFractureToolFlushEmbeddedGeometry : UFractureModalTool, IStaticClass
	{
		public UFractureToolFlushEmbeddedGeometrySettings FlushEmbeddedGeometrySettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FlushEmbeddedGeometrySettings, __ReturnBuffer);

					return *(UFractureToolFlushEmbeddedGeometrySettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FlushEmbeddedGeometrySettings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FractureEditor.FractureToolFlushEmbeddedGeometry");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __FlushEmbeddedGeometrySettings = 0;
	}
}