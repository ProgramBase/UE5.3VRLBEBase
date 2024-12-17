using Script.Binding;

namespace Script.CoreUObject
{
	public partial class FSoftClassPath
	{
		public FSoftClassPath(FSoftClassPath Other)
		{
			if (GetType() == typeof(FSoftClassPath))
			{
				FSoftClassPathImplementation.FSoftClassPath_FSoftClassPathImplementation(this, Other?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public FSoftClassPath(FString PathString)
		{
			if (GetType() == typeof(FSoftClassPath))
			{
				FSoftClassPathImplementation.FSoftClassPath_FSoftClassPath1Implementation(this, PathString?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public FSoftClassPath(UClass InClass)
		{
			if (GetType() == typeof(FSoftClassPath))
			{
				FSoftClassPathImplementation.FSoftClassPath_FSoftClassPath2Implementation(this, InClass?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public UClass ResolveClass()
		{
			return FSoftClassPathImplementation.FSoftClassPath_ResolveClassImplementation(GarbageCollectionHandle) as UClass;
		}

		public static FSoftClassPath GetOrCreateIDForClass(UClass InClass)
		{
			return FSoftClassPathImplementation.FSoftClassPath_GetOrCreateIDForClassImplementation(nint.Zero, InClass?.GarbageCollectionHandle ?? nint.Zero) as FSoftClassPath;
		}
	}
}