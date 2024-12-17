using Script.CoreUObject;
using Script.InterchangeCore;
using Script.Library;

namespace Script.InterchangeMessages
{
	[PathName("/Script/InterchangeMessages.InterchangeResultMeshError")]
	public partial class UInterchangeResultMeshError : UInterchangeResultError, IStaticClass
	{
		public FString MeshName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MeshName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MeshName, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeMessages.InterchangeResultMeshError");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __MeshName = 0;
	}
}