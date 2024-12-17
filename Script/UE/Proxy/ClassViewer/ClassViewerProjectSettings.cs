using Script.CoreUObject;
using Script.Library;

namespace Script.ClassViewer
{
	[PathName("/Script/ClassViewer.ClassViewerProjectSettings")]
	public partial class UClassViewerProjectSettings : UObject, IStaticClass
	{
		public TArray<FDirectoryPath> InternalOnlyPaths
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InternalOnlyPaths, __ReturnBuffer);

					return *(TArray<FDirectoryPath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InternalOnlyPaths, __InBuffer);
				}
			}
		}

		public TArray<FSoftClassPath> InternalOnlyClasses
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InternalOnlyClasses, __ReturnBuffer);

					return *(TArray<FSoftClassPath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InternalOnlyClasses, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ClassViewer.ClassViewerProjectSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __InternalOnlyPaths = 0;

		private static uint __InternalOnlyClasses = 0;
	}
}