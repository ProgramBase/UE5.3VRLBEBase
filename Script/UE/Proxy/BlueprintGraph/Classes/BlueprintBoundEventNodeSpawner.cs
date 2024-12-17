using Script.CoreUObject;
using Script.Reflection.Property;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.BlueprintBoundEventNodeSpawner")]
	public partial class UBlueprintBoundEventNodeSpawner : UBlueprintEventNodeSpawner, IStaticClass
	{
		public TFieldPath<FMulticastDelegateProperty> EventDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EventDelegate, __ReturnBuffer);

					return *(TFieldPath<FMulticastDelegateProperty>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EventDelegate, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.BlueprintBoundEventNodeSpawner");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __EventDelegate = 0;
	}
}