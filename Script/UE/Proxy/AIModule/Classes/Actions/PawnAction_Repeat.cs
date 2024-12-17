using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.PawnAction_Repeat")]
	public partial class UDEPRECATED_PawnAction_Repeat : UDEPRECATED_PawnAction, IStaticClass
	{
		public EPawnActionFailHandling ChildFailureHandlingMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ChildFailureHandlingMode, __ReturnBuffer);

					return *(EPawnActionFailHandling*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ChildFailureHandlingMode, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.PawnAction_Repeat");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ChildFailureHandlingMode = 0;
	}
}