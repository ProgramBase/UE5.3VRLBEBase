using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.ContentBrowserData
{
	[PathName("/Script/ContentBrowserData.ContentBrowserItemPathExtensions")]
	public partial class UContentBrowserItemPathExtensions : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ContentBrowserData.ContentBrowserItemPathExtensions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void SetPath(ref FContentBrowserItemPath ItemPath, FName InPath, EContentBrowserPathType InPathType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = ItemPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InPath?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)InPathType;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetPath, __InBuffer, __OutBuffer);

				ItemPath = *(FContentBrowserItemPath*)(__OutBuffer);

			}
		}

		public static FContentBrowserItemPath MakeContentBrowserItemPath(FName InPath, EContentBrowserPathType InPathType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InPath?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)InPathType;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeContentBrowserItemPath, __InBuffer, __ReturnBuffer);

				return *(FContentBrowserItemPath*)__ReturnBuffer;
			}
		}

		public static FName GetVirtualPath(FContentBrowserItemPath ItemPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ItemPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetVirtualPath, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public static FName GetInternalPath(FContentBrowserItemPath ItemPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ItemPath?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetInternalPath, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public static void BreakContentBrowserItemPath(FContentBrowserItemPath ItemPath, ref FName VirtualPath, ref FName InternalPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = ItemPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = VirtualPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InternalPath?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __BreakContentBrowserItemPath, __InBuffer, __OutBuffer);

				VirtualPath = *(FName*)(__OutBuffer);

				InternalPath = *(FName*)(__OutBuffer + 8);

			}
		}

		private static uint __SetPath = 0;

		private static uint __MakeContentBrowserItemPath = 0;

		private static uint __GetVirtualPath = 0;

		private static uint __GetInternalPath = 0;

		private static uint __BreakContentBrowserItemPath = 0;
	}
}