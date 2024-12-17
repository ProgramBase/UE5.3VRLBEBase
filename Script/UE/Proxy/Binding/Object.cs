using Script.Library;
using Script.Engine;

namespace Script.CoreUObject
{
	public partial class UObject
	{
		public UWorld GetWorld()
		{
			return UObjectImplementation.UObject_GetWorldImplementation(GarbageCollectionHandle) as UWorld;
		}
	}
}