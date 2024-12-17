using Script.CoreUObject;
using Script.Library;

namespace Script.SignificanceManager
{
	[PathName("/Script/SignificanceManager.SignificanceManager")]
	public partial class USignificanceManager : UObject, IStaticClass
	{
		public FSoftClassPath SignificanceManagerClassName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SignificanceManagerClassName, __ReturnBuffer);

					return *(FSoftClassPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SignificanceManagerClassName, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SignificanceManager.SignificanceManager");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SignificanceManagerClassName = 0;
	}
}