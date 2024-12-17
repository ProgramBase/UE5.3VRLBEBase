using Script.Binding;

namespace Script.CoreUObject
{
	public partial class FSoftObjectPath
	{
		public FSoftObjectPath(FSoftObjectPath Other)
		{
			if (GetType() == typeof(FSoftObjectPath))
			{
				FSoftObjectPathImplementation.FSoftObjectPath_FSoftObjectPathImplementation(this, Other?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public FSoftObjectPath(FString Path)
		{
			if (GetType() == typeof(FSoftObjectPath))
			{
				FSoftObjectPathImplementation.FSoftObjectPath_FSoftObjectPath1Implementation(this, Path?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public FSoftObjectPath(UObject InObject)
		{
			if (GetType() == typeof(FSoftObjectPath))
			{
				FSoftObjectPathImplementation.FSoftObjectPath_FSoftObjectPath2Implementation(this, InObject?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public new FString ToString()
		{
			return FSoftObjectPathImplementation.FSoftObjectPath_ToStringImplementation(GarbageCollectionHandle) as FString;
		}

		public FString GetAssetPathName()
		{
			return FSoftObjectPathImplementation.FSoftObjectPath_GetAssetPathNameImplementation(GarbageCollectionHandle) as FString;
		}

		public FString GetAssetPathString()
		{
			return FSoftObjectPathImplementation.FSoftObjectPath_GetAssetPathStringImplementation(GarbageCollectionHandle) as FString;
		}

		public FString GetSubPathString()
		{
			return FSoftObjectPathImplementation.FSoftObjectPath_GetSubPathStringImplementation(GarbageCollectionHandle) as FString;
		}

		public void SetSubPathString(FString InSubPathString)
		{
			FSoftObjectPathImplementation.FSoftObjectPath_SetSubPathStringImplementation(GarbageCollectionHandle, InSubPathString?.GarbageCollectionHandle ?? nint.Zero);
		}

		public FString GetLongPackageName()
		{
			return FSoftObjectPathImplementation.FSoftObjectPath_GetLongPackageNameImplementation(GarbageCollectionHandle) as FString;
		}

		public FName GetLongPackageFName()
		{
			return FSoftObjectPathImplementation.FSoftObjectPath_GetLongPackageFNameImplementation(GarbageCollectionHandle) as FName;
		}

		public FString GetAssetName()
		{
			return FSoftObjectPathImplementation.FSoftObjectPath_GetAssetNameImplementation(GarbageCollectionHandle) as FString;
		}

		public void SetPath(FString Path)
		{
			FSoftObjectPathImplementation.FSoftObjectPath_SetPathImplementation(GarbageCollectionHandle, Path?.GarbageCollectionHandle ?? nint.Zero);
		}

		public UObject ResolveObject()
		{
			return FSoftObjectPathImplementation.FSoftObjectPath_ResolveObjectImplementation(GarbageCollectionHandle) as UObject;
		}

		public void Reset()
		{
			FSoftObjectPathImplementation.FSoftObjectPath_ResetImplementation(GarbageCollectionHandle);
		}

		public bool IsValid()
		{
			return (bool)FSoftObjectPathImplementation.FSoftObjectPath_IsValidImplementation(GarbageCollectionHandle);
		}

		public bool IsNull()
		{
			return (bool)FSoftObjectPathImplementation.FSoftObjectPath_IsNullImplementation(GarbageCollectionHandle);
		}

		public bool IsAsset()
		{
			return (bool)FSoftObjectPathImplementation.FSoftObjectPath_IsAssetImplementation(GarbageCollectionHandle);
		}

		public bool IsSubobject()
		{
			return (bool)FSoftObjectPathImplementation.FSoftObjectPath_IsSubobjectImplementation(GarbageCollectionHandle);
		}

		public bool FixupCoreRedirects()
		{
			return (bool)FSoftObjectPathImplementation.FSoftObjectPath_FixupCoreRedirectsImplementation(GarbageCollectionHandle);
		}

		public static int GetCurrentTag()
		{
			return (int)FSoftObjectPathImplementation.FSoftObjectPath_GetCurrentTagImplementation(nint.Zero);
		}

		public static int InvalidateTag()
		{
			return (int)FSoftObjectPathImplementation.FSoftObjectPath_InvalidateTagImplementation(nint.Zero);
		}

		public static FSoftObjectPath GetOrCreateIDForObject(UObject Object)
		{
			return FSoftObjectPathImplementation.FSoftObjectPath_GetOrCreateIDForObjectImplementation(nint.Zero, Object?.GarbageCollectionHandle ?? nint.Zero) as FSoftObjectPath;
		}

		public static void AddPIEPackageName(FName NewPIEPackageName)
		{
			FSoftObjectPathImplementation.FSoftObjectPath_AddPIEPackageNameImplementation(nint.Zero, NewPIEPackageName?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static void ClearPIEPackageNames()
		{
			FSoftObjectPathImplementation.FSoftObjectPath_ClearPIEPackageNamesImplementation(nint.Zero);
		}
	}
}