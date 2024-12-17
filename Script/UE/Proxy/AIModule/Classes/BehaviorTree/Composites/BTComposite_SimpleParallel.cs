using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.BTComposite_SimpleParallel")]
	public partial class UBTComposite_SimpleParallel : UBTCompositeNode, IStaticClass
	{
		public EBTParallelMode FinishMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FinishMode, __ReturnBuffer);

					return *(EBTParallelMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FinishMode, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.BTComposite_SimpleParallel");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __FinishMode = 0;
	}
}