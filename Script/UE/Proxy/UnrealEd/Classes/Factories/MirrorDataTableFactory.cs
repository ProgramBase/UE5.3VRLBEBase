using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.MirrorDataTableFactory")]
	public partial class UMirrorDataTableFactory : UFactory, IStaticClass
	{
		public UScriptStruct Struct
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Struct, __ReturnBuffer);

					return *(UScriptStruct*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Struct, __InBuffer);
				}
			}
		}

		public USkeleton Skeleton
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Skeleton, __ReturnBuffer);

					return *(USkeleton*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Skeleton, __InBuffer);
				}
			}
		}

		public UMirrorTableFindReplaceExpressions MirrorFindReplaceExpressions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MirrorFindReplaceExpressions, __ReturnBuffer);

					return *(UMirrorTableFindReplaceExpressions*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MirrorFindReplaceExpressions, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.MirrorDataTableFactory");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Struct = 0;

		private static uint __Skeleton = 0;

		private static uint __MirrorFindReplaceExpressions = 0;
	}
}