using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeMessages
{
	[PathName("/Script/InterchangeMessages.InterchangeResultMeshWarning_TooManyUVs")]
	public partial class UInterchangeResultMeshWarning_TooManyUVs : UInterchangeResultMeshWarning, IStaticClass
	{
		public int ExcessUVs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ExcessUVs, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ExcessUVs, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeMessages.InterchangeResultMeshWarning_TooManyUVs");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ExcessUVs = 0;
	}
}