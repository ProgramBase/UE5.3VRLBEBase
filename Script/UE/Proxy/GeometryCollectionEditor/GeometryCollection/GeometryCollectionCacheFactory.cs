using Script.CoreUObject;
using Script.UnrealEd;
using Script.GeometryCollectionEngine;
using Script.Library;

namespace Script.GeometryCollectionEditor
{
	[PathName("/Script/GeometryCollectionEditor.GeometryCollectionCacheFactory")]
	public partial class UGeometryCollectionCacheFactory : UFactory, IStaticClass
	{
		public UGeometryCollection TargetCollection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TargetCollection, __ReturnBuffer);

					return *(UGeometryCollection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TargetCollection, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryCollectionEditor.GeometryCollectionCacheFactory");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __TargetCollection = 0;
	}
}