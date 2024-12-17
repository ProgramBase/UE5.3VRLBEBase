using Script.Library;

namespace Script.CoreUObject
{
	public partial class UClass
	{
		public UObject ClassDefaultObject
		{
			get => UClassImplementation.UClass_GetClassDefaultObjectImplementation(GarbageCollectionHandle);
		}

		public UObject GetDefaultObject(bool bCreateIfNeeded = true)
		{
			return UClassImplementation.UClass_GetDefaultObjectImplementation(GarbageCollectionHandle, bCreateIfNeeded) as UObject;
		}
	}
}