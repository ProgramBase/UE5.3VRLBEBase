using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AIGraph
{
	[PathName("/Script/AIGraph.AIGraph")]
	public partial class UAIGraph : UEdGraph, IStaticClass
	{
		public int GraphVersion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GraphVersion, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GraphVersion, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIGraph.AIGraph");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __GraphVersion = 0;
	}
}